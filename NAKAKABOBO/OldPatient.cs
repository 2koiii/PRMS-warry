using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using System.Drawing;

namespace NAKAKABOBO
{
    public partial class OldPatient : Form
    {
        //Thread th;
        private string status = "0";
        SqlConnection con = new SqlConnection(@"Data Source=axolo2l\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        SqlCommand cmd;
        //int Record_ID;
       

        public OldPatient()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            txtlast.ReadOnly = true;
            txtfirst.ReadOnly = true;
            txtmiddle.ReadOnly = true;
            combogender.Enabled = false;
            txtcontact.ReadOnly = true;
            txtadd.ReadOnly = true;

            
        }
        private void LoadData()
        {
           

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timer = DateTime.Now;
            this.label13.Text = timer.ToString("hh:mm:ss tt");
        }

        private void btnsumbit_Click(object sender, EventArgs e)
        {

            if (this.status.Trim().Equals("0"))
            {

                if (dtdate.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Date Visited is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtdate.Focus();
                    return;
                }
                if (combomedicine.SelectedItem.ToString().Length == 0)
                {
                    MessageBox.Show("Medicine is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    combomedicine.Focus();
                    return;
                }
                if (combocondition.SelectedItem.ToString().Length == 0)
                {
                    MessageBox.Show("No Medical Condition!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    combocondition.Focus();
                    return;
                }
                if (combostatus.SelectedItem.ToString().Length == 0)
                {
                    MessageBox.Show("Please put status!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    combostatus.Focus();
                    return;
                }
                if (MessageBox.Show("Save new Patient Information", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("INSERT into tbl_final2 (LastName,FirstName,MiddleName,Gender,Contact_Number,Address,Time_Visited,Date_Visited,Medicine,Medical_Condition,Status) Values('"
                         + txtlast.Text + "','"
                         + txtfirst.Text + "','"
                         + txtmiddle.Text + "','"
                         + combogender.Text + "','"
                         + txtcontact.Text + "','"
                         + txtadd.Text + "','"
                         + label13.Text + "','"
                         + dtdate.Text + "','"
                         + combomedicine.SelectedItem.ToString() + "','"
                         + combocondition.SelectedItem.ToString() + "','"
                         + combostatus.SelectedItem.ToString() + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Patient Added Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 f = new Form1();
                            f.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure to Exit", "Exit Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            txtlast.Clear();

            String source  = @"Data Source=axolo2l\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            //string Xstring = "4";
            //int x = int.Parse(Xstring);

            String sqlSelectQuery = "Select ID, LastName,FirstName,MiddleName,Gender,Contact_Number,Address from tbl_final2 WHERE LastName= '" + textBox1.Text+ "' and FirstName='" +textBox2.Text+ "' ";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //txtid.Text = (dr["ID"].ToString());
                txtlast.Text = (dr["LastName"].ToString());
                txtfirst.Text = (dr["FirstName"].ToString());
                txtmiddle.Text = (dr["MiddleName"].ToString());
                combogender.SelectedItem = (dr["Gender"].ToString());
                txtcontact.Text = (dr["Contact_Number"].ToString());
                txtadd.Text = (dr["Address"].ToString());
               
                //label13.Text = (dr["Time_Visited"].ToString());
                //dtdate.Text = (dr["Date_Visited"].ToString());
                //combomedicine.Text = (dr["Medicine"].ToString());
                //combocondition.Text = (dr["Medical_Condition"].ToString());
                //combostatus.Text = (dr["Status"].ToString());


            }
            con.Close();

            if (txtlast.Text == "")
            {
                MessageBox.Show("No records found.\nTry finding the right patient or add new patient", "Record doesn't exists", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "Last Name")
            {
                textBox1.Clear();
            }
            else
                textBox1.ForeColor = Color.Black;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text == "First Name")
            {
                textBox2.Clear();
            }
            else
                textBox2.ForeColor = Color.Black;
        }

        private void combostatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

