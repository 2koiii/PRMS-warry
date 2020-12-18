using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace NAKAKABOBO
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter dm;
        string date1;
        string date2;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;

            con.Open();

            DataTable dt = new DataTable();


            cmd = new SqlCommand("Select LastName,FirstName,MiddleName,Gender,Contact_Number,Address,Date_Visited,Medicine,Medical_Condition From tbl_final3 where Date_Visited between '" + date1 + "' and '" + date2 + "' ", con);
            dm = new SqlDataAdapter(cmd);
            dm.Fill(dt);  

            CrystalReport1 cr = new CrystalReport1();
            cr.Database.Tables["tbl_final3"].SetDataSource(dt);

            this.crystalReportViewer1.ReportSource = cr;
            

            con.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit?", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
