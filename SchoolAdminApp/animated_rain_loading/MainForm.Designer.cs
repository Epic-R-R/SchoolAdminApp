namespace animated_rain_loading
{
    partial class MainForm
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnAttendance = new FontAwesome.Sharp.IconButton();
            this.btnSMS = new FontAwesome.Sharp.IconButton();
            this.btnTime = new FontAwesome.Sharp.IconButton();
            this.btnClass = new FontAwesome.Sharp.IconButton();
            this.btnTeachers = new FontAwesome.Sharp.IconButton();
            this.btnStudents = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelSideMenu.Controls.Add(this.btnSetting);
            this.panelSideMenu.Controls.Add(this.btnAttendance);
            this.panelSideMenu.Controls.Add(this.btnSMS);
            this.panelSideMenu.Controls.Add(this.btnTime);
            this.panelSideMenu.Controls.Add(this.btnClass);
            this.panelSideMenu.Controls.Add(this.btnTeachers);
            this.panelSideMenu.Controls.Add(this.btnStudents);
            this.panelSideMenu.Controls.Add(this.btnDashboard);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(164, 532);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 358);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(164, 40);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "Settings";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAttendance.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnAttendance.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAttendance.IconSize = 32;
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(0, 318);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAttendance.Size = new System.Drawing.Size(164, 40);
            this.btnAttendance.TabIndex = 6;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.BtnAttendance_Click);
            // 
            // btnSMS
            // 
            this.btnSMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMS.FlatAppearance.BorderSize = 0;
            this.btnSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMS.IconChar = FontAwesome.Sharp.IconChar.Sms;
            this.btnSMS.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSMS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSMS.IconSize = 32;
            this.btnSMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMS.Location = new System.Drawing.Point(0, 278);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSMS.Size = new System.Drawing.Size(164, 40);
            this.btnSMS.TabIndex = 5;
            this.btnSMS.Text = "SMS";
            this.btnSMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMS.UseVisualStyleBackColor = true;
            this.btnSMS.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // btnTime
            // 
            this.btnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTime.FlatAppearance.BorderSize = 0;
            this.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTime.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnTime.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTime.IconSize = 32;
            this.btnTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTime.Location = new System.Drawing.Point(0, 238);
            this.btnTime.Name = "btnTime";
            this.btnTime.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTime.Size = new System.Drawing.Size(164, 40);
            this.btnTime.TabIndex = 4;
            this.btnTime.Text = "Time";
            this.btnTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnClass
            // 
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClass.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnClass.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClass.IconSize = 32;
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(0, 198);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClass.Size = new System.Drawing.Size(164, 40);
            this.btnClass.TabIndex = 3;
            this.btnClass.Text = "Class";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTeachers.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnTeachers.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTeachers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeachers.IconSize = 32;
            this.btnTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.Location = new System.Drawing.Point(0, 158);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTeachers.Size = new System.Drawing.Size(164, 40);
            this.btnTeachers.TabIndex = 2;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnStudents.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudents.IconSize = 32;
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(0, 118);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStudents.Size = new System.Drawing.Size(164, 40);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 78);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(164, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(164, 78);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::animated_rain_loading.Properties.Resources.Logo;
            this.btnHome.Location = new System.Drawing.Point(21, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 60);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(164, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(890, 50);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.DimGray;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(852, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(40, 22);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(164, 50);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(890, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.labelDate);
            this.panelDesktop.Controls.Add(this.labelTime);
            this.panelDesktop.Controls.Add(this.picLogo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(164, 59);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(890, 473);
            this.panelDesktop.TabIndex = 3;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.labelDate.Location = new System.Drawing.Point(293, 274);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(72, 31);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.labelTime.Location = new System.Drawing.Point(293, 234);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(74, 31);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = global::animated_rain_loading.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(296, 59);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(269, 167);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 532);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnSMS;
        private FontAwesome.Sharp.IconButton btnTime;
        private FontAwesome.Sharp.IconButton btnClass;
        private FontAwesome.Sharp.IconButton btnTeachers;
        private FontAwesome.Sharp.IconButton btnStudents;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}