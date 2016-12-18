using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsForms.Band.Controls;
using Band.Model.DB;
using Band.Model.Entities;
using Band.Model.Google;

namespace WindowsForms.Band.Forms
{
    public partial class AgreementsForm : PBandForm
    {
        private readonly BindingSource _bs = new BindingSource();

        public AgreementsForm()
        {
            InitializeComponent();
            ConfigureDataGrid();
                       
           // _bs.DataSource = DataBase.Instance.Session.CreateCriteria(typeof(Agreement)).List<Agreement>();
            _bs.ResetBindings(false);
        }
 

        private void ConfigureDataGrid()
        {
            dataGridView.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn colType1 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType1.Name = colType1.HeaderText = colType1.DataPropertyName = "Id";
            dataGridView.Columns.Add(colType1);

            DataGridViewTextBoxColumn colType2 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType2.Name = colType2.HeaderText = colType2.DataPropertyName = "Name";
            dataGridView.Columns.Add(colType2);

            DataGridViewTextBoxColumn colType3 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType3.Name = colType3.HeaderText = colType3.DataPropertyName = "Address";
            dataGridView.Columns.Add(colType3);

            DataGridViewTextBoxColumn colType4 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType4.Name = colType4.HeaderText = colType4.DataPropertyName = "Phone";
            dataGridView.Columns.Add(colType4);

            DataGridViewTextBoxColumn colType5 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType5.Name = colType5.HeaderText = colType5.DataPropertyName = "Member";            
            dataGridView.Columns.Add(colType5);

            DataGridViewTextBoxColumn colType6 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType6.Name = colType6.HeaderText = colType6.DataPropertyName = "City";
            dataGridView.Columns.Add(colType6);

            DataGridViewTextBoxColumn colType7 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType7.Name = colType7.HeaderText = colType7.DataPropertyName = "Place";
            dataGridView.Columns.Add(colType7);

            DataGridViewCalendarColumn colType8 = new DataGridViewCalendarColumn {CellTemplate = new DataGridViewCalendarCell()};
            colType8.Name = colType8.HeaderText = colType8.DataPropertyName = "StartTime";
            dataGridView.Columns.Add(colType8);

            DataGridViewTextBoxColumn colType9 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType9.Name = colType9.HeaderText = colType9.DataPropertyName = "Remarks";
            dataGridView.Columns.Add(colType9);

            DataGridViewCheckBoxColumn colType10 = new DataGridViewCheckBoxColumn {CellTemplate = new DataGridViewCheckBoxCell()};
            colType10.Name = colType10.HeaderText = colType10.DataPropertyName = "Signed";
            dataGridView.Columns.Add(colType10);

            DataGridViewTextBoxColumn colType11 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType11.Name = colType11.HeaderText = colType11.DataPropertyName = "Amount";
            dataGridView.Columns.Add(colType11);

            DataGridViewTextBoxColumn colType12 = new DataGridViewTextBoxColumn {CellTemplate = new DataGridViewTextBoxCell()};
            colType12.Name = colType12.HeaderText = colType12.DataPropertyName = "DownPayment";
            dataGridView.Columns.Add(colType12);

            DataGridViewCalendarColumn colType13 = new DataGridViewCalendarColumn {CellTemplate = new DataGridViewCalendarCell()};
            colType13.Name = colType13.HeaderText = colType13.DataPropertyName = "TimeStamp";
            dataGridView.Columns.Add(colType13);

            dataGridView.DataSource = _bs;
            
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoResizeColumns();
           
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
                return;

            var gridDetailForm = new GridDetailForm {Text = "Agreement", Items = this.dataGridView.CurrentRow.Cells};
            gridDetailForm.ShowDialog();
        }
        

        private void UpdateEventInCalendar()
        {  
            if (_bs.Current != null)
            {
                Agreement agreement = (Agreement)_bs.Current;
                PBCalendar calendar = new PBCalendar();
                PBCalendar.AsyncMethodCaller caller = calendar.CreateEvent;
                caller.BeginInvoke("Wesele", agreement.GetEventDescription(), agreement.City, agreement.StartTime, null, null);
            }

        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (IsSignedColumnClicked(e))
            {
                
                object value = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                //DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell) dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (value is DBNull)
                    return;

                if ((bool)value)
                {
                    UpdateEventInCalendar();
                    DisplayAgreementPDF();
                    //cell.ReadOnly = true;
                }
            }
        }

        private void DisplayAgreementPDF()
        {
            if (_bs.Current != null)
            {
                Agreement agreement = (Agreement) _bs.Current;
                agreement.DisplayPdf();
            }
        }

        private bool IsSignedColumnClicked(DataGridViewCellEventArgs e)
        {
            //This is not exact
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex != -1)
            {
                return true;
            }
            return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveChangesInDataBase();
            Close();
        }

        private void SaveChangesInDataBase()
        {
            var list = (List<Agreement>)_bs.DataSource;
            using (var session = DataBase.Instance.SessionFactory.OpenSession())
            {
                foreach (var element in list)
                {
                    session.SaveOrUpdate(element);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var agreement = (Agreement)_bs.Current;
            if (agreement != null)
            {
                using (var session = DataBase.Instance.SessionFactory.OpenSession())
                {
                    session.Delete(agreement);
                }
            }
        }
    }
}
