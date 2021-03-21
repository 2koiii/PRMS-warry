using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace NAKAKABOBO
{
    public partial class Rport_Viewer : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=axolo2l\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter dm;
        string date1;
        string date2;

        public Rport_Viewer()
        {
            InitializeComponent();
        }
        private void Rport_Viewer_Load(object sender, EventArgs e)
        {
        
        }

        private void btngo_Click(object sender, EventArgs e)
        {

            
                date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
                date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;

                con.Open();

                cmd = new SqlCommand("Select LastName,FirstName,MiddleName,Gender,Contact_Number,Address,Time_Visited,Date_Visited,Medicine,Medical_Condition From tbl_final2 where Date_Visited between '" + date1 + "' and '" + date2 + "' ", con);
                DataTable dt = new DataTable();
                dm = new SqlDataAdapter(cmd);
                dm.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
               
            
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            

          

           
        }

        Bitmap bmp;
        
        private void btnprint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }



//        private void btnprint_Click(object sender, EventArgs e)
//        {
//            
//                tbl_report.Date_Visited = date1.ToString();
//               Class1.Date_Visited = date2.ToString();
//
//                print f = new print();
//                f.Show();
//            
//        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
