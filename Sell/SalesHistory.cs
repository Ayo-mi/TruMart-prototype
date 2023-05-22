using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruMart.Sell.Util;

namespace TruMart.Sell
{
    public partial class SalesHistory : Form
    {
        private Main main;

        public FlowLayoutPanel TablePanel { get { return tableFlowPanel; } }
        public SalesHistory(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.main.Title = "Sales History";
        }
       
        private void tableFlowPanel_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < ((FlowLayoutPanel)sender).Controls.Count; i++)
                ((FlowLayoutPanel)sender).Controls[i].Size = new Size(((FlowLayoutPanel)sender).Size.Width, ((FlowLayoutPanel)sender).Controls[i].Size.Height);
        }

        private void SalesHistory_Shown(object sender, EventArgs e)
        {
            new Row(this);            
            new Row(this);
            new Row(this);
            saleCount.Text = $"Showing {tableFlowPanel.Controls.Count - 1} sale";
        }
    }
}
