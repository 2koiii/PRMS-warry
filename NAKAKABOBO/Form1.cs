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
using System.Threading;

namespace NAKAKABOBO
{
    public partial class Form1 : Form
    {
        
        //private string status = "0";
        SqlConnection con = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        SqlCommand cmd;
        // SqlDataAdapter SDA;
        //DataTable dt;
        int Record_ID;
        

        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }
        private void DisplayRecord()
        {
            //SqlConnection connection = new SqlConnection(con.Trim());

            //try
            //{
            //    SqlCommand command = connection.CreateCommand();
            //    command.CommandText = "Select ID,LastName,MiddleName,FirstName,Contact_Number,Address,Time_Visited,Date_Visited,Medicine,Medical_Condition,Status ORDER BY LastName";
            //    SqlDataAdapter data_adapter = new SqlDataAdapter();
            //    data_adapter.SelectCommand = command;
            //    DataSet myDataSet = new DataSet();
            //    connection.Open();
            //    data_adapter.Fill(myDataSet, "Table");
            //    DataTable dttable = myDataSet.Tables["Tables"];
            //    dataGridView1.Items.Clear();
            //}
        }
        private void dataGridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    ID.Text = dataGridView1.Items[dataGridView1.FocusedItem.Index].SubItem[0].Text.Trim();
            //}
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //if (this.status.Trim().Equals("0"))
            //{
            //    if (txtlast.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        txtlast.Focus();
            //        return;
            //    }
            //    if (txtfirst.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        txtfirst.Focus();
            //        return;
            //    }
            //    if (txtmiddle.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        txtmiddle.Focus();
            //        return;
            //    }
            //    if (txtcontact.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        txtcontact.Focus();
            //        return;
            //    }
            //    if (txtadd.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        txtadd.Focus();
            //        return;
            //    }
            //    if (dtdate.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        dtdate.Focus();
            //        return;
            //    }
            //    if (txtmedicine.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        txtmedicine.Focus();
            //        return;
            //    }
            //    if (combocondition.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        combocondition.Focus();
            //        return;
            //    }
            //    if (combostatus.Text.Trim().Length == 0)
            //    {
            //        MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        combostatus.Focus();
            //        return;
            //    }
            //    if (MessageBox.Show("Save new Patient Information", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {

            //        con.Open();
            //        cmd = new SqlCommand("INSERT into tbl_final2 (LastName,FirstName,MiddleName,Gender,Contact_Number,Address,Time_Visited,Date_Visited,Medicine,Medical_Condition,Status) Values('"
            //         + txtlast.Text + "','"
            //         + txtfirst.Text + "','"
            //         + txtmiddle.Text + "','"
            //         + combogender.Text + "','"
            //         + txtcontact.Text + "','"
            //         + txtadd.Text + "','"
            //         + lbltime.Text + "','"
            //         + dtdate.Text + "','"
            //         + txtmedicine.Text + "','"
            //         + combocondition.Text + "','"

            //         + combostatus.Text + "') Insert into Patient_History2 (LastName,FirstName,Gender,Address,MedicalCondition) values ('" 
            //         + txtlast.Text + "','" 
            //         + txtfirst.Text + "','"
            //         + combogender.Text + "','"
            //         + txtadd.Text + "','"
            //         + combocondition.Text + "')", con);

            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //        MessageBox.Show("New Patient Added");
            //    }

            //}

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timer = DateTime.Now;
            this.lbltime.Text = timer.ToString("hh:mm:ss tt");
        }

        
        private void btnnew_Click(object sender, EventArgs e)
        {
            //reset();
            //txtlast.Focus();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Record_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtlast.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtfirst.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtmiddle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                combogender.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtcontact.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtadd.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                lbltime.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dtdate.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                combomedicine.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                combocondition.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                combostatus.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

                btnupdate.Enabled = true;

            }

        }
        void reset()
        {
            //txtlast.Text = txtfirst.Text = txtmiddle.Text = combogender.Text = txtcontact.Text = txtadd.Text = lbltime.Text = dtdate.Text = txtmedicine.Text = combocondition.Text = combostatus.Text = "";
            ////.Text = "Save";
            //Record_ID = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtlast.ReadOnly = true;
            txtfirst.ReadOnly = true;
            txtmiddle.ReadOnly = true;
            combogender.Enabled = false;
            txtcontact.ReadOnly = true;
            txtadd.ReadOnly = true;

            string query = "Select * from tbl_final3";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            btnupdate.Enabled = false;

            

            reset();
            combocondition.SelectedIndex = -1;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtfirst.Text == "" || txtlast.Text == "")
            {
                MessageBox.Show("Please input information before saving!!!");
            }
            else
            {
                if (MessageBox.Show("Do you want to update Patient!!!! info?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("UPDATE tbl_final3 set LastName='"
                            + txtlast.Text +
                            "',MiddleName='" + txtmiddle.Text +
                            "',FirstName='" + txtfirst.Text +
                             "',Gender='" + combogender.Text +
                            "',Contact_Number='" + txtcontact.Text +
                            "',Address='" + txtadd.Text +
                            "',Date_Visited='" + dtdate.Text +
                            "',Medicine='" + combomedicine.Text +
                            "',Medical_Condition='" + combocondition.Text +
                            "',Status='" + combostatus.Text +
                            "'WHERE ID='" + Record_ID + "'",con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Patient Updated");
                        //con.Close();

                        //con.Open();
                        //cmd=new SqlCommand ("Update  Patient_History4 set LastName='"+txtlast.Text+"' ,FirstName='"+ txtfirst.Text + "',Gender='"+ combogender.Text + "',ContactNumber='"
                        //    +txtcontact.Text+"',Address='" + txtadd.Text + "',Medicine='"+combomedicine.Text+"',MedicalCondition='"+combocondition.Text+"'", con);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");

            SqlDataAdapter SDA = new SqlDataAdapter("Select ID,LastName, FirstName, MiddleName,Gender, Contact_Number, Address, Time_Visited, Date_Visited, Medicine, Medical_Condition, Status from tbl_final3 where LastName like '%" + txtsearch.Text + "%' OR FirstName like '%" + txtsearch.Text + "%'", conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text == "Search")
            {
                int n = dataGridView1.Rows.Add();
                txtsearch.Clear();
                txtsearch.ForeColor = Color.Black;
            }
        }
       

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Focused && txtsearch.Text == "Search")
            {
                txtsearch.Clear();
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            VIEW v = new VIEW();
            v.Show();
            
        }

        private void opennewForm()
        {
            Application.Run(new MAINPAGE());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            string query = "Select * from tbl_final3";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        
    }
}
