namespace WindowsForms.Band.Forms
{
    partial class CalendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSelected = new System.Windows.Forms.Button();
            this.btnUpcoming = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBoxCalendarLocation = new System.Windows.Forms.TextBox();
            this.txtBoxCalendarContents = new System.Windows.Forms.TextBox();
            this.txtBoxCalendarTitle = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSelected);
            this.groupBox5.Controls.Add(this.btnUpcoming);
            this.groupBox5.Controls.Add(this.dateTimePicker);
            this.groupBox5.Controls.Add(this.txtBoxCalendarLocation);
            this.groupBox5.Controls.Add(this.txtBoxCalendarContents);
            this.groupBox5.Controls.Add(this.txtBoxCalendarTitle);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(385, 404);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Upcoming event";
            // 
            // btnSelected
            // 
            this.btnSelected.Location = new System.Drawing.Point(253, 76);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(116, 23);
            this.btnSelected.TabIndex = 5;
            this.btnSelected.Text = "Get Selected Event";
            this.btnSelected.UseVisualStyleBackColor = true;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // btnUpcoming
            // 
            this.btnUpcoming.Location = new System.Drawing.Point(253, 27);
            this.btnUpcoming.Name = "btnUpcoming";
            this.btnUpcoming.Size = new System.Drawing.Size(116, 23);
            this.btnUpcoming.TabIndex = 5;
            this.btnUpcoming.Text = "Get Upcoming Event";
            this.btnUpcoming.UseVisualStyleBackColor = true;
            this.btnUpcoming.Click += new System.EventHandler(this.btnUpcoming_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 79);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // txtBoxCalendarLocation
            // 
            this.txtBoxCalendarLocation.Location = new System.Drawing.Point(6, 53);
            this.txtBoxCalendarLocation.Name = "txtBoxCalendarLocation";
            this.txtBoxCalendarLocation.ReadOnly = true;
            this.txtBoxCalendarLocation.Size = new System.Drawing.Size(227, 20);
            this.txtBoxCalendarLocation.TabIndex = 2;
            // 
            // txtBoxCalendarContents
            // 
            this.txtBoxCalendarContents.Location = new System.Drawing.Point(6, 120);
            this.txtBoxCalendarContents.Multiline = true;
            this.txtBoxCalendarContents.Name = "txtBoxCalendarContents";
            this.txtBoxCalendarContents.ReadOnly = true;
            this.txtBoxCalendarContents.Size = new System.Drawing.Size(373, 278);
            this.txtBoxCalendarContents.TabIndex = 1;
            // 
            // txtBoxCalendarTitle
            // 
            this.txtBoxCalendarTitle.Location = new System.Drawing.Point(6, 27);
            this.txtBoxCalendarTitle.Name = "txtBoxCalendarTitle";
            this.txtBoxCalendarTitle.ReadOnly = true;
            this.txtBoxCalendarTitle.Size = new System.Drawing.Size(227, 20);
            this.txtBoxCalendarTitle.TabIndex = 0;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(409, 426);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendar";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtBoxCalendarLocation;
        private System.Windows.Forms.TextBox txtBoxCalendarContents;
        private System.Windows.Forms.TextBox txtBoxCalendarTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSelected;
        private System.Windows.Forms.Button btnUpcoming;
    }
}
