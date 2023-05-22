
namespace TruMart
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.user_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.psw = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            // 
            // user_id
            // 
            this.user_id.Animated = true;
            this.user_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.user_id.BorderRadius = 15;
            this.user_id.BorderThickness = 2;
            this.user_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_id.DefaultText = "";
            this.user_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.user_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.user_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_id.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.user_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_id.Location = new System.Drawing.Point(120, 112);
            this.user_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_id.Name = "user_id";
            this.user_id.PasswordChar = '\0';
            this.user_id.PlaceholderText = "Enter your username";
            this.user_id.SelectedText = "";
            this.user_id.Size = new System.Drawing.Size(437, 44);
            this.user_id.TabIndex = 12;
            // 
            // psw
            // 
            this.psw.Animated = true;
            this.psw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.psw.BorderRadius = 15;
            this.psw.BorderThickness = 2;
            this.psw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.psw.DefaultText = "";
            this.psw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.psw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.psw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.psw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.psw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.psw.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.psw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.psw.Location = new System.Drawing.Point(120, 190);
            this.psw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.psw.Name = "psw";
            this.psw.PasswordChar = '●';
            this.psw.PlaceholderText = "Enter your password";
            this.psw.SelectedText = "";
            this.psw.Size = new System.Drawing.Size(437, 44);
            this.psw.TabIndex = 13;
            this.psw.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(237, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(172, 47);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "<b>Welcome Back</b> <br>Sign-in to continue";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button6
            // 
            this.guna2Button6.Animated = true;
            this.guna2Button6.AnimatedGIF = true;
            this.guna2Button6.BorderRadius = 20;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.guna2Button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.guna2Button6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.guna2Button6.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.Image = global::TruMart.Properties.Resources.enter_50px;
            this.guna2Button6.Image = global::TruMart.Properties.Resources.enter_50px_g;
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button6.Location = new System.Drawing.Point(169, 281);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.PressedDepth = 10;
            this.guna2Button6.Size = new System.Drawing.Size(146, 45);
            this.guna2Button6.TabIndex = 10;
            this.guna2Button6.Text = "Sign-in";
            this.guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.TextOffset = new System.Drawing.Point(25, 0);
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button9
            // 
            this.guna2Button9.Animated = true;
            this.guna2Button9.AnimatedGIF = true;
            this.guna2Button9.BorderRadius = 20;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.guna2Button9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button9.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button9.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button9.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button9.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.HoverState.Image = global::TruMart.Properties.Resources.shutdown_50px_w;
            this.guna2Button9.Image = global::TruMart.Properties.Resources.shutdown_50px;
            this.guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button9.Location = new System.Drawing.Point(340, 281);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.PressedDepth = 10;
            this.guna2Button9.Size = new System.Drawing.Size(126, 45);
            this.guna2Button9.TabIndex = 11;
            this.guna2Button9.Text = "Quit";
            this.guna2Button9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.TextOffset = new System.Drawing.Point(25, 0);
            this.guna2Button9.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 377);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.psw);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.guna2Button9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(641, 377);
            this.MinimumSize = new System.Drawing.Size(641, 377);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login - Barcode Security System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2TextBox psw;
        private Guna.UI2.WinForms.Guna2TextBox user_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}