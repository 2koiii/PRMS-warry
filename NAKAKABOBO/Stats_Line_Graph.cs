using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NAKAKABOBO
{
    public partial class Stats_Line_Graph : Form
    {
        string connectionstring = @"Data Source=gaming-rig\SQLEXPRESS;Initial Catalog=FINAL_DB;Integrated Security=True";

        public Stats_Line_Graph()
        {
            InitializeComponent();
        }



        private void Stats_Line_Graph_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter data = new SqlDataAdapter("select COUNT(ID)ID From [dbo].[tbl_final3] where Medical_Condition='Fever' ", connectionstring);
                DataTable ss = new DataTable();
                data.Fill(ss);
                dataGridView1.DataSource = ss;
                dataGridView1.AllowUserToAddRows = false;

                for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
                {
                    int total =

                    Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value.ToString());


                    lblfever.Text = total.ToString().Trim();

                }
            }
            catch (Exception)
            {
            }
            try
            {
                SqlDataAdapter data = new SqlDataAdapter("select COUNT(ID)ID From[dbo].[tbl_final3] where Medical_Condition = 'Cough' ", connectionstring);
                DataTable ss = new DataTable();
                data.Fill(ss);
                dataGridView1.DataSource = ss;
                dataGridView1.AllowUserToAddRows = false;

                for (int l = 0; l <= dataGridView1.Columns.Count - 1; l++)
                {
                    int total = Convert.ToInt32(dataGridView1.Rows[l].Cells["ID"].Value.ToString());

                    lblcough.Text = total.ToString().Trim();
                }
            }
            catch (Exception)
            {
            }
            try
            {
                SqlDataAdapter data = new SqlDataAdapter("select COUNT(ID)ID From[dbo].[tbl_final3] where Medical_Condition = 'Diarrhea' ", connectionstring);
                DataTable ss = new DataTable();
                data.Fill(ss);
                dataGridView1.DataSource = ss;
                dataGridView1.AllowUserToAddRows = false;

                for (int l = 0; l <= dataGridView1.Columns.Count - 1; l++)
                {
                    int total = Convert.ToInt32(dataGridView1.Rows[l].Cells["ID"].Value.ToString());

                    lbldiarrhea.Text = total.ToString().Trim();
                }
            }
            catch (Exception)
            {
            }
            try
            {
                SqlDataAdapter data = new SqlDataAdapter("select COUNT(ID)TOtal From[dbo].[tbl_final3] where Medical_Condition = 'Cold' ", connectionstring);
                DataTable ss = new DataTable();
                data.Fill(ss);
                dataGridView1.DataSource = ss;
                dataGridView1.AllowUserToAddRows = false;

                for (int l = 0; l <= dataGridView1.Columns.Count - 1; l++)
                {
                    int total = Convert.ToInt32(dataGridView1.Rows[l].Cells["TOtal"].Value.ToString());

                    lblcold.Text = total.ToString().Trim();
                }
            }
            catch (Exception)
            {
            }
            try
            {
                SqlDataAdapter data = new SqlDataAdapter("select COUNT(ID)TOtal From[dbo].[tbl_final3] where Medical_Condition = 'Dysmenorhea' ", connectionstring);
                DataTable ss = new DataTable();
                data.Fill(ss);
                dataGridView1.DataSource = ss;
                dataGridView1.AllowUserToAddRows = false;

                for (int l = 0; l <= dataGridView1.Columns.Count - 1; l++)
                {
                    int total = Convert.ToInt32(dataGridView1.Rows[l].Cells["TOtal"].Value.ToString());

                    lbldys.Text = total.ToString().Trim();
                }
            }
            catch (Exception)
            {
            }
            try
            {
                SqlDataAdapter data = new SqlDataAdapter("select COUNT(ID)TOtal From[dbo].[tbl_final3] where Medical_Condition = 'Stomach Ache' ", connectionstring);
                DataTable ss = new DataTable();
                data.Fill(ss);
                dataGridView1.DataSource = ss;
                dataGridView1.AllowUserToAddRows = false;

                for (int l = 0; l <= dataGridView1.Columns.Count - 1; l++)
                {
                    int total = Convert.ToInt32(dataGridView1.Rows[l].Cells["TOtal"].Value.ToString());

                    lblstomach.Text = total.ToString().Trim();
                }
            }
            catch (Exception)
            {
            }
            try
            {
                SqlDataAdapter data = new SqlDataAdapter("select COUNT(ID)TOtal From[dbo].[tbl_final3] where Medical_Condition = 'Head Ache' ", connectionstring);
                DataTable ss = new DataTable();
                data.Fill(ss);
                dataGridView1.DataSource = ss;
                dataGridView1.AllowUserToAddRows = false;

                for (int l = 0; l <= dataGridView1.Columns.Count - 1; l++)
                {
                    int total = Convert.ToInt32(dataGridView1.Rows[l].Cells["TOtal"].Value.ToString());

                    lblhead.Text = total.ToString().Trim();
                }
            }
            catch (Exception)
            {
            }

            //chart1.Titles.Add("Pie Chart").Font = new Font("Century Gothic", 14, FontStyle.Bold);

            chart1.Series["Series1"].IsValueShownAsLabel = true;
            //chart1.Series["Series1"].Points.AddXY("Male:" + lblMale.Text + "", lblMale.Text);
            //chart1.Series["Series1"].Points.AddXY("Female:" + lblFemale.Text + "", lblFemale.Text);
            chart1.Series["Series1"].Points.AddXY("Fever:" + lblfever.Text + "", lblfever.Text);
            chart1.Series["Series1"].Points.AddXY("Cough:" + lblcough.Text + "", lblcough.Text);
            chart1.Series["Series1"].Points.AddXY("Diarrhea:" + lbldiarrhea.Text + "", lbldiarrhea.Text);
            chart1.Series["Series1"].Points.AddXY("Cold:" + lblcold.Text + "", lblcold.Text);
            chart1.Series["Series1"].Points.AddXY("Dysmenorhea:" + lbldys.Text + "", lbldys.Text);
            chart1.Series["Series1"].Points.AddXY("Stomach Ache:" + lblstomach.Text + "", lblstomach.Text);
            chart1.Series["Series1"].Points.AddXY("Head Ache:" + lblhead.Text + "", lblhead.Text);
        }

        private void lblhead_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
        //    if (MessageBox.Show("Are you sure to EXIT?", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        this.Close();
        //    }
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to EXIT?", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
