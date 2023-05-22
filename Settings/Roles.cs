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
    public partial class Roles : Form
    {
        private Main main;
        public Roles(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.main.Title = "Roles";
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add("Admin", "18th Apr 2023, 08:23am");
            guna2DataGridView1.Rows.Add("Manager", "18th Apr 2023, 08:33am");
            guna2DataGridView1.Rows.Add("Cashier", "18th Apr 2023, 08:43am");
        }
    }
}
