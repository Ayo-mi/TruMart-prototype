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
    public partial class Users : Form
    {
        private Main main;
        public Users(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.main.Title = "Users;";
        }

        private void Users_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add("John Doe", "Manager", "All Outlets", "28th Apr 2023, 08:23pm", "Yes");
            guna2DataGridView1.Rows.Add("Jane Doe", "Cashier", "AXL Outlet", "19th Apr 2023, 08:23pm", "Yes");
            guna2DataGridView1.Rows.Add("Jack Doe", "Cashier", "Main Outlet", "29th Apr 2023, 08:23pm", "Yes");
            guna2DataGridView1.Rows.Add("Willie Doe", "Manager", "Main Outlet", "29th Apr 2023, 08:23pm", "Yes");


        }
    }
}
