using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace NotePad
{
    public partial class NotePad : Form
    {
        string fileAddress;
        bool saveFlag;
        UndoClass undo = new UndoClass();
        int lastFoundPosition = -1;


        public NotePad()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFun()
        {
            openFileDialog1.Filter = "text File|*.txt|Document File|*.doc| All Files|*.*";
            DialogResult loadDialogResult = openFileDialog1.ShowDialog();
            if (loadDialogResult == DialogResult.Cancel)
            {
                return;
            }
            if (loadDialogResult == DialogResult.OK)
            {
                fileAddress = openFileDialog1.FileName;
                txtMain.Text = System.IO.File.ReadAllText(fileAddress);
                this.Text = fileAddress;
                saveFlag = true;
            }
        }

        private void SetCursorPosition(int position)
        {
            txtMain.SelectionStart = position;
            txtMain.SelectionLength = 0;
            txtMain.ScrollToCaret();
            txtMain.Focus();
        }


        public class UndoClass
        {
            private Stack<string> undoStack;
            private Stack<string> redoStack;
            private string text;

            public UndoClass()
            {
                undoStack = new Stack<string>();
                redoStack = new Stack<string>();
                text = string.Empty;
            }

            public bool CanUndo => undoStack.Count > 0;
            public bool CanRedo => redoStack.Count > 0;

            public void SetText(string s)
            {
                undoStack.Push(text);
                text = s;
                redoStack.Clear();
            }

            public string Undo()
            {
                if (CanUndo)
                {
                    redoStack.Push(text);
                    text = undoStack.Pop();
                    return text;
                }

                return text;
            }

            public string Redo()
            {
                if (CanRedo)
                {
                    undoStack.Push(text);
                    text = redoStack.Pop();
                    return text;
                }

                return text;
            }

            public string GetText()
            {
                return text;
            }
        }


        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undo.CanUndo)
            {
                txtMain.Text = undo.Undo();
                SetCursorPosition(txtMain.Text.Length); 
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undo.CanRedo)
            {
                txtMain.Text = undo.Redo();
                SetCursorPosition(txtMain.Text.Length);
            }
        }



        private void SetBackColor(object sender, EventArgs e)
        {
            txtMain.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            foreach (ToolStripMenuItem item in backColorToolStripMenuItem.DropDownItems)
                if (item.Text == ((ToolStripMenuItem)sender).Text)
                    item.Checked = true;
                else item.Checked = false;
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusBar1.Visible = statusToolStripMenuItem.Checked;
        }
        private void SetForeColor(object sender, EventArgs e)
        {
            txtMain.ForeColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            foreach (ToolStripMenuItem item in foreColorToolStripMenuItem.DropDownItems)
                if (item.Text == ((ToolStripMenuItem)sender).Text)
                    item.Checked = true;
                else item.Checked = false;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtMain.Font;
            fontDialog1.ShowDialog();
            txtMain.Font = fontDialog1.Font;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.WordWrap = !txtMain.WordWrap;
        }

        private void NotSavedAlarmFun()
        {
            DialogResult r;
            r = MessageBox.Show("Your file has changed since your last save. Do you want to save it now?", "Caution!", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(null, null);
                txtMain.Text = string.Empty;
                fileAddress = null;
                this.Text = "NotePad";
                saveFlag = true;
            }
            else if (r == DialogResult.No)
            {
                txtMain.Text = string.Empty;
                fileAddress = null;
                saveFlag = true;
            }
        }

        private void NotePad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!saveFlag)
                NotSavedAlarmFun();

            string[] x = new string[8];
            x[0] = txtMain.BackColor.Name;
            x[1] = txtMain.ForeColor.Name;
            x[2] = fontDialog1.Font.Name;
            x[3] = fontDialog1.Font.Size.ToString();
            x[4] = fontDialog1.Font.Style.ToString();
            x[5] = txtMain.Font.Style.ToString();
            x[6] = this.Height.ToString();
            x[7] = this.Width.ToString();

            System.IO.File.WriteAllLines("LayOut.txt", x);
        }
        private void NotePad_Load(object sender, EventArgs e)
        {
            saveFlag = true;
            string[] x = new string[8];
            SetShortCuts();



            if (System.IO.File.Exists(@"LayOut.txt"))
            {
                x = System.IO.File.ReadAllLines(@"LayOut.txt");

                foreach (ToolStripMenuItem item in backColorToolStripMenuItem.DropDownItems)
                {
                    if (item.Text == x[0])
                    {
                        txtMain.BackColor = Color.FromName(x[0]);
                        SetBackColor(item, null);
                    }
                }

                FontStyle fontStyle;
                if (Enum.TryParse(x[4], out fontStyle))
                {
                    txtMain.Font = new Font(x[2], float.Parse(x[3]), fontStyle);
                }

                this.Height = (int)Convert.ToDouble(x[6]);
                this.Width = (int)Convert.ToDouble(x[7]);

                foreach (ToolStripMenuItem item in foreColorToolStripMenuItem.DropDownItems)
                {
                    if (item.Text == x[1])
                    {
                        txtMain.ForeColor = Color.FromName(x[1]);
                        SetForeColor(item, null);
                    }
                }
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileAddress))
            {
                saveFileDialog1.Filter = "Text Documents|*txt| All Files |*.";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.FileName = fileAddress;

                DialogResult saveDialogResult = saveFileDialog1.ShowDialog();

                if (saveDialogResult == DialogResult.OK)
                {
                    fileAddress = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }
            System.IO.File.WriteAllText(fileAddress, txtMain.Text);
            saveFlag = true;
            this.Text = fileAddress;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saveFlag)
            {
                NotSavedAlarmFun();
            }

            if (saveFlag)
            {
                txtMain.Text = string.Empty;
                fileAddress = null;
                this.Text = "NotePad";
            }
        }

        private void txtMain_TextChanged(object sender, EventArgs e)
        {

            SetRowCol();
            SetEnables();
            SetShortCuts();

            if (txtMain.Text == string.Empty)
                saveFlag = true;
            else
            {
                saveFlag = false;
            }

            if (txtMain.Text != undo.GetText())
            {
                undo.SetText(txtMain.Text);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saveFlag)
            {
                NotSavedAlarmFun();
            }

            if (saveFlag)
            {
                OpenFun();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileAddress = null;
            saveToolStripMenuItem_Click(null, null);
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (txtMain.Text != string.Empty)
                    Clipboard.SetText(txtMain.SelectedText);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.SelectedText = Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(null, null);
            deleteToolStripMenuItem_Click(null, null);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.SelectedText = string.Empty;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFind FindWindow = new frmFind(this);
            FindWindow.Show(this);
        }

        public bool FindFunction(string s, StringComparison compFlag, bool DownOrLeft)
        {
            int check = txtMain.Text.IndexOf(s, compFlag);
            if (check == -1)
            {
                MessageBox.Show("Not Found.");
                lastFoundPosition = -1;
                return false;
            }
            else
            {
                lastFoundPosition = check;
                txtMain.SelectionStart = check;
                txtMain.SelectionLength = s.Length;
                txtMain.Focus();
                return true;
            }
        }

        public bool FindNextFunction(string s, StringComparison compFlag, bool UpOrDown)
        {
            if (lastFoundPosition == -1)
            {
                return FindFunction(s, compFlag, UpOrDown);
            }
            else
            {
                int check;
                if (UpOrDown)
                {
                    if (lastFoundPosition == 0)
                    {

                        check = txtMain.Text.LastIndexOf(s, txtMain.Text.Length - 1, compFlag);
                    }
                    else
                    {
                        check = txtMain.Text.LastIndexOf(s, lastFoundPosition - 1, compFlag);
                        if (check == -1)
                        {
                            check = txtMain.Text.LastIndexOf(s, txtMain.Text.Length - 1, compFlag);
                        }
                    }
                }
                else
                {
                    check = txtMain.Text.IndexOf(s, lastFoundPosition + 1, compFlag);
                    if (check == -1)
                    {
                        check = txtMain.Text.IndexOf(s, 0, compFlag);
                    }
                }

                if (check == -1)
                {
                    MessageBox.Show("No more occurrences found.");
                    lastFoundPosition = -1;
                    return false;
                }
                else
                {
                    lastFoundPosition = check;
                    txtMain.SelectionStart = check;
                    txtMain.SelectionLength = s.Length;
                    txtMain.Focus();
                    return true;
                }
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplace frmReplace = new frmReplace(this);
            frmReplace.Show(this);
            //this: owner (so that the window stays on top and interactive.
        }

        public void Replace(string x)
        {
            if (txtMain.SelectionLength > 0)
                txtMain.SelectedText = x;
        }

        /// <summary>
        /// Gets 4 parameters and replaces all of the words in a text with another word.
        /// </summary>
        /// <param name="x"> the string that should be searched.</param>
        /// <param name="y">the string that is going to replace</param>
        /// <param name="comparison">case sensitivity</param>
        /// <param name="DownOrUp">from up to bottom or not</param>
        public void ReplaceAll(string x, string y, StringComparison comparison, bool DownOrUp)
        {
            while (FindNextFunction(x, comparison, DownOrUp))
            {
                Replace(y);
            }
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoTo frmGoTo = new frmGoTo(this);
            frmGoTo.Show(this);
        }

        public int GetLine()
        {
            return txtMain.Lines.Count();
        }

        public void GoToFunction(int x)
        {
            txtMain.SelectionStart = txtMain.GetFirstCharIndexFromLine(x);
        }

        public void SetRowCol()
        {
            int row = txtMain.GetLineFromCharIndex(txtMain.SelectionStart) + 1;
            int col = txtMain.SelectionStart - txtMain.GetFirstCharIndexOfCurrentLine() + 1;
            lblRowAndCol.Text = "Ln, " + row + " Col, " + col;
        }

        private void txtMain_Click(object sender, EventArgs e)
        {
            SetRowCol();
        }

        private void txtMain_KeyUp(object sender, KeyEventArgs e)
        {
            SetRowCol();
        }

        public void SetEnables()
        {

            printToolStripMenuItem.Enabled = txtMain.Text.Length > 0;
            printPreviewToolStripMenuItem.Enabled = txtMain.TextLength > 0;
            copyToolStripMenuItem.Enabled = Convert.ToBoolean(txtMain.SelectionLength);
            cutToolStripMenuItem.Enabled = txtMain.SelectionLength > 0;
            // Both method work. in SelectionLength, When int is 0 it means false.
            deleteToolStripMenuItem.Enabled = txtMain.SelectionLength > 0;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
            selectAllToolStripMenuItem.Enabled = txtMain.TextLength > 0;
            findToolStripMenuItem.Enabled = txtMain.Text.Length > 0;
            replaceToolStripMenuItem.Enabled = txtMain.TextLength > 0;
            goToToolStripMenuItem.Enabled = txtMain.TextLength > 0;
            SaveToolStripMenuitem.Enabled = !saveFlag;
            saveAsToolStripMenuItem.Enabled = !saveFlag;
            undoToolStripMenuItem.Enabled = undo.CanUndo;
            redoToolStripMenuItem.Enabled = undo.CanRedo;

            if (!printToolStripMenuItem.Enabled)
            {
                printToolStripMenuItem.ShortcutKeys = Keys.None;
            }
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x;
            printDialog1.Document = printDocument1;
            x = printDialog1.ShowDialog();
            if (x == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtMain.Text, fontDialog1.Font, Brushes.Black, 1, 1);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void aboutNotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This NotePad has been developed as a learning project by Amir Jahednia. it is based on Microsoft Windows default NotePad's platform with a couple of minor changes. \nJahedniaamir@gmail.com", "About");
        }

        private void fileToolStripMenuItem_DropDownOpening_1(object sender, EventArgs e)
        {
            SetEnables();
        }

        private void SetShortCuts()
        {
            if (txtMain.Text.Length > 0)
            {
                printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
                SaveToolStripMenuitem.ShortcutKeys = Keys.Control | Keys.S;
                findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
                replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;

            }
            else if (txtMain.Text.Length == 0)
            {
                printToolStripMenuItem.ShortcutKeys = Keys.None;
                SaveToolStripMenuitem.ShortcutKeys = Keys.None;
                findToolStripMenuItem.ShortcutKeys = Keys.None;
                replaceToolStripMenuItem.ShortcutKeys = Keys.None;
            }
        }
    }
}