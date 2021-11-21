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
using System.Globalization;

namespace GUI.UC
{
    public partial class fScholarship_Edit : Form
    {
        public static bool flag = false;
        public fScholarship_Edit()
        {
            InitializeComponent();
        }

        #region Methods

        // Lấy dữ liệu từ UC_Study cho chức năng Edit
        public void SetData(string MAHB, string TENHB, string TRIGIA, string TGDK, string TGKT, string DVTT)
        {
            //10/31/2020 12:00:00 AM
            //DateTime _TGDK = DateTime.Parse(TGDK,"dd/MM/yyyy HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
            CultureInfo culture = new CultureInfo("en-US");
            DateTime _TGDK = Convert.ToDateTime(TGDK, culture);
            DateTime _TGKT = Convert.ToDateTime(TGKT, culture);
            txt_MAHB.Text = MAHB;
            txt_TENHB.Text = TENHB;
            txt_TRIGIA.Text = TRIGIA;
            dtp_TGDK.Value = _TGDK;
            dtp_TGKT.Value = _TGKT;
            txt_DVTT.Text = DVTT;
        }
        #endregion



        #region Events
        private void btn_back_Click(object sender, EventArgs e)
        {
            flag = false;
            Close();
        }
        #endregion
    }
}
