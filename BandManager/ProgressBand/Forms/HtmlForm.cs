using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using mshtml;
using ProgressBand.Properties;


namespace ProgressBand
{
    public partial class HtmlForm : ProgressBand.Forms.PBandForm
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
