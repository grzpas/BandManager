using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowsForms.Band.Forms
{
    public partial class PBandForm : Form
    {
        public PBandForm()
        {
            Cursor = Cursors.WaitCursor;
            InitializeComponent();
        }

        public void TakeScreenshot()
        {
            //this.Hide();
            var bmpScreenshot = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(this.Left, this.Top, 0, 0, this.Bounds.Size, CopyPixelOperation.SourceCopy);
            bmpScreenshot.Save(this.Text + ".jpg", ImageFormat.Jpeg);
            //this.Show();            
        }

        private void PBandForm_Activated(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }        
    }
}
