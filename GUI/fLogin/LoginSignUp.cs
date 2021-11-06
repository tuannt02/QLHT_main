using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.fLogin
{
    public partial class LoginSignUp : Form
    {
        public LoginSignUp()
        {
            InitializeComponent();
        }

        private void fLogin_LoginSignUp_btn_backto_Click(object sender, EventArgs e)
        {
            Hide();
            Login.Instance.Show();
        }
    }
}
