
namespace GUI.UC
{
    partial class UC_Dashboard
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
            this.lab_today = new System.Windows.Forms.Label();
            this.panel_weather = new Guna.UI2.WinForms.Guna2Panel();
            this.lab_location = new System.Windows.Forms.Label();
            this.panel_press = new Guna.UI2.WinForms.Guna2Panel();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.lab_resultPress = new System.Windows.Forms.Label();
            this.panel_visi = new Guna.UI2.WinForms.Guna2Panel();
            this.lab_resultVis = new System.Windows.Forms.Label();
            this.lab_visibility = new System.Windows.Forms.Label();
            this.panel_huma = new Guna.UI2.WinForms.Guna2Panel();
            this.lab_resultHuma = new System.Windows.Forms.Label();
            this.lab_humadity = new System.Windows.Forms.Label();
            this.txt_C = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_location = new System.Windows.Forms.PictureBox();
            this.panel_weather.SuspendLayout();
            this.panel_press.SuspendLayout();
            this.panel_visi.SuspendLayout();
            this.panel_huma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_location)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_today
            // 
            this.lab_today.AutoSize = true;
            this.lab_today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lab_today.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_today.ForeColor = System.Drawing.Color.White;
            this.lab_today.Location = new System.Drawing.Point(18, 16);
            this.lab_today.Name = "lab_today";
            this.lab_today.Size = new System.Drawing.Size(79, 32);
            this.lab_today.TabIndex = 4;
            this.lab_today.Text = "Today";
            // 
            // panel_weather
            // 
            this.panel_weather.BorderRadius = 16;
            this.panel_weather.Controls.Add(this.panel_huma);
            this.panel_weather.Controls.Add(this.panel_visi);
            this.panel_weather.Controls.Add(this.panel_press);
            this.panel_weather.Controls.Add(this.txt_C);
            this.panel_weather.Controls.Add(this.pic_location);
            this.panel_weather.Controls.Add(this.lab_location);
            this.panel_weather.Controls.Add(this.lab_today);
            this.panel_weather.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_weather.Location = new System.Drawing.Point(730, 19);
            this.panel_weather.Name = "panel_weather";
            this.panel_weather.ShadowDecoration.Parent = this.panel_weather;
            this.panel_weather.Size = new System.Drawing.Size(391, 288);
            this.panel_weather.TabIndex = 5;
            // 
            // lab_location
            // 
            this.lab_location.AutoSize = true;
            this.lab_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lab_location.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(162)))), ((int)(((byte)(85)))));
            this.lab_location.Location = new System.Drawing.Point(54, 63);
            this.lab_location.Name = "lab_location";
            this.lab_location.Size = new System.Drawing.Size(156, 21);
            this.lab_location.TabIndex = 5;
            this.lab_location.Text = "Qui Nhon, Binh Dinh";
            // 
            // panel_press
            // 
            this.panel_press.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_press.BorderRadius = 16;
            this.panel_press.Controls.Add(this.lab_resultPress);
            this.panel_press.Controls.Add(this.lab_pressure);
            this.panel_press.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.panel_press.Location = new System.Drawing.Point(33, 196);
            this.panel_press.Name = "panel_press";
            this.panel_press.ShadowDecoration.Parent = this.panel_press;
            this.panel_press.Size = new System.Drawing.Size(138, 79);
            this.panel_press.TabIndex = 11;
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.lab_pressure.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pressure.ForeColor = System.Drawing.Color.White;
            this.lab_pressure.Location = new System.Drawing.Point(35, 11);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(68, 21);
            this.lab_pressure.TabIndex = 12;
            this.lab_pressure.Text = "Áp thấp";
            // 
            // lab_resultPress
            // 
            this.lab_resultPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.lab_resultPress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_resultPress.ForeColor = System.Drawing.Color.White;
            this.lab_resultPress.Location = new System.Drawing.Point(3, 36);
            this.lab_resultPress.Name = "lab_resultPress";
            this.lab_resultPress.Size = new System.Drawing.Size(132, 32);
            this.lab_resultPress.TabIndex = 13;
            this.lab_resultPress.Text = "800mb";
            this.lab_resultPress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_visi
            // 
            this.panel_visi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_visi.BorderRadius = 16;
            this.panel_visi.Controls.Add(this.lab_resultVis);
            this.panel_visi.Controls.Add(this.lab_visibility);
            this.panel_visi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(106)))));
            this.panel_visi.Location = new System.Drawing.Point(227, 196);
            this.panel_visi.Name = "panel_visi";
            this.panel_visi.ShadowDecoration.Parent = this.panel_visi;
            this.panel_visi.Size = new System.Drawing.Size(138, 79);
            this.panel_visi.TabIndex = 14;
            // 
            // lab_resultVis
            // 
            this.lab_resultVis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(106)))));
            this.lab_resultVis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_resultVis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lab_resultVis.Location = new System.Drawing.Point(3, 36);
            this.lab_resultVis.Name = "lab_resultVis";
            this.lab_resultVis.Size = new System.Drawing.Size(132, 32);
            this.lab_resultVis.TabIndex = 13;
            this.lab_resultVis.Text = "4.3 km";
            this.lab_resultVis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_visibility
            // 
            this.lab_visibility.AutoSize = true;
            this.lab_visibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(106)))));
            this.lab_visibility.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_visibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lab_visibility.Location = new System.Drawing.Point(32, 11);
            this.lab_visibility.Name = "lab_visibility";
            this.lab_visibility.Size = new System.Drawing.Size(76, 21);
            this.lab_visibility.TabIndex = 12;
            this.lab_visibility.Text = "Tầm nhìn";
            // 
            // panel_huma
            // 
            this.panel_huma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_huma.BorderRadius = 16;
            this.panel_huma.Controls.Add(this.lab_resultHuma);
            this.panel_huma.Controls.Add(this.lab_humadity);
            this.panel_huma.FillColor = System.Drawing.Color.White;
            this.panel_huma.Location = new System.Drawing.Point(227, 85);
            this.panel_huma.Name = "panel_huma";
            this.panel_huma.ShadowDecoration.Parent = this.panel_huma;
            this.panel_huma.Size = new System.Drawing.Size(138, 79);
            this.panel_huma.TabIndex = 12;
            // 
            // lab_resultHuma
            // 
            this.lab_resultHuma.BackColor = System.Drawing.Color.White;
            this.lab_resultHuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_resultHuma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lab_resultHuma.Location = new System.Drawing.Point(3, 36);
            this.lab_resultHuma.Name = "lab_resultHuma";
            this.lab_resultHuma.Size = new System.Drawing.Size(132, 32);
            this.lab_resultHuma.TabIndex = 13;
            this.lab_resultHuma.Text = "87%";
            this.lab_resultHuma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_humadity
            // 
            this.lab_humadity.AutoSize = true;
            this.lab_humadity.BackColor = System.Drawing.Color.White;
            this.lab_humadity.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_humadity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lab_humadity.Location = new System.Drawing.Point(39, 9);
            this.lab_humadity.Name = "lab_humadity";
            this.lab_humadity.Size = new System.Drawing.Size(57, 21);
            this.lab_humadity.TabIndex = 12;
            this.lab_humadity.Text = "Độ ẩm";
            // 
            // txt_C
            // 
            this.txt_C.AutoSize = true;
            this.txt_C.BorderThickness = 0;
            this.txt_C.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_C.DefaultText = "30";
            this.txt_C.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_C.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_C.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_C.DisabledState.Parent = this.txt_C;
            this.txt_C.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_C.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_C.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_C.FocusedState.Parent = this.txt_C;
            this.txt_C.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C.ForeColor = System.Drawing.Color.White;
            this.txt_C.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_C.HoverState.Parent = this.txt_C;
            this.txt_C.IconLeft = global::GUI.Properties.Resources._10d;
            this.txt_C.IconLeftOffset = new System.Drawing.Point(0, 5);
            this.txt_C.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txt_C.IconRight = global::GUI.Properties.Resources.celsius_degrees_symbol_of_temperature;
            this.txt_C.IconRightOffset = new System.Drawing.Point(0, -5);
            this.txt_C.Location = new System.Drawing.Point(24, 103);
            this.txt_C.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_C.Name = "txt_C";
            this.txt_C.PasswordChar = '\0';
            this.txt_C.PlaceholderText = "";
            this.txt_C.ReadOnly = true;
            this.txt_C.SelectedText = "";
            this.txt_C.SelectionStart = 2;
            this.txt_C.ShadowDecoration.Parent = this.txt_C;
            this.txt_C.Size = new System.Drawing.Size(169, 59);
            this.txt_C.TabIndex = 10;
            // 
            // pic_location
            // 
            this.pic_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pic_location.Image = global::GUI.Properties.Resources.location_pin;
            this.pic_location.Location = new System.Drawing.Point(24, 60);
            this.pic_location.Name = "pic_location";
            this.pic_location.Size = new System.Drawing.Size(24, 24);
            this.pic_location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_location.TabIndex = 6;
            this.pic_location.TabStop = false;
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panel_weather);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1147, 710);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.panel_weather.ResumeLayout(false);
            this.panel_weather.PerformLayout();
            this.panel_press.ResumeLayout(false);
            this.panel_press.PerformLayout();
            this.panel_visi.ResumeLayout(false);
            this.panel_visi.PerformLayout();
            this.panel_huma.ResumeLayout(false);
            this.panel_huma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_location)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_today;
        private Guna.UI2.WinForms.Guna2Panel panel_weather;
        private System.Windows.Forms.Label lab_location;
        private System.Windows.Forms.PictureBox pic_location;
        private Guna.UI2.WinForms.Guna2TextBox txt_C;
        private Guna.UI2.WinForms.Guna2Panel panel_press;
        private System.Windows.Forms.Label lab_pressure;
        private Guna.UI2.WinForms.Guna2Panel panel_huma;
        private System.Windows.Forms.Label lab_resultHuma;
        private System.Windows.Forms.Label lab_humadity;
        private Guna.UI2.WinForms.Guna2Panel panel_visi;
        private System.Windows.Forms.Label lab_resultVis;
        private System.Windows.Forms.Label lab_visibility;
        private System.Windows.Forms.Label lab_resultPress;
    }
}
