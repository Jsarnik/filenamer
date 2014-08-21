namespace DynamicFileName
{
    partial class Form1
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
            this.txtAppend = new System.Windows.Forms.TextBox();
            this.lblAt = new System.Windows.Forms.Label();
            this.txtOldString = new System.Windows.Forms.TextBox();
            this.txtNewString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.chkReplace = new System.Windows.Forms.CheckBox();
            this.chkInsert = new System.Windows.Forms.CheckBox();
            this.chkAppend = new System.Windows.Forms.CheckBox();
            this.grpReplace = new System.Windows.Forms.GroupBox();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.grpInsert = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToPos = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeftPos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkUseClipBoard = new System.Windows.Forms.CheckBox();
            this.grpAppend = new System.Windows.Forms.GroupBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpClipboard = new System.Windows.Forms.GroupBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.txtSubEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpInsertAll = new System.Windows.Forms.GroupBox();
            this.lblListCount = new System.Windows.Forms.Label();
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createNewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpReplace.SuspendLayout();
            this.grpInsert.SuspendLayout();
            this.grpAppend.SuspendLayout();
            this.grpClipboard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpInsertAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAppend
            // 
            this.txtAppend.Location = new System.Drawing.Point(19, 16);
            this.txtAppend.Name = "txtAppend";
            this.txtAppend.Size = new System.Drawing.Size(308, 20);
            this.txtAppend.TabIndex = 0;
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Location = new System.Drawing.Point(163, 23);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(17, 13);
            this.lblAt.TabIndex = 3;
            this.lblAt.Text = "At";
            // 
            // txtOldString
            // 
            this.txtOldString.Location = new System.Drawing.Point(19, 14);
            this.txtOldString.Name = "txtOldString";
            this.txtOldString.Size = new System.Drawing.Size(149, 20);
            this.txtOldString.TabIndex = 4;
            // 
            // txtNewString
            // 
            this.txtNewString.Location = new System.Drawing.Point(206, 14);
            this.txtNewString.Name = "txtNewString";
            this.txtNewString.Size = new System.Drawing.Size(152, 20);
            this.txtNewString.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "with";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(47, 20);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(110, 20);
            this.txtInsert.TabIndex = 9;
            // 
            // chkReplace
            // 
            this.chkReplace.AutoSize = true;
            this.chkReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReplace.Location = new System.Drawing.Point(9, 36);
            this.chkReplace.Name = "chkReplace";
            this.chkReplace.Size = new System.Drawing.Size(73, 17);
            this.chkReplace.TabIndex = 13;
            this.chkReplace.Text = "Replace";
            this.chkReplace.UseVisualStyleBackColor = true;
            this.chkReplace.CheckedChanged += new System.EventHandler(this.chkReplace_CheckedChanged);
            // 
            // chkInsert
            // 
            this.chkInsert.AutoSize = true;
            this.chkInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsert.Location = new System.Drawing.Point(9, 94);
            this.chkInsert.Name = "chkInsert";
            this.chkInsert.Size = new System.Drawing.Size(58, 17);
            this.chkInsert.TabIndex = 14;
            this.chkInsert.Text = "Insert";
            this.chkInsert.UseVisualStyleBackColor = true;
            this.chkInsert.CheckedChanged += new System.EventHandler(this.chkInsert_CheckedChanged);
            // 
            // chkAppend
            // 
            this.chkAppend.AutoSize = true;
            this.chkAppend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAppend.Location = new System.Drawing.Point(9, 234);
            this.chkAppend.Name = "chkAppend";
            this.chkAppend.Size = new System.Drawing.Size(69, 17);
            this.chkAppend.TabIndex = 15;
            this.chkAppend.Text = "Append";
            this.chkAppend.UseVisualStyleBackColor = true;
            this.chkAppend.CheckedChanged += new System.EventHandler(this.chkAppend_CheckedChanged);
            // 
            // grpReplace
            // 
            this.grpReplace.Controls.Add(this.chkCase);
            this.grpReplace.Controls.Add(this.txtOldString);
            this.grpReplace.Controls.Add(this.txtNewString);
            this.grpReplace.Controls.Add(this.btnReplace);
            this.grpReplace.Controls.Add(this.label3);
            this.grpReplace.Enabled = false;
            this.grpReplace.Location = new System.Drawing.Point(15, 50);
            this.grpReplace.Name = "grpReplace";
            this.grpReplace.Size = new System.Drawing.Size(529, 40);
            this.grpReplace.TabIndex = 16;
            this.grpReplace.TabStop = false;
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(371, 16);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(83, 17);
            this.chkCase.TabIndex = 8;
            this.chkCase.Text = "Match Case";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(460, 12);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(56, 23);
            this.btnReplace.TabIndex = 36;
            this.btnReplace.Text = "Apply";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // grpInsert
            // 
            this.grpInsert.Controls.Add(this.label8);
            this.grpInsert.Controls.Add(this.label4);
            this.grpInsert.Controls.Add(this.txtToPos);
            this.grpInsert.Controls.Add(this.lblTo);
            this.grpInsert.Controls.Add(this.label2);
            this.grpInsert.Controls.Add(this.txtLeftPos);
            this.grpInsert.Controls.Add(this.label5);
            this.grpInsert.Controls.Add(this.chkUseClipBoard);
            this.grpInsert.Controls.Add(this.lblAt);
            this.grpInsert.Controls.Add(this.txtInsert);
            this.grpInsert.Enabled = false;
            this.grpInsert.Location = new System.Drawing.Point(6, 9);
            this.grpInsert.Name = "grpInsert";
            this.grpInsert.Size = new System.Drawing.Size(239, 105);
            this.grpInsert.TabIndex = 17;
            this.grpInsert.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Pos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pos";
            // 
            // txtToPos
            // 
            this.txtToPos.Location = new System.Drawing.Point(183, 46);
            this.txtToPos.Name = "txtToPos";
            this.txtToPos.Size = new System.Drawing.Size(24, 20);
            this.txtToPos.TabIndex = 22;
            this.txtToPos.Text = "0";
            this.txtToPos.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(163, 49);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 21;
            this.lblTo.Text = "To";
            this.lblTo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Text:";
            // 
            // txtLeftPos
            // 
            this.txtLeftPos.Location = new System.Drawing.Point(183, 20);
            this.txtLeftPos.Name = "txtLeftPos";
            this.txtLeftPos.Size = new System.Drawing.Size(24, 20);
            this.txtLeftPos.TabIndex = 19;
            this.txtLeftPos.Text = "0";
            this.txtLeftPos.TextChanged += new System.EventHandler(this.txtLeftPos_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.label5.Location = new System.Drawing.Point(10, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "[ *NOTE: 0 based index BEFORE cut.* ]";
            // 
            // chkUseClipBoard
            // 
            this.chkUseClipBoard.AutoSize = true;
            this.chkUseClipBoard.Location = new System.Drawing.Point(47, 48);
            this.chkUseClipBoard.Name = "chkUseClipBoard";
            this.chkUseClipBoard.Size = new System.Drawing.Size(100, 17);
            this.chkUseClipBoard.TabIndex = 17;
            this.chkUseClipBoard.Text = "Move Substring";
            this.chkUseClipBoard.UseVisualStyleBackColor = true;
            this.chkUseClipBoard.CheckedChanged += new System.EventHandler(this.chkUseClipBoard_CheckedChanged);
            // 
            // grpAppend
            // 
            this.grpAppend.Controls.Add(this.txtAppend);
            this.grpAppend.Controls.Add(this.btnAppend);
            this.grpAppend.Enabled = false;
            this.grpAppend.Location = new System.Drawing.Point(14, 248);
            this.grpAppend.Name = "grpAppend";
            this.grpAppend.Size = new System.Drawing.Size(418, 44);
            this.grpAppend.TabIndex = 18;
            this.grpAppend.TabStop = false;
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(346, 14);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(56, 23);
            this.btnAppend.TabIndex = 38;
            this.btnAppend.Text = "Apply";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 121);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(12, 64);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 27;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 92);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Unselect All";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grpClipboard
            // 
            this.grpClipboard.Controls.Add(this.chkDelete);
            this.grpClipboard.Controls.Add(this.txtSubEnd);
            this.grpClipboard.Controls.Add(this.label7);
            this.grpClipboard.Controls.Add(this.txtSubStart);
            this.grpClipboard.Controls.Add(this.label6);
            this.grpClipboard.Enabled = false;
            this.grpClipboard.Location = new System.Drawing.Point(251, 9);
            this.grpClipboard.Name = "grpClipboard";
            this.grpClipboard.Size = new System.Drawing.Size(203, 105);
            this.grpClipboard.TabIndex = 18;
            this.grpClipboard.TabStop = false;
            this.grpClipboard.Text = "Substring";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(9, 79);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(158, 17);
            this.chkDelete.TabIndex = 42;
            this.chkDelete.Text = "Delete Substring Altogether!";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // txtSubEnd
            // 
            this.txtSubEnd.Location = new System.Drawing.Point(88, 43);
            this.txtSubEnd.Name = "txtSubEnd";
            this.txtSubEnd.Size = new System.Drawing.Size(62, 20);
            this.txtSubEnd.TabIndex = 19;
            this.txtSubEnd.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Length";
            // 
            // txtSubStart
            // 
            this.txtSubStart.Location = new System.Drawing.Point(88, 19);
            this.txtSubStart.Name = "txtSubStart";
            this.txtSubStart.Size = new System.Drawing.Size(62, 20);
            this.txtSubStart.TabIndex = 17;
            this.txtSubStart.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Start Position";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(460, 15);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(56, 23);
            this.btnInsert.TabIndex = 37;
            this.btnInsert.Text = "Apply";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(446, 254);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(202, 38);
            this.btnRename.TabIndex = 29;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Location = new System.Drawing.Point(550, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 178);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(12, 14);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 39;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpInsertAll
            // 
            this.grpInsertAll.Controls.Add(this.grpInsert);
            this.grpInsertAll.Controls.Add(this.grpClipboard);
            this.grpInsertAll.Controls.Add(this.btnInsert);
            this.grpInsertAll.Enabled = false;
            this.grpInsertAll.Location = new System.Drawing.Point(15, 108);
            this.grpInsertAll.Name = "grpInsertAll";
            this.grpInsertAll.Size = new System.Drawing.Size(529, 120);
            this.grpInsertAll.TabIndex = 40;
            this.grpInsertAll.TabStop = false;
            // 
            // lblListCount
            // 
            this.lblListCount.AutoSize = true;
            this.lblListCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCount.Location = new System.Drawing.Point(640, 324);
            this.lblListCount.Name = "lblListCount";
            this.lblListCount.Size = new System.Drawing.Size(0, 13);
            this.lblListCount.TabIndex = 41;
            // 
            // dgFiles
            // 
            this.dgFiles.AllowDrop = true;
            this.dgFiles.AllowUserToAddRows = false;
            this.dgFiles.AllowUserToOrderColumns = true;
            this.dgFiles.AllowUserToResizeRows = false;
            this.dgFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgFiles.Location = new System.Drawing.Point(12, 318);
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.RowHeadersWidth = 40;
            this.dgFiles.Size = new System.Drawing.Size(639, 459);
            this.dgFiles.TabIndex = 43;
            this.dgFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstOld_DragDrop);
            this.dgFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstOld_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Drag and Drop Files or Folders Below";
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(196, 296);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 19);
            this.lblCount.TabIndex = 45;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelImportToolStripMenuItem,
            this.toolStripSeparator1,
            this.createNewOrderToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.optionsToolStripMenuItem.Text = "Custom Tools";
            // 
            // excelImportToolStripMenuItem
            // 
            this.excelImportToolStripMenuItem.Name = "excelImportToolStripMenuItem";
            this.excelImportToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.excelImportToolStripMenuItem.Text = "Excel Import";
            this.excelImportToolStripMenuItem.ToolTipText = "Rename files based off excel sheet";
            this.excelImportToolStripMenuItem.Click += new System.EventHandler(this.excelImportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // createNewOrderToolStripMenuItem
            // 
            this.createNewOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seperatorToolStripMenuItem});
            this.createNewOrderToolStripMenuItem.Name = "createNewOrderToolStripMenuItem";
            this.createNewOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createNewOrderToolStripMenuItem.Text = "Re-Order";
            this.createNewOrderToolStripMenuItem.ToolTipText = "Append (index_) to filename in the current row order.";
            // 
            // seperatorToolStripMenuItem
            // 
            this.seperatorToolStripMenuItem.Name = "seperatorToolStripMenuItem";
            this.seperatorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.seperatorToolStripMenuItem.Text = "Enter Seperator";
            this.seperatorToolStripMenuItem.Click += new System.EventHandler(this.seperatorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 788);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgFiles);
            this.Controls.Add(this.lblListCount);
            this.Controls.Add(this.grpInsertAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.chkAppend);
            this.Controls.Add(this.chkInsert);
            this.Controls.Add(this.chkReplace);
            this.Controls.Add(this.grpAppend);
            this.Controls.Add(this.grpReplace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File Renamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpReplace.ResumeLayout(false);
            this.grpReplace.PerformLayout();
            this.grpInsert.ResumeLayout(false);
            this.grpInsert.PerformLayout();
            this.grpAppend.ResumeLayout(false);
            this.grpAppend.PerformLayout();
            this.grpClipboard.ResumeLayout(false);
            this.grpClipboard.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpInsertAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppend;
        private System.Windows.Forms.Label lblAt;
        private System.Windows.Forms.TextBox txtOldString;
        private System.Windows.Forms.TextBox txtNewString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.CheckBox chkReplace;
        private System.Windows.Forms.CheckBox chkInsert;
        private System.Windows.Forms.CheckBox chkAppend;
        private System.Windows.Forms.GroupBox grpReplace;
        private System.Windows.Forms.GroupBox grpInsert;
        private System.Windows.Forms.GroupBox grpAppend;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.GroupBox grpClipboard;
        private System.Windows.Forms.TextBox txtSubStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkUseClipBoard;
        private System.Windows.Forms.TextBox txtSubEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeftPos;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpInsertAll;
        private System.Windows.Forms.Label lblListCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToPos;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelImportToolStripMenuItem;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.ToolStripMenuItem createNewOrderToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem seperatorToolStripMenuItem;
    }
}

