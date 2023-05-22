using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruMart.Sell.Util
{
    public partial class Row : Form
    {
        
        public Guna2Panel RowContainer { get; private set; }

        private const int ANIMATION_DURATION = 500;
        private bool isExpanded = false;
        private SalesHistory history;

        private void AnimatePanel(Guna2Panel panel, int startHeight, int endHeight)
        {
            int animationStart = Environment.TickCount;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (sender, args) =>
            {
                int elapsed = Environment.TickCount - animationStart;
                float progress = (float)elapsed / ANIMATION_DURATION;
                if (progress > 1)
                    progress = 1;
                int newheight = (int)(startHeight + (endHeight - startHeight) * progress);
                panel.Size = new Size(rowContainer.Size.Width, newheight);

                if (progress == 1)
                    timer.Stop();
            };
            timer.Start();
        }

        public Row(SalesHistory history)
        {
            InitializeComponent();            
            detailsContainer.AutoScroll = false;
            this.history = history;
            rowContainer.Size = new Size(this.history.TablePanel.Size.Width, 65);
            this.history.TablePanel.Controls.Add(rowContainer);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                AnimatePanel(rowContainer, 378, 65);                
                guna2PictureBox1.Image = Properties.Resources.forward_120px;
                isExpanded = false;
                leftPanel.Visible = false;
            }
            else
            {
                leftPanel.Visible = true;
                AnimatePanel(rowContainer, 65, 378);
                guna2PictureBox1.Image = Properties.Resources.expand_arrow_120px;
                isExpanded = true;
            }
        }

        private void guna2PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            guna2PictureBox1.BackColor = Color.LightGray;
            guna2Panel21.BackColor = Color.LightGray;
            guna2Panel21.BorderColor = Color.LightGray;
        }

        private void guna2Panel21_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox1.BackColor = SystemColors.Control;
            guna2Panel21.BackColor = SystemColors.Control;
            guna2Panel21.BorderColor = SystemColors.Control;
        }
    }
}
