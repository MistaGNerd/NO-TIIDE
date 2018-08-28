using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TIIDE.Compile;
using TICalcLibrary;

namespace TIIDE
{
    public partial class TIIDE : Form
    {
        public static TI83Model prgm83 = new TI83Model();

        #region Private Fields

        private OpenFileDialog ofd = new OpenFileDialog() {Filter= "TI-83+ Program Files (*.8xp)|*.8xp|TI-82/83 Program Files (*.83p)|*.83p|All Files (*.*)|*.*" };
        private string programCode = "";

        #endregion Private Fields

        #region Public Constructors

        public TIIDE()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            lineNumberDisplay.SelectionAlignment = HorizontalAlignment.Right;
            rtxtbIDE.Select();
            UpdateGUI();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void InsertLineNumbers()
        {
            lineNumberDisplay.Text = "";
            int fLine = GetLineNumberOfFirstVisibleLine();
            int lLine = GetLineNumberOfLastVisibleLine();

            for (int i = fLine; i <= lLine; i++)
            {
                lineNumberDisplay.Text += i + "\n";
            }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void RichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            //checks if text cursor is at start of line. Assumes new line is created and runs UpdateGUI for linenumbers.
            if (rtxtbIDE.GetPositionFromCharIndex(rtxtbIDE.SelectionStart).X == 1)
            {
                UpdateGUI();
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void RichTextBox1_VScroll(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void RtxtbLineNumbers_MouseDown(object sender, MouseEventArgs e)
        {
            rtxtbIDE.Select();
            lineNumberDisplay.DeselectAll();
        }

        private void RtxtbLineNumbers_VScroll(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            Console.WriteLine("UpdateGUI()");
            InsertLineNumbers();
            //LineStartSyntaxCorrection();
            lineNumberDisplay.Invalidate();
        }

        #endregion Private Methods

        #region IDE Methods

        private string ApplyHexOrderFormatting(string s)
        {
            int loops = s.Length / 16;
            string o = "";
            Console.WriteLine("Length of document : {0}", s.Length);
            for (int i = 0; i < loops; i++)
            {
                Console.WriteLine("loop {0}", i);
                o += s.Substring(i * 16, 16) + (char)10;
            }
            if (s.Length > (loops * 16))
            {
                int r = s.Length - (loops * 16);
                o += s.Substring(loops * 16, r);
            }
            return o;
        }

        private string ApplyIDEFormatting(string s)
        {
            string[] t = s.Split(':');
            string o = "";
            foreach (string sub in t)
            {
                o += ":" + sub + (char)10;
            }
            return o;
        }

        private int GetLineNumberOfFirstVisibleLine()
        {
            Point pt = new Point(1, 1);
            char firstChar = rtxtbIDE.GetCharFromPosition(pt);
            int firstCharIndex = rtxtbIDE.GetCharIndexFromPosition(pt);

            int fLine = rtxtbIDE.GetLineFromCharIndex(firstCharIndex) + 1;

            Console.WriteLine(firstCharIndex + " : " + fLine);

            return fLine;
        }

        private int GetLineNumberOfLastVisibleLine()
        {
            Point pt = new Point(ClientRectangle.Width, ClientRectangle.Height);
            char lastChar = rtxtbIDE.GetCharFromPosition(pt);
            int lastCharIndex = rtxtbIDE.GetCharIndexFromPosition(pt);

            int lLine = rtxtbIDE.GetLineFromCharIndex(lastCharIndex) + 1;

            //if lastChar is a carriage return. count next line as last line.
            if (lastChar == (char)10) { lLine++; }
            return lLine;
        }

        private int GetTotalNumberOfLines()
        {
            return rtxtbIDE.Lines.Length;
        }

        #endregion IDE Methods

        private void ImportProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // Load in file from Open File Dialog
        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Init()
        {
            FontSizeComboBox.SelectedIndex = 6;
            Font ideFont = new Font("Arial", 16, FontStyle.Regular);
            rtxtbIDE.Font = ideFont;
            lineNumberDisplay.Font = ideFont;
        }

        private void LineStartSyntaxCorrection()
        {
            Console.WriteLine("Running Correction");
            string[] lines = rtxtbIDE.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (!line.StartsWith(":")) { lines[i] = ":" + line; Console.WriteLine("Line " + i + " - Corrected. Was -" + line); }
            }
            if (rtxtbIDE.Lines != lines) { rtxtbIDE.Lines = lines; }
        }

        private void OpenTIProjectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // Code formatting selection box controls
        // ---------------------------------------
        private void RawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make sure standard and hex are unchecked
            rawToolStripMenuItem.Checked = true;
            standardToolStripMenuItem.Checked = false;
            hexToolStripMenuItem.Checked = false;
            rtxtbIDE.Text = programCode;
        }

        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make sure raw and hex are unchecked
            rawToolStripMenuItem.Checked = false;
            standardToolStripMenuItem.Checked = true;
            hexToolStripMenuItem.Checked = false;

            // Apply "Standard" formatting
            rtxtbIDE.Text = ApplyIDEFormatting(programCode);
        }

        private void HexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make sure raw and standard are unchecked
            rawToolStripMenuItem.Checked = false;
            standardToolStripMenuItem.Checked = false;
            hexToolStripMenuItem.Checked = true;
            rtxtbIDE.Text = ApplyHexOrderFormatting(programCode);
        }

        private void RtxtbIDE_MouseEnter(object sender, EventArgs e)
        {
            Point pt = rtxtbIDE.GetPositionFromCharIndex(rtxtbIDE.SelectionStart);
            Console.WriteLine(pt.ToString());
        }



        private void FontSizeComboBox_TextChanged(object sender, EventArgs e)
        {
            int size = int.Parse(FontSizeComboBox.Text);
            Font fontArial = new Font("Arial", size, FontStyle.Regular);
            rtxtbIDE.Font = fontArial;
            lineNumberDisplay.Font = fontArial;
        }

        private void RichTextBox1_FontChanged(object sender, EventArgs e)
        {
            lineNumberDisplay.Font = rtxtbIDE.Font;
            rtxtbIDE.Select();
            UpdateGUI();
        }



        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            if (File.Exists(ofd.FileName))
            {
                Console.WriteLine("Importing file {0}", ofd.FileName);
                prgm83 = Compiler.GetTI83Object(new BinaryReader(File.OpenRead(ofd.FileName)));
                programCode = Compiler.ReverseCompile(new List<Byte>(prgm83.Data));
            }
            //Console.WriteLine("writing to ide");
            // Apply standard formatting at load
            rtxtbIDE.Text = ApplyIDEFormatting(programCode);
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFileDetails formFileDetails = new FormFileDetails(prgm83);
            formFileDetails.Show(this);
        }





        #region Background Worker Methods


        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        #endregion Background Worker Methods



    }
}