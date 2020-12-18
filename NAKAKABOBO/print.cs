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
    public partial class print : Form
    {
        public print()
        {
            InitializeComponent();
        }

        private void print_Load(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["dbx"].ToString();

            string sql = "Select LastName,FirstName,MiddleName,Gender,Contact_Number,Address,Time_Visited,Date_Visited,Medicine,Medical_Condition from tbl_final3 where Date_Visited between '" + tbl_report.Date_Visited + "' and '" + Class1.Date_Visited + "'";
            DataSet1 ds = new DataSet1();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "tbl_final3");

            cr.SetDataSource(ds.Tables["tbl_final3"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
