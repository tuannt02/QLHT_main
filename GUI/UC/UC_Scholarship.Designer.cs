
namespace GUI.UC
{
    partial class UC_Scholarship
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Scholarship));
            this.UC_AboutUs_txb_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.UC_AboutUs_btn_Search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.UC_AboutUs_btn_All = new Guna.UI2.WinForms.Guna2Button();
            this.UC_AboutUs_btn_Active = new Guna.UI2.WinForms.Guna2Button();
            this.UC_AboutUs_btn_OnLeave = new Guna.UI2.WinForms.Guna2Button();
            this.dtgv_ShowHB = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UC_AboutUs_scrbar_main = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.UC_AboutUs_imgList_ListImg = new System.Windows.Forms.ImageList(this.components);
            this.UC_AboutUs_lab_Rec = new System.Windows.Forms.Label();
            this.UC_AboutUs_lab_Fil = new System.Windows.Forms.Label();
            this.UC_AboutUs_btn_CheckAdmin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ShowHB)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_AboutUs_txb_Search
            // 
            this.UC_AboutUs_txb_Search.BorderRadius = 16;
            this.UC_AboutUs_txb_Search.BorderThickness = 0;
            this.UC_AboutUs_txb_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UC_AboutUs_txb_Search.DefaultText = "";
            this.UC_AboutUs_txb_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UC_AboutUs_txb_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UC_AboutUs_txb_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UC_AboutUs_txb_Search.DisabledState.Parent = this.UC_AboutUs_txb_Search;
            this.UC_AboutUs_txb_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UC_AboutUs_txb_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.UC_AboutUs_txb_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_AboutUs_txb_Search.FocusedState.Parent = this.UC_AboutUs_txb_Search;
            this.UC_AboutUs_txb_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UC_AboutUs_txb_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UC_AboutUs_txb_Search.HoverState.Parent = this.UC_AboutUs_txb_Search;
            this.UC_AboutUs_txb_Search.Location = new System.Drawing.Point(21, 20);
            this.UC_AboutUs_txb_Search.Name = "UC_AboutUs_txb_Search";
            this.UC_AboutUs_txb_Search.PasswordChar = '\0';
            this.UC_AboutUs_txb_Search.PlaceholderText = "Search";
            this.UC_AboutUs_txb_Search.SelectedText = "";
            this.UC_AboutUs_txb_Search.ShadowDecoration.Parent = this.UC_AboutUs_txb_Search;
            this.UC_AboutUs_txb_Search.Size = new System.Drawing.Size(215, 50);
            this.UC_AboutUs_txb_Search.TabIndex = 5;
            this.UC_AboutUs_txb_Search.TextChanged += new System.EventHandler(this.UC_AboutUs_btn_Search_Click);
            // 
            // UC_AboutUs_btn_Search
            // 
            this.UC_AboutUs_btn_Search.CheckedState.Parent = this.UC_AboutUs_btn_Search;
            this.UC_AboutUs_btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_AboutUs_btn_Search.CustomImages.Parent = this.UC_AboutUs_btn_Search;
            this.UC_AboutUs_btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_AboutUs_btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UC_AboutUs_btn_Search.DisabledState.Parent = this.UC_AboutUs_btn_Search;
            this.UC_AboutUs_btn_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UC_AboutUs_btn_Search.ForeColor = System.Drawing.Color.White;
            this.UC_AboutUs_btn_Search.HoverState.Parent = this.UC_AboutUs_btn_Search;
            this.UC_AboutUs_btn_Search.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.UC_AboutUs_btn_Search.ImageOffset = new System.Drawing.Point(1, 0);
            this.UC_AboutUs_btn_Search.Location = new System.Drawing.Point(251, 20);
            this.UC_AboutUs_btn_Search.Name = "UC_AboutUs_btn_Search";
            this.UC_AboutUs_btn_Search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UC_AboutUs_btn_Search.ShadowDecoration.Parent = this.UC_AboutUs_btn_Search;
            this.UC_AboutUs_btn_Search.Size = new System.Drawing.Size(50, 50);
            this.UC_AboutUs_btn_Search.TabIndex = 6;
            this.UC_AboutUs_btn_Search.Click += new System.EventHandler(this.UC_AboutUs_btn_Search_Click);
            // 
            // UC_AboutUs_btn_All
            // 
            this.UC_AboutUs_btn_All.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_All.BorderRadius = 20;
            this.UC_AboutUs_btn_All.BorderThickness = 2;
            this.UC_AboutUs_btn_All.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UC_AboutUs_btn_All.Checked = true;
            this.UC_AboutUs_btn_All.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_All.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_All.CheckedState.Parent = this.UC_AboutUs_btn_All;
            this.UC_AboutUs_btn_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_AboutUs_btn_All.CustomImages.Parent = this.UC_AboutUs_btn_All;
            this.UC_AboutUs_btn_All.CustomizableEdges.BottomRight = false;
            this.UC_AboutUs_btn_All.CustomizableEdges.TopRight = false;
            this.UC_AboutUs_btn_All.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_All.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_All.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_AboutUs_btn_All.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UC_AboutUs_btn_All.DisabledState.Parent = this.UC_AboutUs_btn_All;
            this.UC_AboutUs_btn_All.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UC_AboutUs_btn_All.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UC_AboutUs_btn_All.ForeColor = System.Drawing.Color.White;
            this.UC_AboutUs_btn_All.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_All.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_All.HoverState.Parent = this.UC_AboutUs_btn_All;
            this.UC_AboutUs_btn_All.Location = new System.Drawing.Point(838, 20);
            this.UC_AboutUs_btn_All.Name = "UC_AboutUs_btn_All";
            this.UC_AboutUs_btn_All.ShadowDecoration.Parent = this.UC_AboutUs_btn_All;
            this.UC_AboutUs_btn_All.Size = new System.Drawing.Size(85, 50);
            this.UC_AboutUs_btn_All.TabIndex = 7;
            this.UC_AboutUs_btn_All.Text = "All";
            this.UC_AboutUs_btn_All.Click += new System.EventHandler(this.UC_AboutUs_btn_All_Click);
            // 
            // UC_AboutUs_btn_Active
            // 
            this.UC_AboutUs_btn_Active.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_Active.BorderRadius = 20;
            this.UC_AboutUs_btn_Active.BorderThickness = 2;
            this.UC_AboutUs_btn_Active.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UC_AboutUs_btn_Active.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_Active.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_Active.CheckedState.Parent = this.UC_AboutUs_btn_Active;
            this.UC_AboutUs_btn_Active.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_AboutUs_btn_Active.CustomImages.Parent = this.UC_AboutUs_btn_Active;
            this.UC_AboutUs_btn_Active.CustomizableEdges.BottomLeft = false;
            this.UC_AboutUs_btn_Active.CustomizableEdges.BottomRight = false;
            this.UC_AboutUs_btn_Active.CustomizableEdges.TopLeft = false;
            this.UC_AboutUs_btn_Active.CustomizableEdges.TopRight = false;
            this.UC_AboutUs_btn_Active.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_Active.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_Active.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_AboutUs_btn_Active.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UC_AboutUs_btn_Active.DisabledState.Parent = this.UC_AboutUs_btn_Active;
            this.UC_AboutUs_btn_Active.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UC_AboutUs_btn_Active.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UC_AboutUs_btn_Active.ForeColor = System.Drawing.Color.White;
            this.UC_AboutUs_btn_Active.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_Active.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_Active.HoverState.Parent = this.UC_AboutUs_btn_Active;
            this.UC_AboutUs_btn_Active.Location = new System.Drawing.Point(923, 20);
            this.UC_AboutUs_btn_Active.Name = "UC_AboutUs_btn_Active";
            this.UC_AboutUs_btn_Active.ShadowDecoration.Parent = this.UC_AboutUs_btn_Active;
            this.UC_AboutUs_btn_Active.Size = new System.Drawing.Size(82, 50);
            this.UC_AboutUs_btn_Active.TabIndex = 8;
            this.UC_AboutUs_btn_Active.Text = "Active";
            this.UC_AboutUs_btn_Active.Click += new System.EventHandler(this.UC_AboutUs_btn_Active_Click);
            // 
            // UC_AboutUs_btn_OnLeave
            // 
            this.UC_AboutUs_btn_OnLeave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_OnLeave.BorderRadius = 20;
            this.UC_AboutUs_btn_OnLeave.BorderThickness = 2;
            this.UC_AboutUs_btn_OnLeave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UC_AboutUs_btn_OnLeave.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_OnLeave.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_OnLeave.CheckedState.Parent = this.UC_AboutUs_btn_OnLeave;
            this.UC_AboutUs_btn_OnLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UC_AboutUs_btn_OnLeave.CustomImages.Parent = this.UC_AboutUs_btn_OnLeave;
            this.UC_AboutUs_btn_OnLeave.CustomizableEdges.BottomLeft = false;
            this.UC_AboutUs_btn_OnLeave.CustomizableEdges.TopLeft = false;
            this.UC_AboutUs_btn_OnLeave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_OnLeave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_OnLeave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_AboutUs_btn_OnLeave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UC_AboutUs_btn_OnLeave.DisabledState.Parent = this.UC_AboutUs_btn_OnLeave;
            this.UC_AboutUs_btn_OnLeave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.UC_AboutUs_btn_OnLeave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UC_AboutUs_btn_OnLeave.ForeColor = System.Drawing.Color.White;
            this.UC_AboutUs_btn_OnLeave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_OnLeave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_OnLeave.HoverState.Parent = this.UC_AboutUs_btn_OnLeave;
            this.UC_AboutUs_btn_OnLeave.Location = new System.Drawing.Point(1004, 20);
            this.UC_AboutUs_btn_OnLeave.Name = "UC_AboutUs_btn_OnLeave";
            this.UC_AboutUs_btn_OnLeave.ShadowDecoration.Parent = this.UC_AboutUs_btn_OnLeave;
            this.UC_AboutUs_btn_OnLeave.Size = new System.Drawing.Size(105, 50);
            this.UC_AboutUs_btn_OnLeave.TabIndex = 9;
            this.UC_AboutUs_btn_OnLeave.Text = "On leave";
            this.UC_AboutUs_btn_OnLeave.Click += new System.EventHandler(this.UC_AboutUs_btn_OnLeave_Click);
            // 
            // dtgv_ShowHB
            // 
            this.dtgv_ShowHB.AllowUserToAddRows = false;
            this.dtgv_ShowHB.AllowUserToDeleteRows = false;
            this.dtgv_ShowHB.AllowUserToOrderColumns = true;
            this.dtgv_ShowHB.AllowUserToResizeRows = false;
            this.dtgv_ShowHB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ShowHB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtgv_ShowHB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_ShowHB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgv_ShowHB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_ShowHB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_ShowHB.ColumnHeadersHeight = 40;
            this.dtgv_ShowHB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_ShowHB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_ShowHB.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_ShowHB.EnableHeadersVisualStyles = false;
            this.dtgv_ShowHB.Location = new System.Drawing.Point(21, 124);
            this.dtgv_ShowHB.MultiSelect = false;
            this.dtgv_ShowHB.Name = "dtgv_ShowHB";
            this.dtgv_ShowHB.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_ShowHB.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_ShowHB.RowHeadersVisible = false;
            this.dtgv_ShowHB.RowHeadersWidth = 62;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtgv_ShowHB.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_ShowHB.RowTemplate.Height = 50;
            this.dtgv_ShowHB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_ShowHB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ShowHB.Size = new System.Drawing.Size(1088, 473);
            this.dtgv_ShowHB.TabIndex = 10;
            this.dtgv_ShowHB.SelectionChanged += new System.EventHandler(this.UC_AboutUs_dtgv_Show_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 11.36947F;
            this.Column1.HeaderText = "MAHB";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 25.74703F;
            this.Column2.HeaderText = "Tên học bổng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 10.12965F;
            this.Column3.HeaderText = "Trị giá";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.FillWeight = 11.46129F;
            this.Column4.HeaderText = "TGDK";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.FillWeight = 10.54326F;
            this.Column5.HeaderText = "TGKT";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 8.479889F;
            this.Column6.HeaderText = "Active";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 21.31482F;
            this.Column7.HeaderText = "Nhà tài trợ";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // UC_AboutUs_scrbar_main
            // 
            this.UC_AboutUs_scrbar_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_AboutUs_scrbar_main.AutoRoundedCorners = true;
            this.UC_AboutUs_scrbar_main.BindingContainer = this.dtgv_ShowHB;
            this.UC_AboutUs_scrbar_main.BorderRadius = 12;
            this.UC_AboutUs_scrbar_main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.UC_AboutUs_scrbar_main.HoverState.Parent = null;
            this.UC_AboutUs_scrbar_main.InUpdate = false;
            this.UC_AboutUs_scrbar_main.LargeChange = 10;
            this.UC_AboutUs_scrbar_main.Location = new System.Drawing.Point(1083, 124);
            this.UC_AboutUs_scrbar_main.Minimum = 1;
            this.UC_AboutUs_scrbar_main.Name = "UC_AboutUs_scrbar_main";
            this.UC_AboutUs_scrbar_main.PressedState.Parent = this.UC_AboutUs_scrbar_main;
            this.UC_AboutUs_scrbar_main.ScrollbarSize = 26;
            this.UC_AboutUs_scrbar_main.Size = new System.Drawing.Size(26, 473);
            this.UC_AboutUs_scrbar_main.TabIndex = 11;
            this.UC_AboutUs_scrbar_main.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_scrbar_main.Value = 1;
            // 
            // UC_AboutUs_imgList_ListImg
            // 
            this.UC_AboutUs_imgList_ListImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("UC_AboutUs_imgList_ListImg.ImageStream")));
            this.UC_AboutUs_imgList_ListImg.TransparentColor = System.Drawing.Color.Transparent;
            this.UC_AboutUs_imgList_ListImg.Images.SetKeyName(0, "check.png");
            this.UC_AboutUs_imgList_ListImg.Images.SetKeyName(1, "close.png");
            // 
            // UC_AboutUs_lab_Rec
            // 
            this.UC_AboutUs_lab_Rec.AutoSize = true;
            this.UC_AboutUs_lab_Rec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_AboutUs_lab_Rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UC_AboutUs_lab_Rec.Location = new System.Drawing.Point(17, 88);
            this.UC_AboutUs_lab_Rec.Name = "UC_AboutUs_lab_Rec";
            this.UC_AboutUs_lab_Rec.Size = new System.Drawing.Size(110, 28);
            this.UC_AboutUs_lab_Rec.TabIndex = 12;
            this.UC_AboutUs_lab_Rec.Text = "Records: 0";
            // 
            // UC_AboutUs_lab_Fil
            // 
            this.UC_AboutUs_lab_Fil.AutoSize = true;
            this.UC_AboutUs_lab_Fil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_AboutUs_lab_Fil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UC_AboutUs_lab_Fil.Location = new System.Drawing.Point(151, 88);
            this.UC_AboutUs_lab_Fil.Name = "UC_AboutUs_lab_Fil";
            this.UC_AboutUs_lab_Fil.Size = new System.Drawing.Size(85, 28);
            this.UC_AboutUs_lab_Fil.TabIndex = 13;
            this.UC_AboutUs_lab_Fil.Text = "Filter: 0";
            // 
            // UC_AboutUs_btn_CheckAdmin
            // 
            this.UC_AboutUs_btn_CheckAdmin.BorderRadius = 20;
            this.UC_AboutUs_btn_CheckAdmin.CheckedState.Parent = this.UC_AboutUs_btn_CheckAdmin;
            this.UC_AboutUs_btn_CheckAdmin.CustomImages.Parent = this.UC_AboutUs_btn_CheckAdmin;
            this.UC_AboutUs_btn_CheckAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_CheckAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UC_AboutUs_btn_CheckAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_AboutUs_btn_CheckAdmin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UC_AboutUs_btn_CheckAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UC_AboutUs_btn_CheckAdmin.DisabledState.Parent = this.UC_AboutUs_btn_CheckAdmin;
            this.UC_AboutUs_btn_CheckAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_CheckAdmin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.UC_AboutUs_btn_CheckAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_AboutUs_btn_CheckAdmin.ForeColor = System.Drawing.Color.White;
            this.UC_AboutUs_btn_CheckAdmin.HoverState.Parent = this.UC_AboutUs_btn_CheckAdmin;
            this.UC_AboutUs_btn_CheckAdmin.Location = new System.Drawing.Point(838, 629);
            this.UC_AboutUs_btn_CheckAdmin.Name = "UC_AboutUs_btn_CheckAdmin";
            this.UC_AboutUs_btn_CheckAdmin.ShadowDecoration.Parent = this.UC_AboutUs_btn_CheckAdmin;
            this.UC_AboutUs_btn_CheckAdmin.Size = new System.Drawing.Size(208, 45);
            this.UC_AboutUs_btn_CheckAdmin.TabIndex = 14;
            this.UC_AboutUs_btn_CheckAdmin.Text = "Xác nhận Admin";
            this.UC_AboutUs_btn_CheckAdmin.Click += new System.EventHandler(this.UC_AboutUs_btn_CheckAdmin_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // UC_Scholarship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.UC_AboutUs_btn_CheckAdmin);
            this.Controls.Add(this.UC_AboutUs_lab_Fil);
            this.Controls.Add(this.UC_AboutUs_lab_Rec);
            this.Controls.Add(this.UC_AboutUs_scrbar_main);
            this.Controls.Add(this.dtgv_ShowHB);
            this.Controls.Add(this.UC_AboutUs_btn_OnLeave);
            this.Controls.Add(this.UC_AboutUs_btn_Active);
            this.Controls.Add(this.UC_AboutUs_btn_All);
            this.Controls.Add(this.UC_AboutUs_btn_Search);
            this.Controls.Add(this.UC_AboutUs_txb_Search);
            this.Name = "UC_Scholarship";
            this.Size = new System.Drawing.Size(1147, 710);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ShowHB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox UC_AboutUs_txb_Search;
        private Guna.UI2.WinForms.Guna2CircleButton UC_AboutUs_btn_Search;
        private Guna.UI2.WinForms.Guna2Button UC_AboutUs_btn_All;
        private Guna.UI2.WinForms.Guna2Button UC_AboutUs_btn_Active;
        private Guna.UI2.WinForms.Guna2Button UC_AboutUs_btn_OnLeave;
        private System.Windows.Forms.DataGridView dtgv_ShowHB;
        private Guna.UI2.WinForms.Guna2VScrollBar UC_AboutUs_scrbar_main;
        private System.Windows.Forms.ImageList UC_AboutUs_imgList_ListImg;
        private System.Windows.Forms.Label UC_AboutUs_lab_Rec;
        private System.Windows.Forms.Label UC_AboutUs_lab_Fil;
        private Guna.UI2.WinForms.Guna2GradientButton UC_AboutUs_btn_CheckAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Timer timer;
    }
}
