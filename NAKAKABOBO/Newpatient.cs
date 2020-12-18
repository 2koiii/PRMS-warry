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
    public partial class Newpatient : Form
    {
        private string status = "0";
        SqlConnection con = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        SqlCommand cmd;

        public Newpatient()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.status.Trim().Equals("0"))
            {
                if (txtlast.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Last Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                    txtlast.Focus();
                    return;
                }
                if (txtfirst.Text.Trim().Length == 0)
                {
                    MessageBox.Show("First Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtfirst.Focus();
                    return;
                }
                if (txtmiddle.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Middle Name is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtmiddle.Focus();
                    return;
                }
                if (combogender.SelectedItem.ToString().Length == 0)
                {
                    MessageBox.Show("Gender is empty", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    combogender.Focus();
                    return;
                }
               

               if (txtcontact.Text.Trim().Length == 0)
                {
                    MessageBox.Show("No Contact #: Input None!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtcontact.Focus();
                    return;
                }
                if (txtadd.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Address is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtadd.Focus();
                    return;
                }
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

                    con.Open();
                    cmd = new SqlCommand("INSERT into tbl_final3 (LastName,FirstName,MiddleName,Gender,Contact_Number,Address,Time_Visited,Date_Visited,Medicine,Medical_Condition,Status) Values('"
                     + txtlast.Text + "','"
                     + txtfirst.Text + "','"
                     + txtmiddle.Text + "','"
                     + combogender.SelectedItem.ToString() + "','"
                     + txtcontact.Text + "','"
                     + txtadd.Text + "','"
                     + label1time.Text + "','"
                     + dtdate.Text + "','"
                     + combomedicine.SelectedItem.ToString() + "','"
                     + combocondition.SelectedItem.ToString() + "','"
                     + combostatus.SelectedItem.ToString() + "') Insert into Patient_History4 (LastName, FirstName,ContactNumber,Gender,Address,Time_Visited,Date_Visited,Medicine, MedicalCondition) values ('"
                     + txtlast.Text + "','"
                     + txtfirst.Text + "','"
                     + txtcontact.Text+"','"
                     + combogender.SelectedItem.ToString() + "','"
                     + txtadd.Text + "','"
                     + label1time.Text +"','"
                     + dtdate.Text + "','"
                     + combomedicine.SelectedItem.ToString() + "','"
                     + combocondition.SelectedItem.ToString() + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Patient Added Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f = new Form1();
                    f.Show();

                    
                }

                txtlast.Text = "";
                txtfirst.Text = "";
                txtmiddle.Text = "";
                combogender.Text = "";
                txtcontact.Text = "";
                combomedicine.Text = "";
                combocondition.Text = "";
                combostatus.Text = "";
                
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timer = DateTime.Now;
            this.label1time.Text = timer.ToString("hh:mm:ss tt");
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
                MessageBox.Show("Invalid Entry");
            }
        }

        

        private void UPDATEBOXES_Load(object sender, EventArgs e)
        {
          
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure to cancel", "Cancel Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {

                this.Close();
            }
            
        }
        
    }
}
