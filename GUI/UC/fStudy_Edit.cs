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


namespace GUI.UC
{
    public partial class fStudy_Edit : Form
    {
        public GetValue send;
        public fStudy_Edit(GetValue sender)
        {
            InitializeComponent();
            send = sender;
        }

        public void SetValue(string mssv, string namhoc, string hocky, string mamh, string QT, string GK, string TH, string CK)
        {
            txb_MSSV.Text = mssv;
            txb_NamHoc.Text = namhoc; // Ctrl + Space
            txb_HocKy.Text = hocky;
            lab_MAMH.Text = mamh;
            txb_QT.Text = QT;
            txb_GK.Text = GK;
            txb_TH.Text = TH;
            txb_CK.Text = CK;
        }

        private bool checkDiem(string s)
        {
            #region kiểm tra điểm nhập vào
            try
            {
                if (0 <= float.Parse(s) && float.Parse(s) <= 10 || s == "")
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            #endregion
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void btn_change_Click(object sender, EventArgs e)
        //{
        //
        //}

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (checkDiem(txb_TH.Text) == checkDiem(txb_QT.Text) == 
                checkDiem(txb_GK.Text) == checkDiem(txb_CK.Text) == true)
            {
                Kqht_BUS.Instance.Edit_dtgv(
                    float.Parse(txb_QT.Text), float.Parse(txb_GK.Text), 
                    float.Parse(txb_TH.Text), float.Parse(txb_CK.Text), 
                    txb_MSSV.Text, txb_NamHoc.Text, 
                    txb_HocKy.Text, lab_MAMH.Text);
        
                this.send(txb_QT.Text, txb_GK.Text, txb_TH.Text, txb_CK.Text);
                MessageBox.Show("Thay đổi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }
    }
}
