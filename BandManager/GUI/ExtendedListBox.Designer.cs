using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class ExtendedListBox : ListBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private int startingIndex;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion

        
        protected override void OnDoubleClick(System.EventArgs e)
        {
            this.Items.Insert(this.SelectedIndex, "");
        }

        public void RemoveSelectedItems()
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < this.SelectedIndices.Count; ++i)
            {
                indices.Add(this.SelectedIndices[i]);
            }

            indices.Sort();
            for (int index = indices.Count - 1; index >= 0; --index)
            {
                this.Items.RemoveAt(index);
            }

            /*while (this.SelectedItems.Count > 0)
            {
                this.Items.Remove(this.SelectedItem);
            }*/
        }

        public void RemoveEmptyItems()
        {
            for (int i = this.Items.Count - 1; i >= 0; --i)
            {
                if (string.IsNullOrEmpty((string)this.Items[i]))
                {
                    this.Items.RemoveAt(i);
                }
            }
        }

        public void MoveSelectedItemsUp(int step)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.SelectedItems.Contains(this.Items[i])) //identify the selected item
                {
                    //swap with the top item(move up)
                    if (i > 0 && !this.SelectedItems.Contains(this.Items[i - step]))
                    {
                        var bottom = this.Items[i];
                        this.Items.Remove(bottom);
                        this.Items.Insert(i - step, bottom);
                        this.SelectedIndices.Add(i - step);
                    }
                }
            }

        }

        public void MoveSelectedItemsDown(int step)
        {
            int startindex = this.Items.Count - 1;
            for (int i = startindex; i > -1; i--)
            {
                if (this.SelectedItems.Contains(this.Items[i]))//identify the selected item
                {
                    //swap with the lower item(move down)
                    if (i < startindex && !this.SelectedItems.Contains(this.Items[i + step]))
                    {
                        var bottom = this.Items[i];
                        this.Items.Remove(bottom);
                        this.Items.Insert(i + step, bottom);
                        this.SelectedIndices.Add(i + step);
                    }
                }
            }
        }                
 
        private void OnDragDrop(object sender, DragEventArgs e)  
        {  
            if(e.Effect == DragDropEffects.Copy)  
            {  
                Point point = this.PointToClient(new Point(e.X, e.Y));
                int index = this.IndexFromPoint(point);
                bool bDataPresent = e.Data.GetDataPresent(typeof(SelectedIndexCollection));
                if (bDataPresent && index >=0)
                {
                    
                    SelectedIndexCollection collection =
                        (SelectedIndexCollection) e.Data.GetData(typeof (SelectedIndexCollection));
                    List<int> list = new List<int>();
                    foreach (int item in collection)
                    {
                        list.Add(item);
                    }
                    list.Sort();
                    Dictionary<string, int> itemsSelected = new Dictionary<string, int>();
                    foreach (int item in list)
                    {
                        itemsSelected.Add((string) this.Items[item], item);
                    }

                    RemoveSelectedItems();
                    //difference between first
                    int difference = list.Count == 0? 0 : index - list[0];
                    //if (difference < 0)
                    //    ++difference;

                    foreach (var item in itemsSelected)
                    {
                        this.Items.Insert(item.Value + difference, item.Key);
                    }
                }

                
                /*if( index > -1 && index < this.Items.Count) 
                    Items.Insert(index, e.Data.GetData(DataFormats.Text)); 
                else 
                    Items.Add(e.Data.GetData(DataFormats.Text)); 
                Items.RemoveAt(startingIndex);*/
            } 
        } 
        
        private void OnDragEnter(object sender, System.Windows.Forms.DragEventArgs e) 
        {
            if (e.Data.GetDataPresent(typeof(SelectedIndexCollection))) 
                e.Effect = DragDropEffects.Copy; 
            else 
                e.Effect = DragDropEffects.None; 
        } 
  
        private void OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e) 
        {
            if (MouseButtons == MouseButtons.Right && SelectedIndices != null && SelectedIndices.Count > 0) 
            {
                //startingIndex = this.IndexFromPoint(new Point(e.X, e.Y)); 
                DoDragDrop(SelectedIndices, DragDropEffects.Copy); 
            } 
        } 
 
        
    }
}
