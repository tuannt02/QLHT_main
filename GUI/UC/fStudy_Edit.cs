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
            txb_MSSV.Text = mssv;
            txb_NamHoc.Text = namhoc; // Ctrl + Space
            txb_HocKy.Text = hocky;
            lab_MAMH.Text = mamh;
            txb_QT.Text = QT;
            txb_GK.Text = GK;
            txb_TH.Text = TH;
            txb_CK.Text = CK;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //if (checkDiem(txbTH.Text) == checkDiem(txbQT.Text) == checkDiem(txbGK.Text) == checkDiem(txbCK.Text) == true)
            //{
            //    KQHT_BUS.Instance.Edit_dtgv(float.Parse(txbQT.Text), float.Parse(txbGK.Text), float.Parse(txbTH.Text), float.Parse(txbCK.Text), txbMSSV.Text, txbNamHoc.Text, txbHocKy.Text, labMaMH.Text);
            //
            //
            //
            //    this.send(txbQT.Text, txbGK.Text, txbTH.Text, txbCK.Text);
            //
            //
            //
            //    MessageBox.Show("Thay đổi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //
            //
            //
            //else MessageBox.Show("Thay đổi dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
