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

                SqlCommand cmd = new SqlCommand("UPDATE UserInfo SET username=@username WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@username", txtNewUsername.Text);


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




        private void UpdateUsername_Load(object sender, EventArgs e)
        {
            InitConnection();
        }
    }
}
