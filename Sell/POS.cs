using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruMart.Sell
{
    public partial class POS : Form
    {
        private Main main;
        public POS(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.main.Title = "Point of Sale";
        }
    }
}
