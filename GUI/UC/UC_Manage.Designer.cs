
namespace GUI.UC
{
    partial class UC_Manage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_header = new System.Windows.Forms.Label();
            this.lab_Username = new System.Windows.Forms.Label();
            this.txb_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_display = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_MSSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ck = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UC_AboutUs_scrbar_main = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.UC_AboutUs_scrbar_main);
            this.panel1.Controls.Add(this.dtgv);
            this.panel1.Location = new System.Drawing.Point(3, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 554);
            this.panel1.TabIndex = 0;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToOrderColumns = true;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeight = 40;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.RowTemplate.Height = 50;
            this.dtgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(672, 554);
            this.dtgv.TabIndex = 11;
            this.dtgv.SelectionChanged += new System.EventHandler(this.dtgv_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tài khoản";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên hiển thị";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MSSV";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Admin";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // lab_header
            // 
            this.lab_header.AutoSize = true;
            this.lab_header.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_header.ForeColor = System.Drawing.Color.White;
            this.lab_header.Location = new System.Drawing.Point(243, 47);
            this.lab_header.Name = "lab_header";
            this.lab_header.Size = new System.Drawing.Size(254, 70);
            this.lab_header.TabIndex = 19;
            this.lab_header.Text = "Tài khoản";
            // 
            // lab_Username
            // 
            this.lab_Username.AutoSize = true;
            this.lab_Username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Username.ForeColor = System.Drawing.Color.White;
            this.lab_Username.Location = new System.Drawing.Point(730, 214);
            this.lab_Username.Name = "lab_Username";
            this.lab_Username.Size = new System.Drawing.Size(108, 28);
            this.lab_Username.TabIndex = 20;
            this.lab_Username.Text = "Tài khoản:";
            // 
            // txb_username
            // 
            this.txb_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.txb_username.BorderRadius = 8;
            this.txb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_username.DefaultText = "";
            this.txb_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_username.DisabledState.Parent = this.txb_username;
            this.txb_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_username.FocusedState.Parent = this.txb_username;
            this.txb_username.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_username.HoverState.Parent = this.txb_username;
            this.txb_username.Location = new System.Drawing.Point(862, 207);
            this.txb_username.Name = "txb_username";
            this.txb_username.PasswordChar = '\0';
            this.txb_username.PlaceholderText = "Nhập tài khoản";
            this.txb_username.SelectedText = "";
            this.txb_username.ShadowDecoration.Parent = this.txb_username;
            this.txb_username.Size = new System.Drawing.Size(266, 44);
            this.txb_username.TabIndex = 21;
            // 
            // txb_password
            // 
            this.txb_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.txb_password.BorderRadius = 8;
            this.txb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_password.DefaultText = "";
            this.txb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.DisabledState.Parent = this.txb_password;
            this.txb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.FocusedState.Parent = this.txb_password;
            this.txb_password.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.HoverState.Parent = this.txb_password;
            this.txb_password.Location = new System.Drawing.Point(862, 300);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '\0';
            this.txb_password.PlaceholderText = "Nhập mật khẩu";
            this.txb_password.SelectedText = "";
            this.txb_password.ShadowDecoration.Parent = this.txb_password;
            this.txb_password.Size = new System.Drawing.Size(266, 44);
            this.txb_password.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(730, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mật khẩu:";
            // 
            // txb_display
            // 
            this.txb_display.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.txb_display.BorderRadius = 8;
            this.txb_display.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_display.DefaultText = "";
            this.txb_display.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_display.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_display.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_display.DisabledState.Parent = this.txb_display;
            this.txb_display.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_display.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_display.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_display.FocusedState.Parent = this.txb_display;
            this.txb_display.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_display.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_display.HoverState.Parent = this.txb_display;
            this.txb_display.Location = new System.Drawing.Point(862, 398);
            this.txb_display.Name = "txb_display";
            this.txb_display.PasswordChar = '\0';
            this.txb_display.PlaceholderText = "Nhập tên hiển thị";
            this.txb_display.SelectedText = "";
            this.txb_display.ShadowDecoration.Parent = this.txb_display;
            this.txb_display.Size = new System.Drawing.Size(266, 44);
            this.txb_display.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(730, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên hiển thị:";
            // 
            // txb_MSSV
            // 
            this.txb_MSSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.txb_MSSV.BorderRadius = 8;
            this.txb_MSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_MSSV.DefaultText = "";
            this.txb_MSSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_MSSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_MSSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_MSSV.DisabledState.Parent = this.txb_MSSV;
            this.txb_MSSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_MSSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_MSSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_MSSV.FocusedState.Parent = this.txb_MSSV;
            this.txb_MSSV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MSSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_MSSV.HoverState.Parent = this.txb_MSSV;
            this.txb_MSSV.Location = new System.Drawing.Point(862, 498);
            this.txb_MSSV.Name = "txb_MSSV";
            this.txb_MSSV.PasswordChar = '\0';
            this.txb_MSSV.PlaceholderText = "Nhập mã số sinh viên";
            this.txb_MSSV.SelectedText = "";
            this.txb_MSSV.ShadowDecoration.Parent = this.txb_MSSV;
            this.txb_MSSV.Size = new System.Drawing.Size(266, 44);
            this.txb_MSSV.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(730, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "MSSV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(730, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Admin:";
            // 
            // ck
            // 
            this.ck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.ck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.ck.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ck.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ck.CheckedState.Parent = this.ck;
            this.ck.Location = new System.Drawing.Point(862, 592);
            this.ck.Name = "ck";
            this.ck.ShadowDecoration.Parent = this.ck;
            this.ck.Size = new System.Drawing.Size(59, 24);
            this.ck.TabIndex = 29;
            this.ck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ck.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ck.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ck.UncheckedState.Parent = this.ck;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.panel2.Location = new System.Drawing.Point(681, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 541);
            this.panel2.TabIndex = 30;
            // 
            // btn_Add
            // 
            this.btn_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.btn_Add.BorderRadius = 4;
            this.btn_Add.BorderThickness = 1;
            this.btn_Add.CheckedState.Parent = this.btn_Add;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.CustomImages.Parent = this.btn_Add;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.DisabledState.Parent = this.btn_Add;
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Add.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.HoverState.Parent = this.btn_Add;
            this.btn_Add.Location = new System.Drawing.Point(713, 665);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.ShadowDecoration.Parent = this.btn_Add;
            this.btn_Add.Size = new System.Drawing.Size(123, 45);
            this.btn_Add.TabIndex = 31;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.btn_Delete.BorderRadius = 4;
            this.btn_Delete.BorderThickness = 1;
            this.btn_Delete.CheckedState.Parent = this.btn_Delete;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.CustomImages.Parent = this.btn_Delete;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.DisabledState.Parent = this.btn_Delete;
            this.btn_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Delete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.HoverState.Parent = this.btn_Delete;
            this.btn_Delete.Location = new System.Drawing.Point(860, 665);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.Parent = this.btn_Delete;
            this.btn_Delete.Size = new System.Drawing.Size(123, 45);
            this.btn_Delete.TabIndex = 32;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.btn_Edit.BorderRadius = 4;
            this.btn_Edit.BorderThickness = 1;
            this.btn_Edit.CheckedState.Parent = this.btn_Edit;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.CustomImages.Parent = this.btn_Edit;
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.DisabledState.Parent = this.btn_Edit;
            this.btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Edit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.HoverState.Parent = this.btn_Edit;
            this.btn_Edit.Location = new System.Drawing.Point(1005, 665);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.ShadowDecoration.Parent = this.btn_Edit;
            this.btn_Edit.Size = new System.Drawing.Size(123, 45);
            this.btn_Edit.TabIndex = 33;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // UC_AboutUs_scrbar_main
            // 
            this.UC_AboutUs_scrbar_main.AutoRoundedCorners = true;
            this.UC_AboutUs_scrbar_main.BindingContainer = this.dtgv;
            this.UC_AboutUs_scrbar_main.BorderRadius = 5;
            this.UC_AboutUs_scrbar_main.Dock = System.Windows.Forms.DockStyle.Right;
            this.UC_AboutUs_scrbar_main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.UC_AboutUs_scrbar_main.HoverState.Parent = null;
            this.UC_AboutUs_scrbar_main.InUpdate = false;
            this.UC_AboutUs_scrbar_main.LargeChange = 10;
            this.UC_AboutUs_scrbar_main.Location = new System.Drawing.Point(659, 0);
            this.UC_AboutUs_scrbar_main.Minimum = 1;
            this.UC_AboutUs_scrbar_main.Name = "UC_AboutUs_scrbar_main";
            this.UC_AboutUs_scrbar_main.PressedState.Parent = this.UC_AboutUs_scrbar_main;
            this.UC_AboutUs_scrbar_main.ScrollbarSize = 13;
            this.UC_AboutUs_scrbar_main.Size = new System.Drawing.Size(13, 554);
            this.UC_AboutUs_scrbar_main.TabIndex = 34;
            this.UC_AboutUs_scrbar_main.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_scrbar_main.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.UC_AboutUs_scrbar_main.Value = 1;
            // 
            // UC_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_MSSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.lab_Username);
            this.Controls.Add(this.lab_header);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Manage";
            this.Size = new System.Drawing.Size(1147, 736);
            this.Load += new System.EventHandler(this.UC_Manage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label lab_header;
        private System.Windows.Forms.Label lab_Username;
        private Guna.UI2.WinForms.Guna2TextBox txb_username;
        private Guna.UI2.WinForms.Guna2TextBox txb_password;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txb_display;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txb_MSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ck;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Add;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Delete;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2VScrollBar UC_AboutUs_scrbar_main;
    }
}
