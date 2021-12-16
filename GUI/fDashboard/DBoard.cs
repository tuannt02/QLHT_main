using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Xml;
using System.IO;
using System.Globalization;
using System.Resources;

using BUS;
using DTO;

namespace GUI.fDashboard
{
    public partial class DBoard : Form
    {
        private const string API_KEY = "8608b783bcb7443f5ed759033233c79b";

        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "q=Qui Nhon&mode=xml&units=metric&APPID=" + API_KEY;

        public DBoard()
        {
            InitializeComponent();
            if(!fLogin.Login.ADMIN)
            {
                btnManage.Hide();
            }
            else
            {
                fDashboard_DBoard_btn_Dashboard.Checked = false;
                fDashboard_DBoard_btn_Dashboard.Hide();
                fDashboard_DBoard_btn_Gmail.Checked = true;
                if (fDashboard_DBoard_btn_Gmail.Checked)
                {
                    uC_Gmail1.BringToFront();
                    lab_breadcrumb.Text = "App > Viết mail";
                }
            }
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
           // UC.UC_AboutUs.
        }

        private void btnManage_CheckedChange(object sender, EventArgs e)
        {
            if (btnManage.Checked)  
            {
                fDashboard_DBoard_btn_AboutUs.Checked = false;
                fDashboard_DBoard_btn_Setting.Checked = false;
                uC_Manage1.BringToFront();
                lab_breadcrumb.Text = "App > Quản lý tài khoản";
            }
        }

        private void fDashboard_DBoard_btn_Dashboard_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Dashboard.Checked) 
            {
                fDashboard_DBoard_btn_AboutUs.Checked = false;
                fDashboard_DBoard_btn_Setting.Checked = false;
                uC_Dashboard1.BringToFront();
                lab_breadcrumb.Text = "App > Trang chủ";
            }
        }

        private void fDashboard_DBoard_btn_Scholarship_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Scholarship.Checked) 
            {
                fDashboard_DBoard_btn_AboutUs.Checked = false;
                fDashboard_DBoard_btn_Setting.Checked = false;
                uC_Scholarship1.BringToFront();
                lab_breadcrumb.Text = "App > Học bổng";
            }
        }

        private void fDashboard_DBoard_btn_Study_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Study.Checked) 
            {
                fDashboard_DBoard_btn_AboutUs.Checked = false;
                fDashboard_DBoard_btn_Setting.Checked = false;
                uC_Study_Main1.BringToFront();
                lab_breadcrumb.Text = "App > Học tập > Sửa";
            }
        }

        private void fDashboard_DBoard_btn_Setting_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Setting.Checked) 
            {
                fDashboard_DBoard_btn_Gmail.Checked = false;
                fDashboard_DBoard_btn_Dashboard.Checked = false;
                fDashboard_DBoard_btn_Scholarship.Checked = false;
                fDashboard_DBoard_btn_Study.Checked = false;
                btnManage.Checked = false;
                uC_Setting1.BringToFront();
                lab_breadcrumb.Text = "App > Cài đặt";
            }
        }

        private void fDashboard_DBoard_btn_AboutUs_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_AboutUs.Checked) 
            {
                fDashboard_DBoard_btn_Gmail.Checked = false;
                fDashboard_DBoard_btn_Dashboard.Checked = false;
                fDashboard_DBoard_btn_Scholarship.Checked = false;
                fDashboard_DBoard_btn_Study.Checked = false;
                btnManage.Checked = false;
                uC_AboutUs1.BringToFront();
                lab_breadcrumb.Text = "App > Giới thiệu";
            }
        }
        private void fDashboard_DBoard_btn_Gmail_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Gmail.Checked)
            {
                uC_Gmail1.BringToFront();
                lab_breadcrumb.Text = "App > Viết mail";
            }
        }

        private void Update_time()
        {
            lab_time.Text = DateTime.UtcNow.AddHours(7).ToString();
        }

        private void DBoard_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    DisplayForecast(client.DownloadString(CurrentUrl));
                }
                catch (WebException ex)
                {
                    DisplayError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown error\n" + ex.Message);
                }
            }
        }
        private void DisplayForecast(string xml)
        {

            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);


            XmlNode temp_node = xml_doc.SelectSingleNode("current/temperature");
            XmlNode ico_node = xml_doc.SelectSingleNode("current/weather");
            string nameImg = ico_node.Attributes["icon"].Value;
            txt_C.Text = temp_node.Attributes["value"].Value;

            ResourceManager rm = Properties.Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(nameImg);

            txt_C.IconLeft = myImage;
        }

        private void DisplayError(WebException exception)
        {
            try
            {
                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode message_node = response_doc.SelectSingleNode("//message");
                MessageBox.Show(message_node.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error\n" + ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lab_time.Text = DateTime.UtcNow.AddHours(7).ToString();
            if(flagUpdate)
            {
                string MSSV = DBoard_BUS.Instance.GetMSSV();
                flagUpdate = false;
                lab_breadcrumb.Text = DBoard_BUS.Instance.GetBREADCRUMB(MSSV);
            }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
            fLogin.Login.Instance.Show();
        }

        private void DBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBoard_BUS.Instance.Delete_TempTable();
        }

        public static bool flagUpdate = false;
        private void fDashboard_DBoard_btn_Study_Click(object sender, EventArgs e)
        {
            string MSSV = DBoard_BUS.Instance.GetMSSV();

            DBoard_BUS.Instance.Update_BREADCRUMB(MSSV, "App > Học tập > Sửa");

            flagUpdate = true;

        }

    }
}
