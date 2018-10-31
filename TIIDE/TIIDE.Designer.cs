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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lineNumberDisplay = new System.Windows.Forms.RichTextBox();
            this.rtxtbIDE = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLoadingBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGitHubWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.buildToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1134, 44);
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
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fILEToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exportProgramToolStripMenuItem
            // 
            this.exportProgramToolStripMenuItem.Enabled = false;
            this.exportProgramToolStripMenuItem.Name = "exportProgramToolStripMenuItem";
            this.exportProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportProgramToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.exportProgramToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(321, 6);
            // 
            // openTIProjectFileToolStripMenuItem
            // 
            this.openTIProjectFileToolStripMenuItem.Enabled = false;
            this.openTIProjectFileToolStripMenuItem.Name = "openTIProjectFileToolStripMenuItem";
            this.openTIProjectFileToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.openTIProjectFileToolStripMenuItem.Text = "Open Project";
            this.openTIProjectFileToolStripMenuItem.Click += new System.EventHandler(this.OpenTIProjectFileToolStripMenuItem_Click);
            // 
            // importProgramToolStripMenuItem
            // 
            this.importProgramToolStripMenuItem.Enabled = false;
            this.importProgramToolStripMenuItem.Name = "importProgramToolStripMenuItem";
            this.importProgramToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.importProgramToolStripMenuItem.Text = "Save Project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(321, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt-F4";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeFormattingToolStripMenuItem,
            this.fileInformationToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(78, 38);
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
            this.codeFormattingToolStripMenuItem.Size = new System.Drawing.Size(372, 38);
            this.codeFormattingToolStripMenuItem.Text = "Code Formatting";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Checked = true;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.StandardToolStripMenuItem_Click);
            // 
            // hexToolStripMenuItem
            // 
            this.hexToolStripMenuItem.Name = "hexToolStripMenuItem";
            this.hexToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.hexToolStripMenuItem.Text = "Hex";
            this.hexToolStripMenuItem.Click += new System.EventHandler(this.HexToolStripMenuItem_Click);
            // 
            // rawToolStripMenuItem
            // 
            this.rawToolStripMenuItem.CheckOnClick = true;
            this.rawToolStripMenuItem.Name = "rawToolStripMenuItem";
            this.rawToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.rawToolStripMenuItem.Text = "Raw";
            this.rawToolStripMenuItem.Click += new System.EventHandler(this.RawToolStripMenuItem_Click);
            // 
            // fileInformationToolStripMenuItem
            // 
            this.fileInformationToolStripMenuItem.Enabled = false;
            this.fileInformationToolStripMenuItem.Name = "fileInformationToolStripMenuItem";
            this.fileInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.fileInformationToolStripMenuItem.Size = new System.Drawing.Size(372, 38);
            this.fileInformationToolStripMenuItem.Text = "File Information...";
            this.fileInformationToolStripMenuItem.Click += new System.EventHandler(this.FileInformationToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem1
            // 
            this.projectToolStripMenuItem1.Enabled = false;
            this.projectToolStripMenuItem1.Name = "projectToolStripMenuItem1";
            this.projectToolStripMenuItem1.Size = new System.Drawing.Size(100, 38);
            this.projectToolStripMenuItem1.Text = "Project";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(81, 38);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.FontSizeComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 44);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1134, 40);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Enabled = false;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(238, 40);
            this.toolStripComboBox1.Text = "Arial";
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
            this.FontSizeComboBox.Size = new System.Drawing.Size(146, 40);
            this.FontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.FontSizeComboBox_TextChanged);
            this.FontSizeComboBox.TextChanged += new System.EventHandler(this.FontSizeComboBox_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 94);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lineNumberDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtxtbIDE);
            this.splitContainer1.Size = new System.Drawing.Size(1134, 764);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.TabIndex = 7;
            // 
            // lineNumberDisplay
            // 
            this.lineNumberDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.lineNumberDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineNumberDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineNumberDisplay.Location = new System.Drawing.Point(0, 0);
            this.lineNumberDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lineNumberDisplay.Name = "lineNumberDisplay";
            this.lineNumberDisplay.ReadOnly = true;
            this.lineNumberDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lineNumberDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lineNumberDisplay.ShortcutsEnabled = false;
            this.lineNumberDisplay.Size = new System.Drawing.Size(87, 764);
            this.lineNumberDisplay.TabIndex = 6;
            this.lineNumberDisplay.TabStop = false;
            this.lineNumberDisplay.Text = "";
            this.lineNumberDisplay.VScroll += new System.EventHandler(this.RtxtbLineNumbers_VScroll);
            // 
            // rtxtbIDE
            // 
            this.rtxtbIDE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtbIDE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbIDE.Location = new System.Drawing.Point(0, 0);
            this.rtxtbIDE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 58);
            this.rtxtbIDE.Name = "rtxtbIDE";
            this.rtxtbIDE.Size = new System.Drawing.Size(1043, 764);
            this.rtxtbIDE.TabIndex = 7;
            this.rtxtbIDE.Text = "";
            this.rtxtbIDE.WordWrap = false;
            this.rtxtbIDE.VScroll += new System.EventHandler(this.RtxtbIDE_VScroll);
            this.rtxtbIDE.TextChanged += new System.EventHandler(this.RtxtbIDE_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLoadingBar2});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 901);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(28, 0, 2, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1134, 5);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 0);
            // 
            // statusLoadingBar2
            // 
            this.statusLoadingBar2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusLoadingBar2.Name = "statusLoadingBar2";
            this.statusLoadingBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLoadingBar2.RightToLeftLayout = true;
            this.statusLoadingBar2.Size = new System.Drawing.Size(200, 31);
            this.statusLoadingBar2.Step = 5;
            this.statusLoadingBar2.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGitHubWikiToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewGitHubWikiToolStripMenuItem
            // 
            this.viewGitHubWikiToolStripMenuItem.Name = "viewGitHubWikiToolStripMenuItem";
            this.viewGitHubWikiToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.viewGitHubWikiToolStripMenuItem.Text = "View GitHub Wiki";
            this.viewGitHubWikiToolStripMenuItem.Click += new System.EventHandler(this.viewGitHubWikiToolStripMenuItem_Click);
            // 
            // TIIDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 906);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.ToolStripMenuItem codeFormattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportProgramToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGitHubWikiToolStripMenuItem;
    }
}

