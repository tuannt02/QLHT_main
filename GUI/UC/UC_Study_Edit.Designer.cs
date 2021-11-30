
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
            this.cb_NamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_HocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_Khoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txb_MSSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.UC_AboutUs_scrbar_main = new Guna.UI2.WinForms.Guna2VScrollBar();
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
            this.UC_Study_lab_Name.Location = new System.Drawing.Point(489, 91);
            this.UC_Study_lab_Name.Name = "UC_Study_lab_Name";
            this.UC_Study_lab_Name.Size = new System.Drawing.Size(156, 32);
            this.UC_Study_lab_Name.TabIndex = 4;
            this.UC_Study_lab_Name.Text = "Tên sinh viên";
            // 
            // cb_NamHoc
            // 
            this.cb_NamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cb_NamHoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.cb_NamHoc.BorderRadius = 16;
            this.cb_NamHoc.BorderThickness = 2;
            this.cb_NamHoc.CustomizableEdges.BottomRight = false;
            this.cb_NamHoc.CustomizableEdges.TopRight = false;
            this.cb_NamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_NamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NamHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cb_NamHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_NamHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_NamHoc.FocusedState.Parent = this.cb_NamHoc;
            this.cb_NamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_NamHoc.ForeColor = System.Drawing.Color.White;
            this.cb_NamHoc.HoverState.Parent = this.cb_NamHoc;
            this.cb_NamHoc.IntegralHeight = false;
            this.cb_NamHoc.ItemHeight = 40;
            this.cb_NamHoc.Items.AddRange(new object[] {
            "2016 - 2017",
            "2017 - 2018",
            "2018 - 2019",
            "2019 - 2020",
            "2020 - 2021",
            "2021 - 2022"});
            this.cb_NamHoc.ItemsAppearance.Parent = this.cb_NamHoc;
            this.cb_NamHoc.Location = new System.Drawing.Point(16, 21);
            this.cb_NamHoc.Name = "cb_NamHoc";
            this.cb_NamHoc.ShadowDecoration.Parent = this.cb_NamHoc;
            this.cb_NamHoc.Size = new System.Drawing.Size(169, 46);
            this.cb_NamHoc.TabIndex = 5;
            this.cb_NamHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_HocKy
            // 
            this.cb_HocKy.BackColor = System.Drawing.Color.Transparent;
            this.cb_HocKy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.cb_HocKy.BorderRadius = 16;
            this.cb_HocKy.BorderThickness = 2;
            this.cb_HocKy.CustomizableEdges.BottomLeft = false;
            this.cb_HocKy.CustomizableEdges.BottomRight = false;
            this.cb_HocKy.CustomizableEdges.TopLeft = false;
            this.cb_HocKy.CustomizableEdges.TopRight = false;
            this.cb_HocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_HocKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cb_HocKy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_HocKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_HocKy.FocusedState.Parent = this.cb_HocKy;
            this.cb_HocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_HocKy.ForeColor = System.Drawing.Color.White;
            this.cb_HocKy.HoverState.Parent = this.cb_HocKy;
            this.cb_HocKy.IntegralHeight = false;
            this.cb_HocKy.ItemHeight = 40;
            this.cb_HocKy.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cb_HocKy.ItemsAppearance.Parent = this.cb_HocKy;
            this.cb_HocKy.Location = new System.Drawing.Point(188, 21);
            this.cb_HocKy.Name = "cb_HocKy";
            this.cb_HocKy.ShadowDecoration.Parent = this.cb_HocKy;
            this.cb_HocKy.Size = new System.Drawing.Size(89, 46);
            this.cb_HocKy.TabIndex = 6;
            this.cb_HocKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.BackColor = System.Drawing.Color.Transparent;
            this.cb_Khoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.cb_Khoa.BorderRadius = 16;
            this.cb_Khoa.BorderThickness = 2;
            this.cb_Khoa.CustomizableEdges.BottomLeft = false;
            this.cb_Khoa.CustomizableEdges.TopLeft = false;
            this.cb_Khoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Khoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cb_Khoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Khoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Khoa.FocusedState.Parent = this.cb_Khoa;
            this.cb_Khoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Khoa.ForeColor = System.Drawing.Color.White;
            this.cb_Khoa.HoverState.Parent = this.cb_Khoa;
            this.cb_Khoa.IntegralHeight = false;
            this.cb_Khoa.ItemHeight = 40;
            this.cb_Khoa.Items.AddRange(new object[] {
            "Công Nghệ Phần Mềm",
            "Hệ Thống Thông Tin",
            "Kỹ Thuật Máy Tính",
            "Khoa Học Máy Tính",
            "Khoa Học Và Kỹ Thuật Thông Tin",
            "Mạng Máy Tính Và Truyền Thông"});
            this.cb_Khoa.ItemsAppearance.Parent = this.cb_Khoa;
            this.cb_Khoa.Location = new System.Drawing.Point(279, 21);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.ShadowDecoration.Parent = this.cb_Khoa;
            this.cb_Khoa.Size = new System.Drawing.Size(330, 46);
            this.cb_Khoa.TabIndex = 7;
            // 
            // txb_MSSV
            // 
            this.txb_MSSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.txb_MSSV.BorderRadius = 16;
            this.txb_MSSV.BorderThickness = 2;
            this.txb_MSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_MSSV.DefaultText = "";
            this.txb_MSSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_MSSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_MSSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_MSSV.DisabledState.Parent = this.txb_MSSV;
            this.txb_MSSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_MSSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txb_MSSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_MSSV.FocusedState.Parent = this.txb_MSSV;
            this.txb_MSSV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MSSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.txb_MSSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_MSSV.HoverState.Parent = this.txb_MSSV;
            this.txb_MSSV.Location = new System.Drawing.Point(933, 24);
            this.txb_MSSV.Name = "txb_MSSV";
            this.txb_MSSV.PasswordChar = '\0';
            this.txb_MSSV.PlaceholderForeColor = System.Drawing.Color.White;
            this.txb_MSSV.PlaceholderText = "Nhập MSSV";
            this.txb_MSSV.SelectedText = "";
            this.txb_MSSV.ShadowDecoration.Parent = this.txb_MSSV;
            this.txb_MSSV.Size = new System.Drawing.Size(202, 46);
            this.txb_MSSV.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 74);
            this.panel1.TabIndex = 10;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BorderRadius = 16;
            this.btn_Edit.CheckedState.Parent = this.btn_Edit;
            this.btn_Edit.CustomImages.Parent = this.btn_Edit;
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.DisabledState.Parent = this.btn_Edit;
            this.btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Edit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.HoverState.Parent = this.btn_Edit;
            this.btn_Edit.Location = new System.Drawing.Point(981, 16);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.ShadowDecoration.Parent = this.btn_Edit;
            this.btn_Edit.Size = new System.Drawing.Size(142, 45);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.Click += new System.EventHandler(this.UC_Study_btn_Edit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_Khoa);
            this.panel2.Controls.Add(this.UC_Study_lab_Name);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Controls.Add(this.cb_NamHoc);
            this.panel2.Controls.Add(this.txb_MSSV);
            this.panel2.Controls.Add(this.cb_HocKy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 137);
            this.panel2.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.BorderRadius = 8;
            this.btn_Search.CheckedState.Parent = this.btn_Search;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.CustomImages.Parent = this.btn_Search;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.DisabledState.Parent = this.btn_Search;
            this.btn_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Search.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.HoverState.Parent = this.btn_Search;
            this.btn_Search.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.btn_Search.Location = new System.Drawing.Point(873, 25);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.Parent = this.btn_Search;
            this.btn_Search.Size = new System.Drawing.Size(50, 45);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Click += new System.EventHandler(this.UC_Study_btn_Search_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.UC_AboutUs_scrbar_main);
            this.guna2Panel1.Controls.Add(this.dtgv);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 137);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1147, 470);
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
            this.dtgv.Size = new System.Drawing.Size(1147, 470);
            this.dtgv.TabIndex = 11;
            this.dtgv.SelectionChanged += new System.EventHandler(this.dtgv_SelectionChanged);
            // 
            // UC_AboutUs_scrbar_main
            // 
            this.UC_AboutUs_scrbar_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_AboutUs_scrbar_main.AutoRoundedCorners = true;
            this.UC_AboutUs_scrbar_main.BindingContainer = this.dtgv;
            this.UC_AboutUs_scrbar_main.BorderRadius = 4;
            this.UC_AboutUs_scrbar_main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.UC_AboutUs_scrbar_main.HoverState.Parent = null;
            this.UC_AboutUs_scrbar_main.InUpdate = false;
            this.UC_AboutUs_scrbar_main.LargeChange = 10;
            this.UC_AboutUs_scrbar_main.Location = new System.Drawing.Point(1137, 0);
            this.UC_AboutUs_scrbar_main.Minimum = 1;
            this.UC_AboutUs_scrbar_main.Name = "UC_AboutUs_scrbar_main";
            this.UC_AboutUs_scrbar_main.PressedState.Parent = this.UC_AboutUs_scrbar_main;
            this.UC_AboutUs_scrbar_main.ScrollbarSize = 10;
            this.UC_AboutUs_scrbar_main.Size = new System.Drawing.Size(10, 470);
            this.UC_AboutUs_scrbar_main.TabIndex = 12;
            this.UC_AboutUs_scrbar_main.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_scrbar_main.Value = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 29.16393F;
            this.dataGridViewTextBoxColumn1.HeaderText = "MAMH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 52.01558F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên môn học";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 33.09014F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Số TC";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.FillWeight = 33.98244F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Quá trình";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.FillWeight = 31.02872F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Giữa kỳ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 43.70222F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Thực hành";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 31.41654F;
            this.Column9.HeaderText = "Cuối kỳ";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 26.69666F;
            this.Column10.HeaderText = "TB môn";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 17.94921F;
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
            this.Size = new System.Drawing.Size(1147, 681);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UC_Study_lab_Name;
        private Guna.UI2.WinForms.Guna2ComboBox cb_NamHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cb_HocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Khoa;
        private Guna.UI2.WinForms.Guna2TextBox txb_MSSV;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Search;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Edit;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dtgv;
        private Guna.UI2.WinForms.Guna2VScrollBar UC_AboutUs_scrbar_main;
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
