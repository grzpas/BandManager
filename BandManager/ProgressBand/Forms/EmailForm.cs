using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Band.Model.Internet;

namespace ProgressBand.Forms
{
    public partial class EmailForm : ProgressBand.Forms.PBandForm
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
