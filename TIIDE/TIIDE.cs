using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TIIDE
{
    public partial class TIIDE : Form
    {
        #region Private Fields

        private OpenFileDialog ofd = new OpenFileDialog();
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
            init();
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
            int fLine = getLineNumberOfFirstVisibleLine();
            int lLine = getLineNumberOfLastVisibleLine();

            for (int i = fLine; i <= lLine; i++)
            {
                lineNumberDisplay.Text += i + "\n";
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            lineNumberDisplay.Font = rtxtbIDE.Font;
            rtxtbIDE.Select();
            UpdateGUI();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            //checks if text cursor is at start of line. Assumes new line is created and runs UpdateGUI for linenumbers.
            if (rtxtbIDE.GetPositionFromCharIndex(rtxtbIDE.SelectionStart).X == 1)
            {
                UpdateGUI();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void rtxtbLineNumbers_MouseDown(object sender, MouseEventArgs e)
        {
            rtxtbIDE.Select();
            lineNumberDisplay.DeselectAll();
        }

        private void rtxtbLineNumbers_VScroll(object sender, EventArgs e)
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

        private string applyHexOrderFormatting(string s)
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

        private string applyIDEFormatting(string s)
        {
            string[] t = s.Split(':');
            string o = "";
            foreach (string sub in t)
            {
                o += ":" + sub + (char)10;
            }
            return o;
        }

        private int getLineNumberOfFirstVisibleLine()
        {
            Point pt = new Point(1, 1);
            char firstChar = rtxtbIDE.GetCharFromPosition(pt);
            int firstCharIndex = rtxtbIDE.GetCharIndexFromPosition(pt);

            int fLine = rtxtbIDE.GetLineFromCharIndex(firstCharIndex) + 1;

            Console.WriteLine(firstCharIndex + " : " + fLine);

            return fLine;
        }

        private int getLineNumberOfLastVisibleLine()
        {
            Point pt = new Point(ClientRectangle.Width, ClientRectangle.Height);
            char lastChar = rtxtbIDE.GetCharFromPosition(pt);
            int lastCharIndex = rtxtbIDE.GetCharIndexFromPosition(pt);

            int lLine = rtxtbIDE.GetLineFromCharIndex(lastCharIndex) + 1;

            //if lastChar is a carriage return. count next line as last line.
            if (lastChar == (char)10) { lLine++; }
            return lLine;
        }

        private int getTotalNumberOfLines()
        {
            return rtxtbIDE.Lines.Length;
        }

        private void hexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtbIDE.Text = applyHexOrderFormatting(programCode);
        }

        private void importProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string import = "";
            rtxtbIDE.Text = import;

            if (File.Exists(ofd.FileName))
            {
                Console.WriteLine("Importing file {0}", ofd.FileName);
                import = Compile.Compiler.ReverseCompile(new BinaryReader(File.OpenRead(ofd.FileName)));
            }
            Console.WriteLine("writing to ide");
            programCode = import;
            rtxtbIDE.Text = programCode;
        }

        private void init()
        {
            toolStripComboBox2.SelectedIndex = 3;
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

        private void openTIProjectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void rawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtbIDE.Text = programCode;
        }

        private void rtxtbIDE_MouseEnter(object sender, EventArgs e)
        {
            Point pt = rtxtbIDE.GetPositionFromCharIndex(rtxtbIDE.SelectionStart);
            Console.WriteLine(pt.ToString());
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtbIDE.Text = applyIDEFormatting(programCode);
        }

        private void toolStripComboBox2_TextChanged(object sender, EventArgs e)
        {
            int size = int.Parse(toolStripComboBox2.Text);
            Font font = new Font("Arial", size, FontStyle.Regular);
            rtxtbIDE.Font = font;
            lineNumberDisplay.Font = font;
        }
    }
}