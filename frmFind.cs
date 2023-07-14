using System.Windows.Forms;
using System;

namespace NotePad
{
    public partial class frmFind : Form
    {
        NotePad Mainfrm;
        public frmFind(NotePad bridge)
        {
            InitializeComponent();
            Mainfrm = bridge;
        }


        // empty constructor for other forms to inherit.
        public frmFind()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            StringComparison compFlag = StringComparison.OrdinalIgnoreCase;
            string userInput = txtFindInput.Text;

            if (checkBox1.Checked)
            {
                compFlag = StringComparison.Ordinal;
            }

            if (!string.IsNullOrEmpty(userInput))
            {
                if (!Mainfrm.FindNextFunction(userInput, compFlag,btnUp.Checked))
                {
                    btnFind.Text = "Find";
                }
                else
                {
                    btnFind.Text = "Next";
                }
            }
            else
            {
                txtFindInput.Text = "Input cannot be empty.";
                txtFindInput.Select();
            }
        }


        private void btnFindCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}