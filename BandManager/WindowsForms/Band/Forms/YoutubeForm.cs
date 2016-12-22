using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForms.Band.Forms
{
    public partial class YoutubeForm : BandForm
    {

        public YoutubeForm()
        {
            InitializeComponent();
        }

        private void txtBoxFilmLinks_DoubleClick(object sender, EventArgs e)
        {
            var videoLinks = new List<string>();
            var stringBuilder = new StringBuilder();
            foreach(var videoLink in videoLinks)
            {
                stringBuilder.AppendLine(videoLink);                
            }
            this.txtBoxFilmLinks.Text = stringBuilder.ToString();
        }
    }
}
