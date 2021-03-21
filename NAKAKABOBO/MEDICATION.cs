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
    public partial class MEDICATION : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=axolo2l\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter dm;
        public MEDICATION()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtlast.Text == "" || txtfirst.Text == "")
            {
                MessageBox.Show("Input Lastname and FirstName to search!", "Search ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else if (txtlast.Text != "1"   &&  txtfirst.Text != "1")
            //{
            //    MessageBox.Show("No data found", "Search Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            else
            {

                con.Open();

                DataTable dt = new DataTable();


                cmd = new SqlCommand("Select * From tbl_final2 where  LastName= '" + txtlast.Text + "' and FirstName=  '" + txtfirst.Text + "' ", con);
                dm = new SqlDataAdapter(cmd);
                dm.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.Columns[0].Visible = false;

                con.Close();

            }

        }
        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtlast.Text == "" || txtfirst.Text == "")
            {
                MessageBox.Show("Choose Data to Print!", " Printing Medical History", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Class4.LastName = txtlast.Text;
                Class3.FirstName = txtfirst.Text;

                medicalhistory f = new medicalhistory();
                f.Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MEDICATION_Load(object sender, EventArgs e)
        {
            string query = "Select * from tbl_final2";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["LastName"], ListSortDirection.Ascending);
        }
    }
}
