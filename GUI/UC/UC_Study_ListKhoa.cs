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

// Author: Phúc

namespace GUI.UC
{
    public partial class UC_Study_ListKhoa : UserControl
    {
        public UC_Study_ListKhoa()
        {
            InitializeComponent();
        }


        #region Events

        // Xử lí btn Search
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dtgv.Rows.Clear();

            if (Kqht_BUS.Instance.KQHT_XemDS_Check(cb_NamHoc.Text, cb_Khoa.Text))
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần tìm kiếm",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            else
            {
                string namhoc = cb_NamHoc.Text;
                string khoa = cb_Khoa.Text;
                List<DTK> DS_kqht = Kqht_BUS.Instance.Load_XemDS_dtgv(namhoc, khoa);


                if (DS_kqht.Count > 0)
                    lab_TenKhoa.Text = "Khoa " + cb_Khoa.Text;
                else
                    lab_TenKhoa.Text = "Không tìm thấy";



                int records = 0;
                foreach (DTK item in DS_kqht)
                {
                    dtgv.Rows.Add(new object[] {
                    item.MSSV,
                    item.HOTEN,
                    item.TBKH1,
                    item.TBHK2,
                    item.TBNAM
                    });
                    records++;
                }

                lab_Recs.Text = "Số dòng: " + records.ToString();
            }
        }

        // Xử lí btn Sv nhất khoa
        private void btn_Svmaster_Click(object sender, EventArgs e)
        {
            dtgv.Rows.Clear();
            if (Kqht_BUS.Instance.KQHT_XemDS_Check(cb_NamHoc.Text, cb_Khoa.Text))
                MessageBox.Show("Vui lòng điền đầy đủ thông tin",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            else
            {
                string namhoc = cb_NamHoc.Text;
                string khoa = cb_Khoa.Text;
                DTK svMaster = Kqht_BUS.Instance.Load_SV_master(namhoc, khoa);


                //if (svMaster.Count > 0)
                //    lab_TenKhoa.Text = "Khoa " + cb_Khoa.Text;
                //else
                //    lab_TenKhoa.Text = "Not found";

                int records = 1;

                dtgv.Rows.Add(new object[] {
                svMaster.MSSV,
                svMaster.HOTEN,
                svMaster.TBKH1,
                svMaster.TBHK2,
                svMaster.TBNAM
                });

                lab_Recs.Text = "Số dòng: " + records.ToString();
            }
        }
        #endregion
    }
}
