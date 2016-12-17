using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace Band.Model.Entities
{
    public class Agreement 
    {
        public virtual int Id { get; private set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Member { get; set; }
        public virtual string City { get; set; }
        public virtual string Place { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual string Remarks { get; set; }
        public virtual bool Signed { get; set; }
        public virtual decimal ? Amount { get; set; }
        public virtual decimal ? DownPayment { get; set; }
        public virtual DateTime TimeStamp { get; set; }

        //Telefon???
        public virtual string GetEventDescription()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Umowa podpisana z: ");
            sb.Append(Name);
            sb.Append(" , adres:");
            sb.Append(Address);
            sb.Append(" , nr tel: ");
            sb.Append(Phone);
            sb.Append(" przez: ");
            sb.Append(Member);
            sb.Append(". Miejsce imprezy: ");
            sb.Append(City);  
            sb.Append(", ");
            sb.Append(Place);
            sb.Append(". Godzina rozpoczęcia: ");
            sb.Append(StartTime.ToString("HH:mm"));
            sb.Append(". Kwota: ");
            sb.Append(Amount);
            sb.Append(". Zaliczka: ");
            sb.Append(DownPayment);
            sb.Append(" zł. Umowa podpisana dnia: ");
            sb.Append(TimeStamp);
            sb.Append(". Uwagi: ");
            sb.Append(Remarks);
            return sb.ToString();
        }

        public virtual string ReplaceKeywords(string line)
        {
            string result = line.Replace("##band_member##", Member);
            result = result.Replace("##client_name##", Name);
            result = result.Replace("##client_address##", Address);
            result = result.Replace("##client_phone##", Phone);
            result = result.Replace("##the_city##", City);
            result = result.Replace("##the_place##", Place);
            result = result.Replace("##the_date##", StartTime.ToString("yyyy-MM-dd hh:mm"));
            result = result.Replace("##the_amount##", Amount.ToString());
            result = result.Replace("##the_downpayment##", DownPayment.ToString());
            result = result.Replace("##the_remarks##", Remarks);
            return result;
        }

        public virtual void DisplayPdf()
        {
            var document = new PdfDocument();
            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Automatic);
            var font = new XFont("Verdana", 10, XFontStyle.Regular, options);
            document.Info.Title = "Progress Band Agreement";

            var page = document.AddPage();
            page.Size = PageSize.A4;
       
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XTextFormatter tf = new XTextFormatter(gfx);
            XRect rect = new XRect(10, 10, page.Width - 10, page.Height - 10);
            var streamReader = new StreamReader("Agreement.txt");
            try
            {
                string line = ReplaceKeywords(streamReader.ReadToEnd());
                tf.DrawString(line, font, XBrushes.Black, rect, XStringFormats.TopLeft);
                const string fileName = "Agreement.pdf";
                document.Save(fileName);
                Process.Start(fileName);
            }
            finally
            {
                streamReader.Close();
            }
        }
    }
}