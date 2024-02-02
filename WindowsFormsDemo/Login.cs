using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linklblForgotPassword_MouseHover(object sender, EventArgs e)
        {
            linklblForgotPassword.ActiveLinkColor = Color.Red;
        }

        private void linklblSignUp_MouseHover(object sender, EventArgs e)
        {
            linklblForgotPassword.ActiveLinkColor = Color.Red;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }



        SqlConnection conn = null;

        IConfiguration _iconfiguration;

        public void InitConnection()
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appSettings.json");
            _iconfiguration = builder.Build();
            conn = new SqlConnection(_iconfiguration.GetConnectionString("DefaultConnection"));
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    throw new ArgumentException("Please enter both username and password.");
                }

                if (!UsernamePasswordMatches(txtUsername.Text, txtPassword.Text))
                {
                    throw new ArgumentException("Username and Password mismatch. Please enter correct values.");
                }

                this.Hide();
                LoggedIn loggedIn = new LoggedIn();
                loggedIn.Show();
            }
            //catch (SqlException ex)
            //{
            //    MessageBox.Show($"Database Error: {ex.Message}");
            //}
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }


        private bool UsernamePasswordMatches(string username, string password)
        {

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserInfo WHERE username = @username AND password= @password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            int count = (int)cmd.ExecuteScalar();
            return count != 0;
        }

        private void linklblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }



        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            InitConnection();
            this.linklblForgotPassword.LinkBehavior = LinkBehavior.NeverUnderline;
            this.linklblSignUp.LinkBehavior = LinkBehavior.NeverUnderline;
        }
    }
}
