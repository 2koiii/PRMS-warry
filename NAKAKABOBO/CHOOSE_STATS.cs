using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace NAKAKABOBO
{
    public partial class CHOOSE_STATS : Form
    {
        Thread th;
        public CHOOSE_STATS()
        {
            InitializeComponent();
        }

        private void btnprocede_Click(object sender, EventArgs e)
        {
            string choice = comboBox1.SelectedItem.ToString();
            if (choice == "Line Graph")
            {
                var line = new Stats_Line_Graph();
                line.StartPosition = FormStartPosition.CenterScreen;
                line.Show();
            }
            else if (choice == "Bar Graph")
            {
                var bar = new BAR_Graph();
                bar.StartPosition = FormStartPosition.CenterScreen;
                bar.Show();
            }
            else if (choice =="Pie Chart")
            {
                var pie = new STATS();
                pie.StartPosition = FormStartPosition.CenterScreen;
                pie.Show();
            }
            else
            {
                MessageBox.Show("Please Select a Graph Type","Incorect Graph Type",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void CHOOSE_STATS_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are You Sure To Exit?", "Exit Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question))==DialogResult.Yes)
            {

                th = new Thread(Opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
        }

        private void Opennewform()
        {
            Application.Run(new MAINPAGE());
        }
    }
}
