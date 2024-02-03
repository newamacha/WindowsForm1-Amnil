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
    public partial class UpdateUsername : Form
    {
        public UpdateUsername()
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


        private void btnUpdateUsername_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                
                if(!UsernamePasswordMatches(txtCurrentUsername.Text, txtPassword.Text)) 
                {
                    throw new ArgumentException("Username and Password mismatch. Please enter correct values.");
                }

                if (string.IsNullOrWhiteSpace(txtNewUsername.Text))
                {
                    throw new ArgumentException("Please enter new Username.");
                }


                SqlCommand cmd = new SqlCommand("UPDATE UserInfo SET username=@username WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@username", txtNewUsername.Text);

                SqlCommand cmd2 = new SqlCommand("SELECT id FROM UserInfo WHERE username=@username", conn);
                cmd2.Parameters.AddWithValue("@username", txtCurrentUsername.Text);

                int cmd2id = (int)cmd2.ExecuteScalar();
                cmd.Parameters.AddWithValue("@id", cmd2id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Username Updated Successfully...");

                this.Hide();
                LoggedIn loggedIn = new LoggedIn();
                loggedIn.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private bool UsernamePasswordMatches(string currentUsername, string password)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserInfo WHERE username=@username AND password=@password", conn);
            cmd.Parameters.AddWithValue("@username", currentUsername);
            cmd.Parameters.AddWithValue ("@password", password);

            int count = (int)cmd.ExecuteScalar();
            return count != 0;
        }

        private void UpdateUsername_Load(object sender, EventArgs e)
        {
            InitConnection();
        }
    }
}
