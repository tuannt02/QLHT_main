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
using DTO;


namespace GUI.UC
{
    public partial class UC_Manage : UserControl
    {
        public static bool flagUpdate = false;
        public UC_Manage()
        {
            InitializeComponent();
            LoadDTGV();
        }

        private void UC_Manage_Load(object sender, EventArgs e)
        {

        }
        private void LoadDTGV()
        {
            dtgv.Rows.Clear();
            List<ACCOUNT> listAcc = Manage_BUS.Instance.getListACCOUNT();

            foreach(ACCOUNT item in listAcc)
            {
                dtgv.Rows.Add(new object[]
                {
                    item.USERNAME,
                    item.PASSWORD,
                    item.DISPLAYNAME,
                    item.MSSV,
                    item.ADMIN,
                });
            }
            flagUpdate = false;
        }

        private void LoadTxb(string USERNAME, string PASSWORD, string DISPLAYNAME, string MSSV, bool ADMIN)
        {
                txb_username.Text = USERNAME;
                txb_password.Text = PASSWORD;
                txb_display.Text = DISPLAYNAME;
                txb_MSSV.Text = MSSV;
                ck.Checked = ADMIN;
        }

        private void dtgv_SelectionChanged(object sender, EventArgs e)
        {
            if(dtgv.Rows.Count > 0 && !flagUpdate)
            {
                LoadTxb(
                    dtgv.SelectedRows[0].Cells[0].Value.ToString(),
                    dtgv.SelectedRows[0].Cells[1].Value.ToString(),
                    dtgv.SelectedRows[0].Cells[2].Value.ToString(),
                    dtgv.SelectedRows[0].Cells[3].Value.ToString(),
                    (bool)dtgv.SelectedRows[0].Cells[4].Value
                    );
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txb_username.Text == "" || txb_password.Text == "" || txb_MSSV.Text == "" || txb_display.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            }
            else if (Login_BUS.Instance.LoginSignUp_CheckUsernameExists(txb_username.Text)) 
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
            }
            else if (!Login_BUS.Instance.LoginSignUp_CheckMSSVExitst(txb_MSSV.Text))
            {
                MessageBox.Show("MSSV chưa tồn tại", "Thông báo");
            }
            else
            {
                flagUpdate = true;
                Manage_BUS.Instance.InsertAcc(txb_username.Text, txb_password.Text, txb_display.Text, txb_MSSV.Text, ck.Checked);
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadDTGV();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(txb_username.Text != "" && txb_password.Text == "" && txb_display.Text == "" && txb_MSSV.Text == "")
            {
                if (!Login_BUS.Instance.LoginSignUp_CheckUsernameExists(txb_username.Text))
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo");
                else
                {
                    flagUpdate = true;
                    Manage_BUS.Instance.DeleteAcc(txb_username.Text);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadDTGV();
                }
            }
            else
            {
                MessageBox.Show("Khi xóa chỉ cần nhập tài khoản", "Thông báo");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txb_username.Text == "" || txb_password.Text == "" || txb_MSSV.Text == "" || txb_display.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
            }
            else if(!Login_BUS.Instance.LoginSignUp_CheckUsernameExists(txb_username.Text))
            {
                MessageBox.Show("Tài khoản không tồn tại","Thông báo");
            }
            else if(!Login_BUS.Instance.LoginSignUp_CheckMSSVExitst(txb_MSSV.Text))
            {
                MessageBox.Show("Mã số sinh viên không tồn tại", "Thông báo");
            }
            else
            {
                flagUpdate = true;
                Manage_BUS.Instance.UpdateAcc(txb_username.Text, txb_password.Text, txb_display.Text, txb_MSSV.Text, ck.Checked);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                LoadDTGV();
            }
        }
    }
}
