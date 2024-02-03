namespace WindowsFormsDemo
{
    partial class LoggedIn
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
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.linklblUpdateUsername = new System.Windows.Forms.LinkLabel();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedIn.Location = new System.Drawing.Point(121, 186);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(545, 35);
            this.lblLoggedIn.TabIndex = 0;
            this.lblLoggedIn.Text = "Congratulations!! You are a member.";
            // 
            // linklblUpdateUsername
            // 
            this.linklblUpdateUsername.AutoSize = true;
            this.linklblUpdateUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblUpdateUsername.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linklblUpdateUsername.Location = new System.Drawing.Point(609, 348);
            this.linklblUpdateUsername.Name = "linklblUpdateUsername";
            this.linklblUpdateUsername.Size = new System.Drawing.Size(155, 22);
            this.linklblUpdateUsername.TabIndex = 1;
            this.linklblUpdateUsername.TabStop = true;
            this.linklblUpdateUsername.Text = "Update Username";
            this.linklblUpdateUsername.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblUpdateUsername_LinkClicked);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Location = new System.Drawing.Point(448, 391);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(133, 30);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(613, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.linklblUpdateUsername);
            this.Controls.Add(this.lblLoggedIn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "LoggedIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoggedIn";
            this.Load += new System.EventHandler(this.LoggedIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.LinkLabel linklblUpdateUsername;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Button btnClose;
    }
}