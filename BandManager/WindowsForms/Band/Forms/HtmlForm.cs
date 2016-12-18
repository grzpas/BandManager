using System;

namespace WindowsForms.Band.Forms
{
    public partial class HtmlForm : PBandForm
    {
        public string HtmlContent { get; set; }

        public HtmlForm()
        {
            InitializeComponent();           
        }
               
        private void MapForm_Activated(object sender, EventArgs e)
        {
            this.webBrowser.AllowNavigation = false;
            this.webBrowser.Navigate("about:blank");
            this.webBrowser.DocumentText = HtmlContent;
        }               
    }
}
