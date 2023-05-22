using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruMart.Reports
{
    public partial class SalesReport : Form
    {
        private Main main;
        public SalesReport(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.main.Title = "Sales Report";
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add("₦430,005.00", "₦254,000.00", "₦176,005.00", "78%");
        }
    }
}
