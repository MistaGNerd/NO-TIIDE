﻿using System;
using System.Windows.Forms;
using TICalcLibrary;

namespace TIIDE
{
    public partial class FormFileDetails : Form
    {
        public FormFileDetails(TI83Model pgrm83)
        {
            InitializeComponent();
            try
            {
                lblFileName.Text = TIIDE.prgm83.AssociatedFileName;
                lblProgramName.Text = TIIDE.prgm83.Name;
                lblComment.Text = TIIDE.prgm83.Comment;
                if (TIIDE.prgm83.ProtectFlag)
                    lblProtected.Text = "Yes";
                else
                    lblProtected.Text = "No";
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        private void FormFileDetailsLoad(object sender, EventArgs e)
        {
            TICalcLibrary.TI83Model prgm83 = TIIDE.prgm83;
            lblFileName.Text = prgm83.AssociatedFileName;
            lblProgramName.Text = prgm83.Name;
            lblComment.Text = prgm83.Comment;
            if (prgm83.ProtectFlag)
                lblProtected.Text = "Yes";
            else
                lblProtected.Text = "No";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}