using System;
using System.Windows.Forms;


namespace WindowsForms.Band.Forms
{
    public partial class EmailForm : PBandForm
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
