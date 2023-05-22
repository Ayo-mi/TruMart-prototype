using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruMart.Cards.Util;

namespace TruMart.Cards
{
    public partial class Card : Form
    {
        public FlowLayoutPanel TablePanel { get { return tableFlowPanel; } }

        private Main main;
        public Card(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.main.Title = "Cards";
        }

        private void tableFlowPanel_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < ((FlowLayoutPanel)sender).Controls.Count; i++)
                ((FlowLayoutPanel)sender).Controls[i].Size = new Size(((FlowLayoutPanel)sender).Size.Width, ((FlowLayoutPanel)sender).Controls[i].Size.Height);
        }

        private void Card_Shown(object sender, EventArgs e)
        {
            new CardRow(this);
            new CardRow(this);
            new CardRow(this);
            saleCount.Text = $"Showing {tableFlowPanel.Controls.Count - 1} record";
        }
    }
}
