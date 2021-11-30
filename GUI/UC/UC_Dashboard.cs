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

// Author: Tuấn, Phúc

namespace GUI.UC
{
    public partial class UC_Dashboard : UserControl
    {
        // OpenWeatherAPI
        private const string API_KEY = "8608b783bcb7443f5ed759033233c79b";

        // Lấy API thời tiết hiện tại của một địa phương
        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "q=Qui Nhon&mode=xml&units=metric&APPID=" + API_KEY;

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        

        #region Methods

        // Lấy dữ liệu từ API
        private void DisplayForecast(string xml)
        {

            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);


            XmlNode temp_node = xml_doc.SelectSingleNode("current/temperature");
            XmlNode press_node = xml_doc.SelectSingleNode("current/pressure");
            XmlNode visi_node = xml_doc.SelectSingleNode("current/visibility");
            XmlNode huma_node = xml_doc.SelectSingleNode("current/humidity");
            XmlNode ico_node = xml_doc.SelectSingleNode("current/weather");
            string nameImg = ico_node.Attributes["icon"].Value;
            //int Celsius = int.Parse(temp_node.Attributes["value"].Value);
            int visi = int.Parse(visi_node.Attributes["value"].Value);
            visi /= 1000;
            txt_C.Text = temp_node.Attributes["value"].Value; 
            lab_resultPress.Text = press_node.Attributes["value"].Value+ " hPa";
            lab_resultVis.Text = visi.ToString() + " km";
            lab_resultHuma.Text = huma_node.Attributes["value"].Value + "%";

            ResourceManager rm = Properties.Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(nameImg);

            txt_C.IconLeft = myImage;
        }

        // Thông báo chi tiết lỗi
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
        #endregion

        #region Events
        // Load dữ liệu lên DB
        private void UC_Dashboard_Load(object sender, EventArgs e)
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
        #endregion
    }
}
