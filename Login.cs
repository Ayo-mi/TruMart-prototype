using TruMart.Util;
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

namespace TruMart
{
    public partial class Login : Form
    {
        private Main m;
        private Functions fxn;
        public Login(Main m)
        {
            InitializeComponent();
            this.m = m;
            Size screenSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(screenSize.Width / 2 - Width / 2, screenSize.Height / 2 - Height / 2);
            fxn = new Functions();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            m.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrEmpty(user_id.Text) || string.IsNullOrEmpty(psw.Text))
            //{
            //    fxn.ErrorPrompt(this, "Enter username and password", "Sign-in");
            //    return;
            //}

            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync();
            //}

            psw.Text = "";
            m.Visible = true;
            this.Close();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String stmt = "SELECT username, first_name, last_name, pic from users where username = @us and password = @pw limit 1";
            Hashtable attr = new Hashtable
            {
                { "@us", user_id.Text },
                { "@pw", psw.Text }
            };
            Database dB = new Database();
            MySqlDataReader data = dB.Select(stmt, attr);
            if(data != null)
            {
                if (data.Read())
                {
                    e.Result = true;
                    m.User = data;
                }
                else
                {
                    e.Result = false;
                }
            }            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                psw.Text = "";
                m.Visible = true;
                this.Close();
            }
            else
            {
                fxn.ErrorPrompt(this, "Incorrect username or password", "Sign-in");
                return;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (m.User == null)
            //{
            //    m.Close();
            //}
        }
    }
}
