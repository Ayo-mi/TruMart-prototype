using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruMart.Settings
{
    public partial class Outlets : Form
    {
        private Main main;
        public Outlets(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.main.Title = "Outlets";
        }

        private void Outlets_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add("Main Outlet", "8", "18th Apr 2023, 08:23am");
            guna2DataGridView1.Rows.Add("AXL Outlet", "3", "18th Apr 2023, 08:33am");

        }
    }
}
