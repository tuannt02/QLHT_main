
namespace GUI.UC
{
    partial class UC_Study
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
            this.UC_Study_lab_Name = new System.Windows.Forms.Label();
            this.UC_Study_cb_NamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UC_Study_cb_HocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UC_Study_cb_Khoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UC_Study_txb_MSSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.UC_Study_btn_Search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.UC_Study_dtgv_Show1 = new System.Windows.Forms.DataGridView();
            this.UC_Study_btn_Edit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UC_Study_btn_ListKhoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UC_Study_dtgv_Show1)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_Study_lab_Name
            // 
            this.UC_Study_lab_Name.AutoSize = true;
            this.UC_Study_lab_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UC_Study_lab_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_Study_lab_Name.ForeColor = System.Drawing.Color.White;
            this.UC_Study_lab_Name.Location = new System.Drawing.Point(486, 144);
            this.UC_Study_lab_Name.Name = "UC_Study_lab_Name";
            this.UC_Study_lab_Name.Size = new System.Drawing.Size(156, 32);
            this.UC_Study_lab_Name.TabIndex = 4;
            this.UC_Study_lab_Name.Text = "Tên sinh viên";
            // 
            // UC_Study_cb_NamHoc
            // 
            this.UC_Study_cb_NamHoc.BackColor = System.Drawing.Color.Transparent;
            this.UC_Study_cb_NamHoc.BorderRadius = 16;
            this.UC_Study_cb_NamHoc.BorderThickness = 2;
            this.UC_Study_cb_NamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UC_Study_cb_NamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UC_Study_cb_NamHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UC_Study_cb_NamHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_Study_cb_NamHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_Study_cb_NamHoc.FocusedState.Parent = this.UC_Study_cb_NamHoc;
            this.UC_Study_cb_NamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UC_Study_cb_NamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.UC_Study_cb_NamHoc.HoverState.Parent = this.UC_Study_cb_NamHoc;
            this.UC_Study_cb_NamHoc.IntegralHeight = false;
            this.UC_Study_cb_NamHoc.ItemHeight = 40;
            this.UC_Study_cb_NamHoc.Items.AddRange(new object[] {
            "2016 - 2017",
            "2017 - 2018",
            "2018 - 2019",
            "2019 - 2020",
            "2020 - 2021",
            "2021 - 2022"});
            this.UC_Study_cb_NamHoc.ItemsAppearance.Parent = this.UC_Study_cb_NamHoc;
            this.UC_Study_cb_NamHoc.Location = new System.Drawing.Point(16, 21);
            this.UC_Study_cb_NamHoc.Name = "UC_Study_cb_NamHoc";
            this.UC_Study_cb_NamHoc.ShadowDecoration.Parent = this.UC_Study_cb_NamHoc;
            this.UC_Study_cb_NamHoc.Size = new System.Drawing.Size(169, 46);
            this.UC_Study_cb_NamHoc.TabIndex = 5;
            // 
            // UC_Study_cb_HocKy
            // 
            this.UC_Study_cb_HocKy.BackColor = System.Drawing.Color.Transparent;
            this.UC_Study_cb_HocKy.BorderRadius = 16;
            this.UC_Study_cb_HocKy.BorderThickness = 2;
            this.UC_Study_cb_HocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UC_Study_cb_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UC_Study_cb_HocKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UC_Study_cb_HocKy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_Study_cb_HocKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_Study_cb_HocKy.FocusedState.Parent = this.UC_Study_cb_HocKy;
            this.UC_Study_cb_HocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UC_Study_cb_HocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.UC_Study_cb_HocKy.HoverState.Parent = this.UC_Study_cb_HocKy;
            this.UC_Study_cb_HocKy.IntegralHeight = false;
            this.UC_Study_cb_HocKy.ItemHeight = 40;
            this.UC_Study_cb_HocKy.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.UC_Study_cb_HocKy.ItemsAppearance.Parent = this.UC_Study_cb_HocKy;
            this.UC_Study_cb_HocKy.Location = new System.Drawing.Point(201, 21);
            this.UC_Study_cb_HocKy.Name = "UC_Study_cb_HocKy";
            this.UC_Study_cb_HocKy.ShadowDecoration.Parent = this.UC_Study_cb_HocKy;
            this.UC_Study_cb_HocKy.Size = new System.Drawing.Size(153, 46);
            this.UC_Study_cb_HocKy.TabIndex = 6;
            // 
            // UC_Study_cb_Khoa
            // 
            this.UC_Study_cb_Khoa.BackColor = System.Drawing.Color.Transparent;
            this.UC_Study_cb_Khoa.BorderRadius = 16;
            this.UC_Study_cb_Khoa.BorderThickness = 2;
            this.UC_Study_cb_Khoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UC_Study_cb_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UC_Study_cb_Khoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UC_Study_cb_Khoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_Study_cb_Khoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_Study_cb_Khoa.FocusedState.Parent = this.UC_Study_cb_Khoa;
            this.UC_Study_cb_Khoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UC_Study_cb_Khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.UC_Study_cb_Khoa.HoverState.Parent = this.UC_Study_cb_Khoa;
            this.UC_Study_cb_Khoa.IntegralHeight = false;
            this.UC_Study_cb_Khoa.ItemHeight = 40;
            this.UC_Study_cb_Khoa.Items.AddRange(new object[] {
            "Công Nghệ Phần Mềm",
            "Hệ Thống Thông Tin",
            "Kỹ Thuật Máy Tính",
            "Khoa Học Máy Tính",
            "Khoa Học Và Kỹ Thuật Thông Tin",
            "Mạng Máy Tính Và Truyền Thông"});
            this.UC_Study_cb_Khoa.ItemsAppearance.Parent = this.UC_Study_cb_Khoa;
            this.UC_Study_cb_Khoa.Location = new System.Drawing.Point(372, 21);
            this.UC_Study_cb_Khoa.Name = "UC_Study_cb_Khoa";
            this.UC_Study_cb_Khoa.ShadowDecoration.Parent = this.UC_Study_cb_Khoa;
            this.UC_Study_cb_Khoa.Size = new System.Drawing.Size(330, 46);
            this.UC_Study_cb_Khoa.TabIndex = 7;
            // 
            // UC_Study_txb_MSSV
            // 
            this.UC_Study_txb_MSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UC_Study_txb_MSSV.DefaultText = "";
            this.UC_Study_txb_MSSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UC_Study_txb_MSSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UC_Study_txb_MSSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UC_Study_txb_MSSV.DisabledState.Parent = this.UC_Study_txb_MSSV;
            this.UC_Study_txb_MSSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UC_Study_txb_MSSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UC_Study_txb_MSSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_Study_txb_MSSV.FocusedState.Parent = this.UC_Study_txb_MSSV;
            this.UC_Study_txb_MSSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UC_Study_txb_MSSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_Study_txb_MSSV.HoverState.Parent = this.UC_Study_txb_MSSV;
            this.UC_Study_txb_MSSV.Location = new System.Drawing.Point(802, 21);
            this.UC_Study_txb_MSSV.Name = "UC_Study_txb_MSSV";
            this.UC_Study_txb_MSSV.PasswordChar = '\0';
            this.UC_Study_txb_MSSV.PlaceholderText = "";
            this.UC_Study_txb_MSSV.SelectedText = "";
            this.UC_Study_txb_MSSV.ShadowDecoration.Parent = this.UC_Study_txb_MSSV;
            this.UC_Study_txb_MSSV.Size = new System.Drawing.Size(314, 46);
            this.UC_Study_txb_MSSV.TabIndex = 8;
            // 
            // UC_Study_btn_Search
            // 
            this.UC_Study_btn_Search.BorderRadius = 16;
            this.UC_Study_btn_Search.CheckedState.Parent = this.UC_Study_btn_Search;
            this.UC_Study_btn_Search.CustomImages.Parent = this.UC_Study_btn_Search;
            this.UC_Study_btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UC_Study_btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UC_Study_btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_Study_btn_Search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_Study_btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UC_Study_btn_Search.DisabledState.Parent = this.UC_Study_btn_Search;
            this.UC_Study_btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UC_Study_btn_Search.ForeColor = System.Drawing.Color.White;
            this.UC_Study_btn_Search.HoverState.Parent = this.UC_Study_btn_Search;
            this.UC_Study_btn_Search.Location = new System.Drawing.Point(974, 73);
            this.UC_Study_btn_Search.Name = "UC_Study_btn_Search";
            this.UC_Study_btn_Search.ShadowDecoration.Parent = this.UC_Study_btn_Search;
            this.UC_Study_btn_Search.Size = new System.Drawing.Size(142, 45);
            this.UC_Study_btn_Search.TabIndex = 9;
            this.UC_Study_btn_Search.Text = "Search";
            this.UC_Study_btn_Search.Click += new System.EventHandler(this.UC_Study_btn_Search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UC_Study_btn_ListKhoa);
            this.panel1.Controls.Add(this.UC_Study_btn_Edit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 117);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UC_Study_cb_Khoa);
            this.panel2.Controls.Add(this.UC_Study_lab_Name);
            this.panel2.Controls.Add(this.UC_Study_btn_Search);
            this.panel2.Controls.Add(this.UC_Study_cb_NamHoc);
            this.panel2.Controls.Add(this.UC_Study_txb_MSSV);
            this.panel2.Controls.Add(this.UC_Study_cb_HocKy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 191);
            this.panel2.TabIndex = 11;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.UC_Study_dtgv_Show1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 191);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1147, 402);
            this.guna2Panel1.TabIndex = 12;
            // 
            // UC_Study_dtgv_Show1
            // 
            this.UC_Study_dtgv_Show1.AllowUserToAddRows = false;
            this.UC_Study_dtgv_Show1.AllowUserToDeleteRows = false;
            this.UC_Study_dtgv_Show1.AllowUserToOrderColumns = true;
            this.UC_Study_dtgv_Show1.AllowUserToResizeRows = false;
            this.UC_Study_dtgv_Show1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UC_Study_dtgv_Show1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UC_Study_dtgv_Show1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UC_Study_dtgv_Show1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UC_Study_dtgv_Show1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.UC_Study_dtgv_Show1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Study_dtgv_Show1.Location = new System.Drawing.Point(0, 0);
            this.UC_Study_dtgv_Show1.Name = "UC_Study_dtgv_Show1";
            this.UC_Study_dtgv_Show1.RowHeadersVisible = false;
            this.UC_Study_dtgv_Show1.RowHeadersWidth = 62;
            this.UC_Study_dtgv_Show1.RowTemplate.Height = 28;
            this.UC_Study_dtgv_Show1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UC_Study_dtgv_Show1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UC_Study_dtgv_Show1.Size = new System.Drawing.Size(1147, 402);
            this.UC_Study_dtgv_Show1.TabIndex = 0;
            this.UC_Study_dtgv_Show1.SelectionChanged += new System.EventHandler(this.UC_Study_dtgv_Show1_SelectionChanged);
            // 
            // UC_Study_btn_Edit
            // 
            this.UC_Study_btn_Edit.BorderRadius = 16;
            this.UC_Study_btn_Edit.CheckedState.Parent = this.UC_Study_btn_Edit;
            this.UC_Study_btn_Edit.CustomImages.Parent = this.UC_Study_btn_Edit;
            this.UC_Study_btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UC_Study_btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UC_Study_btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_Study_btn_Edit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_Study_btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UC_Study_btn_Edit.DisabledState.Parent = this.UC_Study_btn_Edit;
            this.UC_Study_btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UC_Study_btn_Edit.ForeColor = System.Drawing.Color.White;
            this.UC_Study_btn_Edit.HoverState.Parent = this.UC_Study_btn_Edit;
            this.UC_Study_btn_Edit.Location = new System.Drawing.Point(781, 36);
            this.UC_Study_btn_Edit.Name = "UC_Study_btn_Edit";
            this.UC_Study_btn_Edit.ShadowDecoration.Parent = this.UC_Study_btn_Edit;
            this.UC_Study_btn_Edit.Size = new System.Drawing.Size(142, 45);
            this.UC_Study_btn_Edit.TabIndex = 10;
            this.UC_Study_btn_Edit.Text = "Edit";
            this.UC_Study_btn_Edit.Click += new System.EventHandler(this.UC_Study_btn_Edit_Click);
            // 
            // UC_Study_btn_ListKhoa
            // 
            this.UC_Study_btn_ListKhoa.BorderRadius = 16;
            this.UC_Study_btn_ListKhoa.CheckedState.Parent = this.UC_Study_btn_ListKhoa;
            this.UC_Study_btn_ListKhoa.CustomImages.Parent = this.UC_Study_btn_ListKhoa;
            this.UC_Study_btn_ListKhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UC_Study_btn_ListKhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UC_Study_btn_ListKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_Study_btn_ListKhoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_Study_btn_ListKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UC_Study_btn_ListKhoa.DisabledState.Parent = this.UC_Study_btn_ListKhoa;
            this.UC_Study_btn_ListKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UC_Study_btn_ListKhoa.ForeColor = System.Drawing.Color.White;
            this.UC_Study_btn_ListKhoa.HoverState.Parent = this.UC_Study_btn_ListKhoa;
            this.UC_Study_btn_ListKhoa.Location = new System.Drawing.Point(959, 36);
            this.UC_Study_btn_ListKhoa.Name = "UC_Study_btn_ListKhoa";
            this.UC_Study_btn_ListKhoa.ShadowDecoration.Parent = this.UC_Study_btn_ListKhoa;
            this.UC_Study_btn_ListKhoa.Size = new System.Drawing.Size(142, 45);
            this.UC_Study_btn_ListKhoa.TabIndex = 11;
            this.UC_Study_btn_ListKhoa.Text = "Danh sách";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MAMH";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên môn học";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số tín chỉ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quá trình";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giữa kỳ";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thực hành";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cuối kỳ";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "TB Môn";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // UC_Study
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Study";
            this.Size = new System.Drawing.Size(1147, 710);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UC_Study_dtgv_Show1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UC_Study_lab_Name;
        private Guna.UI2.WinForms.Guna2ComboBox UC_Study_cb_NamHoc;
        private Guna.UI2.WinForms.Guna2ComboBox UC_Study_cb_HocKy;
        private Guna.UI2.WinForms.Guna2ComboBox UC_Study_cb_Khoa;
        private Guna.UI2.WinForms.Guna2TextBox UC_Study_txb_MSSV;
        private Guna.UI2.WinForms.Guna2GradientButton UC_Study_btn_Search;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton UC_Study_btn_ListKhoa;
        private Guna.UI2.WinForms.Guna2GradientButton UC_Study_btn_Edit;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView UC_Study_dtgv_Show1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
