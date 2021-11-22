
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UC_Study_lab_Name = new System.Windows.Forms.Label();
            this.UC_Study_cb_NamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UC_Study_cb_HocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UC_Study_cb_Khoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UC_Study_txb_MSSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.UC_Study_btn_Search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UC_Study_btn_ListKhoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UC_Study_btn_Edit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 618);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 92);
            this.panel1.TabIndex = 10;
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
            this.UC_Study_btn_ListKhoa.Location = new System.Drawing.Point(961, 23);
            this.UC_Study_btn_ListKhoa.Name = "UC_Study_btn_ListKhoa";
            this.UC_Study_btn_ListKhoa.ShadowDecoration.Parent = this.UC_Study_btn_ListKhoa;
            this.UC_Study_btn_ListKhoa.Size = new System.Drawing.Size(142, 45);
            this.UC_Study_btn_ListKhoa.TabIndex = 11;
            this.UC_Study_btn_ListKhoa.Text = "Danh sách";
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
            this.UC_Study_btn_Edit.Location = new System.Drawing.Point(781, 23);
            this.UC_Study_btn_Edit.Name = "UC_Study_btn_Edit";
            this.UC_Study_btn_Edit.ShadowDecoration.Parent = this.UC_Study_btn_Edit;
            this.UC_Study_btn_Edit.Size = new System.Drawing.Size(142, 45);
            this.UC_Study_btn_Edit.TabIndex = 10;
            this.UC_Study_btn_Edit.Text = "Edit";
            this.UC_Study_btn_Edit.Click += new System.EventHandler(this.UC_Study_btn_Edit_Click);
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
            this.guna2Panel1.Controls.Add(this.dtgv);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 191);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1147, 427);
            this.guna2Panel1.TabIndex = 12;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column9,
            this.Column10,
            this.dataGridViewImageColumn1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 62;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv.RowTemplate.Height = 50;
            this.dtgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1147, 427);
            this.dtgv.TabIndex = 11;
            this.dtgv.SelectionChanged += new System.EventHandler(this.dtgv_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 27.60738F;
            this.dataGridViewTextBoxColumn1.HeaderText = "MAMH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 49.23939F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên môn học";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 31.32404F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Số TC";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.FillWeight = 45.60638F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Quá trình";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.FillWeight = 29.37265F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Giữa kỳ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 41.36973F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Thực hành";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 29.73977F;
            this.Column9.HeaderText = "Cuối kỳ";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 27.79487F;
            this.Column10.HeaderText = "TB môn";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 16.99122F;
            this.dataGridViewImageColumn1.HeaderText = "Pass";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
