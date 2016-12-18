using System;
using System.Text;
using Band.Model.Google;

namespace WindowsForms.Band.Forms
{
    public partial class YoutubeForm : PBandForm
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
