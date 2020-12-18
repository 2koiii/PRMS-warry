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
    public partial class MAINPAGE : Form
    {
        //Thread th;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        

        public MAINPAGE()
        {
            InitializeComponent();
            timer1.Start();
            

            //searchData = ("");
            //panelleft.Height = button1.Height;
            //panelleft.RightToLeft = button1.RightToLeft;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Rport_Viewer f = new Rport_Viewer();
            f.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to Log Out?", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void Timer1(object sender, EventArgs e)
        {
            if (label1.Left < 0 && (Math.Abs(label1.Left) > label1.Width))
                label1.Left = this.Width;

            label1.Left -= 3;

            DateTime timer = DateTime.Now;
            this.lbltime.Text = timer.ToString("hh:mm:ss tt");


        }
        private void btnstats_Click(object sender, EventArgs e)
        {
            var choose = new CHOOSE_STATS();
            choose.FormBorderStyle = FormBorderStyle.None;
            choose.StartPosition = FormStartPosition.CenterScreen;
            choose.Show();
            this.Hide();
        }

        private void MAINPAGE_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 20;
        }

       
        private void btnhistory_Click(object sender, EventArgs e)
        {
            MEDICATION patient = new MEDICATION();
            patient.Show();
        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add f = new add();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btnadd.Enabled = true;
        }
    }
}
