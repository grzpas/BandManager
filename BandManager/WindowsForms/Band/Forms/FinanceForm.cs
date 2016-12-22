using System;
using System.Windows.Forms;

namespace WindowsForms.Band.Forms
{
    public partial class FinanceForm : BandForm
    {              
        public FinanceForm()
        {
            InitializeComponent();                   
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
                           
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSavePayroll_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
               
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

    

        private void FinanceForm_DoubleClick(object sender, EventArgs e)
        {            
            var mapForm = new HtmlForm { Text = "Route", HtmlContent = "" };
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
            this.webBrowser.DocumentText = ""; //Todo
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
