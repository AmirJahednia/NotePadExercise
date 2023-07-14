namespace NotePad
{
    partial class frmGoTo
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
            this.lblLineNumber = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLineNumber
            // 
            this.lblLineNumber.AutoSize = true;
            this.lblLineNumber.Location = new System.Drawing.Point(13, 15);
            this.lblLineNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLineNumber.Name = "lblLineNumber";
            this.lblLineNumber.Size = new System.Drawing.Size(109, 21);
            this.lblLineNumber.TabIndex = 0;
            this.lblLineNumber.Text = "Line Number:";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(13, 41);
            this.txtLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(272, 28);
            this.txtLine.TabIndex = 0;
            // 
            // btnGoTo
            // 
            this.btnGoTo.Location = new System.Drawing.Point(13, 79);
            this.btnGoTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(135, 37);
            this.btnGoTo.TabIndex = 3;
            this.btnGoTo.Text = "GoTo";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(150, 79);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmGoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 131);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.lblLineNumber);
            this.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGoTo";
            this.Text = "Go to...";
            this.Load += new System.EventHandler(this.frmGoTo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLineNumber;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Button btnClose;
    }
}