using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.fDashboard
{
    public partial class DBoard : Form
    {
        public DBoard()
        {
            InitializeComponent();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
           // UC.UC_AboutUs.
        }

        private void uC_AboutUs1_Load(object sender, EventArgs e)
        {

        }

        private void fDashboard_DBoard_btn_Dashboard_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Dashboard.Checked) uC_Dashboard1.BringToFront();
        }

        private void fDashboard_DBoard_btn_Scholarship_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Scholarship.Checked) uC_Scholarship1.BringToFront();
        }

        private void fDashboard_DBoard_btn_Study_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Study.Checked) uC_Study1.BringToFront();
        }

        private void fDashboard_DBoard_btn_Setting_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Setting.Checked) uC_Setting1.BringToFront();
        }

        private void fDashboard_DBoard_btn_AboutUs_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_AboutUs.Checked) uC_AboutUs1.BringToFront();
        }
    }
}
