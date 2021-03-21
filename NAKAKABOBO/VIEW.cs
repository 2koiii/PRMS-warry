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
    public partial class VIEW : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=axolo2l\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True");
        public VIEW()
        {
            InitializeComponent();
        }

       private void Opennewform()
        {
            Application.Run(new Form1());
        }

        private void VIEW_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from tbl_final2";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            con.Close();
        }
    }
}
