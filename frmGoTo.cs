using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class frmGoTo : Form
    {
        NotePad mainForm;
        public frmGoTo(NotePad bridge)
        {
            InitializeComponent();
            mainForm = bridge;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGoTo_Load(object sender, EventArgs e)
        {
            txtLine.Text = mainForm.GetLine().ToString(); 
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtLine.Text) - 1;
            if (x > mainForm.GetLine())
            {
                MessageBox.Show("Out of range.");
                txtLine.Focus();
                txtLine.SelectAll();
            }
            else
            {
                mainForm.GoToFunction(x);
                this.Close();
            }
               
        }
    }
}
