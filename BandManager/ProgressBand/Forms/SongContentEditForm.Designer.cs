namespace ProgressBand
{
    partial class SongContentEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongContentEditForm));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.richTextBoxChords = new System.Windows.Forms.RichTextBox();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxLowestTone = new System.Windows.Forms.TextBox();
            this.textBoxHighestTone = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScale = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLowerTone = new System.Windows.Forms.Label();
            this.lblLowestTone = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(88, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(198, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // richTextBoxChords
            // 
            this.richTextBoxChords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxChords.Location = new System.Drawing.Point(292, 2);
            this.richTextBoxChords.Name = "richTextBoxChords";
            this.richTextBoxChords.Size = new System.Drawing.Size(439, 184);
            this.richTextBoxChords.TabIndex = 1;
            this.richTextBoxChords.Text = "";
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(88, 38);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(198, 20);
            this.textBoxScale.TabIndex = 2;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(88, 67);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(198, 20);
            this.textBoxType.TabIndex = 3;
            // 
            // textBoxLowestTone
            // 
            this.textBoxLowestTone.Location = new System.Drawing.Point(88, 93);
            this.textBoxLowestTone.Name = "textBoxLowestTone";
            this.textBoxLowestTone.Size = new System.Drawing.Size(198, 20);
            this.textBoxLowestTone.TabIndex = 4;
            // 
            // textBoxHighestTone
            // 
            this.textBoxHighestTone.Location = new System.Drawing.Point(88, 123);
            this.textBoxHighestTone.Name = "textBoxHighestTone";
            this.textBoxHighestTone.Size = new System.Drawing.Size(198, 20);
            this.textBoxHighestTone.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(12, 46);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(34, 13);
            this.lblScale.TabIndex = 7;
            this.lblScale.Text = "SongScale";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 74);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // lblLowerTone
            // 
            this.lblLowerTone.AutoSize = true;
            this.lblLowerTone.Location = new System.Drawing.Point(12, 102);
            this.lblLowerTone.Name = "lblLowerTone";
            this.lblLowerTone.Size = new System.Drawing.Size(69, 13);
            this.lblLowerTone.TabIndex = 9;
            this.lblLowerTone.Text = "Lowest Tone";
            // 
            // lblLowestTone
            // 
            this.lblLowestTone.AutoSize = true;
            this.lblLowestTone.Location = new System.Drawing.Point(12, 130);
            this.lblLowestTone.Name = "lblLowestTone";
            this.lblLowestTone.Size = new System.Drawing.Size(68, 13);
            this.lblLowestTone.TabIndex = 10;
            this.lblLowestTone.Text = "HighestTone";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(88, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(211, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SongContentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 188);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLowestTone);
            this.Controls.Add(this.lblLowerTone);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblScale);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textBoxHighestTone);
            this.Controls.Add(this.textBoxLowestTone);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.richTextBoxChords);
            this.Controls.Add(this.textBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SongContentEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SongContentEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.RichTextBox richTextBoxChords;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxLowestTone;
        private System.Windows.Forms.TextBox textBoxHighestTone;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLowerTone;
        private System.Windows.Forms.Label lblLowestTone;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}