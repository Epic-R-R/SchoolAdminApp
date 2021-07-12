using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace animated_rain_loading
{
    public partial class LoginForm : Form
    {
        public const int WindowsLeftClickMessage = 0xA1;

        public const int AdditionalInformation = 0x2;

        public LoginForm()
        {
            InitializeComponent();
            textUsername.Enter += TxtUserName_Enter;
            textPassword.Enter += TxtPassword_Enter;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if(textUsername.Text == "sullivan" && textPassword.Text == "112233!@#")
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username Or Password is incorrect, Try again");
                textUsername.Clear();
                textPassword.Clear();
                textUsername.Focus();
            }
        }

        /// <summary>
        /// با استفاده از این متد میتوانیم کلید میانبر تعریف کنیم 
        /// </summary>
        /// <param name="msg">آدرس پیامی که به ویندوز ارسال میشود</param>
        /// <param name="keyData">اطلاعاتی که فرستاده میشود</param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    BtnSignIn_Click(null, null);
                    break;

                case Keys.Escape:
                    Dispose(true);
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                textPassword.Text = "Password";
                textPassword.UseSystemPasswordChar = true;
                textPassword.ForeColor = SystemColors.InactiveCaption;
            }
            if (textUsername.Text == "Username")
                textUsername.Text = "";

            textUsername.ForeColor = Color.FromArgb(0, 228, 225);
            textUsername.SelectAll();
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text))
            {
                textUsername.Text = "Username";
                textUsername.ForeColor = SystemColors.InactiveCaption;
            }
            else
            {
                textUsername.ForeColor = Color.FromArgb(0, 228, 225);
            }
            if (textPassword.Text == "Password")
                textPassword.Text = "";

            textPassword.ForeColor = Color.FromArgb(0, 228, 225);
            textPassword.UseSystemPasswordChar = false;
            textPassword.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WindowsLeftClickMessage, AdditionalInformation, 0);
        }
    }
}