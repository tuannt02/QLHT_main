
namespace GUI.UC
{
    partial class fAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlert));
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.picbox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lab_submes = new System.Windows.Forms.Label();
            this.effect = new System.Windows.Forms.Timer(this.components);
            this.transtart = new System.Windows.Forms.Timer(this.components);
            this.lab_mes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ContainerControl = this;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_close
            // 
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.DisabledState.Parent = this.btn_close;
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Image = global::GUI.Properties.Resources.close2;
            this.btn_close.Location = new System.Drawing.Point(438, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(24, 24);
            this.btn_close.TabIndex = 2;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // picbox
            // 
            this.picbox.Image = global::GUI.Properties.Resources.warning;
            this.picbox.ImageRotate = 0F;
            this.picbox.Location = new System.Drawing.Point(21, 36);
            this.picbox.Name = "picbox";
            this.picbox.ShadowDecoration.Parent = this.picbox;
            this.picbox.Size = new System.Drawing.Size(48, 48);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            // 
            // lab_submes
            // 
            this.lab_submes.AutoSize = true;
            this.lab_submes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_submes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_submes.Location = new System.Drawing.Point(320, 95);
            this.lab_submes.Name = "lab_submes";
            this.lab_submes.Size = new System.Drawing.Size(137, 25);
            this.lab_submes.TabIndex = 4;
            this.lab_submes.Text = "Còn lại 2 ngày";
            // 
            // effect
            // 
            this.effect.Tick += new System.EventHandler(this.effect_Tick);
            // 
            // transtart
            // 
            this.transtart.Enabled = true;
            this.transtart.Interval = 9000;
            this.transtart.Tick += new System.EventHandler(this.transtart_Tick);
            // 
            // lab_mes
            // 
            this.lab_mes.BackColor = System.Drawing.Color.SeaGreen;
            this.lab_mes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lab_mes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lab_mes.ForeColor = System.Drawing.Color.White;
            this.lab_mes.Location = new System.Drawing.Point(87, 29);
            this.lab_mes.Multiline = true;
            this.lab_mes.Name = "lab_mes";
            this.lab_mes.Size = new System.Drawing.Size(345, 63);
            this.lab_mes.TabIndex = 5;
            this.lab_mes.Text = "IT001: Nộp bài tập tuần 6";
            // 
            // fAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(474, 127);
            this.Controls.Add(this.lab_mes);
            this.Controls.Add(this.lab_submes);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.picbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAlert";
            this.Opacity = 0.9D;
            this.Text = "fAlert";
            this.Load += new System.EventHandler(this.fAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2PictureBox picbox;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lab_submes;
        private System.Windows.Forms.Timer effect;
        private System.Windows.Forms.Timer transtart;
        private System.Windows.Forms.TextBox lab_mes;
    }
}