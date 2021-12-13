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
        // Nếu form đang mở flag = true, tránh tràn lỗi từ form UC_Scho đổ qua.
        public static bool flag = false;

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
            try
            {
                if (s == "") return true;
                if (0 <= float.Parse(s) && float.Parse(s) <= 10)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            flag = false;
            Close();
        }

        //private void btn_change_Click(object sender, EventArgs e)
        //{
        //
        //}

        private void btn_change_Click(object sender, EventArgs e)
        {
            //if (checkDiem(txb_TH.Text) == checkDiem(txb_QT.Text) == 
            //    checkDiem(txb_GK.Text) == checkDiem(txb_CK.Text) == true)
            //{
            //    Kqht_BUS.Instance.Edit_dtgv(
            //        float.Parse(txb_QT.Text), float.Parse(txb_GK.Text), 
            //        float.Parse(txb_TH.Text), float.Parse(txb_CK.Text), 
            //        txb_MSSV.Text, txb_NamHoc.Text, 
            //        txb_HocKy.Text, lab_MAMH.Text);
            //
            //    this.send(txb_QT.Text, txb_GK.Text, txb_TH.Text, txb_CK.Text);
            //    MessageBox.Show("Thay đổi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            if (txb_NamHoc.Text != "" && txb_HocKy.Text != "" && txb_MSSV.Text != "")
                if (checkDiem(txb_TH.Text) && checkDiem(txb_QT.Text) &&
                    checkDiem(txb_GK.Text) && checkDiem(txb_CK.Text))
                {
                    if (string.IsNullOrEmpty(txb_MSSV.Text) || string.IsNullOrEmpty(txb_NamHoc.Text) || string.IsNullOrEmpty(txb_HocKy.Text))
                        return;
                    string QT, GK, TH, CK;
                    QT = GK = TH = CK = null;
                    if (!string.IsNullOrEmpty(txb_QT.Text))
                        QT = txb_QT.Text;
                    if (!string.IsNullOrEmpty(txb_GK.Text))
                        GK = txb_GK.Text;
                    if (!string.IsNullOrEmpty(txb_TH.Text))
                        TH = txb_TH.Text;
                    if (!string.IsNullOrEmpty(txb_CK.Text))
                        CK = txb_CK.Text;
                    Kqht_BUS.Instance.Edit_dtgv(QT, GK, TH, CK, txb_MSSV.Text, txb_NamHoc.Text, txb_HocKy.Text, lab_MAMH.Text);

                    this.send(txb_QT.Text, txb_GK.Text, txb_TH.Text, txb_CK.Text);
                    MessageBox.Show("Thay đổi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Điểm phải >= 0 và <= 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
        }
    }
}
