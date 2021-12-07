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
using DTO;
using BUS;

// Author: Tuấn, Phúc

namespace GUI.UC
{
    public partial class UC_Dashboard : UserControl
    {
        #region Tuan
        // OpenWeatherAPI
        private const string API_KEY = "8608b783bcb7443f5ed759033233c79b";

        // Lấy API thời tiết hiện tại của một địa phương
        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "q=Qui Nhon&mode=xml&units=metric&APPID=" + API_KEY;

        public UC_Dashboard()
        {
            InitializeComponent();
            //Load_Matrix();
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
            Controls.Add(tLO1);
            setUpTLO();

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
        #endregion

        #region properties



        private static int DateOfColumn = 7;
        private static int DateOfRow = 6;



        private static int DateBtnWidth = 50;
        private static int DateBtnHeight = 40;
        private static int margin = 6;



        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }



        private List<string> dateOfWeek = new
        List<string>() {"Monday",
                        "Tuesday",
                        "Wednesday",
                        "Thursday",
                        "Friday",
                        "Saturday",
                        "Sunday" };


        #endregion

        private void Load_Matrix()
        {
            Button btnOld = new Button() { Width = 0, Height = 0, Location = new Point(-margin, 0) };

            //btnOld.FlatAppearance.BorderSize = 0;

            Matrix = new List<List<Button>>();
            for (int i = 0; i < DateOfRow; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < DateOfColumn; j++)
                {
                    Button btn = new Button() { Width = DateBtnWidth, Height = DateBtnHeight };
                    btn.Location = new Point(btnOld.Location.X + btnOld.Width + margin, btnOld.Location.Y);

                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;

                    panel_Calendar.Controls.Add(btn); // thêm các button vào panel
                    Matrix[i].Add(btn); // thêm các button vào matrix
                    btnOld = btn;
                }
                btnOld = new Button() { Width = 0, Height = 0, Location = new Point(-margin, btnOld.Location.Y + DateBtnHeight) };
            }
            Set_Default_Date(); // Mặc định ngày hiện tại cho lần đầu chạy ứng dụng
        }






        public void Add_Date_into_Matrix_Btn(DateTime date) // Function thêm các text Ngày vào các button
        {
            Clear_Matrix();
            //setUpTLO();
            DateTime useDate = new DateTime(date.Year, date.Month, 1); // userDate được gán cho ngày đầu tiên trong tháng

            int row = 0;

            List<object[]> A = DBoard_BUS.Instance.list_GetJobs(lab_MSSV.Text, date, DateTime.DaysInMonth(date.Year, date.Month));


            for (int i = 1; i <= DateTime.DaysInMonth(date.Year, date.Month); i++) // Function DayofMonth lấy ra số ngày trong tháng
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString()); // Function DayOfWeek trả về chuỗi ngày trong tuần,
                                                                               // function IndexOf xác định index của ngày dựa trên list dateOfWeek ở properties
                Button btn = Matrix[row][column];
                btn.Text = i.ToString(); // gán số ngày cho btn
                btn.BackColor = Color.FromArgb(38, 38, 38);
                btn.ForeColor = Color.White;
                //btn.Font = new Font("Segoe UI", 9, FontStyle.Bold) ;
                

                btn.Tag = A[i];
                
                if (A[i][0] != null)
                {
                    btn.BackColor = Color.DeepPink;
                    btn.MouseHover += new EventHandler(btn_mouseHover);
                    btn.MouseLeave += new EventHandler(btn_mouseLeave);

                }   



                if (IsEqual_Date(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Aqua;
                    btn.ForeColor = Color.Black;
                }

                useDate = useDate.AddDays(1);

                if (column >= 6)
                    row++;
            }
        }

        TableLayoutPanel tLO1 = new TableLayoutPanel();

        private void btn_mouseHover(object sender, EventArgs e)
        {
            Button b = sender as Button;
            object[] c = (object[])b.Tag;

            DateTime x = DateTime.Parse(c[0].ToString());
            List<DLNOW> listDLNow = DBoard_BUS.Instance.GetlistDLnow("20521711", x);

            foreach(DLNOW item in listDLNow)
            {
                Label ac = CusLab(true, item.MAMH+":");
                Label ab = CusLab(false, item.NOIDUNG+":");
                
                tLO1.Controls.Add(ac);
                tLO1.Controls.Add(ab);
            }

            tLO1.BackColor = Color.White;
            tLO1.BringToFront();
            tLO1.Show();

        }


        void setUpTLO()
        {
            tLO1.Controls.Clear();
            tLO1.Size = new Size(320, 50);
            tLO1.Hide();
            tLO1.AutoSize = true;
            tLO1.Location = new Point(30, 360);
            tLO1.ColumnCount = 2;
        }

        Label CusLab(bool type, string text)
        {
            // True là lab MAMH
            Label a = new Label();
            a.BackColor = Color.White;
            a.Text = text;
            a.AutoSize = true;
            if(type)
            {
                a.ForeColor = Color.FromArgb(232, 162, 85);
                a.Font = new Font("Segoe UI",12,FontStyle.Bold);
            }
            else
            {
                a.ForeColor = Color.Black;
                a.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            }


            return a;
        }

        private void btn_mouseLeave(object sender, EventArgs e)
        {
            tLO1.Controls.Clear();
            tLO1.Hide();
        }

        void Set_Default_Date()
        {
            dtpk_Calendar.Value = DateTime.Now;

            lab_dtpk.Text = "Tháng " + dtpk_Calendar.Value.Month.ToString()
            + " Năm " + dtpk_Calendar.Value.Year.ToString();
        }


        void Clear_Matrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.FromArgb(38, 38, 38);
                    if (btn.Tag!=null)
                    {
                        btn.MouseHover -= new EventHandler(btn_mouseHover);
                        btn.MouseLeave -= new EventHandler(btn_mouseLeave);
                    }
                }
        }


        bool IsEqual_Date(DateTime a, DateTime b)
        {
            return a.Year == b.Year && a.Month == b.Month && a.Day == b.Day;
        }


        #region Event



        public static int index = 0;

        #endregion

        private void dtpk_Calendar_ValueChanged(object sender, EventArgs e)
        {
            Add_Date_into_Matrix_Btn((sender as DateTimePicker).Value);
            
                lab_dtpk.Text = "Tháng " + dtpk_Calendar.Value.Month.ToString()
                + " Năm " + dtpk_Calendar.Value.Year.ToString();
        }

        private void btn_NextMonth_Click(object sender, EventArgs e)
        {
            dtpk_Calendar.Value = dtpk_Calendar.Value.AddMonths(1);
        }

        private void btn_PrevMonth_Click(object sender, EventArgs e)
        {
            dtpk_Calendar.Value = dtpk_Calendar.Value.AddMonths(-1);
        }

        
    }
}
