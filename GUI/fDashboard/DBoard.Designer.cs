﻿
namespace GUI.fDashboard
{
    partial class DBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_time = new System.Windows.Forms.Label();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.fDashboard_DBoard_btn_AboutUs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fDashboard_DBoard_btn_Setting = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fDashboard_DBoard_btn_Gmail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fDashboard_DBoard_btn_Study = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fDashboard_DBoard_btn_Scholarship = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fDashboard_DBoard_btn_Dashboard = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_Dashboard1 = new GUI.UC.UC_Dashboard();
            this.uC_AboutUs1 = new GUI.UC.UC_AboutUs();
            this.uC_Setting1 = new GUI.UC.UC_Setting();
            this.uC_Scholarship1 = new GUI.UC.UC_Scholarship();
            this.uC_Study_Main1 = new GUI.UC.UC_Study_Main();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Gmail1 = new GUI.UC.UC_Gmail();
            this.BorderlessF_DBoard = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txt_C = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_location = new System.Windows.Forms.PictureBox();
            this.lab_location = new System.Windows.Forms.Label();
            this.lab_breadcrumb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_location)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.lab_time);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.fDashboard_DBoard_btn_AboutUs);
            this.panel1.Controls.Add(this.fDashboard_DBoard_btn_Setting);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2GradientButton5);
            this.panel1.Controls.Add(this.fDashboard_DBoard_btn_Gmail);
            this.panel1.Controls.Add(this.fDashboard_DBoard_btn_Study);
            this.panel1.Controls.Add(this.fDashboard_DBoard_btn_Scholarship);
            this.panel1.Controls.Add(this.fDashboard_DBoard_btn_Dashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 810);
            this.panel1.TabIndex = 0;
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_time.ForeColor = System.Drawing.Color.White;
            this.lab_time.Location = new System.Drawing.Point(61, 778);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(176, 21);
            this.lab_time.TabIndex = 11;
            this.lab_time.Text = "11/27/2021 9:11:26 PM";
            // 
            // btn_logout
            // 
            this.btn_logout.BorderRadius = 4;
            this.btn_logout.CheckedState.Parent = this.btn_logout;
            this.btn_logout.CustomImages.Parent = this.btn_logout;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.DisabledState.Parent = this.btn_logout;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.HoverState.Parent = this.btn_logout;
            this.btn_logout.Image = global::GUI.Properties.Resources.logout;
            this.btn_logout.ImageOffset = new System.Drawing.Point(0, 2);
            this.btn_logout.Location = new System.Drawing.Point(89, 716);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShadowDecoration.Parent = this.btn_logout;
            this.btn_logout.Size = new System.Drawing.Size(121, 45);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Log out";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // fDashboard_DBoard_btn_AboutUs
            // 
            this.fDashboard_DBoard_btn_AboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_AboutUs.BorderRadius = 20;
            this.fDashboard_DBoard_btn_AboutUs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.fDashboard_DBoard_btn_AboutUs.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.fDashboard_DBoard_btn_AboutUs.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.fDashboard_DBoard_btn_AboutUs.CheckedState.Image = global::GUI.Properties.Resources.about_us__1_;
            this.fDashboard_DBoard_btn_AboutUs.CheckedState.Parent = this.fDashboard_DBoard_btn_AboutUs;
            this.fDashboard_DBoard_btn_AboutUs.CustomImages.Parent = this.fDashboard_DBoard_btn_AboutUs;
            this.fDashboard_DBoard_btn_AboutUs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_AboutUs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_AboutUs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_AboutUs.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_AboutUs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fDashboard_DBoard_btn_AboutUs.DisabledState.Parent = this.fDashboard_DBoard_btn_AboutUs;
            this.fDashboard_DBoard_btn_AboutUs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_AboutUs.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_AboutUs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDashboard_DBoard_btn_AboutUs.ForeColor = System.Drawing.Color.White;
            this.fDashboard_DBoard_btn_AboutUs.HoverState.Parent = this.fDashboard_DBoard_btn_AboutUs;
            this.fDashboard_DBoard_btn_AboutUs.Image = global::GUI.Properties.Resources.about_us;
            this.fDashboard_DBoard_btn_AboutUs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_AboutUs.ImageOffset = new System.Drawing.Point(16, 0);
            this.fDashboard_DBoard_btn_AboutUs.ImageSize = new System.Drawing.Size(24, 24);
            this.fDashboard_DBoard_btn_AboutUs.Location = new System.Drawing.Point(16, 612);
            this.fDashboard_DBoard_btn_AboutUs.Name = "fDashboard_DBoard_btn_AboutUs";
            this.fDashboard_DBoard_btn_AboutUs.ShadowDecoration.Parent = this.fDashboard_DBoard_btn_AboutUs;
            this.fDashboard_DBoard_btn_AboutUs.Size = new System.Drawing.Size(259, 59);
            this.fDashboard_DBoard_btn_AboutUs.TabIndex = 9;
            this.fDashboard_DBoard_btn_AboutUs.Text = "About Us";
            this.fDashboard_DBoard_btn_AboutUs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_AboutUs.TextOffset = new System.Drawing.Point(24, 0);
            this.fDashboard_DBoard_btn_AboutUs.CheckedChanged += new System.EventHandler(this.fDashboard_DBoard_btn_AboutUs_CheckedChanged);
            this.fDashboard_DBoard_btn_AboutUs.Click += new System.EventHandler(this.guna2GradientButton7_Click);
            // 
            // fDashboard_DBoard_btn_Setting
            // 
            this.fDashboard_DBoard_btn_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Setting.BorderRadius = 20;
            this.fDashboard_DBoard_btn_Setting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.fDashboard_DBoard_btn_Setting.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.fDashboard_DBoard_btn_Setting.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.fDashboard_DBoard_btn_Setting.CheckedState.Image = global::GUI.Properties.Resources.gear__1_;
            this.fDashboard_DBoard_btn_Setting.CheckedState.Parent = this.fDashboard_DBoard_btn_Setting;
            this.fDashboard_DBoard_btn_Setting.CustomImages.Parent = this.fDashboard_DBoard_btn_Setting;
            this.fDashboard_DBoard_btn_Setting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Setting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Setting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Setting.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Setting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fDashboard_DBoard_btn_Setting.DisabledState.Parent = this.fDashboard_DBoard_btn_Setting;
            this.fDashboard_DBoard_btn_Setting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Setting.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Setting.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDashboard_DBoard_btn_Setting.ForeColor = System.Drawing.Color.White;
            this.fDashboard_DBoard_btn_Setting.HoverState.Parent = this.fDashboard_DBoard_btn_Setting;
            this.fDashboard_DBoard_btn_Setting.Image = global::GUI.Properties.Resources.gear;
            this.fDashboard_DBoard_btn_Setting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Setting.ImageOffset = new System.Drawing.Point(16, 0);
            this.fDashboard_DBoard_btn_Setting.ImageSize = new System.Drawing.Size(24, 24);
            this.fDashboard_DBoard_btn_Setting.Location = new System.Drawing.Point(16, 547);
            this.fDashboard_DBoard_btn_Setting.Name = "fDashboard_DBoard_btn_Setting";
            this.fDashboard_DBoard_btn_Setting.ShadowDecoration.Parent = this.fDashboard_DBoard_btn_Setting;
            this.fDashboard_DBoard_btn_Setting.Size = new System.Drawing.Size(259, 59);
            this.fDashboard_DBoard_btn_Setting.TabIndex = 8;
            this.fDashboard_DBoard_btn_Setting.Text = "Setting";
            this.fDashboard_DBoard_btn_Setting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Setting.TextOffset = new System.Drawing.Point(24, 0);
            this.fDashboard_DBoard_btn_Setting.CheckedChanged += new System.EventHandler(this.fDashboard_DBoard_btn_Setting_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(167)))));
            this.label3.Location = new System.Drawing.Point(33, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Other";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(167)))));
            this.label2.Location = new System.Drawing.Point(33, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tools";
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton5.BorderRadius = 20;
            this.guna2GradientButton5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2GradientButton5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.guna2GradientButton5.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.guna2GradientButton5.CheckedState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.CustomImages.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton5.DisabledState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.HoverState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Location = new System.Drawing.Point(16, 428);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.ShadowDecoration.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Size = new System.Drawing.Size(259, 59);
            this.guna2GradientButton5.TabIndex = 5;
            this.guna2GradientButton5.Text = "guna2GradientButton5";
            // 
            // fDashboard_DBoard_btn_Gmail
            // 
            this.fDashboard_DBoard_btn_Gmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Gmail.BorderRadius = 20;
            this.fDashboard_DBoard_btn_Gmail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.fDashboard_DBoard_btn_Gmail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.fDashboard_DBoard_btn_Gmail.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.fDashboard_DBoard_btn_Gmail.CheckedState.Image = global::GUI.Properties.Resources.gmail_logo__1_;
            this.fDashboard_DBoard_btn_Gmail.CheckedState.Parent = this.fDashboard_DBoard_btn_Gmail;
            this.fDashboard_DBoard_btn_Gmail.CustomImages.Parent = this.fDashboard_DBoard_btn_Gmail;
            this.fDashboard_DBoard_btn_Gmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Gmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Gmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Gmail.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Gmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fDashboard_DBoard_btn_Gmail.DisabledState.Parent = this.fDashboard_DBoard_btn_Gmail;
            this.fDashboard_DBoard_btn_Gmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Gmail.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Gmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDashboard_DBoard_btn_Gmail.ForeColor = System.Drawing.Color.White;
            this.fDashboard_DBoard_btn_Gmail.HoverState.Parent = this.fDashboard_DBoard_btn_Gmail;
            this.fDashboard_DBoard_btn_Gmail.Image = global::GUI.Properties.Resources.gmail_logo;
            this.fDashboard_DBoard_btn_Gmail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Gmail.ImageOffset = new System.Drawing.Point(16, 0);
            this.fDashboard_DBoard_btn_Gmail.ImageSize = new System.Drawing.Size(24, 24);
            this.fDashboard_DBoard_btn_Gmail.Location = new System.Drawing.Point(16, 363);
            this.fDashboard_DBoard_btn_Gmail.Name = "fDashboard_DBoard_btn_Gmail";
            this.fDashboard_DBoard_btn_Gmail.ShadowDecoration.Parent = this.fDashboard_DBoard_btn_Gmail;
            this.fDashboard_DBoard_btn_Gmail.Size = new System.Drawing.Size(259, 59);
            this.fDashboard_DBoard_btn_Gmail.TabIndex = 4;
            this.fDashboard_DBoard_btn_Gmail.Text = "Viết mail";
            this.fDashboard_DBoard_btn_Gmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Gmail.TextOffset = new System.Drawing.Point(24, 0);
            this.fDashboard_DBoard_btn_Gmail.CheckedChanged += new System.EventHandler(this.fDashboard_DBoard_btn_Gmail_CheckedChanged);
            // 
            // fDashboard_DBoard_btn_Study
            // 
            this.fDashboard_DBoard_btn_Study.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Study.BorderRadius = 20;
            this.fDashboard_DBoard_btn_Study.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.fDashboard_DBoard_btn_Study.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.fDashboard_DBoard_btn_Study.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.fDashboard_DBoard_btn_Study.CheckedState.Image = global::GUI.Properties.Resources.scores__1_;
            this.fDashboard_DBoard_btn_Study.CheckedState.Parent = this.fDashboard_DBoard_btn_Study;
            this.fDashboard_DBoard_btn_Study.CustomImages.Parent = this.fDashboard_DBoard_btn_Study;
            this.fDashboard_DBoard_btn_Study.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Study.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Study.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Study.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Study.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fDashboard_DBoard_btn_Study.DisabledState.Parent = this.fDashboard_DBoard_btn_Study;
            this.fDashboard_DBoard_btn_Study.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Study.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Study.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDashboard_DBoard_btn_Study.ForeColor = System.Drawing.Color.White;
            this.fDashboard_DBoard_btn_Study.HoverState.Parent = this.fDashboard_DBoard_btn_Study;
            this.fDashboard_DBoard_btn_Study.Image = global::GUI.Properties.Resources.scores;
            this.fDashboard_DBoard_btn_Study.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Study.ImageOffset = new System.Drawing.Point(16, 0);
            this.fDashboard_DBoard_btn_Study.ImageSize = new System.Drawing.Size(24, 24);
            this.fDashboard_DBoard_btn_Study.Location = new System.Drawing.Point(16, 298);
            this.fDashboard_DBoard_btn_Study.Name = "fDashboard_DBoard_btn_Study";
            this.fDashboard_DBoard_btn_Study.ShadowDecoration.Parent = this.fDashboard_DBoard_btn_Study;
            this.fDashboard_DBoard_btn_Study.Size = new System.Drawing.Size(259, 59);
            this.fDashboard_DBoard_btn_Study.TabIndex = 3;
            this.fDashboard_DBoard_btn_Study.Text = "Học tập";
            this.fDashboard_DBoard_btn_Study.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Study.TextOffset = new System.Drawing.Point(24, 0);
            this.fDashboard_DBoard_btn_Study.CheckedChanged += new System.EventHandler(this.fDashboard_DBoard_btn_Study_CheckedChanged);
            // 
            // fDashboard_DBoard_btn_Scholarship
            // 
            this.fDashboard_DBoard_btn_Scholarship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Scholarship.BorderRadius = 20;
            this.fDashboard_DBoard_btn_Scholarship.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.fDashboard_DBoard_btn_Scholarship.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.fDashboard_DBoard_btn_Scholarship.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.fDashboard_DBoard_btn_Scholarship.CheckedState.Image = global::GUI.Properties.Resources.scholarship__1_;
            this.fDashboard_DBoard_btn_Scholarship.CheckedState.Parent = this.fDashboard_DBoard_btn_Scholarship;
            this.fDashboard_DBoard_btn_Scholarship.CustomImages.Parent = this.fDashboard_DBoard_btn_Scholarship;
            this.fDashboard_DBoard_btn_Scholarship.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Scholarship.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Scholarship.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Scholarship.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Scholarship.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fDashboard_DBoard_btn_Scholarship.DisabledState.Parent = this.fDashboard_DBoard_btn_Scholarship;
            this.fDashboard_DBoard_btn_Scholarship.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Scholarship.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Scholarship.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDashboard_DBoard_btn_Scholarship.ForeColor = System.Drawing.Color.White;
            this.fDashboard_DBoard_btn_Scholarship.HoverState.Parent = this.fDashboard_DBoard_btn_Scholarship;
            this.fDashboard_DBoard_btn_Scholarship.Image = global::GUI.Properties.Resources.scholarship;
            this.fDashboard_DBoard_btn_Scholarship.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Scholarship.ImageOffset = new System.Drawing.Point(16, 0);
            this.fDashboard_DBoard_btn_Scholarship.ImageSize = new System.Drawing.Size(24, 24);
            this.fDashboard_DBoard_btn_Scholarship.Location = new System.Drawing.Point(16, 233);
            this.fDashboard_DBoard_btn_Scholarship.Name = "fDashboard_DBoard_btn_Scholarship";
            this.fDashboard_DBoard_btn_Scholarship.ShadowDecoration.Parent = this.fDashboard_DBoard_btn_Scholarship;
            this.fDashboard_DBoard_btn_Scholarship.Size = new System.Drawing.Size(259, 59);
            this.fDashboard_DBoard_btn_Scholarship.TabIndex = 2;
            this.fDashboard_DBoard_btn_Scholarship.Text = "Học bổng";
            this.fDashboard_DBoard_btn_Scholarship.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Scholarship.TextOffset = new System.Drawing.Point(24, 0);
            this.fDashboard_DBoard_btn_Scholarship.CheckedChanged += new System.EventHandler(this.fDashboard_DBoard_btn_Scholarship_CheckedChanged);
            // 
            // fDashboard_DBoard_btn_Dashboard
            // 
            this.fDashboard_DBoard_btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Dashboard.BorderRadius = 20;
            this.fDashboard_DBoard_btn_Dashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.fDashboard_DBoard_btn_Dashboard.Checked = true;
            this.fDashboard_DBoard_btn_Dashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.fDashboard_DBoard_btn_Dashboard.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(212)))), ((int)(((byte)(236)))));
            this.fDashboard_DBoard_btn_Dashboard.CheckedState.Image = global::GUI.Properties.Resources.dashboard__1_;
            this.fDashboard_DBoard_btn_Dashboard.CheckedState.Parent = this.fDashboard_DBoard_btn_Dashboard;
            this.fDashboard_DBoard_btn_Dashboard.CustomImages.Parent = this.fDashboard_DBoard_btn_Dashboard;
            this.fDashboard_DBoard_btn_Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fDashboard_DBoard_btn_Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Dashboard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fDashboard_DBoard_btn_Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fDashboard_DBoard_btn_Dashboard.DisabledState.Parent = this.fDashboard_DBoard_btn_Dashboard;
            this.fDashboard_DBoard_btn_Dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Dashboard.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fDashboard_DBoard_btn_Dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDashboard_DBoard_btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.fDashboard_DBoard_btn_Dashboard.HoverState.Parent = this.fDashboard_DBoard_btn_Dashboard;
            this.fDashboard_DBoard_btn_Dashboard.Image = global::GUI.Properties.Resources.dashboard;
            this.fDashboard_DBoard_btn_Dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Dashboard.ImageOffset = new System.Drawing.Point(16, 0);
            this.fDashboard_DBoard_btn_Dashboard.ImageSize = new System.Drawing.Size(24, 24);
            this.fDashboard_DBoard_btn_Dashboard.Location = new System.Drawing.Point(16, 168);
            this.fDashboard_DBoard_btn_Dashboard.Name = "fDashboard_DBoard_btn_Dashboard";
            this.fDashboard_DBoard_btn_Dashboard.ShadowDecoration.Parent = this.fDashboard_DBoard_btn_Dashboard;
            this.fDashboard_DBoard_btn_Dashboard.Size = new System.Drawing.Size(259, 59);
            this.fDashboard_DBoard_btn_Dashboard.TabIndex = 1;
            this.fDashboard_DBoard_btn_Dashboard.Text = "Dashboard";
            this.fDashboard_DBoard_btn_Dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fDashboard_DBoard_btn_Dashboard.TextOffset = new System.Drawing.Point(24, 0);
            this.fDashboard_DBoard_btn_Dashboard.CheckedChanged += new System.EventHandler(this.fDashboard_DBoard_btn_Dashboard_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "HBoard";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_Dashboard1);
            this.panel3.Controls.Add(this.uC_AboutUs1);
            this.panel3.Controls.Add(this.uC_Setting1);
            this.panel3.Controls.Add(this.uC_Scholarship1);
            this.panel3.Controls.Add(this.uC_Study_Main1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.uC_Gmail1);
            this.panel3.Location = new System.Drawing.Point(293, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 736);
            this.panel3.TabIndex = 2;
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.uC_Dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Dashboard1.Location = new System.Drawing.Point(0, 0);
            //this.uC_Dashboard1.Matrix = null;
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1147, 736);
            this.uC_Dashboard1.TabIndex = 1;
            // 
            // uC_AboutUs1
            // 
            this.uC_AboutUs1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.uC_AboutUs1.AutoScroll = true;
            this.uC_AboutUs1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.uC_AboutUs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.uC_AboutUs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_AboutUs1.Location = new System.Drawing.Point(0, 0);
            this.uC_AboutUs1.Name = "uC_AboutUs1";
            this.uC_AboutUs1.Size = new System.Drawing.Size(1147, 736);
            this.uC_AboutUs1.TabIndex = 0;
            // 
            // uC_Setting1
            // 
            this.uC_Setting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.uC_Setting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Setting1.Location = new System.Drawing.Point(0, 0);
            this.uC_Setting1.Name = "uC_Setting1";
            this.uC_Setting1.Size = new System.Drawing.Size(1147, 736);
            this.uC_Setting1.TabIndex = 3;
            // 
            // uC_Scholarship1
            // 
            this.uC_Scholarship1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.uC_Scholarship1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Scholarship1.Location = new System.Drawing.Point(0, 0);
            this.uC_Scholarship1.Name = "uC_Scholarship1";
            this.uC_Scholarship1.Size = new System.Drawing.Size(1147, 736);
            this.uC_Scholarship1.TabIndex = 2;
            // 
            // uC_Study_Main1
            // 
            this.uC_Study_Main1.Location = new System.Drawing.Point(0, 0);
            this.uC_Study_Main1.Name = "uC_Study_Main1";
            this.uC_Study_Main1.Size = new System.Drawing.Size(1147, 736);
            this.uC_Study_Main1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Location = new System.Drawing.Point(272, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 74);
            this.panel2.TabIndex = 1;
            // 
            // uC_Gmail1
            // 
            this.uC_Gmail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.uC_Gmail1.Location = new System.Drawing.Point(0, 0);
            this.uC_Gmail1.Name = "uC_Gmail1";
            this.uC_Gmail1.Size = new System.Drawing.Size(1147, 736);
            this.uC_Gmail1.TabIndex = 5;
            // 
            // BorderlessF_DBoard
            // 
            this.BorderlessF_DBoard.BorderRadius = 16;
            this.BorderlessF_DBoard.ContainerControl = this;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txt_C
            // 
            this.txt_C.AutoSize = true;
            this.txt_C.BorderThickness = 0;
            this.txt_C.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_C.DefaultText = "30";
            this.txt_C.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_C.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_C.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_C.DisabledState.Parent = this.txt_C;
            this.txt_C.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_C.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txt_C.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_C.FocusedState.Parent = this.txt_C;
            this.txt_C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C.ForeColor = System.Drawing.Color.White;
            this.txt_C.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_C.HoverState.Parent = this.txt_C;
            this.txt_C.IconLeft = global::GUI.Properties.Resources._10d;
            this.txt_C.IconLeftOffset = new System.Drawing.Point(0, 5);
            this.txt_C.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txt_C.IconRight = global::GUI.Properties.Resources.celsius_degrees_symbol_of_temperature;
            this.txt_C.Location = new System.Drawing.Point(1227, 11);
            this.txt_C.Margin = new System.Windows.Forms.Padding(5);
            this.txt_C.Name = "txt_C";
            this.txt_C.PasswordChar = '\0';
            this.txt_C.PlaceholderText = "";
            this.txt_C.ReadOnly = true;
            this.txt_C.SelectedText = "";
            this.txt_C.SelectionStart = 2;
            this.txt_C.ShadowDecoration.Parent = this.txt_C;
            this.txt_C.Size = new System.Drawing.Size(166, 55);
            this.txt_C.TabIndex = 11;
            // 
            // pic_location
            // 
            this.pic_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pic_location.Image = global::GUI.Properties.Resources.location_pin;
            this.pic_location.Location = new System.Drawing.Point(1086, 30);
            this.pic_location.Name = "pic_location";
            this.pic_location.Size = new System.Drawing.Size(24, 24);
            this.pic_location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_location.TabIndex = 8;
            this.pic_location.TabStop = false;
            // 
            // lab_location
            // 
            this.lab_location.AutoSize = true;
            this.lab_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lab_location.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.lab_location.Location = new System.Drawing.Point(1116, 26);
            this.lab_location.Name = "lab_location";
            this.lab_location.Size = new System.Drawing.Size(103, 28);
            this.lab_location.TabIndex = 7;
            this.lab_location.Text = "Qui Nhon";
            // 
            // lab_breadcrumb
            // 
            this.lab_breadcrumb.AutoSize = true;
            this.lab_breadcrumb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_breadcrumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(167)))));
            this.lab_breadcrumb.Location = new System.Drawing.Point(308, 23);
            this.lab_breadcrumb.Name = "lab_breadcrumb";
            this.lab_breadcrumb.Size = new System.Drawing.Size(208, 32);
            this.lab_breadcrumb.TabIndex = 12;
            this.lab_breadcrumb.Text = "App > Dashboard";
            // 
            // DBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.pic_location);
            this.Controls.Add(this.lab_breadcrumb);
            this.Controls.Add(this.lab_location);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.DBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_location)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton fDashboard_DBoard_btn_Dashboard;
        private Guna.UI2.WinForms.Guna2GradientButton fDashboard_DBoard_btn_Scholarship;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton fDashboard_DBoard_btn_Gmail;
        private Guna.UI2.WinForms.Guna2GradientButton fDashboard_DBoard_btn_Study;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton fDashboard_DBoard_btn_AboutUs;
        private Guna.UI2.WinForms.Guna2GradientButton fDashboard_DBoard_btn_Setting;
        private System.Windows.Forms.Panel panel3;
        private UC.UC_AboutUs uC_AboutUs1;
        private UC.UC_Setting uC_Setting1;
        private UC.UC_Scholarship uC_Scholarship1;
        private UC.UC_Dashboard uC_Dashboard1;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessF_DBoard;
        private UC.UC_Study_Main uC_Study_Main1;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Timer timer;
        private UC.UC_Gmail uC_Gmail1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_C;
        private System.Windows.Forms.PictureBox pic_location;
        private System.Windows.Forms.Label lab_breadcrumb;
        private System.Windows.Forms.Label lab_location;
    }
}