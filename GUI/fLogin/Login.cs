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
    public partial class Login : Form
    {
        private static Login instance;
        public Login()
        {
            InitializeComponent();
        }

        public static Login Instance
        {
            get { if (instance == null) instance = new Login(); return instance; }
            private set => instance = value;
        }

        // Nút đóng
        private void fLogin_Login_btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Nút signup
        private void fLogin_Login_btn_signup_Click(object sender, EventArgs e)
        {
            LoginSignUp lgnSU = new LoginSignUp();
            Hide();
            lgnSU.ShowDialog();
        }


        // Nút Log in
        private void fLogin_Login_btn_login_Click(object sender, EventArgs e)
        {
            string username = fLogin_Login_txb_username.Text;
            string password = fLogin_Login_txb_password.Text;
            if (Login_BUS.Instance.Login_Check(username, password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ username và password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Login_BUS.Instance.Login(username, password))
                {
                    Login_BUS.Instance.Insert_Table_Temp(username);
                    fDashboard.DBoard DBoard = new fDashboard.DBoard();
                    Instance.Hide();
                    DBoard.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }




        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
