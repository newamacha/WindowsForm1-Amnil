using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class ReportDemo : Form
    {
        public ReportDemo()
        {
            InitializeComponent();
        }

        public DataTable dt = null;

        private void ReportDemo_Load(object sender, EventArgs e)
        {
            int count = dt.Rows.Count;
            string ImagePaths = @"file:///"  + Application.StartupPath + @"\Reports\" + "image.png";


            this.reportViewer1.LocalReport.EnableExternalImages = true;

            ReportParameter reportParameter = new ReportParameter("RandomParameter", count.ToString());
            ReportParameter reportParameter1 = new ReportParameter("ImagePath", ImagePaths);


            ReportDataSource rds = new ReportDataSource("dsUserInfo", dt);

            this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\" + "rptReportDemo.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {reportParameter, reportParameter1});
            this.reportViewer1.RefreshReport();
        }
    }
}
