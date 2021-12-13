using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC
{
    public partial class fAlert : Form
    {
        public fAlert(string mes, string submes, AlertType type)
        {
            InitializeComponent();
            lab_mes.Text = mes;
            lab_submes.Text = submes;
            switch (type)
            {
                case AlertType.success:
                    BackColor = Color.SeaGreen;
                    picbox.Image = Properties.Resources.check2;
                    break;
                case AlertType.info:
                    BackColor = Color.Gray;
                    picbox.Image = Properties.Resources.info;
                    lab_submes.ForeColor = Color.White;
                    break;
                case AlertType.warning:
                    BackColor = Color.Crimson;
                    picbox.Image = Properties.Resources.warning;
                    lab_submes.ForeColor = Color.White;
                    lab_mes.BackColor = Color.Crimson;
                    break;
                case AlertType.error:
                    BackColor = Color.FromArgb(255, 128, 0);
                    picbox.Image = Properties.Resources.close2;
                    break;
            }
        }

        private void fAlert_Load(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 75;
            Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 15;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void effect_Tick(object sender, EventArgs e)
        {
            if(Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                Close();
            }
        }

        private void transtart_Tick(object sender, EventArgs e)
        {
            effect.Enabled = true;
        }

        public static void Alert(string mes, string submes, AlertType type)
        {
            fAlert a = new fAlert(mes, submes, type);
            a.Show();
        }

    }

    public enum AlertType
    {
        success, info, warning, error
    }
}
