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
        SqlConnection con = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
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

            //string query = "Select * from tbl_final3";
            //SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            //DataTable dt = new DataTable();
            //SDA.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].Visible = false;


            //LoadData();


            //    try
            //    {
            //        SqlDataAdapter data = new SqlDataAdapter("Select SUM(Total)Total From tbl_final2 where Gender='Male' ", connectionstring);
            //        DataTable ss = new DataTable();
            //        data.Fill(ss);
            //        dataGridView1.DataSource = ss;
            //        dataGridView1.AllowUserToAddRows = false;

            //        for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            //        {
            //            int total =
            //            Convert.ToInt32(dataGridView1.Rows[i].Cells["Total"].Value.ToString());

            //            lblMale.Text = total.ToString().Trim();
            //        }
            //    }
            //    catch (Exception)
            //    { }
            //    try
            //    {
            //        SqlDataAdapter data = new SqlDataAdapter("Select SUM(Total)Total From tbl_final2 where Gender='Female'  ", connectionstring);
            //        DataTable ss = new DataTable();
            //        data.Fill(ss);
            //        dataGridView1.DataSource = ss;
            //        dataGridView1.AllowUserToAddRows = false;

            //        for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            //        {
            //            int total = Convert.ToInt32(dataGridView1.Rows[i].Cells["Total"].Value.ToString());

            //            lblFemale.Text = total.ToString().Trim();
            //        }
            //    }
            //    catch (Exception)
            //    {
            //    }

            //    //chart1.Titles.Add("Pie Chart").Font = new Font("Century Gothic", 14, FontStyle.Bold);

            //    chart1.Series["Series1"].IsValueShownAsLabel = true;
            //    chart1.Series["Series1"].Points.AddXY("Male:" + lblMale.Text + "", lblMale.Text);
            //    chart1.Series["Series1"].Points.AddXY("Female:" + lblFemale.Text + "", lblFemale.Text);
            //}
        }
        private void LoadData()
        {
            //chart1.Titles.Add("Pie Chart").Font = new Font("Century Gothic", 14, FontStyle.Bold);
            //chart1.DataSource = GetData();
            
            //chart1.Series["Series1"].XValueMember = "Gender";
            //chart1.Series["Series1"].XValueMember = "Medical_Condition";
            //chart1.Series["Series1"].YValueMembers = "Total";

            //chart1.Series["Series1"].Points.AddXY("Male:" + lblMale.Text + "", lblMale.Text);
            //chart1.Series["Series1"].Points.AddXY("Female:" + lblFemale.Text + "", lblFemale.Text);

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
                        cmd = new SqlCommand("INSERT into tbl_final3 (LastName,FirstName,MiddleName,Gender,Contact_Number,Address,Time_Visited,Date_Visited,Medicine,Medical_Condition,Status) Values('"
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
                         + combostatus.SelectedItem.ToString() + "') Insert into Patient_History4 (LastName, FirstName,ContactNumber,Gender,Address,Time_Visited,Date_Visited,Medicine, MedicalCondition) values ('"
                         + txtlast.Text + "','"
                         + txtfirst.Text + "','"
                         + txtcontact.Text + "','"
                         + combogender.Text + "','"
                         + txtadd.Text + "','"
                         + label13.Text + "','"
                         + dtdate.Text + "','"
                         + combomedicine.Text + "','"
                         + combocondition.Text + "')", con);
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

            String source  = @"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            //string Xstring = "4";
            //int x = int.Parse(Xstring);

            String sqlSelectQuery = "Select ID, LastName,FirstName,MiddleName,Gender,Contact_Number,Address from tbl_final3 WHERE LastName= '" + textBox1.Text+ "' and FirstName='" +textBox2.Text+ "' ";
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

        //DataTable dtChartData = new DataTable();

        //using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbx"].ConnectionString)) 
        //{
        //    using (SqlCommand cmd = new SqlCommand("usp_ChartData7", conn))
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        conn.Open();

        //        SqlDataReader reader = cmd.ExecuteReader();

        //        dtChartData.Load(reader);

        //    }
        //}


        //    return dtChartData;
    }
}

