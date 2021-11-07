using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

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

        private void fLogin_LoginSignUp_btn_creAcc_Click(object sender, EventArgs e)
        {
            string MSSV = fLogin_LoginSignUp_txb_mssv.Text;
            string username = fLogin_LoginSignUp_txb_username.Text;
            string password = fLogin_LoginSignUp_txb_password.Text;
            if(Login_BUS.Instance.LoginSignUp_Check(MSSV, username, password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Login_BUS.Instance.LoginSignUp_CheckMSSVExitst(MSSV))
                    MessageBox.Show("MSSV đã tồn tại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Login_BUS.Instance.InsertAcc(MSSV, username, password);
                    MessageBox.Show("Đăng kí thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }

        }
    }
}
