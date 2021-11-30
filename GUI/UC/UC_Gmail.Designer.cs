
namespace GUI.UC
{
    partial class UC_Gmail
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Gmail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cb_Khoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lab_header = new System.Windows.Forms.Label();
            this.btn_logo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_empty = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_attach = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txb_to = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txb_subject = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txb_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txb_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_send = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txb_mes = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.txt_info = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cb_Khoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(744, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 736);
            this.panel1.TabIndex = 0;
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
            this.btn_Search.Location = new System.Drawing.Point(306, 30);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.Parent = this.btn_Search;
            this.btn_Search.Size = new System.Drawing.Size(50, 45);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv);
            this.panel3.Location = new System.Drawing.Point(3, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 614);
            this.panel3.TabIndex = 10;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgv.ColumnHeadersHeight = 40;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.Name = "dtgv";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 62;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgv.RowTemplate.Height = 50;
            this.dtgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(397, 614);
            this.dtgv.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 52.6308F;
            this.dataGridViewTextBoxColumn1.HeaderText = "MSSV";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 110.2545F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sinh viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 33.46959F;
            this.Column1.HeaderText = "Check";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.BackColor = System.Drawing.Color.Transparent;
            this.cb_Khoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.cb_Khoa.BorderRadius = 16;
            this.cb_Khoa.BorderThickness = 2;
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
            "CNPM",
            "HTTT",
            "KHMT",
            "MMTTT",
            "KTMT",
            "KHKTTT"});
            this.cb_Khoa.ItemsAppearance.Parent = this.cb_Khoa;
            this.cb_Khoa.Location = new System.Drawing.Point(32, 30);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.ShadowDecoration.Parent = this.cb_Khoa;
            this.cb_Khoa.Size = new System.Drawing.Size(268, 46);
            this.cb_Khoa.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_info);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ToggleSwitch);
            this.panel2.Controls.Add(this.lab_header);
            this.panel2.Controls.Add(this.btn_logo);
            this.panel2.Controls.Add(this.btn_empty);
            this.panel2.Controls.Add(this.btn_attach);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.txb_to);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.txb_subject);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.txb_username);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txb_password);
            this.panel2.Controls.Add(this.btn_send);
            this.panel2.Controls.Add(this.txb_mes);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 736);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(560, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gửi nhiều";
            // 
            // ToggleSwitch
            // 
            this.ToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.ToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.ToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch.CheckedState.Parent = this.ToggleSwitch;
            this.ToggleSwitch.Location = new System.Drawing.Point(662, 150);
            this.ToggleSwitch.Name = "ToggleSwitch";
            this.ToggleSwitch.ShadowDecoration.Parent = this.ToggleSwitch;
            this.ToggleSwitch.Size = new System.Drawing.Size(59, 24);
            this.ToggleSwitch.TabIndex = 19;
            this.ToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch.UncheckedState.Parent = this.ToggleSwitch;
            // 
            // lab_header
            // 
            this.lab_header.AutoSize = true;
            this.lab_header.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_header.ForeColor = System.Drawing.Color.White;
            this.lab_header.Location = new System.Drawing.Point(309, 49);
            this.lab_header.Name = "lab_header";
            this.lab_header.Size = new System.Drawing.Size(189, 70);
            this.lab_header.TabIndex = 18;
            this.lab_header.Text = "GMAIL";
            // 
            // btn_logo
            // 
            this.btn_logo.BorderRadius = 8;
            this.btn_logo.CheckedState.Parent = this.btn_logo;
            this.btn_logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_logo.CustomImages.Parent = this.btn_logo;
            this.btn_logo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logo.DisabledState.Parent = this.btn_logo;
            this.btn_logo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_logo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_logo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_logo.ForeColor = System.Drawing.Color.White;
            this.btn_logo.HoverState.Parent = this.btn_logo;
            this.btn_logo.Image = global::GUI.Properties.Resources.gmail_logo__1_1;
            this.btn_logo.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_logo.Location = new System.Drawing.Point(235, 41);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.ShadowDecoration.Parent = this.btn_logo;
            this.btn_logo.Size = new System.Drawing.Size(80, 80);
            this.btn_logo.TabIndex = 17;
            // 
            // btn_empty
            // 
            this.btn_empty.BorderRadius = 8;
            this.btn_empty.CheckedState.Parent = this.btn_empty;
            this.btn_empty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empty.CustomImages.Parent = this.btn_empty;
            this.btn_empty.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_empty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_empty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_empty.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_empty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_empty.DisabledState.Parent = this.btn_empty;
            this.btn_empty.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_empty.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_empty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_empty.ForeColor = System.Drawing.Color.White;
            this.btn_empty.HoverState.Parent = this.btn_empty;
            this.btn_empty.Image = global::GUI.Properties.Resources.trash;
            this.btn_empty.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_empty.Location = new System.Drawing.Point(233, 680);
            this.btn_empty.Name = "btn_empty";
            this.btn_empty.ShadowDecoration.Parent = this.btn_empty;
            this.btn_empty.Size = new System.Drawing.Size(50, 45);
            this.btn_empty.TabIndex = 16;
            this.btn_empty.Click += new System.EventHandler(this.btn_empty_Click);
            // 
            // btn_attach
            // 
            this.btn_attach.BorderRadius = 8;
            this.btn_attach.CheckedState.Parent = this.btn_attach;
            this.btn_attach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_attach.CustomImages.Parent = this.btn_attach;
            this.btn_attach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_attach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_attach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_attach.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_attach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_attach.DisabledState.Parent = this.btn_attach;
            this.btn_attach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_attach.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_attach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_attach.ForeColor = System.Drawing.Color.White;
            this.btn_attach.HoverState.Parent = this.btn_attach;
            this.btn_attach.Image = global::GUI.Properties.Resources.attach_file;
            this.btn_attach.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_attach.Location = new System.Drawing.Point(164, 680);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.ShadowDecoration.Parent = this.btn_attach;
            this.btn_attach.Size = new System.Drawing.Size(50, 45);
            this.btn_attach.TabIndex = 12;
            this.btn_attach.Click += new System.EventHandler(this.btn_attach_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.panel8.Location = new System.Drawing.Point(21, 171);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(535, 1);
            this.panel8.TabIndex = 15;
            // 
            // txb_to
            // 
            this.txb_to.BorderThickness = 0;
            this.txb_to.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_to.DefaultText = "";
            this.txb_to.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_to.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_to.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_to.DisabledState.Parent = this.txb_to;
            this.txb_to.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_to.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txb_to.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_to.FocusedState.Parent = this.txb_to;
            this.txb_to.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_to.ForeColor = System.Drawing.Color.White;
            this.txb_to.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_to.HoverState.Parent = this.txb_to;
            this.txb_to.Location = new System.Drawing.Point(21, 123);
            this.txb_to.Name = "txb_to";
            this.txb_to.PasswordChar = '\0';
            this.txb_to.PlaceholderText = "Gửi đến";
            this.txb_to.SelectedText = "";
            this.txb_to.ShadowDecoration.Parent = this.txb_to;
            this.txb_to.Size = new System.Drawing.Size(535, 46);
            this.txb_to.TabIndex = 14;
            this.txb_to.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.panel7.Location = new System.Drawing.Point(21, 230);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(695, 1);
            this.panel7.TabIndex = 13;
            // 
            // txb_subject
            // 
            this.txb_subject.BorderThickness = 0;
            this.txb_subject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_subject.DefaultText = "";
            this.txb_subject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_subject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_subject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_subject.DisabledState.Parent = this.txb_subject;
            this.txb_subject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_subject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txb_subject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_subject.FocusedState.Parent = this.txb_subject;
            this.txb_subject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_subject.ForeColor = System.Drawing.Color.White;
            this.txb_subject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_subject.HoverState.Parent = this.txb_subject;
            this.txb_subject.Location = new System.Drawing.Point(21, 182);
            this.txb_subject.Name = "txb_subject";
            this.txb_subject.PasswordChar = '\0';
            this.txb_subject.PlaceholderText = "Chủ đề";
            this.txb_subject.SelectedText = "";
            this.txb_subject.ShadowDecoration.Parent = this.txb_subject;
            this.txb_subject.Size = new System.Drawing.Size(695, 46);
            this.txb_subject.TabIndex = 12;
            this.txb_subject.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.panel6.Location = new System.Drawing.Point(21, 291);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(695, 1);
            this.panel6.TabIndex = 11;
            // 
            // txb_username
            // 
            this.txb_username.BorderThickness = 0;
            this.txb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_username.DefaultText = "";
            this.txb_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_username.DisabledState.Parent = this.txb_username;
            this.txb_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txb_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_username.FocusedState.Parent = this.txb_username;
            this.txb_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_username.ForeColor = System.Drawing.Color.White;
            this.txb_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_username.HoverState.Parent = this.txb_username;
            this.txb_username.Location = new System.Drawing.Point(21, 243);
            this.txb_username.Name = "txb_username";
            this.txb_username.PasswordChar = '\0';
            this.txb_username.PlaceholderText = "Tài khoản";
            this.txb_username.SelectedText = "";
            this.txb_username.ShadowDecoration.Parent = this.txb_username;
            this.txb_username.Size = new System.Drawing.Size(695, 46);
            this.txb_username.TabIndex = 10;
            this.txb_username.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.panel5.Location = new System.Drawing.Point(21, 354);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(695, 1);
            this.panel5.TabIndex = 9;
            // 
            // txb_password
            // 
            this.txb_password.BorderThickness = 0;
            this.txb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_password.DefaultText = "";
            this.txb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.DisabledState.Parent = this.txb_password;
            this.txb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.FocusedState.Parent = this.txb_password;
            this.txb_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_password.ForeColor = System.Drawing.Color.White;
            this.txb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.HoverState.Parent = this.txb_password;
            this.txb_password.Location = new System.Drawing.Point(21, 306);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '\0';
            this.txb_password.PlaceholderText = "Mật khẩu";
            this.txb_password.SelectedText = "";
            this.txb_password.ShadowDecoration.Parent = this.txb_password;
            this.txb_password.Size = new System.Drawing.Size(695, 46);
            this.txb_password.TabIndex = 8;
            this.txb_password.TextOffset = new System.Drawing.Point(0, 10);
            this.txb_password.UseSystemPasswordChar = true;
            // 
            // btn_send
            // 
            this.btn_send.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.btn_send.BorderRadius = 4;
            this.btn_send.BorderThickness = 1;
            this.btn_send.CheckedState.Parent = this.btn_send;
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.CustomImages.Parent = this.btn_send;
            this.btn_send.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_send.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_send.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_send.DisabledState.Parent = this.btn_send;
            this.btn_send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_send.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.HoverState.Parent = this.btn_send;
            this.btn_send.Location = new System.Drawing.Point(21, 680);
            this.btn_send.Name = "btn_send";
            this.btn_send.ShadowDecoration.Parent = this.btn_send;
            this.btn_send.Size = new System.Drawing.Size(123, 45);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txb_mes
            // 
            this.txb_mes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.txb_mes.BorderRadius = 8;
            this.txb_mes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_mes.DefaultText = "";
            this.txb_mes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_mes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_mes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_mes.DisabledState.Parent = this.txb_mes;
            this.txb_mes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_mes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txb_mes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_mes.FocusedState.Parent = this.txb_mes;
            this.txb_mes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_mes.ForeColor = System.Drawing.Color.White;
            this.txb_mes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_mes.HoverState.Parent = this.txb_mes;
            this.txb_mes.Location = new System.Drawing.Point(21, 378);
            this.txb_mes.Multiline = true;
            this.txb_mes.Name = "txb_mes";
            this.txb_mes.PasswordChar = '\0';
            this.txb_mes.PlaceholderText = "Nội dung ...";
            this.txb_mes.SelectedText = "";
            this.txb_mes.ShadowDecoration.Parent = this.txb_mes;
            this.txb_mes.Size = new System.Drawing.Size(695, 292);
            this.txb_mes.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.panel4.Location = new System.Drawing.Point(734, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 634);
            this.panel4.TabIndex = 1;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "check1.png");
            this.imgList.Images.SetKeyName(1, "check-box-empty.png");
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // txt_info
            // 
            this.txt_info.BorderThickness = 0;
            this.txt_info.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_info.DefaultText = "";
            this.txt_info.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_info.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_info.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_info.DisabledState.Parent = this.txt_info;
            this.txt_info.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_info.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txt_info.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_info.FocusedState.Parent = this.txt_info;
            this.txt_info.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.txt_info.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_info.HoverState.Parent = this.txt_info;
            this.txt_info.IconLeftSize = new System.Drawing.Size(24, 24);
            this.txt_info.Location = new System.Drawing.Point(298, 680);
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.PasswordChar = '\0';
            this.txt_info.PlaceholderText = "";
            this.txt_info.SelectedText = "";
            this.txt_info.ShadowDecoration.Parent = this.txt_info;
            this.txt_info.Size = new System.Drawing.Size(418, 45);
            this.txt_info.TabIndex = 21;
            // 
            // UC_Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Gmail";
            this.Size = new System.Drawing.Size(1147, 736);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Khoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Search;
        private System.Windows.Forms.ImageList imgList;
        private Guna.UI2.WinForms.Guna2TextBox txb_mes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_attach;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox txb_to;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox txb_subject;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox txb_username;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox txb_password;
        private Guna.UI2.WinForms.Guna2GradientButton btn_send;
        private Guna.UI2.WinForms.Guna2GradientButton btn_empty;
        private Guna.UI2.WinForms.Guna2GradientButton btn_logo;
        private System.Windows.Forms.Label lab_header;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch;
        private System.Windows.Forms.OpenFileDialog openFile;
        private Guna.UI2.WinForms.Guna2TextBox txt_info;
    }
}
