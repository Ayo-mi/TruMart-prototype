using TruMart.Util;
using Guna.Charts.WinForms;
using LiveCharts;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Defaults;
using Guna.UI2.WinForms;
using TruMart.Sell;
using TruMart.Cards;
using TruMart.Reports;
using TruMart.Settings;

namespace TruMart
{
    public partial class Main : Form
    {
        private Form currentChildForm;
        private Functions fxn;

        protected ChartValues<ObservableValue> Values { get; set; }
        public Main()
        {
            InitializeComponent();
            fxn = new Functions();
            Values = new ChartValues<ObservableValue>
            {
                new ObservableValue(58900),
                new ObservableValue(39000),
                new ObservableValue(78900),
                new ObservableValue(122900),
                new ObservableValue(158900),
                new ObservableValue(0),
            };
            
        }
        public void OpenChildForm(Form childForm)
        {
            if (childForm != null)
            {
                currentChildForm = childForm;
                currentChildForm.FormBorderStyle = FormBorderStyle.None;
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.TopLevel = false;
                desktopPanel.Controls.Clear();
                desktopPanel.Controls.Add(currentChildForm);
                //desktopPanel.Controls.Add(titlePanel);
                currentChildForm.Visible = true;
                currentChildForm.BringToFront();                
            }
        }

        public MySqlDataReader User
        {
            get; set;
        }

        public String Title
        {
            set { pageTitle.Text = value; }
        }

        private int CountRecord(string table, string whereClause="")
        {
            int count = 0;

            String stmt = String.Format("SELECT COUNT(*) as count from {0} {1};", table, whereClause);

            Hashtable attr = new Hashtable();
            Database dB = new Database();
            MySqlDataReader data = dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    count = data.GetInt32(0);                    
                }
            }

            return count;
        }

        private void PrepareChart()
        {
            LPoint lPoint1 = new LPoint();
            LPoint lPoint2 = new LPoint();
            LPoint lPoint3 = new LPoint();
            LPoint lPoint4 = new LPoint();
            LPoint lPoint5 = new LPoint();
            LPoint lPoint6 = new LPoint();
            LPoint lPoint7 = new LPoint();
            LPoint lPoint8 = new LPoint();
            LPoint lPoint9 = new LPoint();
            LPoint lPoint10 = new LPoint();
            LPoint lPoint11 = new LPoint();
            LPoint lPoint12 = new LPoint();

            lPoint1.Label = "Jan";
            lPoint2.Label = "Feb";
            lPoint3.Label = "Mar";
            lPoint4.Label = "Apr";
            lPoint5.Label = "May";
            lPoint6.Label = "Jun";
            lPoint7.Label = "Jul";
            lPoint8.Label = "Aug";
            lPoint9.Label = "Sep";
            lPoint10.Label = "Oct";
            lPoint11.Label = "Nov";
            lPoint12.Label = "Dec";

            lPoint1.Y = Convert.ToDouble(65678);
            lPoint2.Y = Convert.ToDouble(259544);
            lPoint3.Y = Convert.ToDouble(133212);
            lPoint4.Y = Convert.ToDouble(43532);
            lPoint5.Y = Convert.ToDouble(165464);
            lPoint6.Y = Convert.ToDouble(14330);
            lPoint7.Y = Convert.ToDouble(4330);
            lPoint8.Y = Convert.ToDouble(84330);
            lPoint9.Y = Convert.ToDouble(34330);
            lPoint10.Y = Convert.ToDouble(104330);
            lPoint11.Y = Convert.ToDouble(64330);
            lPoint11.Y = Convert.ToDouble(4330);

            gunaLineDataset1.DataPoints.Clear();
            gunaLineDataset1.DataPoints.AddRange(new LPoint[] {
                    lPoint1,
                    lPoint2,
                    lPoint3,
                    lPoint4,
                    lPoint5,
                    lPoint6,
                    lPoint7,
                    lPoint8,
                    lPoint9,
                    lPoint10,
                    lPoint11,
                    lPoint12
                });
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width <= 1013)
                guna2GradientPanel2.Visible = false;
            else
                guna2GradientPanel2.Visible = true;
            //int formWidth = this.Size.Width;
            //int formHeight = this.Size.Height;
            //int h = cardsSummPanel.Size.Height;
            //int p = panel1.Size.Height;
            //cardsSummPanel.Size = new Size(formWidth - 221, h);
            //panel3.Size = new Size(781, 292);
            //panel1.Size = new Size(formWidth - 521, p);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!statistics.IsBusy)
                statistics.RunWorkerAsync();
            this.Visible = false;
            new Functions().openDialogOverlay(new Login(this));
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            new Functions(this).openChildDialogOverlay(new Login(this));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!statistics.IsBusy)
                statistics.RunWorkerAsync();
            desktopPanel.Controls.Clear();
            desktopPanel.Controls.Add(scrollablePanel);
            desktopPanel.Controls.Add(titlePanel);
            pageTitle.Text = "Report Summary";
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            //user_names.Text = User["first_name"].ToString()+" "+User["last_name"].ToString();
            //dp.Image = fxn.BinaryToImage(User["pic"]);
        }

        private void statistics_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                //tUsers.Text = CountRecord("employees").ToString();
                //tAssets.Text = CountRecord("assets").ToString();
                //unUsers.Text = CountRecord("employees", "where asset_id is null").ToString();
                PrepareChart();
            }));
        }

        private void guna2ShadowPanel8_MouseEnter(object sender, EventArgs e)
        {
            guna2ShadowPanel8.FillColor = Color.WhiteSmoke;
        }

        private void guna2ShadowPanel8_MouseLeave(object sender, EventArgs e)
        {
            guna2ShadowPanel8.FillColor = Color.White;
        }

        private void guna2ShadowPanel2_MouseEnter(object sender, EventArgs e)
        {
            ((Guna2ShadowPanel)sender).FillColor = Color.WhiteSmoke;
        }

        private void guna2ShadowPanel2_MouseLeave(object sender, EventArgs e)
        {
            ((Guna2ShadowPanel)sender).FillColor = Color.White;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new POS(this));
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            if (!desktopPanel.Controls.Contains(scrollablePanel))
            {
                desktopPanel.Controls.Clear();
                desktopPanel.Controls.Add(scrollablePanel);
                Title = "Dashboard";
            }            
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesHistory(this));
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Card(this));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesReport(this));
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CardsReport(this));
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Outlets(this));
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Roles(this));
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users(this));
        }

        private void label41_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.WhiteSmoke;
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            guna2ShadowPanel3.FillColor = Color.WhiteSmoke;
        }

        private void label20_MouseLeave(object sender, EventArgs e)
        {
            guna2ShadowPanel3.FillColor = Color.White;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            guna2ShadowPanel1.FillColor = Color.WhiteSmoke;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            guna2ShadowPanel1.FillColor = Color.White;
        }

        private void label33_MouseEnter(object sender, EventArgs e)
        {
            guna2ShadowPanel6.FillColor = Color.WhiteSmoke;
        }

        private void label33_MouseLeave(object sender, EventArgs e)
        {
            guna2ShadowPanel6.FillColor = Color.White;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            guna2ShadowPanel2.FillColor = Color.WhiteSmoke;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            guna2ShadowPanel2.FillColor = Color.White;
        }

        private void label41_MouseEnter_1(object sender, EventArgs e)
        {
            guna2ShadowPanel8.FillColor = Color.WhiteSmoke;
        }

        private void label41_MouseLeave(object sender, EventArgs e)
        {
            guna2ShadowPanel8.FillColor = Color.White;
        }
    }
}
