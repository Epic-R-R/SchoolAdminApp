using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace animated_rain_loading
{
    public partial class MainForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panelSideMenu.Controls.Add(leftBorderBtn);

            //Form 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtom();
                //Buttom
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border buttom
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButtom()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            if (currentChildForm != null)
            {
                var control = panelDesktop.Controls.Find(currentChildForm.Name, true);
                if (control.Count() > 0)
                    panelDesktop.Controls.Remove(control[0]);
            }
            OpenChildForm(new FormDashboard());
        }
        
        private void btnStudents_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormStudents());
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormTeachers());
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormClass());
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormTime());
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormSMS());
        }

        private void BtnAttendance_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormAttendance());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormSettings());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButtom();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTitleChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.labelTime.Text = datetime.ToLongTimeString();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}