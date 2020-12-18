using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NAKAKABOBO
{
    public partial class PRODUCEMH : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        //SqlCommand cmd;
        //SqlDataAdapter dm;
        //string first;
        //string last;
        public PRODUCEMH()
        {
            InitializeComponent();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            ////first = txtfirst.ToString();
            ////last = txtlast.ToString();
            //con.Open();

            //DataTable dt = new DataTable();


            //cmd = new SqlCommand("Select * From Patient_History4 where FirstName=  '" + txtfirst.Text + "' and LastName= '" + txtlast.Text + "' ", con);
            //dm = new SqlDataAdapter(cmd);
            //dm.Fill(dt);

            //CrystalReport2 cr = new CrystalReport2();
            //cr.Database.Tables["Patient_History4"].SetDataSource(dt);

            //this.crystalReportViewer1.ReportSource = cr;

            //con.Close();
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
