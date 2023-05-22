using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruMart.Util
{
    class Functions
    {
        private Form currentChildDialog;
        private Main m;
        private Guna.UI2.WinForms.Guna2MessageDialog prompt;

        public Functions(Main m)
        {
            this.m = m;
        }
        public Functions()
        {
            prompt = new Guna.UI2.WinForms.Guna2MessageDialog();
        }
        public void openDialogOverlay(Form form)
        {
            overlayBg formBackground = new overlayBg();
            try
            {

                formBackground.Show();
                form.Owner = formBackground;
                openChildDialog(form);

                formBackground.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        public void openChildDialogOverlay(Form form)
        {
            overlayBg formBackground = new overlayBg(m);
            try
            {

                formBackground.Show();
                form.Owner = formBackground;
                openChildDialog(form);

                formBackground.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        public void openChildDialog(Form childForm)
        {
            if (currentChildDialog != null)
            {
                currentChildDialog.Close();
            }
            currentChildDialog = childForm;
            childForm.ShowDialog();
        }

        public void ErrorPrompt(Form parent, string msg, string caption)
        {
            prompt.Parent = parent;
            prompt.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            prompt.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            prompt.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            prompt.Caption = caption;
            prompt.Text = msg;
            prompt.Show();
        }

        public void InfoPrompt(Form parent, string msg, string caption)
        {
            prompt.Parent = parent;
            prompt.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            prompt.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            prompt.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            prompt.Caption = caption;
            prompt.Text = msg;
            prompt.Show();
        }

        public void WarningPrompt(Form parent, string msg, string caption)
        {
            prompt.Parent = parent;
            prompt.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            prompt.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            prompt.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            prompt.Caption = caption;
            prompt.Text = msg;
            prompt.Show();
        }

        public void QuestionPrompt(Form parent, string msg, string caption)
        {
            prompt.Parent = parent;
            prompt.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            prompt.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            prompt.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            prompt.Caption = caption;
            prompt.Text = msg;
            prompt.Show();
        }

        public void ChooseImg(ref string imgLoc, ref Guna.UI2.WinForms.Guna2CirclePictureBox dp)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg;*.png;*.jpeg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = openFileDialog1.FileName;
                    dp.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public byte[] ImageToBinary(string img)
        {
            if (string.IsNullOrEmpty(img))
            {
                ErrorPrompt(null, "No Image specified", "Image");
                return null;
            }
            byte[] imageData;
            FileStream fs = new FileStream(img, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)fs.Length);
            
            br.Close();
            fs.Close();
            
            return imageData;
        }

        public Image BinaryToImage(Object binImg)
        {
            Image img = null;
            if (binImg != DBNull.Value)
            {
                byte[] byteImage = (byte[])binImg;
                using (MemoryStream ms = new MemoryStream(byteImage))
                {
                    //saving to jpg image
                    img = new Bitmap(ms);                    
                }
                
            }
            return img;
        }

        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        
        public string RandomNumbers(int len)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for(int i =0; i<len; i++)
            {
                sb.Append(random.Next(10).ToString());
            }

            return sb.ToString();
        }
    }
}
