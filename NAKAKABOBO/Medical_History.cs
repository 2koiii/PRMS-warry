using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace NAKAKABOBO
{
   

    public partial class Medical_History : Form
    {
        Thread th;
        SqlConnection con = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        public Medical_History()
        {
            InitializeComponent();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (txtsearch.Focused && txtsearch.Text == "Search")
            //{
            //    txtsearch.Clear();
            //}
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");

            //SqlDataAdapter SDA = new SqlDataAdapter("Select HistoryID, LastName, FirstName,Gender,ContactNumber,Address,Time_Visited,Date_Visited,Medicine, MedicalCondition from Patient_History4 where LastName like '%" + txtsearch.Text + "%' And FirstName like '%" + txtsearch.Text + "%' " , conn);
            //DataTable dt = new DataTable();
            //SDA.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].Visible = false;
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            //if (txtsearch.Text == "Search")
            //{

            //    int n = dataGridView1.Rows.Add();
            //    txtsearch.Clear();
            //    txtsearch.ForeColor = Color.Black;
            //}
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit?", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                

                this.Close();
                th = new Thread(Opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void Opennewform()
        {
            Application.Run(new MAINPAGE());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (!(txtsearch.Text == ""))
            //{
            //    foreach (DataGridView i in dataGridView1.Rows)
            //    {
            //        //txtsearch += i.Rows.Count.ToString().["LastName"].Value;
                    
            //    }

            //    Class2.ID = txtsearch.Text;
            //    medicalhistory f = new medicalhistory();
            //    f.Show();
            //}
            //else
            //{ 
            //    MessageBox.Show("Select Data to be reported?", "History Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void Medical_History_Load(object sender, EventArgs e)
        {

            //SqlConnection conn = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = ConfigurationManager.ConnectionStrings["dbx"].ToString();

            //string sql = "Select HistoryID, LastName, FirstName,Gender,ContactNumber,Address,Time_Visited,Date_Visited,Medicine, MedicalCondition from Patient_History4 where LastName= '" + Class4.LastName + "' and FirstName=  '" + Class3.FirstName + "'";
            //DataSet3 ds = new DataSet3();
            //SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            //adapter.Fill(ds, "Patient_History4");
            //dataGridView1.DataSource = ds;


            //con.Open();
            //string query = "Select * from Patient_History4";
            //SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            //DataTable dt = new DataTable();
            //SDA.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].Visible = false;
            //con.Close();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["LastName"], ListSortDirection.Ascending);
          
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");

            //SqlDataAdapter SDA = new SqlDataAdapter("Select * from Patient_History4 where FirstName ='" + textBox1.Text + "'  ", conn);
            //DataTable dt = new DataTable();
            //SDA.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].Visible = false;

            ////itemsFoundList.Columns.Cleard();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow currentrow = dataGridView1.SelectedRows ();
        }
    }
}
