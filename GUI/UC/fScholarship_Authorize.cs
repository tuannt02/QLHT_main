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
    public partial class fScholarship_Authorize : Form
    {
        public fScholarship_Edit f2 = null;
        public fScholarship_Authorize()
        {
            InitializeComponent();
            lab_warning.Hide();
        }


        #region Events
        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (txb_input.Text == "1234")
            {
                fScholarship_Edit a = new fScholarship_Edit();
                f2 = a;
                fScholarship_Edit.flag = true;
                a.Show();
                Close();
            }
            else lab_warning.Show();
        }
        #endregion

    }
}
