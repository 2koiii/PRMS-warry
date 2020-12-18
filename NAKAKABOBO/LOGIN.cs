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

namespace NAKAKABOBO
{
    public partial class LOGIN : Form
    {
       // private string connectionString = @"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True";

        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            txtuser.Text = "username";
            txtlogin.Text = "password";
            txtuser.ForeColor = Color.Black;
            txtlogin.ForeColor = Color.Black;
            //var log = new LOGIN();
            //log.StartPosition = FormStartPosition.WindowsDefaultLocation;
            //this.reportViewer1.RefreshReport();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
            string query = "Select * from LOGIN where Username = '" + txtuser.Text.Trim() + "' and Password = '" + txtlogin.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MAINPAGE objMAINPAGE = new MAINPAGE();
                MessageBox.Show("Login Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                objMAINPAGE.Show();
            }
     
            //if (txtuser.Text == "" && txtlogin.Text == "")
            //{
            //    MessageBox.Show("Invalid input!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtuser.ResetText();
            //    txtlogin.ResetText();
            //    txtuser.Focus();
            //}
            else
            {
                MessageBox.Show("Invalid Username and Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.ResetText();
                txtlogin.ResetText();
                txtuser.Focus();
            }
            
        }

        private void txtlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnlogin.PerformClick();
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "username")
            {
                txtuser.ResetText();
                txtlogin.ResetText();
            }
            txtuser.ForeColor = Color.Black;
            txtlogin.ForeColor = Color.Black;
            txtlogin.PasswordChar = '*';
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
