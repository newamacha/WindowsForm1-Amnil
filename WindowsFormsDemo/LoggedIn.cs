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
    public partial class LoggedIn : Form
    {
        public LoggedIn()
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
            //conn = new SqlConnection(db.connstring);
        }



        private void linklblUpdateUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UpdateUsername updateUsername = new UpdateUsername();
            updateUsername.Show();
        }



        private void btnShowReport_Click(object sender, EventArgs e)
        {

            this.Hide();


            ReportDemo reportDemo = new ReportDemo();

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id, name, address, gender, phonenumber FROM UserInfo", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportDemo.dt = dt;

            reportDemo.ShowDialog();
            
            
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoggedIn_Load(object sender, EventArgs e)
        {
            InitConnection();
        }
    }
}
