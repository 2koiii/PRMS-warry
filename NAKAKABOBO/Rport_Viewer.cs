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
        
        SqlConnection con = new SqlConnection(@"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
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
            //string query = "Select * from tbl_final3";
            //SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            //DataTable dt = new DataTable();
            //SDA.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].Visible = false;
        }

        private void btngo_Click(object sender, EventArgs e)
        {

            
                date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
                date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;

                con.Open();

                cmd = new SqlCommand("Select LastName,FirstName,MiddleName,Gender,Contact_Number,Address,Time_Visited,Date_Visited,Medicine,Medical_Condition From tbl_final3 where Date_Visited between '" + date1 + "' and '" + date2 + "' ", con);
                DataTable dt = new DataTable();
                dm = new SqlDataAdapter(cmd);
                dm.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
                //CrystalReport3 crystal = new CrystalReport3();
                //crystal.Database.Tables["tbl_final"].SetDataSource(dt);

                //ReportDataSource rs = new ReportDataSource();
                //List<Final> lst = new List<Final>();
                //lst.Clear();

                //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                //{
                //    lst.Add(new Final
                //    {
                //        LastName = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                //        FirstName = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                //        MiddleName = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                //        Gender = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                //        Contact_Number = dataGridView1.Rows[i].Cells[4].Value.ToString(),
                //        Address = dataGridView1.Rows[i].Cells[5].Value.ToString(),
                //        Date_Visited = dataGridView1.Rows[i].Cells[6].Value.ToString(),
                //        Medical_Condition = dataGridView1.Rows[i].Cells[7].Value.ToString()
                //    });
                //    rs.Name = "tbl_final";
                //    rs.Value = lst;
                //    Rport_Viewer frm = new Rport_Viewer();

                //}
            
        }

        //public class Final
        //{

        //    public string LastName { get; set; }
        //    public string FirstName { get; set; }
        //    public string MiddleName { get; set; }
        //    public string Gender { get; set; }
        //    public string Contact_Number { get; set; }
        //    public string Address { get; set; }
        //    public string Date_Visited { get; set; }
        //    public string Medical_Condition { get; set; }

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            //date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;

            //con.Open();
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();



            //cmd = new SqlCommand("Select LastName,FirstName,MiddleName,Gender,Contact_Number,Address,Date_Visited,Medical_Condition From tbl_final2 where Date_Visited between '" + date1 + "' and '" + date2 + "' ", con);
            //dm = new SqlDataAdapter(cmd);
            //dm.Fill(dt);

            //foreach (DataGridViewRow dgv in dataGridView1.Rows)
            //{
            //    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2]);
            //    ds.Tables.Add(dt);
            //    ds.WriteXmlSchema("tbl_final");

            //    //CrystalReport3 cr = new CrystalReport3();
            //    //cr.Database.Tables["tbl_final2"].SetDataSource(dt);
                
            //    //print frm = new print();
            //    //crystalReportViewer1.ReportSource = cr;
            //    //frm.ShowDialog();
                

            //    con.Close();
           // }

            


            //CrystalReport3 cr = new CrystalReport3();
            //cr.Database.Tables["tbl_final2"].SetDataSource(dt);
            //dataGridView1.DataSource = dt;

          

           
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            
                tbl_report.Date_Visited = date1.ToString();
                Class1.Date_Visited = date2.ToString();

                print f = new print();
                f.Show();
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //public class CrystalReportViewer1
        //{
        //    public string LastName { get; set; }
        //    public string FirstName { get; set; }
        //    public string MiddleName { get; set; }
        //    public string Gender { get; set; }
        //    public string Contact_Number { get; set; }
        //    public string Address { get; set; }
        //    public string Date_Visited { get; set; }
        //    public string Medical_Condition { get; set; }
        //}


    }
}
