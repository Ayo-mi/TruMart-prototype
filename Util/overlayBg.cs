using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruMart.Util
{
    public partial class overlayBg : Form
    {
        private Main m;
        public overlayBg()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }
        public overlayBg(Main m)
        {
            InitializeComponent();
            this.m = m;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            adjust();
        }

        private void adjust()
        {
            int w = m.Size.Width-15;
            int h = m.Size.Height-9;
            int x = m.Location.X+7;
            int y = m.Location.Y+1;
            this.Location = new Point(x, y);
            this.Size = new Size(w, h);
        }
    }
}
