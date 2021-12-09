
namespace GUI.UC
{
    partial class fDashboard_Edit
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
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cb_MAMH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_NoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.dtpk_NGKT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chHT = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Ghichu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.panel4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chHT);
            this.panel1.Controls.Add(this.lab);
            this.panel1.Controls.Add(this.dtpk_NGKT);
            this.panel1.Controls.Add(this.txb_NoiDung);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_MAMH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 433);
            this.panel1.TabIndex = 0;
            // 
            // btn_Update
            // 
            this.btn_Update.BorderRadius = 4;
            this.btn_Update.CheckedState.Parent = this.btn_Update;
            this.btn_Update.CustomImages.Parent = this.btn_Update;
            this.btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Update.DisabledState.Parent = this.btn_Update;
            this.btn_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Update.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.HoverState.Parent = this.btn_Update;
            this.btn_Update.Image = global::GUI.Properties.Resources.refresh;
            this.btn_Update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Update.ImageOffset = new System.Drawing.Point(0, 2);
            this.btn_Update.Location = new System.Drawing.Point(219, 472);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.Parent = this.btn_Update;
            this.btn_Update.Size = new System.Drawing.Size(139, 45);
            this.btn_Update.TabIndex = 38;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // cb_MAMH
            // 
            this.cb_MAMH.BackColor = System.Drawing.Color.Transparent;
            this.cb_MAMH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_MAMH.BorderRadius = 24;
            this.cb_MAMH.BorderThickness = 2;
            this.cb_MAMH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_MAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MAMH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cb_MAMH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_MAMH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_MAMH.FocusedState.Parent = this.cb_MAMH;
            this.cb_MAMH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_MAMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_MAMH.HoverState.Parent = this.cb_MAMH;
            this.cb_MAMH.IntegralHeight = false;
            this.cb_MAMH.ItemHeight = 47;
            this.cb_MAMH.Items.AddRange(new object[] {
            "IT001",
            "IT002",
            "IT003",
            "IT005",
            "IT006",
            "IT007",
            "IT008",
            "IT009",
            "IT010",
            "IT011",
            "IT012",
            "MA005"});
            this.cb_MAMH.ItemsAppearance.Parent = this.cb_MAMH;
            this.cb_MAMH.Location = new System.Drawing.Point(20, 131);
            this.cb_MAMH.Name = "cb_MAMH";
            this.cb_MAMH.ShadowDecoration.Parent = this.cb_MAMH;
            this.cb_MAMH.Size = new System.Drawing.Size(167, 53);
            this.cb_MAMH.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã môn học:";
            // 
            // txb_NoiDung
            // 
            this.txb_NoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txb_NoiDung.BorderRadius = 24;
            this.txb_NoiDung.BorderThickness = 2;
            this.txb_NoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_NoiDung.DefaultText = "";
            this.txb_NoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_NoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_NoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_NoiDung.DisabledState.Parent = this.txb_NoiDung;
            this.txb_NoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_NoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txb_NoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_NoiDung.FocusedState.Parent = this.txb_NoiDung;
            this.txb_NoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_NoiDung.HoverState.Parent = this.txb_NoiDung;
            this.txb_NoiDung.Location = new System.Drawing.Point(20, 239);
            this.txb_NoiDung.Name = "txb_NoiDung";
            this.txb_NoiDung.PasswordChar = '\0';
            this.txb_NoiDung.PlaceholderText = "Nhập nội dung";
            this.txb_NoiDung.SelectedText = "";
            this.txb_NoiDung.ShadowDecoration.Parent = this.txb_NoiDung;
            this.txb_NoiDung.Size = new System.Drawing.Size(324, 53);
            this.txb_NoiDung.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(33, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nội dung:";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lab.Location = new System.Drawing.Point(33, 314);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(137, 25);
            this.lab.TabIndex = 38;
            this.lab.Text = "Ngày kết thúc:";
            // 
            // dtpk_NGKT
            // 
            this.dtpk_NGKT.BorderRadius = 24;
            this.dtpk_NGKT.Checked = true;
            this.dtpk_NGKT.CheckedState.Parent = this.dtpk_NGKT;
            this.dtpk_NGKT.CustomFormat = "dd/MM/yyyy";
            this.dtpk_NGKT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtpk_NGKT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpk_NGKT.ForeColor = System.Drawing.Color.White;
            this.dtpk_NGKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_NGKT.HoverState.Parent = this.dtpk_NGKT;
            this.dtpk_NGKT.Location = new System.Drawing.Point(20, 343);
            this.dtpk_NGKT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpk_NGKT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpk_NGKT.Name = "dtpk_NGKT";
            this.dtpk_NGKT.ShadowDecoration.Parent = this.dtpk_NGKT;
            this.dtpk_NGKT.Size = new System.Drawing.Size(324, 53);
            this.dtpk_NGKT.TabIndex = 37;
            this.dtpk_NGKT.Value = new System.DateTime(2021, 12, 8, 20, 42, 23, 629);
            // 
            // chHT
            // 
            this.chHT.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.chHT.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.chHT.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chHT.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chHT.CheckedState.Parent = this.chHT;
            this.chHT.Location = new System.Drawing.Point(336, 104);
            this.chHT.Name = "chHT";
            this.chHT.ShadowDecoration.Parent = this.chHT;
            this.chHT.Size = new System.Drawing.Size(59, 24);
            this.chHT.TabIndex = 39;
            this.chHT.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chHT.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chHT.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chHT.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.chHT.UncheckedState.Parent = this.chHT;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(204, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Hoàn thành:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(102, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "Thêm DEADLINE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.panel2.Location = new System.Drawing.Point(432, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 433);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_Ghichu);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(439, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 433);
            this.panel3.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(135, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ghi chú";
            // 
            // txb_Ghichu
            // 
            this.txb_Ghichu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txb_Ghichu.BorderRadius = 24;
            this.txb_Ghichu.BorderThickness = 2;
            this.txb_Ghichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_Ghichu.DefaultText = "";
            this.txb_Ghichu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_Ghichu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_Ghichu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Ghichu.DisabledState.Parent = this.txb_Ghichu;
            this.txb_Ghichu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Ghichu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txb_Ghichu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Ghichu.FocusedState.Parent = this.txb_Ghichu;
            this.txb_Ghichu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txb_Ghichu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Ghichu.HoverState.Parent = this.txb_Ghichu;
            this.txb_Ghichu.Location = new System.Drawing.Point(22, 104);
            this.txb_Ghichu.Multiline = true;
            this.txb_Ghichu.Name = "txb_Ghichu";
            this.txb_Ghichu.PasswordChar = '\0';
            this.txb_Ghichu.PlaceholderText = "Nhập ghi chú ...";
            this.txb_Ghichu.SelectedText = "";
            this.txb_Ghichu.ShadowDecoration.Parent = this.txb_Ghichu;
            this.txb_Ghichu.Size = new System.Drawing.Size(324, 292);
            this.txb_Ghichu.TabIndex = 43;
            // 
            // btn_back
            // 
            this.btn_back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.btn_back.BorderRadius = 4;
            this.btn_back.BorderThickness = 1;
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.DisabledState.Parent = this.btn_back;
            this.btn_back.FillColor = System.Drawing.Color.White;
            this.btn_back.FillColor2 = System.Drawing.Color.White;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Location = new System.Drawing.Point(499, 472);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(123, 45);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_back);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.btn_Update);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(823, 544);
            this.panel4.TabIndex = 42;
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.BorderRadius = 8;
            this.BorderlessForm.ContainerControl = this;
            // 
            // fDashboard_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(823, 544);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDashboard_Edit";
            this.Text = "Chỉnh sửa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Update;
        private Guna.UI2.WinForms.Guna2ComboBox cb_MAMH;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txb_NoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpk_NGKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chHT;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txb_Ghichu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_back;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
    }
}