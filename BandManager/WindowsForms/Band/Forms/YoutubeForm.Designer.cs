namespace WindowsForms.Band.Forms
{
    partial class YoutubeForm
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
            this.txtBoxFilmLinks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxFilmLinks
            // 
            this.txtBoxFilmLinks.Location = new System.Drawing.Point(12, 12);
            this.txtBoxFilmLinks.Multiline = true;
            this.txtBoxFilmLinks.Name = "txtBoxFilmLinks";
            this.txtBoxFilmLinks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxFilmLinks.Size = new System.Drawing.Size(568, 242);
            this.txtBoxFilmLinks.TabIndex = 0;
            this.txtBoxFilmLinks.DoubleClick += new System.EventHandler(this.txtBoxFilmLinks_DoubleClick);
            // 
            // YoutubeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(592, 266);
            this.Controls.Add(this.txtBoxFilmLinks);
            this.Name = "YoutubeForm";
            this.Text = "Youtube";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxFilmLinks;
    }
}
