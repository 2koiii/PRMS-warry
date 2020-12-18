using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NAKAKABOBO
{
    public partial class medicalhistory : Form
    {
        public medicalhistory()
        {
            InitializeComponent();
        }

        private void medicalhistory_Load(object sender, EventArgs e)
        {
            
                history cr = new history();
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["dbx"].ToString();

                string sql = "Select * from Patient_History4 where LastName = '" + Class4.LastName + "' and FirstName=  '" + Class3.FirstName + "' ";
                DataSet3 ds = new DataSet3();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.Fill(ds, "Patient_History4");

                cr.SetDataSource(ds.Tables["Patient_History4"]);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
