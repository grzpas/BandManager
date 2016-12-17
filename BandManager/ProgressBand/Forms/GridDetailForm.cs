using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GUI;

namespace ProgressBand.Forms
{ 
        public partial class GridDetailForm : ProgressBand.Forms.PBandForm
        {
            private Point _startingPoint = new Point(20, 20);
            private readonly List<Control> _controls = new List<Control>();
            private readonly List<Label> _labels = new List<Label>();
            private readonly Button _btnOK = new Button();

            public GridDetailForm()
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterParent;
                _btnOK.Text = "OK";
                _btnOK.Click += OnOKClick;
            }

            private void OnOKClick(object sender, EventArgs e)
            {
                UpdateDataGridViewCells();
                Close();
            }

            private void UpdateDataGridViewCells()
            {
                for(int i = 0; i < _controls.Count; ++i)
                {
                    var textBox = (_controls[i] as TextBox);
                    if (textBox != null)
                    {
                        if (!textBox.ReadOnly)
                            Items[i].Value = textBox.Text;
                        continue;
                    }
                    var checkBox = (_controls[i] as CheckBox);
                    if (checkBox != null)
                    {
                        Items[i].Value = checkBox.Checked;
                        continue;
                    }

                    var dateTimePicker = (_controls[i] as DateTimePicker);
                    if (dateTimePicker != null)
                    {
                        Items[i].Value = dateTimePicker.Value;
                        continue;
                    }
                }
            }

            public DataGridViewCellCollection Items { get; set; }

            private static Control ConvertEditTypes(Type type)
            {
                if (type == typeof(DataGridViewCheckBoxCell))
                {
                    return new CheckBox();
                }
                
                if (type == typeof(DataGridViewTextBoxCell))
                {
                    return new TextBox();
                }

                if (type == typeof(DataGridViewCalendarCell))
                {
                    var dateTimePicker = new DateTimePicker();
                    dateTimePicker.Format = DateTimePickerFormat.Custom;
                    dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
                    return dateTimePicker;
                }
                return new TextBox();
            }

            private void GridDetailForm_Load(object sender, EventArgs e)
            {
                if (Items == null || Items.Count == 0)
                    return;
                
                for (int i = 0; i <= Items.Count - 1; ++i)
                {                    
                    DataGridViewCell cell = (DataGridViewCell)Items[i];
                    Type type = cell.GetType();                        
                    var control = ConvertEditTypes(type);
                    _controls.Add(control);
                    _labels.Add(new Label());
                    if (!Convert.IsDBNull(((DataGridViewCell) Items[i]).Value))
                    {
                        _labels[i].Text = ((DataGridViewCell) Items[i]).OwningColumn.HeaderText;
                        _labels[i].Left = _startingPoint.X;
                        _labels[i].Top = _startingPoint.Y;
                        var value = ((DataGridViewCell) Items[i]).Value;
                        string text = (value != null) ? value.ToString() : "";
                    
                        _controls[i].Text = text;
                        _controls[i].Left = _startingPoint.X + 130;
                        _controls[i].Top = _startingPoint.Y;
                        _controls[i].Width = 150;
                        _startingPoint = new Point(_startingPoint.X, _startingPoint.Y + 30);
                        
                    }
                    else
                    {
                        _labels[i].Text = ((DataGridViewCell)Items[i]).OwningColumn.HeaderText;
                        _controls[i].Left = _startingPoint.X + 130;
                        _controls[i].Top = _startingPoint.Y;                        
                        _labels[i].Left = _startingPoint.X;
                        _labels[i].Top = _startingPoint.Y;
                    }
                }
                foreach (var control in _controls)
                    Controls.Add(control);
                foreach (var label in _labels)
                    Controls.Add(label);
                
                Controls.Add(_btnOK);                    

                Height = _controls[Items.Count - 1].Bottom + 100;
                _btnOK.Top = _controls[Items.Count - 1].Bottom + 30;
                _btnOK.Left = (Width / 2) - (_btnOK.Width / 2);
                if (_controls.Count > 0)
                {
                    _controls[0].Enabled = false;
                    _btnOK.Left = _controls[0].Left;
                }
            }
        }
    
}
