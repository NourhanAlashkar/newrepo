using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace Remote_SDS_Control_V1_0
{
    public partial class Main_Form : Form
    {
        int message_Counter = 0;
        int Message_Length;
        string message_Counter_Hex;

        public Main_Form()
        {
            InitializeComponent();
            Auditing.InitializeCreatingAuditAndErrorFile();
            textBox2.Text = Properties.Settings.Default.Map_URI;
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox2.Items.Add(port);
            }

        }

        public void Sending(String password, String cmd, String ISSI)
        {
            byte[] getbyte = Encoding.Default.GetBytes(cmd);
            var hexString = BitConverter.ToString(getbyte);
            hexString = hexString.Replace("-", "");
            Message_Length = (10 + (cmd.Length * 2)) * 4;
            SP.WriteLine("AT+CMGS=" + ISSI + ",1,0," + Message_Length + "" + (char)13);
            if (message_Counter > 9)
            {
                message_Counter = 0;
            }
            message_Counter_Hex = message_Counter.ToString("X");
            message_Counter_Hex = message_Counter_Hex.Length == 1 ? "0" + message_Counter_Hex : message_Counter_Hex;

            string p = "E000010" + message_Counter.ToString() + hexString + "0d" + (char)26;

            SP.WriteLine(p);
            message_Counter++;
        }//Radio Send Commands

        private void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(400);
                string Recived_Data = SP.ReadExisting();

                #region Connect
                if(Connection_Flag == false && Recived_Data.Contains("OK"))
                {
                    pictureBox1_Update(true, true);
                    Connection_Flag = true;
                    button6_Update(false);
                    button1_Update(true);
                    button4_Update(true);
                    button3_Update(true);
                    button5_Update(true);
                    button2_Update(true);
                }
                #endregion

                #region Read TETRA Sites
                if (Get_Radio_Sites && Recived_Data.Contains("E0"))
                {
                    string[] Recived_Array = Recived_Data.Split(new string[] { "+CMT" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int index = 0; index < Recived_Array.Length; index++)
                    {
                        if (Recived_Array[index].Contains("E0"))
                        {
                            string[] Recived_Array_2 = Recived_Array[index].Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            if (Recived_Array_2.Length > 1)
                            {
                                byte[] hexBytes = new byte[(Recived_Array_2[1].Length / 2) - 5];
                                int index_2 = 10;
                                for (int i = 9; i < Recived_Array_2[1].Length; i++)
                                {
                                    if (index_2 + 2 < Recived_Array_2[1].Length)
                                    {
                                        string Obj = Recived_Array_2[1].Substring(index_2, 2);
                                        hexBytes[i - 9] = Convert.ToByte(Obj, 16);
                                        index_2 = index_2 + 2;
                                    }
                                }
                                string Radio_Sites = Encoding.ASCII.GetString(hexBytes);

                                string[] Radios_Array_3 = Radio_Sites.Split(new string[] { "\r\n", "\r\0" }, StringSplitOptions.RemoveEmptyEntries);
                                Regex re = new Regex(@".*\,.*\,.*\,.*");


                                for (int i = 0; i < Radios_Array_3.Length; i++)
                                {
                                    Match Match_obj = re.Match(Radios_Array_3[i]);
                                    if (Match_obj.Success)
                                    {
                                        string[] Site_info_Array = Radios_Array_3[i].Split(',');
                                        Site_info += "LA : " + Site_info_Array[0] + " ";
                                        int RSSI_Value = int.Parse(Site_info_Array[2]);

                                        switch (RSSI_Value)
                                        {
                                            case 0:
                                                Site_info += "RSSI : " + "-113 dBm or less";
                                                break;
                                            case 1:
                                                Site_info += "RSSI : " + "-111 or -112 dBm";
                                                break;
                                            case 2:
                                                Site_info += "RSSI : " + "-109 dBm";
                                                break;
                                            case 3:
                                                Site_info += "RSSI : " + "-107 dBm";
                                                break;
                                            case 4:
                                                Site_info += "RSSI : " + "-105 dBm";
                                                break;
                                            case 5:
                                                Site_info += "RSSI : " + "-103 dBm";
                                                break;
                                            case 6:
                                                Site_info += "RSSI : " + "-101 dBm";
                                                break;
                                            case 7:
                                                Site_info += "RSSI : " + "-99 dBm";
                                                break;
                                            case 8:
                                                Site_info += "RSSI : " + "-97 dBm";
                                                break;
                                            case 9:
                                                Site_info += "RSSI : " + "-95 dBm";
                                                break;
                                            case 10:
                                                Site_info += "RSSI : " + "-93 dBm";
                                                break;
                                            case 11:
                                                Site_info += "RSSI : " + "-91 dBm";
                                                break;
                                            case 12:
                                                Site_info += "RSSI : " + "-89 dBm";
                                                break;
                                            case 13:
                                                Site_info += "RSSI : " + "-87 dBm";
                                                break;
                                            case 14:
                                                Site_info += "RSSI : " + "-85 dBm";
                                                break;
                                            case 15:
                                                Site_info += "RSSI : " + "-83 dBm";
                                                break;
                                            case 16:
                                                Site_info += "RSSI : " + "-81 dBm";
                                                break;
                                            case 17:
                                                Site_info += "RSSI : " + "-79 dBm";
                                                break;
                                            case 18:
                                                Site_info += "RSSI : " + "-77 dBm";
                                                break;
                                            case 19:
                                                Site_info += "RSSI : " + "-75 dBm";
                                                break;
                                            case 20:
                                                Site_info += "RSSI : " + "-73 dBm";
                                                break;
                                            case 21:
                                                Site_info += "RSSI : " + "-71 dBm";
                                                break;
                                            case 22:
                                                Site_info += "RSSI : " + "-69 dBm";
                                                break;
                                            case 23:
                                                Site_info += "RSSI : " + "-67 dBm";
                                                break;
                                            case 24:
                                                Site_info += "RSSI : " + "-65 dBm";
                                                break;
                                            case 25:
                                                Site_info += "RSSI : " + "-63 dBm";
                                                break;
                                            case 26:
                                                Site_info += "RSSI : " + "-61 dBm";
                                                break;
                                            case 27:
                                                Site_info += "RSSI : " + "-59 dBm";
                                                break;
                                            case 28:
                                                Site_info += "RSSI : " + "-57 dBm";
                                                break;
                                            case 29:
                                                Site_info += "RSSI : " + "-55 dBm";
                                                break;
                                            case 30:
                                                Site_info += "RSSI : " + "-53 dBm";
                                                break;
                                            case 31:
                                                Site_info += "RSSI : " + "-51 dBm or greater";
                                                break;
                                            case 99:
                                                Site_info += "RSSI : " + "Unknown or undetectable";
                                                break;
                                            default:
                                                break;
                                        }

                                        Sites_List.Add(Radios_Array_3[i]);
                                        Site_info += "\r\n";
                                    }
                                }
                                txt_TETRA_Sites_Update(Site_info);
                                pictureBox3_Update(true, true);
                            }
                        }
                    }
                    Get_Radio_Sites = false;
                }
                #endregion

                #region Read All TGs
                if (Get_All_Radio_TGs && Recived_Data.Contains("E0"))
                {
                    string[] Recived_Array = Recived_Data.Split(new string[] { "+CMT" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int index = 0; index < Recived_Array.Length; index++)
                    {
                        if (Recived_Array[index].Contains("E0"))
                        {
                            string[] Recived_Array_2 = Recived_Array[index].Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            if (Recived_Array_2.Length > 1)
                            {
                                byte[] hexBytes = new byte[(Recived_Array_2[1].Length / 2) - 5];
                                int index_2 = 10;
                                for (int i = 9; i < Recived_Array_2[1].Length; i++)
                                {
                                    if (index_2 + 2 < Recived_Array_2[1].Length)
                                    {
                                        string Obj = Recived_Array_2[1].Substring(index_2, 2);
                                        hexBytes[i - 9] = Convert.ToByte(Obj, 16);
                                        index_2 = index_2 + 2;
                                    }
                                }
                                string Radio_TGs = Encoding.ASCII.GetString(hexBytes);

                                string[] Radios_Array_3 = Radio_TGs.Split(new string[] { "\r\n", "\r\0" }, StringSplitOptions.RemoveEmptyEntries);
                                Regex re = new Regex(@".*\,.*\,.*");
                                for (int i = 0; i < Radios_Array_3.Length; i++)
                                {
                                    Match Match_obj = re.Match(Radios_Array_3[i]);
                                    if (Match_obj.Success)
                                    {
                                        TGs_List.Add(Radios_Array_3[i]);
                                    }
                                }
                                comboBox1_Update(TGs_List);
                                if (TGs_List.Count > 0)
                                {
                                    pictureBox4_Update(true, true);
                                }

                            }
                        }
                    }
                    Get_All_Radio_TGs = false;
                }
                #endregion

                #region Read Current TG
                if (Get_Current_Radio_TG && Recived_Data.Contains("E0") && Get_All_Radio_TGs == false)
                {
                    string[] Recived_Array = Recived_Data.Split(new string[] { "+CMT" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int index = 0; index < Recived_Array.Length; index++)
                    {
                        if (Recived_Array[index].Contains("E0"))
                        {
                            string[] Recived_Array_2 = Recived_Array[index].Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            if (Recived_Array_2.Length > 1)
                            {
                                byte[] hexBytes = new byte[(Recived_Array_2[1].Length / 2) - 5];
                                int index_2 = 10;
                                for (int i = 9; i < Recived_Array_2[1].Length; i++)
                                {
                                    if (index_2 + 2 < Recived_Array_2[1].Length)
                                    {
                                        string Obj = Recived_Array_2[1].Substring(index_2, 2);
                                        hexBytes[i - 9] = Convert.ToByte(Obj, 16);
                                        index_2 = index_2 + 2;
                                    }
                                }

                                string Radio_TG = Encoding.ASCII.GetString(hexBytes);

                                string[] Radios_Array_3 = Radio_TG.Split(new string[] { "\r\n", "\r\0" }, StringSplitOptions.RemoveEmptyEntries);

                                Regex re = new Regex(@".*\,.*");
                                for (int i = 0; i < Radios_Array_3.Length; i++)
                                {
                                    Match Match_obj = re.Match(Radios_Array_3[i]);
                                    if (Match_obj.Success)
                                    {
                                        comboBox1_Select_Update(Radios_Array_3[i]);
                                        Get_Current_Radio_TG = false;
                                        if (Radios_Array_3[i] != "")
                                        {
                                            pictureBox4_Update(true, true);
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion

                #region change TG
                if (Change_Current_Radio_TG && Recived_Data.Contains("E0") && Get_All_Radio_TGs == false)
                {
                    string[] Recived_Array = Recived_Data.Split(new string[] { "+CMT" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int index = 0; index < Recived_Array.Length; index++)
                    {
                        if (Recived_Array[index].Contains("E0"))
                        {
                            string[] Recived_Array_2 = Recived_Array[index].Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            if (Recived_Array_2.Length > 1)
                            {
                                byte[] hexBytes = new byte[(Recived_Array_2[1].Length / 2) - 5];
                                int index_2 = 10;
                                for (int i = 9; i < Recived_Array_2[1].Length; i++)
                                {
                                    if (index_2 + 2 < Recived_Array_2[1].Length)
                                    {
                                        string Obj = Recived_Array_2[1].Substring(index_2, 2);
                                        hexBytes[i - 9] = Convert.ToByte(Obj, 16);
                                        index_2 = index_2 + 2;
                                    }
                                }

                                string Radio_Confirmation = Encoding.ASCII.GetString(hexBytes);
                                if(Radio_Confirmation.Contains("OK"))
                                {
                                    pictureBox4_Update(true, true);
                                }
                                Change_Current_Radio_TG = false;
                            }
                        }
                    }
                }
                #endregion

                #region GPS Location
                if (Read_GPS_location && Recived_Data.Contains("E0"))
                {
                    string[] Recived_Array = Recived_Data.Split(new string[] { "+CMT" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int index = 0; index < Recived_Array.Length; index++)
                    {
                        if (Recived_Array[index].Contains("E0"))
                        {
                            string[] Recived_Array_2 = Recived_Array[index].Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            if (Recived_Array_2.Length > 1)
                            {
                                byte[] hexBytes = new byte[(Recived_Array_2[1].Length / 2) - 5];
                                int index_2 = 10;
                                for (int i = 9; i < Recived_Array_2[1].Length; i++)
                                {
                                    if (index_2 + 2 < Recived_Array_2[1].Length)
                                    {
                                        string Obj = Recived_Array_2[1].Substring(index_2, 2);
                                        hexBytes[i - 9] = Convert.ToByte(Obj, 16);
                                        index_2 = index_2 + 2;
                                    }
                                }

                                string Radio_TG = Encoding.ASCII.GetString(hexBytes);

                                string[] Radios_Array_3 = Radio_TG.Split(new string[] { "\r\n", "\r\0" }, StringSplitOptions.RemoveEmptyEntries);
                                for (int i = 0; i < Radios_Array_3.Length; i++)
                                {
                                    if (Radios_Array_3[i].Contains("+GPSPOS"))
                                    {
                                        string[] GPS_Location_ArrayInfo = Radios_Array_3[i].Split(',');

                                        string[] Lat_info = GPS_Location_ArrayInfo[1].Split(':', '_');
                                        double lat = double.Parse(Lat_info[1].Trim()) + (double.Parse(Lat_info[2].Trim())) / 60;

                                        string[] Lon_info = GPS_Location_ArrayInfo[2].Split(':', '_');
                                        double lon = double.Parse(Lon_info[1].Trim()) + (double.Parse(Lon_info[2].Trim())) / 60;

                                        txt_lat_Update(lat.ToString());
                                        txt_lon_Update(lon.ToString());

                                        #region Plot Radio
                                        SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.User_Simple_MapPoint Simple_Point_Obj = new SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.User_Simple_MapPoint();
                                        Simple_Point_Obj.User_Mappoint_Visibility = true;

                                        Simple_Point_Obj.User_Mappoint_Text = textBox9.Text;
                                        Simple_Point_Obj.Font_Color = System.Windows.Media.Color.FromRgb(0, 0, 0);
                                        Simple_Point_Obj.Font_Family = "Bold";
                                        Simple_Point_Obj.Font_Size = 18;
                                        Simple_Point_Obj.MapPoint_Simple_Style = 1;
                                        Simple_Point_Obj.SimpleMarkerSymbol_Size = 100;
                                        Simple_Point_Obj.MapPoint_Simple_Color = System.Windows.Media.Color.FromArgb(1, 0, 0, 255);
                                        Simple_Point_Obj.User_Mappoint_Postion.Latitude = lat;
                                        Simple_Point_Obj.User_Mappoint_Postion.Longitude = lon;
                                        Simple_Point_Obj.Text_XOffset = 10;
                                        Simple_Point_Obj.Text_YOffset = -30;

                                        SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.User_Picture_MapPoint Picture_Point_Obj = new SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.User_Picture_MapPoint();
                                        Picture_Point_Obj.User_Mappoint_Postion.Latitude = lat;
                                        Picture_Point_Obj.User_Mappoint_Postion.Longitude = lon;
                                        Picture_Point_Obj.Uri = Application.StartupPath + "\\Files\\Images_Icons\\placemark_1.png";
                                        _esri_MAP.Add_Radios_GraphicOverlay_Layer("Radios_Layer_2", new List<SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.User_Picture_MapPoint> { Picture_Point_Obj });
                                        _esri_MAP.Add_Radios_GraphicOverlay_Layer("Radios_Layer_1", new List<SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.User_Simple_MapPoint> { Simple_Point_Obj });

                                        SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.MapPoint_Position Map_Point_Obj = new SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.MapPoint_Position();
                                        Map_Point_Obj.Latitude = lat;
                                        Map_Point_Obj.Longitude = lon;
                                        _esri_MAP.Fly_To(Map_Point_Obj, 4000);
                                        pictureBox2_Update(true, true);

                                        #endregion
                                    }

                                }

                            }
                        }
                    }
                }
                #endregion

            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }

        }//Radio Received Info, works by waiting for 3 successful responses then parsing each one and adding to database

        #region Connect

        bool Connection_Flag;
        ElementHost ctrlHost;
        SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control _esri_MAP;
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Connection_Flag = false;
                SP.PortName = comboBox2.SelectedItem.ToString();
                SP.BaudRate = int.Parse(comboBox3.SelectedItem.ToString());
                SP.Open();
                String at_commands = "AT+RCPIN =" + textBox3.Text;
                SP.WriteLine(at_commands + (Char)13);

                Properties.Settings.Default.Map_URI = textBox2.Text;
                Properties.Settings.Default.Save();

                if (Properties.Settings.Default.Map_URI != "")
                {
                    ctrlHost = new ElementHost();
                    ctrlHost.Dock = DockStyle.Fill;
                    pnl_Map.Controls.Add(ctrlHost);

                    _esri_MAP = new SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control("lriRsrLANJyLeDDu", "runtimestandard,101," + "rud336290293" + ",none,GB1P0H4EN96HF5KHT247");

                    _esri_MAP.InitializeComponent();
                    ctrlHost.Child = _esri_MAP;
                    _esri_MAP.Add_Online_Map_Layer("Main_Map", Properties.Settings.Default.Map_URI);

                    SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.MapPoint_Position Map_Point_Obj = new SYSTEL_ESRI_Control.SYSTEL_ESRI_Main_Control.MapPoint_Position();
                    Map_Point_Obj.Latitude = 26.869798;
                    Map_Point_Obj.Longitude = 30.670388;
                    _esri_MAP.Fly_To(Map_Point_Obj, 10000000);

                    _esri_MAP.Send_DroppedMapPoint_Info += _esri_MAP_Send_DroppedMapPoint_Info;
                    _esri_MAP.Send_MAP_ExtentChanged_Info += _esri_MAP_Send_MAP_ExtentChanged_Info;
                    _esri_MAP.Send_TappedMapPoint_Info += _esri_MAP_Send_TappedMapPoint_Info;

                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
                pictureBox1_Update(false, true);
            }
        }

        private void _esri_MAP_Send_TappedMapPoint_Info(object sender, SYSTEL_ESRI_Control.TappedReturnEventArgs args, int option)
        {
            //throw new NotImplementedException();
        }

        private void _esri_MAP_Send_MAP_ExtentChanged_Info(double w, double h)
        {
            //throw new NotImplementedException();
        }

        private void _esri_MAP_Send_DroppedMapPoint_Info(string name)
        {
            //throw new NotImplementedException();
        }

        delegate void pictureBox1_Update_Delegate(bool flag, bool visability);
        void pictureBox1_Update(bool flag, bool visability)
        {
            try
            {
                if (pictureBox1.InvokeRequired)
                {
                    pictureBox1_Update_Delegate delegate_obj = new pictureBox1_Update_Delegate(pictureBox1_Update);
                    pictureBox1.Invoke(delegate_obj, new object[] { flag, visability });
                }
                else
                {
                    pictureBox1.Visible = visability;

                    if (flag)
                        pictureBox1.Image = Properties.Resources.Online;
                    else
                        pictureBox1.Image = Properties.Resources.Offline;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }

        }


        delegate void button6_Update_Delegate(bool flag);
        void button6_Update(bool flag)
        {
            try
            {
                if (button6.InvokeRequired)
                {
                    button6_Update_Delegate delegate_obj = new button6_Update_Delegate(button6_Update);
                    button6.Invoke(delegate_obj, new object[] { flag });
                }
                else
                {
                    button6.Enabled = flag;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }
        #endregion

        #region Read Radio Location
        bool Read_GPS_location;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Read_GPS_location = true;
                pictureBox2_Update(false, false);
                Sending(textBox1.Text, "AT+GPSPOS?", textBox9.Text);
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
                pictureBox2_Update(false, true);
            }
        }

        delegate void txt_lat_Update_Delegate(string text);
        void txt_lat_Update(string text)
        {
            try
            {
                if (txt_lat.InvokeRequired)
                {
                    txt_lat_Update_Delegate delegate_obj = new txt_lat_Update_Delegate(txt_lat_Update);
                    txt_lat.Invoke(delegate_obj, new object[] { text });
                }
                else
                {
                    txt_lat.Text = text;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }

        delegate void txt_lon_Update_Delegate(string text);
        void txt_lon_Update(string text)
        {
            try
            {
                if (txt_lon.InvokeRequired)
                {
                    txt_lon_Update_Delegate delegate_obj = new txt_lon_Update_Delegate(txt_lon_Update);
                    txt_lon.Invoke(delegate_obj, new object[] { text });
                }
                else
                {
                    txt_lon.Text = text;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }

        delegate void pictureBox2_Update_Delegate(bool flag, bool visability);
        void pictureBox2_Update(bool flag, bool visability)
        {
            try
            {
                if (pictureBox2.InvokeRequired)
                {
                    pictureBox2_Update_Delegate delegate_obj = new pictureBox2_Update_Delegate(pictureBox2_Update);
                    pictureBox2.Invoke(delegate_obj, new object[] { flag, visability });
                }
                else
                {
                    pictureBox2.Visible = visability;

                    if (flag)
                        pictureBox2.Image = Properties.Resources.Online;
                    else
                        pictureBox2.Image = Properties.Resources.Offline;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }

        delegate void button1_Update_Delegate(bool flag);
        void button1_Update(bool flag)
        {
            try
            {
                if (button1.InvokeRequired)
                {
                    button1_Update_Delegate delegate_obj = new button1_Update_Delegate(button1_Update);
                    button1.Invoke(delegate_obj, new object[] { flag });
                }
                else
                {
                    button1.Enabled = flag;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }
        #endregion

        #region Radio TETRA Sites
        bool Get_Radio_Sites;
        List<string> Sites_List = new List<string>();
        List<string> Sites_RSSI_List = new List<string>();
        string Site_info = "";
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text.Trim() != "" && textBox7.Text.Trim() != "")
                {
                    Get_Radio_Sites = true;
                    pictureBox3_Update(false, false);

                    Sites_List.Clear();
                    Site_info = "";
                    txt_TETRA_Sites.Text = "";
                    Sites_RSSI_List.Clear();
                    Sending(textBox7.Text, "AT+GCLI?", textBox8.Text);
                }
            }catch(Exception ex)
            {
                Auditing.Error(ex.Message);
                pictureBox3_Update(false, true);

            }
        }

        delegate void txt_TETRA_Sites_Update_Delegate(string text);
        void txt_TETRA_Sites_Update(string text)
        {
            try
            {
                if (txt_TETRA_Sites.InvokeRequired)
                {
                    txt_TETRA_Sites_Update_Delegate delegate_obj = new txt_TETRA_Sites_Update_Delegate(txt_TETRA_Sites_Update);
                    txt_TETRA_Sites.Invoke(delegate_obj, new object[] { text });
                }
                else
                {
                    txt_TETRA_Sites.Text = text;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }

        delegate void pictureBox3_Update_Delegate(bool flag, bool visability);
        void pictureBox3_Update(bool flag, bool visability)
        {
            try
            {
                if (pictureBox3.InvokeRequired)
                {
                    pictureBox3_Update_Delegate delegate_obj = new pictureBox3_Update_Delegate(pictureBox3_Update);
                    pictureBox3.Invoke(delegate_obj, new object[] { flag, visability });
                }
                else
                {
                    pictureBox3.Visible = visability;

                    if (flag)
                        pictureBox3.Image = Properties.Resources.Online;
                    else
                        pictureBox3.Image = Properties.Resources.Offline;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }

        delegate void button4_Update_Delegate(bool flag);
        void button4_Update(bool flag)
        {
            try
            {
                if (button4.InvokeRequired)
                {
                    button4_Update_Delegate delegate_obj = new button4_Update_Delegate(button4_Update);
                    button4.Invoke(delegate_obj, new object[] { flag });
                }
                else
                {
                    button4.Enabled = flag;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }
        #endregion

        #region Read and set radio TG

        #region Radio TGs
        bool Get_All_Radio_TGs;

        List<string> TGs_List = new List<string>();
        string TG_info = "";

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text.Trim() != "" && textBox4.Text.Trim() != "")
                {
                    TGs_List.Clear();
                    comboBox1.Items.Clear();
                    pictureBox4_Update(false, false);

                    TG_info = "";
                    Sending(textBox4.Text, "AT+CTGL=1,0", textBox5.Text);
                    Thread.Sleep(1000);
                    Get_All_Radio_TGs = true;
                    Sending(textBox4.Text, "AT+CTGL?", textBox5.Text);

                }
            }catch(Exception ex)
            {
                Auditing.Error(ex.Message);
               pictureBox4_Update(false, true);
            }
        }

        delegate void comboBox1_Update_Delegate(List<string> TGs);
        void comboBox1_Update(List<string> TGs)
        {
            try
            {
                if (comboBox1.InvokeRequired)
                {
                    comboBox1_Update_Delegate delegate_obj = new comboBox1_Update_Delegate(comboBox1_Update);
                    comboBox1.Invoke(delegate_obj, new object[] { TGs });
                }
                else
                {
                    comboBox1.Items.AddRange((object[])TGs.ToArray());
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }

        delegate void button2_Update_Delegate(bool flag);
        void button2_Update(bool flag)
        {
            try
            {
                if (button2.InvokeRequired)
                {
                    button2_Update_Delegate delegate_obj = new button2_Update_Delegate(button2_Update);
                    button2.Invoke(delegate_obj, new object[] { flag });
                }
                else
                {
                    button2.Enabled = flag;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }
        #endregion

        #region Read Current group
        bool Get_Current_Radio_TG;
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox4_Update(false, false);

                Sending(textBox4.Text, "AT+CTSP=1,1,11", textBox5.Text);
                Thread.Sleep(1000);
                Get_Current_Radio_TG = true;
                Sending(textBox4.Text, "AT+CTGS?", textBox5.Text);
            }catch(Exception ex)
            {
                Auditing.Error(ex.Message);
                pictureBox4_Update(false, true);

            }
        }

        delegate void comboBox1_Select_Update_Delegate(string Current_TG);
        void comboBox1_Select_Update(string Current_TG)
        {
            try
            {
                if (comboBox1.InvokeRequired)
                {
                    comboBox1_Select_Update_Delegate delegate_obj = new comboBox1_Select_Update_Delegate(comboBox1_Select_Update);
                    comboBox1.Invoke(delegate_obj, new object[] { Current_TG });
                }
                else
                {
                    int Selected_Index = 0;

                    string[] TG_info = Current_TG.Split(',');
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString().Contains(TG_info[1]))
                        {
                            Selected_Index = i;
                            break;
                        }
                    }
                    comboBox1.SelectedIndex = (Selected_Index);
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }


        delegate void button5_Update_Delegate(bool flag);
        void button5_Update(bool flag)
        {
            try
            {
                if (button5.InvokeRequired)
                {
                    button5_Update_Delegate delegate_obj = new button5_Update_Delegate(button5_Update);
                    button5.Invoke(delegate_obj, new object[] { flag });
                }
                else
                {
                    button5.Enabled = flag;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }
        #endregion

        #region Change TG

        bool Change_Current_Radio_TG;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox4_Update(false, false);

                Change_Current_Radio_TG = true;
                Sending(textBox4.Text, "AT+CTGS=1," + comboBox1.SelectedItem.ToString().Split(',')[1], textBox5.Text);
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
                pictureBox4_Update(false, true);

            }
        }


        delegate void button3_Update_Delegate(bool flag);
        void button3_Update(bool flag)
        {
            try
            {
                if (button3.InvokeRequired)
                {
                    button3_Update_Delegate delegate_obj = new button3_Update_Delegate(button3_Update);
                    button3.Invoke(delegate_obj, new object[] { flag });
                }
                else
                {
                    button3.Enabled = flag;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }
        #endregion


        delegate void pictureBox4_Update_Delegate(bool flag, bool visability);
        void pictureBox4_Update(bool flag, bool visability)
        {
            try
            {
                if (pictureBox4.InvokeRequired)
                {
                    pictureBox4_Update_Delegate delegate_obj = new pictureBox4_Update_Delegate(pictureBox4_Update);
                    pictureBox4.Invoke(delegate_obj, new object[] { flag, visability });
                }
                else
                {
                    pictureBox4.Visible = visability;

                    if (flag)
                        pictureBox4.Image = Properties.Resources.Online;
                    else
                        pictureBox4.Image = Properties.Resources.Offline;
                }
            }
            catch (Exception ex)
            {
                Auditing.Error(ex.Message);
            }
        }
        #endregion

    }
}
