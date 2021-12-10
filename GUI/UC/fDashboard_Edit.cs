using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;


namespace GUI.UC
{
    public partial class fDashboard_Edit : Form
    {
        public fDashboard_Edit()
        {
            InitializeComponent();
            Load_GHICHU();
            cb_MAMH.SelectedIndex = 0;
        }

        public void Load_GHICHU()
        {
            string MSSV = DBoard_BUS.Instance.GetMSSV();
            string GhiChu = DBoard_BUS.Instance.Load_GHICHU(MSSV);

            txb_Ghichu.Text = GhiChu; 

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string MSSV = DBoard_BUS.Instance.GetMSSV();

            if (txb_NoiDung.Text == "")
                MessageBox.Show("Vui lòng nhập nội dung", "Thông báo");
            else
            {
                UC_Dashboard.flagUpdate = true;
                DBoard_BUS.Instance.AddDL(MSSV, cb_MAMH.SelectedItem.ToString(), dtpk_NGKT.Value,
                    txb_NoiDung.Text, chHT.Checked ? 1 : 0);
                DBoard_BUS.Instance.UpdateGhiChu(MSSV,txb_Ghichu.Text);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
        }
    }
}
