namespace TIIDE
{
    partial class FormFileDetails
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblProtected = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFileNameText = new System.Windows.Forms.Label();
            this.lblProgramNameText = new System.Windows.Forms.Label();
            this.lblCommentText = new System.Windows.Forms.Label();
            this.lblProtectedText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(9, 7);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(26, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File:";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(9, 21);
            this.lblProgramName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(80, 13);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "Program Name:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(9, 35);
            this.lblComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 2;
            this.lblComment.Text = "Comment:";
            // 
            // lblProtected
            // 
            this.lblProtected.AutoSize = true;
            this.lblProtected.Location = new System.Drawing.Point(9, 49);
            this.lblProtected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProtected.Name = "lblProtected";
            this.lblProtected.Size = new System.Drawing.Size(56, 13);
            this.lblProtected.TabIndex = 3;
            this.lblProtected.Text = "Protected:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(110, 70);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 19);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblFileNameText
            // 
            this.lblFileNameText.AutoSize = true;
            this.lblFileNameText.Location = new System.Drawing.Point(41, 6);
            this.lblFileNameText.Name = "lblFileNameText";
            this.lblFileNameText.Size = new System.Drawing.Size(0, 13);
            this.lblFileNameText.TabIndex = 5;
            // 
            // lblProgramNameText
            // 
            this.lblProgramNameText.AutoSize = true;
            this.lblProgramNameText.Location = new System.Drawing.Point(95, 20);
            this.lblProgramNameText.Name = "lblProgramNameText";
            this.lblProgramNameText.Size = new System.Drawing.Size(10, 13);
            this.lblProgramNameText.TabIndex = 6;
            this.lblProgramNameText.Text = " ";
            // 
            // lblCommentText
            // 
            this.lblCommentText.AutoSize = true;
            this.lblCommentText.Location = new System.Drawing.Point(69, 34);
            this.lblCommentText.Name = "lblCommentText";
            this.lblCommentText.Size = new System.Drawing.Size(10, 13);
            this.lblCommentText.TabIndex = 7;
            this.lblCommentText.Text = " ";
            // 
            // lblProtectedText
            // 
            this.lblProtectedText.AutoSize = true;
            this.lblProtectedText.Location = new System.Drawing.Point(71, 48);
            this.lblProtectedText.Name = "lblProtectedText";
            this.lblProtectedText.Size = new System.Drawing.Size(10, 13);
            this.lblProtectedText.TabIndex = 8;
            this.lblProtectedText.Text = " ";
            this.lblProtectedText.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormFileDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 98);
            this.Controls.Add(this.lblProtectedText);
            this.Controls.Add(this.lblCommentText);
            this.Controls.Add(this.lblProgramNameText);
            this.Controls.Add(this.lblFileNameText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblProtected);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.lblFileName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileDetails";
            this.Text = "File Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblProtected;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFileNameText;
        private System.Windows.Forms.Label lblProgramNameText;
        private System.Windows.Forms.Label lblCommentText;
        private System.Windows.Forms.Label lblProtectedText;
    }
}