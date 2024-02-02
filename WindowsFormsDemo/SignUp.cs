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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        //DbConnect db=new DbConnect();
        SqlConnection conn = null;

        IConfiguration _iconfiguration;

        public void InitConnection()
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appSettings.json");
            _iconfiguration = builder.Build();
            conn = new SqlConnection(_iconfiguration.GetConnectionString("DefaultConnection"));
            //conn = new SqlConnection(db.connstring);
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AllFieldsFilled())
                {
                    throw new ArgumentException("Please fill in all the fields.");
                }

                conn.Open();

                if (UsernameExists(txtUsername.Text))
                {
                    throw new ArgumentException("Username already exists. Please choose a different username.");
                }

                SqlCommand cmdInsert = new SqlCommand("INSERT INTO UserInfo VALUES (@name, @address, @phoneNumber, @gender, @username, @password)", conn);
                cmdInsert.Parameters.AddWithValue("@name", txtName.Text);
                cmdInsert.Parameters.AddWithValue("@address", txtAddress.Text);
                cmdInsert.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text); // Correct parameter name
                cmdInsert.Parameters.AddWithValue("@gender", rbMale.Checked ? "Male" : "Female"); // Simplified gender assignment
                cmdInsert.Parameters.AddWithValue("@username", txtUsername.Text);
                cmdInsert.Parameters.AddWithValue("@password", txtPassword.Text);

                if (txtPhoneNumber.Text.Length != 10)
                {
                    throw new ArgumentException("Invalid Phone number!!!");
                }

                if (!rbMale.Checked && !rbFemale.Checked)
                {
                    throw new ArgumentException("Select your gender!!!");
                }

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    throw new ArgumentException("Password mismatched!!!");
                }

                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Sign up successful...");
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            
        }

        private bool AllFieldsFilled()
        {
            List<TextBox> requiredFields = new List<TextBox> { txtName, txtAddress, txtPhoneNumber, txtUsername, txtPassword, txtConfirmPassword };

            foreach (var field in requiredFields)
            {
                if (string.IsNullOrWhiteSpace(field.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private bool UsernameExists(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserInfo WHERE username = @username", conn);
            cmd.Parameters.AddWithValue("@username", username);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }




        private void SignUp_Load(object sender, EventArgs e)
        {
            InitConnection();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
    }
}
