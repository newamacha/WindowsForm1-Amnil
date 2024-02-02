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
            this.linklblUpdateUsername.Location = new System.Drawing.Point(606, 395);
            this.linklblUpdateUsername.Name = "linklblUpdateUsername";
            this.linklblUpdateUsername.Size = new System.Drawing.Size(155, 22);
            this.linklblUpdateUsername.TabIndex = 1;
            this.linklblUpdateUsername.TabStop = true;
            this.linklblUpdateUsername.Text = "Update Username";
            this.linklblUpdateUsername.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblUpdateUsername_LinkClicked);
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linklblUpdateUsername);
            this.Controls.Add(this.lblLoggedIn);
            this.Name = "LoggedIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoggedIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.LinkLabel linklblUpdateUsername;
    }
}