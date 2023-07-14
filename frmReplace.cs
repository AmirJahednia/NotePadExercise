using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotePad
{
    public partial class frmReplace : frmFind
    {
        NotePad mainForm;
        public frmReplace()
        {
            InitializeComponent();
        }
        public frmReplace(NotePad x) : base(x)
        {
            InitializeComponent();
            mainForm = x;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            mainForm.Replace(txtReplaceInput.Text);
        }

        private void btnReplaecAll_Click(object sender, EventArgs e)
        {
            StringComparison cmp = StringComparison.OrdinalIgnoreCase;
            if (checkBox1.Checked)
                cmp = StringComparison.Ordinal;
            mainForm.ReplaceAll(txtFindInput.Text, txtReplaceInput.Text, cmp, btnDown.Checked);
        }
    }
}
