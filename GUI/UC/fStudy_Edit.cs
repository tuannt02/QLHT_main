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
    public partial class fStudy_Edit : Form
    {
        public fStudy_Edit()
        {
            InitializeComponent();
        }

        public void SetValue(string mssv, string namhoc, string hocky, string mamh, string QT, string GK, string TH, string CK)
        {
            fStudy_Edit_txb_MSSV.Text = mssv;
            fStudy_Edit_txb_NamHoc.Text = namhoc; // Ctrl + Space
            fStudy_Edit_txb_HocKy.Text = hocky;
            fStudy_Edit_lab_MAMH.Text = mamh;
            fStudy_Edit_txb_QT.Text = QT;
            fStudy_Edit_txb_GK.Text = GK;
            fStudy_Edit_txb_TH.Text = TH;
            fStudy_Edit_txb_CK.Text = CK;
        }

        //private void btnChange_Click(object sender, EventArgs e)
        //{
        //    if (checkDiem(txbTH.Text) == checkDiem(txbQT.Text) == checkDiem(txbGK.Text) == checkDiem(txbCK.Text) == true)
        //    {
        //        KQHT_BUS.Instance.Edit_dtgv(float.Parse(txbQT.Text), float.Parse(txbGK.Text), float.Parse(txbTH.Text), float.Parse(txbCK.Text), txbMSSV.Text, int.Parse(txbNamHoc.Text), txbHocKy.Text, labMaMH.Text);
        //
        //
        //
        //        this.send(txbQT.Text, txbGK.Text, txbTH.Text, txbCK.Text);
        //
        //
        //
        //        MessageBox.Show("Thay đổi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //
        //
        //
        //    else MessageBox.Show("Thay đổi dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

    }
}
