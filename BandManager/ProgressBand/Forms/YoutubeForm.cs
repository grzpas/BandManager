using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Band.Model.Google;

namespace ProgressBand.Forms
{
    public partial class YoutubeForm : ProgressBand.Forms.PBandForm
    {
        private PBandYoutube _youtube = new PBandYoutube();
        public YoutubeForm()
        {
            InitializeComponent();
        }

        private void txtBoxFilmLinks_DoubleClick(object sender, EventArgs e)
        {
            var videoLinks = _youtube.GetAllVideoLinks();
            var stringBuilder = new StringBuilder();
            foreach(var videoLink in videoLinks)
            {
                stringBuilder.AppendLine(videoLink);                
            }
            this.txtBoxFilmLinks.Text = stringBuilder.ToString();
        }
    }
}
