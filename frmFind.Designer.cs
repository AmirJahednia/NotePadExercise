namespace NotePad
{
    partial class frmFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFind));
            this.lblExplain = new System.Windows.Forms.Label();
            this.txtFindInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.RadioButton();
            this.btnUp = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFindCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblExplain.Location = new System.Drawing.Point(28, 21);
            this.lblExplain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(216, 22);
            this.lblExplain.TabIndex = 0;
            this.lblExplain.Text = "What are you looking for?";
            // 
            // txtFindInput
            // 
            this.txtFindInput.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtFindInput.Location = new System.Drawing.Point(15, 49);
            this.txtFindInput.Margin = new System.Windows.Forms.Padding(6);
            this.txtFindInput.Name = "txtFindInput";
            this.txtFindInput.Size = new System.Drawing.Size(242, 28);
            this.txtFindInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(15, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // btnDown
            // 
            this.btnDown.AutoSize = true;
            this.btnDown.Checked = true;
            this.btnDown.Location = new System.Drawing.Point(7, 50);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(62, 21);
            this.btnDown.TabIndex = 4;
            this.btnDown.TabStop = true;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.AutoSize = true;
            this.btnUp.Location = new System.Drawing.Point(7, 23);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(43, 21);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkBox1.Location = new System.Drawing.Point(22, 179);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Match case";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnFind.Location = new System.Drawing.Point(15, 206);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(115, 42);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFindCancel
            // 
            this.btnFindCancel.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnFindCancel.Location = new System.Drawing.Point(142, 206);
            this.btnFindCancel.Name = "btnFindCancel";
            this.btnFindCancel.Size = new System.Drawing.Size(115, 42);
            this.btnFindCancel.TabIndex = 5;
            this.btnFindCancel.Text = "End search";
            this.btnFindCancel.UseVisualStyleBackColor = true;
            this.btnFindCancel.Click += new System.EventHandler(this.btnFindCancel_Click);
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 260);
            this.Controls.Add(this.btnFindCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFindInput);
            this.Controls.Add(this.lblExplain);
            this.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "frmFind";
            this.Text = "Find";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblExplain;
        protected System.Windows.Forms.TextBox txtFindInput;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.CheckBox checkBox1;
        protected System.Windows.Forms.Button btnFind;
        protected System.Windows.Forms.Button btnFindCancel;
        protected System.Windows.Forms.RadioButton btnDown;
        protected System.Windows.Forms.RadioButton btnUp;
    }
}