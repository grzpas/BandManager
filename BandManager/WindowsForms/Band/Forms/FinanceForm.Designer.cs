using WindowsForms.Band.Controls;

namespace WindowsForms.Band.Forms
{
    partial class FinanceForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckBoxOptimize = new System.Windows.Forms.CheckBox();
            this.btnShowRoute = new System.Windows.Forms.Button();
            this.chckBoxAvoidTolls = new System.Windows.Forms.CheckBox();
            this.chckBoxAvoidHighways = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtBoxDistance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstBoxPlaces = new System.Windows.Forms.ListBox();
            this.txtBoxPlace = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEventDetails = new System.Windows.Forms.Button();
            this.chkBoxDeletePrevious = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSavePayroll = new System.Windows.Forms.Button();
            this.btnCalculatePayroll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTotal = new NumericTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckBoxOptimize);
            this.groupBox1.Controls.Add(this.btnShowRoute);
            this.groupBox1.Controls.Add(this.chckBoxAvoidTolls);
            this.groupBox1.Controls.Add(this.chckBoxAvoidHighways);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lstBoxPlaces);
            this.groupBox1.Controls.Add(this.txtBoxPlace);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 458);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transport Cost Calculation";
            // 
            // chckBoxOptimize
            // 
            this.chckBoxOptimize.AutoSize = true;
            this.chckBoxOptimize.Location = new System.Drawing.Point(25, 87);
            this.chckBoxOptimize.Name = "chckBoxOptimize";
            this.chckBoxOptimize.Size = new System.Drawing.Size(116, 17);
            this.chckBoxOptimize.TabIndex = 9;
            this.chckBoxOptimize.TabStop = false;
            this.chckBoxOptimize.Text = "Optimize waypoints";
            this.chckBoxOptimize.UseVisualStyleBackColor = true;
            // 
            // btnShowRoute
            // 
            this.btnShowRoute.Location = new System.Drawing.Point(24, 106);
            this.btnShowRoute.Name = "btnShowRoute";
            this.btnShowRoute.Size = new System.Drawing.Size(75, 23);
            this.btnShowRoute.TabIndex = 1;
            this.btnShowRoute.Text = "Show Route";
            this.btnShowRoute.UseVisualStyleBackColor = true;
            this.btnShowRoute.Click += new System.EventHandler(this.btnShowRoute_Click);
            // 
            // chckBoxAvoidTolls
            // 
            this.chckBoxAvoidTolls.AutoSize = true;
            this.chckBoxAvoidTolls.Location = new System.Drawing.Point(25, 65);
            this.chckBoxAvoidTolls.Name = "chckBoxAvoidTolls";
            this.chckBoxAvoidTolls.Size = new System.Drawing.Size(74, 17);
            this.chckBoxAvoidTolls.TabIndex = 8;
            this.chckBoxAvoidTolls.TabStop = false;
            this.chckBoxAvoidTolls.Text = "Avoid tolls";
            this.chckBoxAvoidTolls.UseVisualStyleBackColor = true;
            // 
            // chckBoxAvoidHighways
            // 
            this.chckBoxAvoidHighways.AutoSize = true;
            this.chckBoxAvoidHighways.Location = new System.Drawing.Point(25, 42);
            this.chckBoxAvoidHighways.Name = "chckBoxAvoidHighways";
            this.chckBoxAvoidHighways.Size = new System.Drawing.Size(100, 17);
            this.chckBoxAvoidHighways.TabIndex = 7;
            this.chckBoxAvoidHighways.TabStop = false;
            this.chckBoxAvoidHighways.Text = "Avoid highways";
            this.chckBoxAvoidHighways.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser);
            this.groupBox2.Controls.Add(this.lblDistance);
            this.groupBox2.Controls.Add(this.txtBoxDistance);
            this.groupBox2.Location = new System.Drawing.Point(6, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 314);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actual";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(6, 14);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(325, 268);
            this.webBrowser.TabIndex = 5;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(40, 288);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(52, 13);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Distance:";
            // 
            // txtBoxDistance
            // 
            this.txtBoxDistance.Location = new System.Drawing.Point(139, 288);
            this.txtBoxDistance.Name = "txtBoxDistance";
            this.txtBoxDistance.Size = new System.Drawing.Size(177, 20);
            this.txtBoxDistance.TabIndex = 2;
            this.txtBoxDistance.Text = "0";
            this.txtBoxDistance.DoubleClick += new System.EventHandler(this.txtBoxDistance_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Add Place:";
            // 
            // lstBoxPlaces
            // 
            this.lstBoxPlaces.FormattingEnabled = true;
            this.lstBoxPlaces.Location = new System.Drawing.Point(145, 42);
            this.lstBoxPlaces.Name = "lstBoxPlaces";
            this.lstBoxPlaces.Size = new System.Drawing.Size(198, 82);
            this.lstBoxPlaces.TabIndex = 1;
            this.lstBoxPlaces.TabStop = false;
            this.lstBoxPlaces.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstBoxPlaces_KeyUp);
            // 
            // txtBoxPlace
            // 
            this.txtBoxPlace.Location = new System.Drawing.Point(145, 16);
            this.txtBoxPlace.Name = "txtBoxPlace";
            this.txtBoxPlace.Size = new System.Drawing.Size(177, 20);
            this.txtBoxPlace.TabIndex = 0;
            this.txtBoxPlace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPlace_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEventDetails);
            this.groupBox3.Controls.Add(this.chkBoxDeletePrevious);
            this.groupBox3.Controls.Add(this.dateTimePicker);
            this.groupBox3.Controls.Add(this.btnSavePayroll);
            this.groupBox3.Controls.Add(this.btnCalculatePayroll);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBoxTotal);
            this.groupBox3.Location = new System.Drawing.Point(367, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 432);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payroll";
            // 
            // btnEventDetails
            // 
            this.btnEventDetails.Location = new System.Drawing.Point(192, 10);
            this.btnEventDetails.Name = "btnEventDetails";
            this.btnEventDetails.Size = new System.Drawing.Size(100, 23);
            this.btnEventDetails.TabIndex = 39;
            this.btnEventDetails.Text = "Upcoming event";
            this.btnEventDetails.UseVisualStyleBackColor = true;
            this.btnEventDetails.Click += new System.EventHandler(this.btnEventDetails_Click);
            // 
            // chkBoxDeletePrevious
            // 
            this.chkBoxDeletePrevious.AutoSize = true;
            this.chkBoxDeletePrevious.Location = new System.Drawing.Point(100, 276);
            this.chkBoxDeletePrevious.Name = "chkBoxDeletePrevious";
            this.chkBoxDeletePrevious.Size = new System.Drawing.Size(100, 17);
            this.chkBoxDeletePrevious.TabIndex = 41;
            this.chkBoxDeletePrevious.Text = "Delete previous";
            this.chkBoxDeletePrevious.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(2, 248);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker.TabIndex = 40;
            // 
            // btnSavePayroll
            // 
            this.btnSavePayroll.Location = new System.Drawing.Point(200, 272);
            this.btnSavePayroll.Name = "btnSavePayroll";
            this.btnSavePayroll.Size = new System.Drawing.Size(75, 23);
            this.btnSavePayroll.TabIndex = 36;
            this.btnSavePayroll.Text = "Save Payroll";
            this.btnSavePayroll.UseVisualStyleBackColor = true;
            this.btnSavePayroll.Click += new System.EventHandler(this.btnSavePayroll_Click);
            // 
            // btnCalculatePayroll
            // 
            this.btnCalculatePayroll.Location = new System.Drawing.Point(200, 245);
            this.btnCalculatePayroll.Name = "btnCalculatePayroll";
            this.btnCalculatePayroll.Size = new System.Drawing.Size(75, 23);
            this.btnCalculatePayroll.TabIndex = 29;
            this.btnCalculatePayroll.Text = "Calculate";
            this.btnCalculatePayroll.UseVisualStyleBackColor = true;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total:";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(100, 12);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(85, 20);
            this.txtBoxTotal.TabIndex = 15;
            this.txtBoxTotal.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(592, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(679, 471);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FinanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finances";
            this.DoubleClick += new System.EventHandler(this.FinanceForm_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxPlace;
        private System.Windows.Forms.ListBox lstBoxPlaces;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxDistance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalculatePayroll;
        private System.Windows.Forms.Label label1;
        private NumericTextBox txtBoxTotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSavePayroll;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox chkBoxDeletePrevious;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.CheckBox chckBoxAvoidTolls;
        private System.Windows.Forms.CheckBox chckBoxAvoidHighways;
        private System.Windows.Forms.Button btnEventDetails;
        private System.Windows.Forms.Button btnShowRoute;
        private System.Windows.Forms.CheckBox chckBoxOptimize;
    }
}
