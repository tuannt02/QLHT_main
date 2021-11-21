
namespace GUI.UC
{
    partial class fScholarship_Authorize
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
            this.BorderlessF_Auth = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lab_header = new System.Windows.Forms.Label();
            this.txb_subheader = new System.Windows.Forms.TextBox();
            this.txb_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_next = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lab_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BorderlessF_Auth
            // 
            this.BorderlessF_Auth.BorderRadius = 24;
            this.BorderlessF_Auth.ContainerControl = this;
            this.BorderlessF_Auth.ResizeForm = false;
            // 
            // lab_header
            // 
            this.lab_header.AutoSize = true;
            this.lab_header.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.lab_header.Location = new System.Drawing.Point(23, 19);
            this.lab_header.Name = "lab_header";
            this.lab_header.Size = new System.Drawing.Size(208, 38);
            this.lab_header.TabIndex = 0;
            this.lab_header.Text = "Xác thực cấp 2";
            // 
            // txb_subheader
            // 
            this.txb_subheader.BackColor = System.Drawing.Color.White;
            this.txb_subheader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_subheader.Enabled = false;
            this.txb_subheader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_subheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.txb_subheader.Location = new System.Drawing.Point(30, 60);
            this.txb_subheader.Multiline = true;
            this.txb_subheader.Name = "txb_subheader";
            this.txb_subheader.ReadOnly = true;
            this.txb_subheader.Size = new System.Drawing.Size(509, 59);
            this.txb_subheader.TabIndex = 2;
            this.txb_subheader.Text = "Nhập mật khẩu cấp 2 để có thể chỉnh sửa danh sách học bổng.";
            // 
            // txb_input
            // 
            this.txb_input.BorderThickness = 0;
            this.txb_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_input.DefaultText = "";
            this.txb_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_input.DisabledState.Parent = this.txb_input;
            this.txb_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_input.FocusedState.Parent = this.txb_input;
            this.txb_input.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_input.HoverState.Parent = this.txb_input;
            this.txb_input.Location = new System.Drawing.Point(30, 126);
            this.txb_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_input.Name = "txb_input";
            this.txb_input.PasswordChar = '\0';
            this.txb_input.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.txb_input.PlaceholderText = "Nhập ở đây";
            this.txb_input.SelectedText = "";
            this.txb_input.ShadowDecoration.Parent = this.txb_input;
            this.txb_input.Size = new System.Drawing.Size(492, 41);
            this.txb_input.TabIndex = 3;
            this.txb_input.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.panel1.Location = new System.Drawing.Point(30, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 1);
            this.panel1.TabIndex = 4;
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
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(169)))), ((int)(((byte)(187)))));
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Location = new System.Drawing.Point(264, 188);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(123, 45);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.btn_next.BorderRadius = 4;
            this.btn_next.BorderThickness = 1;
            this.btn_next.CheckedState.Parent = this.btn_next;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.CustomImages.Parent = this.btn_next;
            this.btn_next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_next.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_next.DisabledState.Parent = this.btn_next;
            this.btn_next.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_next.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.HoverState.Parent = this.btn_next;
            this.btn_next.Location = new System.Drawing.Point(399, 188);
            this.btn_next.Name = "btn_next";
            this.btn_next.ShadowDecoration.Parent = this.btn_next;
            this.btn_next.Size = new System.Drawing.Size(123, 45);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "Next";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lab_warning
            // 
            this.lab_warning.AutoSize = true;
            this.lab_warning.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_warning.ForeColor = System.Drawing.Color.Red;
            this.lab_warning.Location = new System.Drawing.Point(439, 138);
            this.lab_warning.Name = "lab_warning";
            this.lab_warning.Size = new System.Drawing.Size(83, 25);
            this.lab_warning.TabIndex = 7;
            this.lab_warning.Text = "Nhập sai";
            // 
            // fScholarship_Authorize
            // 
            this.AcceptButton = this.btn_next;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 260);
            this.Controls.Add(this.lab_warning);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txb_input);
            this.Controls.Add(this.txb_subheader);
            this.Controls.Add(this.lab_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fScholarship_Authorize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác thực cấp 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessF_Auth;
        private Guna.UI2.WinForms.Guna2TextBox txb_input;
        private System.Windows.Forms.TextBox txb_subheader;
        private System.Windows.Forms.Label lab_header;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_next;
        private Guna.UI2.WinForms.Guna2GradientButton btn_back;
        private System.Windows.Forms.Label lab_warning;
    }
}