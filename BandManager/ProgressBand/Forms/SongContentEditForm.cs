using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgressBand
{
    public partial class SongContentEditForm : Form
    {
        public SongContentEditForm()
        {
            InitializeComponent();
        }
        
        public string Title 
        { 
            get { return textBoxTitle.Text; }
 
            set 
            { 
                textBoxTitle.Text = value;
                this.Text = value;
            } 
        }
        public string SongScale
        {
            get { return textBoxScale.Text; }
            set { textBoxScale.Text = value; }
        }
        public int Type 
        { 
            get { return Convert.ToInt32(textBoxType.Text.Trim()); } 
            set { textBoxType.Text = value.ToString(); }
        }
        public string HighestTone
        {
            get { return textBoxHighestTone.Text; }
            set { textBoxHighestTone.Text = value; }
        }
        public string LowestTone
        {
            get { return textBoxLowestTone.Text; }
            set { textBoxLowestTone.Text = value; }
        }

        public string Chords
        {
            get { return richTextBoxChords.Text; }
            set { richTextBoxChords.Text = value; }
        }
    }
}
