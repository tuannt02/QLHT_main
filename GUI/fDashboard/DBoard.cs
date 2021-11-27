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
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
           // UC.UC_AboutUs.
        }

        private void uC_AboutUs1_Load(object sender, EventArgs e)
        {

        }

        private void fDashboard_DBoard_btn_Dashboard_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Dashboard.Checked) 
            {
                uC_Dashboard1.BringToFront();
                lab_breadcrumb.Text = "App > Dashboard";
            }
        }

        private void fDashboard_DBoard_btn_Scholarship_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Scholarship.Checked) 
            {
                uC_Scholarship1.BringToFront();
                lab_breadcrumb.Text = "App > Học bổng";
            }
        }

        private void fDashboard_DBoard_btn_Study_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Study.Checked) 
            {
                uC_Study_Main1.BringToFront();
                lab_breadcrumb.Text = "App > Học tập";
            }
        }

        private void fDashboard_DBoard_btn_Setting_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_Setting.Checked) 
            {
                uC_Setting1.BringToFront();
                lab_breadcrumb.Text = "App > Setting";
            }
        }

        private void fDashboard_DBoard_btn_AboutUs_CheckedChanged(object sender, EventArgs e)
        {
            if (fDashboard_DBoard_btn_AboutUs.Checked) 
            {
                uC_AboutUs1.BringToFront();
                lab_breadcrumb.Text = "App > About Us";
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
        }
    }
}
