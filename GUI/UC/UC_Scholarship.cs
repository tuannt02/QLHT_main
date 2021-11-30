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

// Author: Tuấn

namespace GUI.UC
{
    // Khai báo delegate cho mục đích truyền dữ liệu từ UC sang form
    public delegate void GetDataUC_SCHOtoForm(string MAHB, string TENHB, string TRIGIA, string TGDK, string TGKT, string DVTT); 

    public partial class UC_Scholarship : UserControl
    {
        GetDataUC_SCHOtoForm _GetDataUC_SCHOtoForm = null;

        // 0: chế độ All, 1: chế độ Active, 2: chế độ Unactive (Filter)
        public static int flag = 0;

        // Nếu cờ bật thì timer kiểm tra và update lại bảng dữ liệu
        public static bool flagUpdate = false;

        // Form main chứa thuộc tính Form Author
        public fScholarship_Authorize f1 = null;

        // Lưu danh sách số dòng hiện tại của dtgv
        private int Recs;

        public UC_Scholarship()
        {
            InitializeComponent();
            LoadDataFull();
        }


        #region Methods

        // Load dữ liệu bao gồm hết hạn và chưa hết hạn lên dtgv
        void LoadDataFull()
        {
            // Bật false là form Edit không được tương tác, tránh tràn lỗi từ form này sang.
            fScholarship_Edit.flag = false;

            // Đổi cờ sang chế độ LoadAll
            flag = 0;

            dtgv_ShowHB.Rows.Clear();
            List<HOCBONG> listHS = Hocbong_BUS.Instance.getListHBFull();
            Recs = listHS.Count;
            UC_AboutUs_lab_Rec.Text = "Records: " + listHS.Count.ToString();
            UC_AboutUs_lab_Fil.Text = "Filter: " + listHS.Count.ToString() + "/" + listHS.Count.ToString();

            foreach (HOCBONG item in listHS)
            {
                dtgv_ShowHB.Rows.Add(new object[]
                {
                    item.MAHB,
                    item.TENHB,
                    item.TRIGIA,
                    item.TGDK,
                    item.TGKT,
                    item.STATUS ? UC_AboutUs_imgList_ListImg.Images[1] : UC_AboutUs_imgList_ListImg.Images[0],
                    item.DVTT,
                }) ;
            }
            if(flagUpdate)
            fScholarship_Edit.flag = true;
        } 

        // Load dữ liệu còn hạn lên dtgv
        void LoadDataActive()
        {
            // Bật false là form Edit không được tương tác, tránh tràn lỗi từ form này sang.
            fScholarship_Edit.flag = false;

            // Đổi cờ sang chế độ LoadActive
            flag = 1;

            dtgv_ShowHB.Rows.Clear();
            List<HOCBONG> listHS = Hocbong_BUS.Instance.getListHBActive();
            Recs = listHS.Count;
            UC_AboutUs_lab_Rec.Text = "Records: " + listHS.Count.ToString();
            UC_AboutUs_lab_Fil.Text = "Filter: " + listHS.Count.ToString() + "/" + listHS.Count.ToString();
            foreach (HOCBONG item in listHS)
            {
                dtgv_ShowHB.Rows.Add(new object[]
                {
                    item.MAHB,
                    item.TENHB,
                    item.TRIGIA,
                    item.TGDK,
                    item.TGKT,
                    item.STATUS ? UC_AboutUs_imgList_ListImg.Images[1] : UC_AboutUs_imgList_ListImg.Images[0],
                    item.DVTT,
                });
            }
            if (flagUpdate)
                fScholarship_Edit.flag = true;
        }

        // Load dữ liệu hết hạn lên dtgv
        void LoadDataUnActive()
        {
            // Bật false là form Edit không được tương tác, tránh tràn lỗi từ form này sang.
            fScholarship_Edit.flag = false;

            // Đổi cờ sang chế độ LoadUnActive
            flag = 2;

            dtgv_ShowHB.Rows.Clear();
            List<HOCBONG> listHS = Hocbong_BUS.Instance.getListHBUnActive();

            Recs = listHS.Count;
            UC_AboutUs_lab_Rec.Text = "Records: " + listHS.Count.ToString();

            UC_AboutUs_lab_Fil.Text = "Filter: " + listHS.Count.ToString() + "/" + listHS.Count.ToString();

            foreach (HOCBONG item in listHS)
            {
                dtgv_ShowHB.Rows.Add(new object[]
                {
                    item.MAHB,
                    item.TENHB,
                    item.TRIGIA,
                    item.TGDK,
                    item.TGKT,
                    item.STATUS ? UC_AboutUs_imgList_ListImg.Images[1] : UC_AboutUs_imgList_ListImg.Images[0],
                    item.DVTT,
                });
            }
            if (flagUpdate)
                fScholarship_Edit.flag = true;
        }

        // Load dữ liệu từ thanh tìm kiếm
        void LoadDataFilter(int flag)
        {
            // Bật false là form Edit không được tương tác, tránh tràn lỗi từ form này sang.
            fScholarship_Edit.flag = false;

            dtgv_ShowHB.Rows.Clear();
            List<HOCBONG> listHS = Hocbong_BUS.Instance.getListHBFilter(UC_AboutUs_txb_Search.Text,flag);

            UC_AboutUs_lab_Fil.Text = "Filter: " + listHS.Count.ToString() + "/" + Recs.ToString();

            foreach (HOCBONG item in listHS)
            {
                dtgv_ShowHB.Rows.Add(new object[]
                {
                    item.MAHB,
                    item.TENHB,
                    item.TRIGIA,
                    item.TGDK,
                    item.TGKT,
                    item.STATUS ? UC_AboutUs_imgList_ListImg.Images[1] : UC_AboutUs_imgList_ListImg.Images[0],
                    item.DVTT,
                });
            }
            if (flagUpdate)
                fScholarship_Edit.flag = true;
        }
        #endregion

        #region Events

        //Xử lí btn Search
        private void UC_AboutUs_btn_Search_Click(object sender, EventArgs e)
        {
            LoadDataFilter(flag);
        }

        //Xử lí btn All
        private void UC_AboutUs_btn_All_Click(object sender, EventArgs e)
        {
            LoadDataFull();

        }

        // Xử lí btn Active
        private void UC_AboutUs_btn_Active_Click(object sender, EventArgs e)
        {
            LoadDataActive();

        }

        // Xử lí btn OnLeave (Hết hạn)
        private void UC_AboutUs_btn_OnLeave_Click(object sender, EventArgs e)
        {
            LoadDataUnActive();
        }

        // Xử lí btn CheckAmin
        private void UC_AboutUs_btn_CheckAdmin_Click(object sender, EventArgs e)
        {
            fScholarship_Authorize a = new fScholarship_Authorize();
            f1 = a;
            a.Show();
            
        }

        // Sự kiện xảy ra khi người dùng click vào row bất kì
        private void UC_AboutUs_dtgv_Show_SelectionChanged(object sender, EventArgs e)
        {
            if(fScholarship_Edit.flag && dtgv_ShowHB.Rows.Count > 0)
            {
                _GetDataUC_SCHOtoForm = f1.f2.SetData;
                _GetDataUC_SCHOtoForm(
                    dtgv_ShowHB.SelectedRows[0].Cells[0].Value.ToString(),
                    dtgv_ShowHB.SelectedRows[0].Cells[1].Value.ToString(),
                    dtgv_ShowHB.SelectedRows[0].Cells[2].Value.ToString(),
                    dtgv_ShowHB.SelectedRows[0].Cells[3].Value.ToString(),
                    dtgv_ShowHB.SelectedRows[0].Cells[4].Value.ToString(),
                    dtgv_ShowHB.SelectedRows[0].Cells[6].Value.ToString()
                    );
            }
        }

        // Load lại dtgv sau một khoảng thời gian
        private void timer_Tick(object sender, EventArgs e)
        {
            if(flagUpdate)
            {
                LoadDataFilter(flag);
                flagUpdate = false;
            }   
        }


        #endregion

       
    }
}
