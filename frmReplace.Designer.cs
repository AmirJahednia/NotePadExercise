namespace NotePad
{
    partial class frmReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReplace = new System.Windows.Forms.Label();
            this.txtReplaceInput = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaecAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExplain
            // 
            this.lblExplain.Location = new System.Drawing.Point(12, 21);
            this.lblExplain.Size = new System.Drawing.Size(49, 22);
            this.lblExplain.Text = "Find:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 151);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(22, 242);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(15, 269);
            // 
            // btnFindCancel
            // 
            this.btnFindCancel.Location = new System.Drawing.Point(15, 317);
            this.btnFindCancel.Text = "Close";
            // 
            // txtReplace
            // 
            this.txtReplace.AutoSize = true;
            this.txtReplace.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtReplace.Location = new System.Drawing.Point(12, 83);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(115, 22);
            this.txtReplace.TabIndex = 6;
            this.txtReplace.Text = "Replace with:";
            // 
            // txtReplaceInput
            // 
            this.txtReplaceInput.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtReplaceInput.Location = new System.Drawing.Point(15, 108);
            this.txtReplaceInput.Name = "txtReplaceInput";
            this.txtReplaceInput.Size = new System.Drawing.Size(240, 28);
            this.txtReplaceInput.TabIndex = 7;
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnReplace.Location = new System.Drawing.Point(136, 269);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(119, 42);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaecAll
            // 
            this.btnReplaecAll.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnReplaecAll.Location = new System.Drawing.Point(136, 317);
            this.btnReplaecAll.Name = "btnReplaecAll";
            this.btnReplaecAll.Size = new System.Drawing.Size(119, 42);
            this.btnReplaecAll.TabIndex = 8;
            this.btnReplaecAll.Text = "Replace All";
            this.btnReplaecAll.UseVisualStyleBackColor = true;
            this.btnReplaecAll.Click += new System.EventHandler(this.btnReplaecAll_Click);
            // 
            // frmReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(275, 369);
            this.Controls.Add(this.btnReplaecAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplaceInput);
            this.Controls.Add(this.txtReplace);
            this.Name = "frmReplace";
            this.Text = "Replace";
            this.Controls.SetChildIndex(this.lblExplain, 0);
            this.Controls.SetChildIndex(this.txtFindInput, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnFindCancel, 0);
            this.Controls.SetChildIndex(this.txtReplace, 0);
            this.Controls.SetChildIndex(this.txtReplaceInput, 0);
            this.Controls.SetChildIndex(this.btnReplace, 0);
            this.Controls.SetChildIndex(this.btnReplaecAll, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtReplace;
        private System.Windows.Forms.TextBox txtReplaceInput;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaecAll;
    }
}
