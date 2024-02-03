namespace WindowsFormsDemo
{
    partial class UpdateUsername
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
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpdateUsername = new System.Windows.Forms.Button();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.txtCurrentUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Location = new System.Drawing.Point(166, 88);
            this.lblNewUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(133, 22);
            this.lblNewUsername.TabIndex = 0;
            this.lblNewUsername.Text = "New Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(210, 200);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 22);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(326, 85);
            this.txtNewUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(256, 28);
            this.txtNewUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(326, 197);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnUpdateUsername
            // 
            this.btnUpdateUsername.Location = new System.Drawing.Point(299, 288);
            this.btnUpdateUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateUsername.Name = "btnUpdateUsername";
            this.btnUpdateUsername.Size = new System.Drawing.Size(104, 45);
            this.btnUpdateUsername.TabIndex = 4;
            this.btnUpdateUsername.Text = "Update";
            this.btnUpdateUsername.UseVisualStyleBackColor = true;
            this.btnUpdateUsername.Click += new System.EventHandler(this.btnUpdateUsername_Click);
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.AutoSize = true;
            this.lblCurrentUsername.Location = new System.Drawing.Point(142, 143);
            this.lblCurrentUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(157, 22);
            this.lblCurrentUsername.TabIndex = 5;
            this.lblCurrentUsername.Text = "Current Username";
            // 
            // txtCurrentUsername
            // 
            this.txtCurrentUsername.Location = new System.Drawing.Point(326, 140);
            this.txtCurrentUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentUsername.Name = "txtCurrentUsername";
            this.txtCurrentUsername.Size = new System.Drawing.Size(256, 28);
            this.txtCurrentUsername.TabIndex = 6;
            // 
            // UpdateUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 400);
            this.Controls.Add(this.txtCurrentUsername);
            this.Controls.Add(this.lblCurrentUsername);
            this.Controls.Add(this.btnUpdateUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNewUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(752, 447);
            this.MinimumSize = new System.Drawing.Size(752, 447);
            this.Name = "UpdateUsername";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateUsername";
            this.Load += new System.EventHandler(this.UpdateUsername_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUpdateUsername;
        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.TextBox txtCurrentUsername;
    }
}