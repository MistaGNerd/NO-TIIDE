using System;
using System.Windows.Forms;
using TICalcLibrary;

namespace TIIDE
{
    public partial class FormFileDetails : Form
    {
        public FormFileDetails(TI83Model pgrm83)
        {
            InitializeComponent();
            TI83Model prgm83 = TIIDE.prgm83;
            lblFileNameText.Text = prgm83.AssociatedFileName;
            lblProgramNameText.Text = prgm83.Name;
            lblCommentText.Text = prgm83.Comment;
            if (prgm83.ProtectFlag)
                lblProtectedText.Text = "Yes";
            else
                lblProtectedText.Text = "No";
        }

        private void FormFileDetailsLoad(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}