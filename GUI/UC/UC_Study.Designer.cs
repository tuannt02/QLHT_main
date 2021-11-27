
namespace GUI.UC
{
    partial class UC_Study_Main
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_DanhSach = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.uC_Study1 = new GUI.UC.UC_Study();
            this.uC_Study_ListKhoa1 = new GUI.UC.UC_Study_ListKhoa();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.guna2Panel1.Controls.Add(this.btn_DanhSach);
            this.guna2Panel1.Controls.Add(this.btn_Edit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1147, 55);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btn_DanhSach
            // 
            this.btn_DanhSach.BorderRadius = 8;
            this.btn_DanhSach.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_DanhSach.CheckedState.Parent = this.btn_DanhSach;
            this.btn_DanhSach.CustomImages.Parent = this.btn_DanhSach;
            this.btn_DanhSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DanhSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DanhSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DanhSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DanhSach.DisabledState.Parent = this.btn_DanhSach;
            this.btn_DanhSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_DanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(222)))));
            this.btn_DanhSach.HoverState.Parent = this.btn_DanhSach;
            this.btn_DanhSach.Location = new System.Drawing.Point(141, 3);
            this.btn_DanhSach.Name = "btn_DanhSach";
            this.btn_DanhSach.ShadowDecoration.Parent = this.btn_DanhSach;
            this.btn_DanhSach.Size = new System.Drawing.Size(134, 46);
            this.btn_DanhSach.TabIndex = 1;
            this.btn_DanhSach.Text = "Danh sách";
            this.btn_DanhSach.Click += new System.EventHandler(this.btn_DanhSach_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BorderRadius = 8;
            this.btn_Edit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Edit.Checked = true;
            this.btn_Edit.CheckedState.Parent = this.btn_Edit;
            this.btn_Edit.CustomImages.Parent = this.btn_Edit;
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.DisabledState.Parent = this.btn_Edit;
            this.btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(222)))));
            this.btn_Edit.HoverState.Parent = this.btn_Edit;
            this.btn_Edit.Location = new System.Drawing.Point(1, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.ShadowDecoration.Parent = this.btn_Edit;
            this.btn_Edit.Size = new System.Drawing.Size(134, 46);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // uC_Study1
            // 
            this.uC_Study1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.uC_Study1.Location = new System.Drawing.Point(0, 55);
            this.uC_Study1.Name = "uC_Study1";
            this.uC_Study1.Size = new System.Drawing.Size(1147, 681);
            this.uC_Study1.TabIndex = 2;
            // 
            // uC_Study_ListKhoa1
            // 
            this.uC_Study_ListKhoa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.uC_Study_ListKhoa1.Location = new System.Drawing.Point(0, 55);
            this.uC_Study_ListKhoa1.Name = "uC_Study_ListKhoa1";
            this.uC_Study_ListKhoa1.Size = new System.Drawing.Size(1147, 681);
            this.uC_Study_ListKhoa1.TabIndex = 3;
            // 
            // UC_Study_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_Study1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.uC_Study_ListKhoa1);
            this.Name = "UC_Study_Main";
            this.Size = new System.Drawing.Size(1147, 736);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_DanhSach;
        private UC_Study uC_Study1;
        private UC_Study_ListKhoa uC_Study_ListKhoa1;
    }
}
