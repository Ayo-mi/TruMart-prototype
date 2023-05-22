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
    public partial class CardsReport : Form
    {
        private Main main;
        public CardsReport(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.main.Title = "Cards Report";
        }

        private void CardsReport_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add("5841 4523 6985 7742", "₦430,005.00", "₦254,000.00", "₦176,005.00");
            guna2DataGridView1.Rows.Add("5841 4523 6985 0742", "₦430,005.00", "₦254,000.00", "₦176,005.00");
            guna2DataGridView1.Rows.Add("5841 4523 3985 7742", "₦430,005.00", "₦254,000.00", "₦176,005.00");
        }
    }
}
