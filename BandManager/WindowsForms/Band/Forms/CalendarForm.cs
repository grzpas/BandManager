using System;
using System.Windows.Forms;
using Google.GData.Calendar;

namespace WindowsForms.Band.Forms
{
    public partial class CalendarForm : PBandForm
    {
        private void UpdateControls(EventEntry upComingEvent)
        {
            if (upComingEvent != null)
            {
                txtBoxCalendarTitle.Text = upComingEvent.Title.Text;
                dateTimePicker.Value = upComingEvent.Times[0].StartTime;
                txtBoxCalendarLocation.Text = upComingEvent.Locations[0].ValueString;
                txtBoxCalendarContents.Text = upComingEvent.Content.Content;
            }
            else
            {
                txtBoxCalendarTitle.Text = "";                
                txtBoxCalendarLocation.Text = "";
                txtBoxCalendarContents.Text = "";
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
