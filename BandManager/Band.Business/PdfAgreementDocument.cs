using System.Diagnostics;
using System.IO;
using System.Text;
using Band.Domain;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace Band.Business
{
    //Todo: This class should be only responsible for creating a pdf file with specified name
    public class PdfAgreementDocument
    {
        private readonly Agreement _agreement;

        public PdfAgreementDocument(Agreement  agreement)
        {
            _agreement = agreement;
        }

        public virtual string GetEventDescription()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Umowa podpisana z: ");
            sb.Append(_agreement.Name);
            sb.Append(" , adres:");
            sb.Append(_agreement.Address);
            sb.Append(" , nr tel: ");
            sb.Append(_agreement.Phone);
            sb.Append(" przez: ");
            sb.Append(_agreement.Member);
            sb.Append(". Miejsce imprezy: ");
            sb.Append(_agreement.City);
            sb.Append(", ");
            sb.Append(_agreement.Place);
            sb.Append(". Godzina rozpoczęcia: ");
            sb.Append(_agreement.StartTime.ToString("HH:mm"));
            sb.Append(". Kwota: ");
            sb.Append(_agreement.Amount);
            sb.Append(". Zaliczka: ");
            sb.Append(_agreement.DownPayment);
            sb.Append(" zł. Umowa podpisana dnia: ");
            sb.Append(_agreement.TimeStamp);
            sb.Append(". Uwagi: ");
            sb.Append(_agreement.Remarks);
            return sb.ToString();
        }

        public virtual string ReplaceKeywords(string line)
        {
            string result = line.Replace("##band_member##", _agreement.Member);
            result = result.Replace("##client_name##", _agreement.Name);
            result = result.Replace("##client_address##", _agreement.Address);
            result = result.Replace("##client_phone##", _agreement.Phone);
            result = result.Replace("##the_city##", _agreement.City);
            result = result.Replace("##the_place##", _agreement.Place);
            result = result.Replace("##the_date##", _agreement.StartTime.ToString("yyyy-MM-dd hh:mm"));
            result = result.Replace("##the_amount##", _agreement.Amount.ToString());
            result = result.Replace("##the_downpayment##", _agreement.DownPayment.ToString());
            result = result.Replace("##the_remarks##", _agreement.Remarks);
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
            var templateFileContents = File.ReadAllText("Agreement.txt");
            string line = ReplaceKeywords(templateFileContents);
            tf.DrawString(line, font, XBrushes.Black, rect, XStringFormats.TopLeft);
            const string fileName = "Agreement.pdf";
            document.Save(fileName);
            Process.Start(fileName);
        }
    }
}
