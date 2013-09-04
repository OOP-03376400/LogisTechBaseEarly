using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using httpHelper;
using System.Diagnostics;

namespace LogisTechBase
{
    public partial class frmGPSReceiver : Form
    {
        bool bRunning = false;
        Timer __timer = null;
        string __IP;
        string __timerStamp = string.Empty;
        string __port = string.Empty;
        List<CarPoint> __pointList = new List<CarPoint>();
        public frmGPSReceiver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.__timer == null)
            {
                this.__timer = new Timer();
                this.__timer.Interval = 5000;
                this.__timer.Tick += new EventHandler(__timer_Tick);
            }
            if (this.bRunning == true)
            {
                this.__timer.Enabled = false;
                this.matrixCircularProgressControl1.Stop();
                this.bRunning = false;
                this.button1.Text = "开始";
            }
            else
            {
                string ip = this.txtIP.Text;
                try
                {
                    IPAddress ipTry = null;

                    ipTry = IPAddress.Parse(ip);
                    this.__IP = ip;
                }
                catch
                {
                    MessageBox.Show("请输入正确的IP地址：(0-255).(0-255).(0-255).(0-255)");
                    return;
                }
                if (this.txtMobileIndex.Text == null || this.txtMobileIndex.Text.Length <= 0)
                {
                    MessageBox.Show("请输入GPS终端的编号！");
                    return;
                }
                else
                {
                    this.__MobileName = this.txtMobileIndex.Text;
                }
                string strPort = this.txtPort.Text;
                if (strPort == null)
                {
                    strPort = string.Empty;
                }
                try
                {
                    int port = int.Parse(strPort);
                    if (port < 80)
                    {
                        MessageBox.Show("端口号不符合系统要求！");
                        return;
                    }
                    __port = port.ToString();
                }
                catch
                {
                    MessageBox.Show("端口号不符合系统要求！");
                    return;
                }

                this.__pointList.Clear();
                this.__timerStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.__timer.Enabled = true;
                this.bRunning = true;
                this.matrixCircularProgressControl1.Start();
                this.button1.Text = "停止";
            }

        }
        string __MobileName = string.Empty;
        void __timer_Tick(object sender, EventArgs e)
        {
            //this.__IP = "localhost";
            //string restUrl = "http://182.18.26.127:80/index.php/LogisTechBase/CarMonitorGet/getLatestCarPoints";
            string restUrl = "http://" + this.__IP + ":" + this.__port + "/index.php/LogisTechBase/CarMonitorGet/getLatestCarPoints";
            //Location l = new Location(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), this.__MobileName);
            CarPoint c = new CarPoint();
            c.strTime = this.__timerStamp;
            c.strCarID = this.__MobileName;
            string jsonString = fastJSON.JSON.Instance.ToJSON(c);
            HttpWebConnect helper = new HttpWebConnect();
            helper.RequestCompleted += new deleGetRequestObject(helper_RequestCompleted_return);
            helper.TryPostData(restUrl, jsonString);

        }
        void helper_RequestCompleted_return(object o)
        {
            deleControlInvoke dele = delegate(object op)
            {
                string strLocations = (string)op;
                Debug.WriteLine(
                    string.Format("frmGPSReceiver.helper_RequestCompleted_return  ->  = {0}"
                    , strLocations));
                object olist = fastJSON.JSON.Instance.ToObjectList(strLocations, typeof(List<CarPoint>), typeof(CarPoint));
                List<CarPoint> locationList = (List<CarPoint>)olist;
                this.__pointList.AddRange(locationList);
                for (int i = 0; i < locationList.Count; i++)
                {
                    //
                    this.txtLocations.Text += locationList[i].toLocationString();
                    if (i == locationList.Count - 1)
                    {
                        if (string.Compare(this.__timerStamp, locationList[i].strTime) < 0)
                        {
                            this.__timerStamp = locationList[i].strTime;
                        }
                    }
                }
            };
            this.Invoke(dele, o);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.__timer.Enabled = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(
                    string.Format("frmGPSReceiver.button2_Click  ->  = {0}"
                    , saveFileDialog1.FileName));
                string strPath = saveFileDialog1.FileName;
                DataSet ds = new DataSet("Points");

                DataTable dt = new DataTable("point");
                dt.Columns.Add("time", typeof(string));
                dt.Columns.Add("latitude", typeof(string));
                dt.Columns.Add("longitude", typeof(string));
                ds.Tables.Add(dt);

                for (int i = 0; i < __pointList.Count; i++)
                {
                    CarPoint c = __pointList[i];
                    dt.Rows.Add(new object[] { c.strTime, c.strLatitude, c.strLongitude });
                }

                ds.WriteXml(strPath);

            }

            return;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class CarPoint
    {
        public string state;
        public string strCarID = string.Empty;
        // no arguments constructor is necessary
        public CarPoint()
        {
            this.strCarID = "0";
            this.strLatitude = "0";
            this.strLongitude = "0";
            this.strTime = "0";

        }
        public CarPoint(string strCarID_in, string strTime_in, string strLat_in, string strLon_in)
        {
            this.strCarID = strCarID_in;
            this.strTime = strTime_in;
            this.strLatitude = strLat_in;
            this.strLongitude = strLon_in;
        }
        public string strTime;
        public string strLatitude = "0";
        public string strLongitude = "0";
        public string toLocationString()
        {
            return "经度: " + this.strLongitude + "  纬度: " + this.strLatitude + "  时间: " + this.strTime + "\r\n";
        }

    }
    public class Location
    {
        public string timeStamp;
        public string name;
        public string lat;
        public string lng;
        public Location()
        {

        }
        public Location(string _time, string _name)
        {
            this.timeStamp = _time;
            this.name = _name;
        }
        public string toLocationString()
        {
            return "经度: " + this.lng + "  纬度: " + this.lat + "  时间: " + this.timeStamp + "\r\n";
        }
    }
}
