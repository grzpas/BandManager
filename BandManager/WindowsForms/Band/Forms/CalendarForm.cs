using System;
using System.Linq;
using System.Windows.Forms;
using Google.GData.Calendar;

namespace WindowsForms.Band.Forms
{
    public partial class CalendarForm : BandForm
    {
        private void UpdateControls(EventEntry upComingEvent)
        {
            if (upComingEvent != null)
            {
                txtBoxCalendarTitle.Text = upComingEvent.Title.Text;
                dateTimePicker.Value = upComingEvent.Times.First().StartTime;
                txtBoxCalendarLocation.Text = upComingEvent.Locations.First().ValueString;
                txtBoxCalendarContents.Text = upComingEvent.Content.Content;
            }
            else
            {
                txtBoxCalendarTitle.Text = string.Empty;                
                txtBoxCalendarLocation.Text = string.Empty;
                txtBoxCalendarContents.Text = string.Empty;
            }
        }

        public CalendarForm()
        {
            InitializeComponent();
        }

        public bool ReadOnly
        {
            set
            {
                btnSelected.Visible = !value;
                btnUpcoming.Visible = !value;
                dateTimePicker.Enabled = !value;
            }        
        }

        private void btnUpcoming_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                GetClosestUpcomingEvent();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public void GetClosestUpcomingEvent()
        {
            UpdateControls(null);
        }

        public DateTime LastSelectedDate
        {
            get { return dateTimePicker.Value; }
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                UpdateControls(null);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
