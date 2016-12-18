using System;
using System.Windows.Forms;
using Band.Model.Internet;

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
                Email.SendEmail("band@progressband.pl", txtBoxTo.Text, txtBoxSubject.Text, txtBoxContent.Text);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            
        }
    }
}
