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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
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




        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (!UsernamePhoneNumberMatches(txtUsername.Text, txtPhoneNumber.Text))
                {
                    throw new ArgumentException("Username and Phone Number mismatch. Please enter correct values.");
                }

                if (string.IsNullOrWhiteSpace(txtNewPassword.Text) && string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                {
                    throw new ArgumentException("Please enter new Password.");
                }
                if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                {
                    throw new ArgumentException("Please enter Password in both box.");
                }


                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    throw new ArgumentException("Password entered doesnot match.");
                }

                SqlCommand cmdInsert = new SqlCommand("UPDATE UserInfo SET password=@password WHERE id=@id", conn);
                cmdInsert.Parameters.AddWithValue("@password", txtNewPassword.Text);

                SqlCommand cmdId = new SqlCommand("SELECT id FROM UserInfo WHERE username=@username AND phonenumber=@phonenumber", conn);
                cmdId.Parameters.AddWithValue("@username", txtUsername.Text);
                cmdId.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);

                int userId = (int)cmdId.ExecuteScalar();

                cmdInsert.Parameters.AddWithValue("@id", userId);

                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Password updated successfully...");
                this.Hide();
                Login login = new Login();
                login.Show();
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


        private bool UsernamePhoneNumberMatches(string username, string phonenumber)
        { 
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserInfo WHERE username = @username AND phonenumber= @phonenumber", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber);

            int count = (int)cmd.ExecuteScalar();
            return count != 0;
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            InitConnection();
        }
    }
}
