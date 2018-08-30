using System;
using System.ComponentModel;

namespace TIIDE
{
    partial class TIIDE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openTIProjectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeFormattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.FontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtxtbIDE = new System.Windows.Forms.RichTextBox();
            this.lineNumberDisplay = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLoadingBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.projectToolStripMenuItem1,
            this.buildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exportProgramToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.openTIProjectFileToolStripMenuItem,
            this.importProgramToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fILEToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exportProgramToolStripMenuItem
            // 
            this.exportProgramToolStripMenuItem.Enabled = false;
            this.exportProgramToolStripMenuItem.Name = "exportProgramToolStripMenuItem";
            this.exportProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportProgramToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportProgramToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // openTIProjectFileToolStripMenuItem
            // 
            this.openTIProjectFileToolStripMenuItem.Enabled = false;
            this.openTIProjectFileToolStripMenuItem.Name = "openTIProjectFileToolStripMenuItem";
            this.openTIProjectFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openTIProjectFileToolStripMenuItem.Text = "Open Project";
            this.openTIProjectFileToolStripMenuItem.Click += new System.EventHandler(this.OpenTIProjectFileToolStripMenuItem_Click);
            // 
            // importProgramToolStripMenuItem
            // 
            this.importProgramToolStripMenuItem.Enabled = false;
            this.importProgramToolStripMenuItem.Name = "importProgramToolStripMenuItem";
            this.importProgramToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importProgramToolStripMenuItem.Text = "Save Project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt-F4";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeFormattingToolStripMenuItem,
            this.fileInformationToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.projectToolStripMenuItem.Text = "View";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // codeFormattingToolStripMenuItem
            // 
            this.codeFormattingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.hexToolStripMenuItem,
            this.rawToolStripMenuItem});
            this.codeFormattingToolStripMenuItem.Name = "codeFormattingToolStripMenuItem";
            this.codeFormattingToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.codeFormattingToolStripMenuItem.Text = "Code Formatting";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Checked = true;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.StandardToolStripMenuItem_Click);
            // 
            // hexToolStripMenuItem
            // 
            this.hexToolStripMenuItem.Name = "hexToolStripMenuItem";
            this.hexToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.hexToolStripMenuItem.Text = "Hex";
            this.hexToolStripMenuItem.Click += new System.EventHandler(this.HexToolStripMenuItem_Click);
            // 
            // rawToolStripMenuItem
            // 
            this.rawToolStripMenuItem.CheckOnClick = true;
            this.rawToolStripMenuItem.Name = "rawToolStripMenuItem";
            this.rawToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.rawToolStripMenuItem.Text = "Raw";
            this.rawToolStripMenuItem.Click += new System.EventHandler(this.RawToolStripMenuItem_Click);
            // 
            // fileInformationToolStripMenuItem
            // 
            this.fileInformationToolStripMenuItem.Enabled = false;
            this.fileInformationToolStripMenuItem.Name = "fileInformationToolStripMenuItem";
            this.fileInformationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.fileInformationToolStripMenuItem.Text = "File Information...";
            this.fileInformationToolStripMenuItem.Click += new System.EventHandler(this.FileInformationToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem1
            // 
            this.projectToolStripMenuItem1.Enabled = false;
            this.projectToolStripMenuItem1.Name = "projectToolStripMenuItem1";
            this.projectToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem1.Text = "Project";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.FontSizeComboBox,
            this.toolStripSplitButton1,
            this.toolStripComboBox2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1007, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // FontSizeComboBox
            // 
            this.FontSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSizeComboBox.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(121, 25);
            this.FontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.FontSizeComboBox_TextChanged);
            this.FontSizeComboBox.TextChanged += new System.EventHandler(this.FontSizeComboBox_TextChanged);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(92, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lineNumberDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtxtbIDE);
            this.splitContainer1.Size = new System.Drawing.Size(1007, 468);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 7;
            // 
            // rtxtbIDE
            // 
            this.rtxtbIDE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtbIDE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbIDE.Location = new System.Drawing.Point(0, 0);
            this.rtxtbIDE.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.rtxtbIDE.Name = "rtxtbIDE";
            this.rtxtbIDE.Size = new System.Drawing.Size(924, 468);
            this.rtxtbIDE.TabIndex = 7;
            this.rtxtbIDE.Text = "";
            this.rtxtbIDE.WordWrap = false;
            // 
            // lineNumberDisplay
            // 
            this.lineNumberDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.lineNumberDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineNumberDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineNumberDisplay.Location = new System.Drawing.Point(0, 0);
            this.lineNumberDisplay.Name = "lineNumberDisplay";
            this.lineNumberDisplay.ReadOnly = true;
            this.lineNumberDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lineNumberDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lineNumberDisplay.ShortcutsEnabled = false;
            this.lineNumberDisplay.Size = new System.Drawing.Size(79, 468);
            this.lineNumberDisplay.TabIndex = 6;
            this.lineNumberDisplay.TabStop = false;
            this.lineNumberDisplay.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLoadingBar2});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1007, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusLoadingBar2
            // 
            this.statusLoadingBar2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusLoadingBar2.Name = "statusLoadingBar2";
            this.statusLoadingBar2.RightToLeftLayout = true;
            this.statusLoadingBar2.Size = new System.Drawing.Size(200, 16);
            // 
            // TIIDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 517);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TIIDE";
            this.Text = "TIIDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTIProjectFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox FontSizeComboBox;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem codeFormattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileInformationToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtxtbIDE;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar statusLoadingBar2;
        public System.Windows.Forms.RichTextBox lineNumberDisplay;
    }
}

