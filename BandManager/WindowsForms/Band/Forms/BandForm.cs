using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowsForms.Band.Forms
{
    public partial class BandForm : Form
    {
        public BandForm()
        {
            InitializeComponent();
        }

        public void TakeScreenshot()
        {
            var bmpScreenshot = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(this.Left, this.Top, 0, 0, this.Bounds.Size, CopyPixelOperation.SourceCopy);
            bmpScreenshot.Save(this.Text + ".jpg", ImageFormat.Jpeg);         
        }

        private void BandForm_Activated(object sender, EventArgs e)
        {
        }        
    }
}
