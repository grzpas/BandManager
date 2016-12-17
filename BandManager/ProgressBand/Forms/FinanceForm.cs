using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Band.Model.DB;
using Band.Model.Entities;
using Band.Model.Google;
using Band.Model.Internet;
using NHibernate;
using ProgressBand.Forms;

namespace ProgressBand
{
    public partial class FinanceForm : ProgressBand.Forms.PBandForm
    {
        private readonly PBDistanceCalculator _distanceCalculator = new PBDistanceCalculator(new MyHttpResponse());               
        public FinanceForm()
        {
            InitializeComponent();
            PrepopulateDistanceCalculatorWithLocations();            
            lstBoxPlaces.Items.AddRange(_distanceCalculator.Locations.Cast<object>().ToArray());                     
        }

        private void PrepopulateDistanceCalculatorWithLocations()
        {
            _distanceCalculator.AddLocation("Maśnik");
            _distanceCalculator.AddLocation("Połaniec");
            _distanceCalculator.AddLocation("Staszów");
        }
               
        private void txtBoxPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(this.txtBoxPlace.Text.Trim()))
                {
                    lstBoxPlaces.Items.Add(this.txtBoxPlace.Text.Trim());
                }
                txtBoxPlace.SelectAll();
                txtBoxPlace.Focus();
            }
        }
        

        private void lstBoxPlaces_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                lstBoxPlaces.Items.RemoveAt(lstBoxPlaces.SelectedIndex);
            }
        }

     
        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
                        
        }
                           
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSavePayroll_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                using (var session = DataBase.Instance.SessionFactory.OpenSession())
                {

                    if (chkBoxDeletePrevious.Checked)
                    {
                        ICriteria criteria = session.CreateCriteria<Payroll>();
                        IList<Payroll> allRecords = criteria.List<Payroll>();
                        foreach (Payroll record in allRecords)
                        {
                            session.Delete(record);
                        }
                    }
                    var payroll = new Payroll();
                    payroll.Date = dateTimePicker.Value;
                    payroll.Total = Convert.ToDecimal(txtBoxTotal.Text);
                    payroll.TimeStamp = DateTime.Now;
                    session.SaveOrUpdate(payroll);
                }
                PutGoogleMapsOnFTP();
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private GoogleMapParams GetGoogleMapsParams()
        {
            return new GoogleMapParams(chckBoxAvoidHighways.Checked, chckBoxAvoidTolls.Checked, chckBoxOptimize.Checked, lstBoxPlaces.Items.Cast<string>());
        }

        private void PutGoogleMapsOnFTP()
        {            
            var ftpClient = new FTP("ftp.progressband.pl", 21, "pband", "yaya2000");
            ftpClient.Connect();
            ftpClient.ChangeDir("domains/progressband.pl/public_html/modules/payroll/");
            if (ftpClient.IsConnected)
            {
                ftpClient.OpenUpload("route.html", new MemoryStream(Encoding.UTF8.GetBytes(new HtmlGoogleMapsRequestGenerator(GetGoogleMapsParams()).Generate(HtmlGoogleMapsRequestGenerator.Template.Big)), false), false);
                while (ftpClient.DoUpload() > 0) ;
            }
        }

        private void FinanceForm_DoubleClick(object sender, EventArgs e)
        {            
            var mapForm = new HtmlForm { Text = "Route", HtmlContent = new HtmlGoogleMapsRequestGenerator(GetGoogleMapsParams()).Generate(HtmlGoogleMapsRequestGenerator.Template.Big) };
            mapForm.ShowDialog();   
        }
              

        private void btnEventDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var calendarForm = new CalendarForm {ReadOnly = true};
                calendarForm.GetClosestUpcomingEvent();
                calendarForm.ShowDialog();
                dateTimePicker.Value = calendarForm.LastSelectedDate;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
       

        private void btnShowRoute_Click(object sender, EventArgs e)
        {            
            this.webBrowser.Navigate("about:blank");
            var htmlDocument = this.webBrowser.Document;
            if (htmlDocument != null) 
            {
                htmlDocument.Write(string.Empty);
            }
            this.webBrowser.DocumentText = new HtmlGoogleMapsRequestGenerator(GetGoogleMapsParams()).Generate(HtmlGoogleMapsRequestGenerator.Template.Small);
        }  
        

        private void txtBoxDistance_DoubleClick(object sender, EventArgs e)
        {
            var element = webBrowser.Document.GetElementById("ttDistance");
            if (element.InnerText != null)
            {
                this.txtBoxDistance.Text = ((int) Math.Ceiling(Convert.ToDouble(element.InnerText.Trim()))).ToString();                
            }
        }
    }
}
