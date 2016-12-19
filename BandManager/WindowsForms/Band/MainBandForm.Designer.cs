using WindowsForms.Band.Controls;

namespace WindowsForms.Band
{
    partial class MainBandForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBandForm));
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.bnSongs = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnMoveSelected = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.chordsRichText = new System.Windows.Forms.RichTextBox();
            this.btnGetSongs = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.txtBoxGroup = new System.Windows.Forms.TextBox();
            this.btnGroup = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnFontSelection = new System.Windows.Forms.Button();
            this.checkBoxChords = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveEmpty = new System.Windows.Forms.Button();
            this.btnTransposeUp = new System.Windows.Forms.Button();
            this.btnTransposeDown = new System.Windows.Forms.Button();
            this.txtBoxTargetScale = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstSelectedSongs = new ExtendedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timerBreaks = new System.Windows.Forms.Timer(this.components);
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.btnFinances = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnAgreements = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnSongs)).BeginInit();
            this.bnSongs.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToOrderColumns = true;
            this.dgvSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(12, 48);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.Size = new System.Drawing.Size(339, 381);
            this.dgvSongs.TabIndex = 0;
            this.dgvSongs.DoubleClick += new System.EventHandler(this.dgvSongs_DoubleClick);
            this.dgvSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSongs_KeyDown);
            // 
            // bnSongs
            // 
            this.bnSongs.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnSongs.CountItem = this.bindingNavigatorCountItem;
            this.bnSongs.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnSongs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnSongs.Location = new System.Drawing.Point(0, 0);
            this.bnSongs.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnSongs.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnSongs.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnSongs.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnSongs.Name = "bnSongs";
            this.bnSongs.PositionItem = this.bindingNavigatorPositionItem;
            this.bnSongs.Size = new System.Drawing.Size(1234, 25);
            this.bnSongs.TabIndex = 1;
            this.bnSongs.Text = "bnSongs";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(24, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print Blocks";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnMoveSelected
            // 
            this.btnMoveSelected.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMoveSelected.Location = new System.Drawing.Point(266, 435);
            this.btnMoveSelected.Name = "btnMoveSelected";
            this.btnMoveSelected.Size = new System.Drawing.Size(87, 23);
            this.btnMoveSelected.TabIndex = 1;
            this.btnMoveSelected.Text = "Move Selected";
            this.btnMoveSelected.UseVisualStyleBackColor = true;
            this.btnMoveSelected.Click += new System.EventHandler(this.btnMoveSelected_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(30, 107);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveSelected.TabIndex = 5;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(30, 16);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(120, 23);
            this.btnMoveUp.TabIndex = 6;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(30, 45);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(120, 23);
            this.btnMoveDown.TabIndex = 7;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(30, 194);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chordsRichText
            // 
            this.chordsRichText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chordsRichText.Location = new System.Drawing.Point(369, 49);
            this.chordsRichText.Name = "chordsRichText";
            this.chordsRichText.ReadOnly = true;
            this.chordsRichText.Size = new System.Drawing.Size(330, 380);
            this.chordsRichText.TabIndex = 11;
            this.chordsRichText.Text = "";
            this.chordsRichText.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chordsRichText_MouseDoubleClick);
            // 
            // btnGetSongs
            // 
            this.btnGetSongs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGetSongs.Location = new System.Drawing.Point(12, 435);
            this.btnGetSongs.Name = "btnGetSongs";
            this.btnGetSongs.Size = new System.Drawing.Size(87, 23);
            this.btnGetSongs.TabIndex = 0;
            this.btnGetSongs.Text = "Get Songs";
            this.btnGetSongs.UseVisualStyleBackColor = true;
            this.btnGetSongs.Click += new System.EventHandler(this.btnGetSongs_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxFilter.Location = new System.Drawing.Point(102, 437);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(160, 20);
            this.textBoxFilter.TabIndex = 14;
            this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
            this.textBoxFilter.Leave += new System.EventHandler(this.textBoxFilter_Leave);
            // 
            // txtBoxGroup
            // 
            this.txtBoxGroup.Location = new System.Drawing.Point(98, 137);
            this.txtBoxGroup.Name = "txtBoxGroup";
            this.txtBoxGroup.Size = new System.Drawing.Size(50, 20);
            this.txtBoxGroup.TabIndex = 15;
            this.txtBoxGroup.Text = "10";
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(30, 136);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(64, 23);
            this.btnGroup.TabIndex = 16;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnFontSelection);
            this.groupBox.Controls.Add(this.checkBoxChords);
            this.groupBox.Controls.Add(this.btnPrint);
            this.groupBox.Location = new System.Drawing.Point(6, 235);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(153, 133);
            this.groupBox.TabIndex = 18;
            this.groupBox.TabStop = false;
            // 
            // btnFontSelection
            // 
            this.btnFontSelection.Location = new System.Drawing.Point(24, 55);
            this.btnFontSelection.Name = "btnFontSelection";
            this.btnFontSelection.Size = new System.Drawing.Size(118, 23);
            this.btnFontSelection.TabIndex = 4;
            this.btnFontSelection.Tag = "";
            this.btnFontSelection.Text = "Print Font";
            this.btnFontSelection.UseVisualStyleBackColor = true;
            this.btnFontSelection.Click += new System.EventHandler(this.btnFontSelection_Click);
            // 
            // checkBoxChords
            // 
            this.checkBoxChords.AutoSize = true;
            this.checkBoxChords.Location = new System.Drawing.Point(24, 95);
            this.checkBoxChords.Name = "checkBoxChords";
            this.checkBoxChords.Size = new System.Drawing.Size(84, 17);
            this.checkBoxChords.TabIndex = 3;
            this.checkBoxChords.Text = "With Chords";
            this.checkBoxChords.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveEmpty);
            this.groupBox1.Controls.Add(this.groupBox);
            this.groupBox1.Controls.Add(this.btnGroup);
            this.groupBox1.Controls.Add(this.txtBoxGroup);
            this.groupBox1.Controls.Add(this.btnMoveUp);
            this.groupBox1.Controls.Add(this.btnMoveDown);
            this.groupBox1.Controls.Add(this.btnRemoveSelected);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(1068, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 380);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnRemoveEmpty
            // 
            this.btnRemoveEmpty.Location = new System.Drawing.Point(30, 77);
            this.btnRemoveEmpty.Name = "btnRemoveEmpty";
            this.btnRemoveEmpty.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveEmpty.TabIndex = 19;
            this.btnRemoveEmpty.Text = "Remove Empty";
            this.btnRemoveEmpty.UseVisualStyleBackColor = true;
            this.btnRemoveEmpty.Click += new System.EventHandler(this.btnRemoveEmpty_Click);
            // 
            // btnTransposeUp
            // 
            this.btnTransposeUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTransposeUp.Location = new System.Drawing.Point(369, 434);
            this.btnTransposeUp.Name = "btnTransposeUp";
            this.btnTransposeUp.Size = new System.Drawing.Size(113, 23);
            this.btnTransposeUp.TabIndex = 2;
            this.btnTransposeUp.Text = "Transpose Up";
            this.btnTransposeUp.UseVisualStyleBackColor = true;
            this.btnTransposeUp.Click += new System.EventHandler(this.btnTransposeUp_Click);
            // 
            // btnTransposeDown
            // 
            this.btnTransposeDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTransposeDown.Location = new System.Drawing.Point(586, 434);
            this.btnTransposeDown.Name = "btnTransposeDown";
            this.btnTransposeDown.Size = new System.Drawing.Size(113, 23);
            this.btnTransposeDown.TabIndex = 3;
            this.btnTransposeDown.Text = "Transpose Down";
            this.btnTransposeDown.UseVisualStyleBackColor = true;
            this.btnTransposeDown.Click += new System.EventHandler(this.btnTransposeDown_Click);
            // 
            // txtBoxTargetScale
            // 
            this.txtBoxTargetScale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBoxTargetScale.Location = new System.Drawing.Point(488, 436);
            this.txtBoxTargetScale.Name = "txtBoxTargetScale";
            this.txtBoxTargetScale.Size = new System.Drawing.Size(91, 20);
            this.txtBoxTargetScale.TabIndex = 22;
            this.txtBoxTargetScale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxTargetScale_KeyDown);
            this.txtBoxTargetScale.Leave += new System.EventHandler(this.txtBoxTargetScale_Leave);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 494);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1234, 22);
            this.statusStrip.TabIndex = 23;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripProgressBar.Size = new System.Drawing.Size(1060, 16);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Location = new System.Drawing.Point(5, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 441);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Songs";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Location = new System.Drawing.Point(363, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 441);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chords";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.lstSelectedSongs);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(711, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 441);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Blocks";
            // 
            // lstSelectedSongs
            // 
            this.lstSelectedSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSelectedSongs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstSelectedSongs.FormattingEnabled = true;
            this.lstSelectedSongs.ItemHeight = 14;
            this.lstSelectedSongs.Location = new System.Drawing.Point(6, 24);
            this.lstSelectedSongs.Name = "lstSelectedSongs";
            this.lstSelectedSongs.ScrollAlwaysVisible = true;
            this.lstSelectedSongs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedSongs.Size = new System.Drawing.Size(339, 368);
            this.lstSelectedSongs.TabIndex = 4;
            this.lstSelectedSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSelectedSongs_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(-586, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get songs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetSongs_Click);
            // 
            // timerBreaks
            // 
            this.timerBreaks.Interval = 1000;
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 60000;
            // 
            // btnFinances
            // 
            this.btnFinances.Location = new System.Drawing.Point(1072, 414);
            this.btnFinances.Name = "btnFinances";
            this.btnFinances.Size = new System.Drawing.Size(76, 23);
            this.btnFinances.TabIndex = 28;
            this.btnFinances.Text = "Finances";
            this.btnFinances.UseVisualStyleBackColor = true;
            this.btnFinances.Click += new System.EventHandler(this.btnFinances_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1154, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 23);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Location = new System.Drawing.Point(1154, 414);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(76, 23);
            this.btnCalendar.TabIndex = 30;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnYoutube
            // 
            this.btnYoutube.Location = new System.Drawing.Point(1072, 439);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(76, 23);
            this.btnYoutube.TabIndex = 31;
            this.btnYoutube.Text = "Youtube";
            this.btnYoutube.UseVisualStyleBackColor = true;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(1154, 439);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(76, 23);
            this.btnEmail.TabIndex = 32;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnAgreements
            // 
            this.btnAgreements.Location = new System.Drawing.Point(1072, 465);
            this.btnAgreements.Name = "btnAgreements";
            this.btnAgreements.Size = new System.Drawing.Size(76, 23);
            this.btnAgreements.TabIndex = 33;
            this.btnAgreements.Text = "Agreements";
            this.btnAgreements.UseVisualStyleBackColor = true;
            this.btnAgreements.Click += new System.EventHandler(this.btnAgreements_Click);
            // 
            // ProgressBandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 516);
            this.Controls.Add(this.btnAgreements);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnYoutube);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFinances);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.txtBoxTargetScale);
            this.Controls.Add(this.btnTransposeDown);
            this.Controls.Add(this.btnTransposeUp);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.btnGetSongs);
            this.Controls.Add(this.chordsRichText);
            this.Controls.Add(this.btnMoveSelected);
            this.Controls.Add(this.bnSongs);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.MaximumSize = new System.Drawing.Size(1250, 1000);
            this.MinimumSize = new System.Drawing.Size(1250, 500);
            this.Name = "ProgressBandForm";
            this.Text = "Progress Band";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnSongs)).EndInit();
            this.bnSongs.ResumeLayout(false);
            this.bnSongs.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.BindingNavigator bnSongs;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnMoveSelected;
        private ExtendedListBox lstSelectedSongs;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox chordsRichText;
        private System.Windows.Forms.Button btnGetSongs;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.TextBox txtBoxGroup;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox checkBoxChords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTransposeUp;
        private System.Windows.Forms.Button btnTransposeDown;
        private System.Windows.Forms.TextBox txtBoxTargetScale;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button btnRemoveEmpty;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button btnFontSelection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerBreaks;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.Button btnFinances;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnYoutube;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnAgreements;
    }
}

