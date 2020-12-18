using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NAKAKABOBO
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Newpatient f = new Newpatient();
                f.Show();
            }
            if (radioButton2.Checked)
            {
                OldPatient f = new OldPatient();
                f.Show();
            }
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
