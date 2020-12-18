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
    public partial class Medecine : Form
    {
        public Medecine()
        {
            InitializeComponent();
        }

        private void Medecine_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
