using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.Band.Forms;
using Band.Model.Entities;

namespace WindowsForms.Band
{
    public partial class ProgressBandForm : PBandForm
    {
        private readonly BindingSource _bs = new BindingSource();
        private Font _printFont = new Font("Courier New", 12);
        private Color _colour = Color.Black;
        private int _currentLine = 0;
        private int _songNo = 0;
        private List<string> _lines;
        private bool _readOnly = false;
        private BindingList<Song> _songs = new BindingList<Song>();

        public ProgressBandForm()
        {
            InitializeComponent();
            ToggleEdition();
            ConfigureDataGrid();
        }

        private void FilterSongs()
        {
            if (textBoxFilter.Text != "")
            {
                _bs.Filter = "Title Like '*" + this.textBoxFilter.Text + "*'";
            }
            else
            {
                _bs.RemoveFilter();
            }
        }

        private List<string> GetSelectedRowsStrings()
        {
            if (this.dgvSongs.SelectedRows.Count == 0)
                return null;

            DataGridViewSelectedRowCollection selectedRowCollection = this.dgvSongs.SelectedRows;
            var result = new List<string>();
            for(int rowIndex = 0; rowIndex < selectedRowCollection.Count; ++rowIndex)
            {
                var cells = selectedRowCollection[rowIndex].Cells;
                if (cells[1].Value != null && cells[2].Value != null)
                {
                    string sLine = ("\"" + cells[1].Value.ToString() + "\"").PadRight(44) + cells[2].Value.ToString().PadRight(3);
                    result.Add(sLine);
                }
            }
            return result;
        }

        private List<string> GetLinesForPrinting()
        {
            var result = new List<string>();
            for (int rowIndex = 0; rowIndex < lstSelectedSongs.Items.Count; ++rowIndex)
            {
                if (lstSelectedSongs.Items[rowIndex].ToString() != "")
                {
                    string sLine = lstSelectedSongs.Items[rowIndex].ToString();
                    result.Add(sLine);
                }
                else
                {
                    result.Add(string.Empty);
                }
            }
            return result;
        }

        private void BindSongData()
        {
            _songs = new BindingList<Song>(); //Todo
            _bs.DataSource = _songs;
            chordsRichText.DataBindings.Add("Text", _bs, "Chords", true);
            dgvSongs.DataSource = _bs;
            _bs.ResetBindings(false);
        }

        private void ConfigureDataGrid()
        {
            dgvSongs.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colType = new DataGridViewTextBoxColumn();                
            colType.CellTemplate = new DataGridViewTextBoxCell(); 
            colType.Name = "Type";
            colType.HeaderText = "Type";                
            colType.DataPropertyName = "Type";
            dgvSongs.Columns.Add(colType);

            DataGridViewTextBoxColumn colTitle = new DataGridViewTextBoxColumn();
            colTitle.CellTemplate = new DataGridViewTextBoxCell();
            colTitle.Name = "Title";
            colTitle.HeaderText = "Title";
            colTitle.DataPropertyName = "Title";
            dgvSongs.Columns.Add(colTitle);

            DataGridViewTextBoxColumn colScale = new DataGridViewTextBoxColumn();
            colScale.CellTemplate = new DataGridViewTextBoxCell();
            colScale.Name = "Scale";
            colScale.HeaderText = "Scale";
            colScale.DataPropertyName = "Scale";
            dgvSongs.Columns.Add(colScale);
            
            dgvSongs.AutoResizeColumns();
            dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void UpdateDataBase()
        {
            var list = (BindingList<Song>)_bs.DataSource;
            foreach (var element in list)
            {
                //session.SaveOrUpdate(element); //Update repository
            }
        }

        private string GetCurrentSongChord()
        {
            return dgvSongs.CurrentRow?.Cells[2].Value.ToString().Trim();
        }
        
        private string GetChords(string sTitle)
        {
            sTitle = sTitle.Replace("'", "''");
            var theItem = _songs.ToList().Find(x => x.Title == sTitle);
            return theItem?.Chords;
        }

        static int CountLinesInString(string s)
        {
            int count = 1;
            int start = 0;
            while ((start = s.IndexOf('\n', start)) != -1)
            {
                count++;
                start++;
            }
            return count;
        }


        KeyValuePair<int, string> GetItem(int currentLine,  bool bIncludeChords)
        {
            string sLine = _lines[currentLine];

            if (string.IsNullOrEmpty(sLine))
            {
                return new KeyValuePair<int, string>(1, "");
            }

            string sString = sLine;
            if (bIncludeChords)
            {
                char[] separators = { '"' };
                string[] columns = sLine.Split(separators);
                string sTitle = columns[1];
                var sChords = GetChords(sTitle);
                if (!string.IsNullOrEmpty(sChords))
                {
                    sChords = sChords.Trim();
                    sChords = sChords.Replace(".", "");
               
                    sString += "\n\n";
                    sString += sChords;
                    sString = sString.Trim();
                    sString += "\n";
                }                               
            }
            int numberOfLines = CountLinesInString(sString);
            var result = new KeyValuePair<int, string>(numberOfLines, sString);
            return result;
        }


        private string GetCurrentChordText()
        {
            return this.chordsRichText.Text.Trim();
        }

        private void ToggleEdition()
        {
            _readOnly = !_readOnly;
            {
                this.dgvSongs.ReadOnly = _readOnly;
                this.chordsRichText.ReadOnly = _readOnly;
                this.btnTransposeDown.Enabled = !_readOnly;
                this.btnTransposeUp.Enabled = !_readOnly;
                this.txtBoxTargetScale.Enabled = !_readOnly;
            }
        }

   

        

        private void SetNewChordText(string sChordText)
        {
            this.chordsRichText.Text = sChordText;
        }

        private void SetNewSongChord(string sChord)
        {
            if (this.dgvSongs.CurrentRow != null)
                this.dgvSongs.CurrentRow.Cells[2].Value = sChord;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _currentLine = 0;
            _songNo = 0;
            _lines = GetLinesForPrinting();
            this.printDocument.Print();

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            if (_currentLine >= _lines.Count)
            {
                ev.HasMorePages = false;
                return;
            }
            int lineOnPage = 0;
            
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            // Calculate the number of lines per page.
            float linesPerPage = ev.MarginBounds.Height / _printFont.GetHeight(ev.Graphics);
                      
            while ((lineOnPage < linesPerPage) && _currentLine < _lines.Count)
            {
                KeyValuePair<int, string> item = GetItem(_currentLine, this.checkBoxChords.Checked);
                if (!string.IsNullOrEmpty(item.Value))
                    ++_songNo;

                if (lineOnPage + item.Key > linesPerPage)
                {
                    ev.HasMorePages = true;
                    return;
                }
                float yPos = topMargin + (lineOnPage *  _printFont.GetHeight(ev.Graphics));
                string sLineToPrint = String.Format("{0} {1}", (!string.IsNullOrEmpty(item.Value) && !item.Value.StartsWith("[")) ?(_songNo.ToString().PadLeft(4)+"."):"", item.Value);
                ev.Graphics.DrawString(sLineToPrint, _printFont, new SolidBrush(_colour), leftMargin, yPos, new StringFormat());
                lineOnPage += item.Key;  
                _currentLine++;
            }

            // If more lines exist, print another page.
            ev.HasMorePages = (_currentLine < _lines.Count);
        }

        private void btnMoveSelected_Click(object sender, EventArgs e)
        {
            MoveItemsToReorderingList();
        }

        private void MoveItemsToReorderingList()
        {
            var selectedRowsStrings = GetSelectedRowsStrings();
            if (selectedRowsStrings == null)
                return;

            foreach (var row in selectedRowsStrings)
            {
                if(!lstSelectedSongs.Items.Contains(row))
                {
                    lstSelectedSongs.Items.Insert(0,row);
                }
            }
            lstSelectedSongs.Focus();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            lstSelectedSongs.RemoveSelectedItems();
        }
     

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            lstSelectedSongs.MoveSelectedItemsUp(1);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            lstSelectedSongs.MoveSelectedItemsDown(1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "songs|*.sng";
            saveFileDialog.Title = "Save list of songs";
            if ((saveFileDialog.ShowDialog(this) == DialogResult.OK) && !string.IsNullOrEmpty(saveFileDialog.FileName))           
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                try
                {
                    foreach(var line in lstSelectedSongs.Items)
                    {
                        streamWriter.WriteLine(line);
                    }
                }
                finally
                {
                    streamWriter.Close();    
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "songs|*.sng";
            openFileDialog.Title = "Open list of songs";
            if ((openFileDialog.ShowDialog(this) == DialogResult.OK) && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                var streamReader = new StreamReader(openFileDialog.FileName);
                try
                {
                    string line = null;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        lstSelectedSongs.Items.Add(line);
                    }
                }
                finally
                {
                    streamReader.Close();
                }
            }            
        }

        private void btnGetSongs_Click(object sender, EventArgs e)
        {
            Cursor oldCursor = Cursor;
            try
            {
                Cursor = Cursors.WaitCursor;
                BindSongData();
                dgvSongs.SelectAll();
                dgvSongs.Focus();
                Text = @"Progress Band [online]";
            }
            finally
            {
                Cursor = oldCursor;
            }
        }

        private void textBoxFilter_Leave(object sender, EventArgs e)
        {
            FilterSongs();
        }

        private void textBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FilterSongs();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            int numberInGroup = Convert.ToInt32(txtBoxGroup.Text);
            int sumOfGroup = numberInGroup;
            while(sumOfGroup < this.lstSelectedSongs.Items.Count)
            {
                this.lstSelectedSongs.Items.Insert(sumOfGroup, "");
                sumOfGroup += numberInGroup + 1;
            }
        }
     
        private void btnTransposeDown_Click(object sender, EventArgs e)
        {
        }

        private void btnTransposeUp_Click(object sender, EventArgs e)
        {
        }

        private void lstSelectedSongs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.A)
                {
                    for (int index = 0; index < lstSelectedSongs.Items.Count; ++index)
                        lstSelectedSongs.SelectedIndices.Add(index);
                    return;
                }
                if (e.KeyCode == Keys.Up)
                {
                    lstSelectedSongs.MoveSelectedItemsUp(1);
                    return;
                }
                if (e.KeyCode == Keys.Down)
                {
                    lstSelectedSongs.MoveSelectedItemsDown(1);
                    return;
                }

            }
            if (e.KeyCode == Keys.Delete)
                lstSelectedSongs.RemoveSelectedItems();

        }

        private void txtBoxTargetScale_Leave(object sender, EventArgs e)
        {

        }

        private void txtBoxTargetScale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void dgvSongs_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSongs.CurrentRow == null)
                return;

            var detailForm = new GridDetailForm {Text = "Song", Items = dgvSongs.CurrentRow.Cells};
            detailForm.ShowDialog();
        }

        private void btnRemoveEmpty_Click(object sender, EventArgs e)
        {
            lstSelectedSongs.RemoveEmptyItems();
        }

        private void btnFontSelection_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.FixedPitchOnly = true; 
            fontDialog.Font = _printFont;
            fontDialog.Color = _colour;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                _printFont = fontDialog.Font;
                _colour = fontDialog.Color;
            }

        }

        private void dgvSongs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                if (e.KeyCode == Keys.Right)
                    MoveItemsToReorderingList();
        }

        private void chordsRichText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.chordsRichText.ReadOnly == false)
                UpdateDataBase();
            ToggleEdition();
        }

   

        private void btnFinances_Click(object sender, EventArgs e)
        {
            var financeForm = new FinanceForm();
            financeForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            var calendarForm = new CalendarForm();
            calendarForm.ShowDialog();
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            var youtubeForm = new YoutubeForm();
            youtubeForm.ShowDialog();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            var emailForm = new EmailForm();
            emailForm.ShowDialog();
        }

        private void btnAgreements_Click(object sender, EventArgs e)
        {            
            var agreementsForm = new AgreementsForm();
            agreementsForm.ShowDialog();                        
        }
    }
}
