using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;
using System.Text.RegularExpressions;
using xNet;

namespace Gekko
{
    public partial class Rows : UserControl
    {
        public Rows()
        {
            InitializeComponent();
        }

        readonly string destFolder;
        readonly string start;
        public int a;
        string[] txtRegArray;
        readonly Random random = new Random();
        public string ein;
        public string[] areacoderandom = { "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "212", "213", "214", "215", "216", "217", "218", "219", "220", "223", "224", "225", "226", "228", "229", "231", "234", "236", "239", "240", "248", "250", "251", "252", "253", "254", "256", "260", "262", "267", "269", "270", "272", "276", "278", "281", "283", "289", "301", "302", "303", "304", "305", "307", "308", "309", "310", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "323", "325", "330", "331", "332", "334", "336", "337", "339", "340", "341", "343", "345", "346", "347", "351", "352", "360", "361", "365", "369", "380", "385", "386", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "412", "413", "414", "415", "416", "417", "418", "419", "423", "424", "425", "430", "431", "432", "434", "435", "437", "438", "440", "442", "443", "450", "458", "464", "469", "470", "475", "478", "479", "480", "481", "484", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "512", "513", "514", "515", "516", "517", "518", "519", "520", "530", "539", "540", "541", "548", "551", "557", "559", "561", "562", "563", "564", "567", "570", "571", "573", "574", "575", "579", "580", "581", "585", "586", "587", "601", "602", "603", "604", "605", "606", "607", "608", "609", "610", "612", "613", "614", "615", "616", "617", "618", "619", "620", "623", "626", "627", "628", "629", "630", "631", "636", "639", "641", "646", "647", "650", "651", "657", "660", "661", "662", "667", "669", "678", "679", "681", "682", "689", "701", "702", "703", "704", "705", "706", "707", "708", "709", "712", "713", "714", "715", "716", "717", "718", "719", "720", "724", "725", "727", "731", "732", "734", "737", "740", "743", "747", "754", "757", "760", "762", "763", "764", "765", "769", "770", "772", "773", "774", "775", "778", "779", "780", "781", "782", "785", "786", "787", "801", "802", "803", "804", "805", "806", "807", "810", "812", "813", "814", "815", "816", "817", "818", "819", "825", "828", "830", "831", "832", "835", "843", "845", "847", "848", "850", "856", "857", "858", "859", "860", "862", "863", "864", "865", "867", "870", "872", "873", "878", "901", "902", "903", "904", "905", "906", "907", "908", "909", "910", "912", "913", "914", "915", "916", "917", "918", "919", "920", "925", "927", "928", "929", "931", "935", "936", "937", "939", "940", "941", "947", "949", "951", "952", "954", "956", "957", "959", "970", "971", "972", "973", "975", "978", "979", "980" };
        public string phone;
        public string ccmonthonenumber;
        readonly string eEmail;
        readonly string ePassword;
        readonly string pathTool = Directory.GetCurrentDirectory();
        readonly string UAa;
        public void AddUserAgent(string config) 
        {
            string pathData = pathTool + @"\Data";

            string savedInfoDir = $@"{pathData}\DataUserAgent.txt";
            if (!File.Exists(savedInfoDir))
            {
                return;
            }
            string selectDevice = string.Empty;
            if (config.Contains("Android"))
            {
                selectDevice = "Android";
            }
            if (config.Contains("Macintosh"))
            {
                selectDevice = "Intel Mac OS";
            }
            if (config.Contains("Windows"))
            {
                selectDevice = "Windows";
            }
            if (config.Contains("Linux"))
            {
                selectDevice = "Linux";
            }
            if (config.Contains("iPhone"))
            {
                selectDevice = "iPhone";
            }
            if (config.Contains("iPad"))
            {
                selectDevice = "iPad";
            }

            string selectBrowser = string.Empty;
            if (config.Contains("Chrome"))
            {
                selectBrowser = "Chrome";
            }
            if (config.Contains("Firefox"))
            {
                selectBrowser = "Firefox";
            }
            if (config.Contains("Safari"))
            {
                selectBrowser = "Safari";
            }
            string UAData = File.ReadAllText(savedInfoDir);
           
            string[] txtEdit = Regex.Split(UAData, "\r\n");
            foreach (string UA in txtEdit)
            {
                if (UA.Contains($"{selectDevice}"))
                {
                    if (UA.Contains($"{selectBrowser}"))
                    {
                        if (!cbbUserAgent.Items.Contains(UA))
                        {
                            cbbUserAgent.Items.Add(UA);
                        }
                    }
                }

            }
        }
       
        public Rows(string data, string UA, string dest_folder, string startPage, string email, string password)
        {
            InitializeComponent();
            string pathTool = System.IO.Directory.GetCurrentDirectory();
            txtFolderName.Text = $@"{dest_folder.Replace($@"{pathTool}\Profile\", "")}";
            if (!data.Contains("/"))
            {
                return;
            }
            string[] DataSplit = data.Split('/');

            UAa = UA;
            txtIP.Text = $@"{DataSplit[0]} {DataSplit[3]} {DataSplit[1]} {DataSplit[2]} {DataSplit[4]}";
            
            
            
            AddUserAgent(UA);
            cbbUserAgent.Text = UA;
            #region properties ptbOSImage

            if (UA.Contains("Windows")) ptbOS.Image = Properties.Resources.logo;
            if (UA.Contains("Linux")) ptbOS.Image = Properties.Resources.linux;
            if (UA.Contains("iPhone")) ptbOS.Image = Properties.Resources.brand;
            if (UA.Contains("iPad")) ptbOS.Image = Properties.Resources.brand;
            if (UA.Contains("Android")) ptbOS.Image = Properties.Resources.android;
            if (UA.Contains("Macintosh")) ptbOS.Image = Properties.Resources.mac;
            #endregion
            cbbUserAgent.SelectedIndex = 0;



            #region properties ptbOSImage

            #endregion
            eEmail = email;
            ePassword = password;
            destFolder = dest_folder;
            start = startPage;
        }

        private void Rows_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void Rows_MouseLeave(object sender, EventArgs e)
        {
            //36, 35, 36
            this.BackColor = Color.FromArgb(36, 35, 36);
        }



        private void BtnDeleteProfile_Click(object sender, EventArgs e)
        {
            try
            {


                System.IO.DirectoryInfo di = new DirectoryInfo($@"{destFolder}");
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                di.Delete(true);
            }
            catch (Exception)
            {

                return;
            }
        }

        Process c;
        private void BtnStart_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            
            string checkIP = http.Get($@"http://ipinfo.io/?token=20b472b9aceb55").ToString();




            if (checkIP != null)
            {

                //string ip = Regex.Match(checkIP, "ip: \"(.+?)\", iso").Groups[1].Value;
                string ip = Regex.Match(checkIP, @"""ip"": ""(.+?)"",").Groups[1].Value.Trim();
                string city = Regex.Match(checkIP, @"""city"": ""(.+?)"",").Groups[1].Value.Trim();
                string region = Regex.Match(checkIP, @"""region"": ""(.+?)"",").Groups[1].Value.Trim();
                string country = Regex.Match(checkIP, @"""country"": ""(.+?)"",").Groups[1].Value.Trim();

                string nameISP = Regex.Match(checkIP, @"""name"": ""(.+?)"",").Groups[1].Value.Trim();

                string data = $@"{country}/{region}/{city}/{ip}/{nameISP}";
                string[] DataSplit = data.Split('/');

                
                txtIP.Text = $@"{DataSplit[0]} {DataSplit[3]} {DataSplit[1]} {DataSplit[2]} {DataSplit[4]}";




                string savedInfo = $@"{data}|{UAa}|{start}|{eEmail}|{ePassword}";
                File.WriteAllText($@"{destFolder}\savedinfo.txt", savedInfo);
                c = Process.Start($@"{destFolder}\FirefoxPortable.exe", start);
            }
            if (checkIP == null) { c = Process.Start($@"{destFolder}\FirefoxPortable.exe", start); }
        }
        private static void KillProcessAndChildren(int pid)
        {
            // Cannot close 'system idle process'.
            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                    ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                KillProcessAndChildren(c.Id);
            }
            catch (Exception) { return; }
        }





        private void BtnPause_Click_1(object sender, EventArgs e)
        {
            string pathBrowser = $@"{destFolder}\App\Firefox\browser\jsoverrider.js";

            if (btnPause.Text == "Pause")
            {


                string text = File.ReadAllText(pathBrowser);
                string text1 = text.Replace("//Write Here 1", "/*x Write Hex");
                string text2 = text1.Replace("//Write Here 2", "//Write Hex*/");
                File.WriteAllText(pathBrowser, text2);
                btnPause.Text = "Resume";
                return;
            }
            if (btnPause.Text == "Resume")
            {
                if (!txtFolderName.Text.Contains("|"))
                {
                    string textResume = File.ReadAllText(pathBrowser);
                    string textResume1 = textResume.Replace("/*x Write Hex", "//Write Here 1");
                    string textResume2 = textResume1.Replace("//Write Hex*/", "//Write Here 2");
                    File.WriteAllText(pathBrowser, textResume2);
                    btnPause.Text = "Pause";
                    return;
                }
                txtRegArray = txtFolderName.Text.Split('|');

                ein = $"{random.Next(10, 99)}-{random.Next(100, 999)}{random.Next(1000, 9999)}";



                phone = $"{areacoderandom[random.Next(areacoderandom.Length)]}-{random.Next(100, 999)}-{random.Next(1000, 9999)}";
                if (txtRegArray.Length == 12)
                {
                    int ccmonth = Convert.ToInt32(txtRegArray[3]);
                    ccmonthonenumber = txtRegArray[3].Trim();
                    if (ccmonth < 10)
                    {
                        ccmonthonenumber = txtRegArray[3].Remove(0, 1).Trim();
                    }

                    if (txtRegArray[4].Length == 2)
                    {
                        a = Convert.ToInt32(txtRegArray[4]) + 2000;
                        txtRegArray[4] = a.ToString();

                    }
                    string fileEdit = File.ReadAllText(pathBrowser);
                    string[] txtEdit = Regex.Split(fileEdit, "//Write Here Edit");
                    string textReplace = $@"function(){{
var quality = parseInt('{txtRegArray[10].Trim()}');
var email = '{txtRegArray[0].Trim()}';
var password = '{txtRegArray[1].Trim()}';
var name = '{txtRegArray[5].Trim()}';
var addr1 = '{txtRegArray[6].Trim()}';
var addr2 = '';
var city = '{txtRegArray[7].Trim()}';
var state = '{txtRegArray[8].Trim()}';
var zip = '{txtRegArray[9].Trim()}';
var phone = '{phone.Trim()}';
var item =  '{txtRegArray[11].Trim()}';
 var ccnum = '{txtRegArray[2].Trim()}';
var ccmonth = parseInt('{txtRegArray[3].Trim()}');
var ccyear = parseInt('{txtRegArray[4].Trim()}'); 
var time = parseInt('8000');
var ccmonthonenumber = parseInt('{ccmonthonenumber.Trim()}');
var ein ='{ein}';
";
                    string note = fileEdit.Replace(txtEdit[0], textReplace);
                    File.WriteAllText(pathBrowser, note);

                }
                string text = File.ReadAllText(pathBrowser);
                string text1 = text.Replace("/*x Write Hex", "//Write Here 1");
                string text2 = text1.Replace("//Write Hex*/", "//Write Here 2");
                File.WriteAllText(pathBrowser, text2);
                btnPause.Text = "Pause";
                return;
            }


        }



        private void GunaPictureBox1_Click(object sender, EventArgs e)
        {
            string editJS = string.Empty;
            string editJSON = string.Empty;
            foreach (string JS in Directory.GetFiles($@"{destFolder}", "jsoverrider.js",
            SearchOption.AllDirectories))
            {
                editJS = File.ReadAllText(JS);
            }
            foreach (string JSON in Directory.GetFiles($@"{destFolder}", "jsoverrider.json",
            SearchOption.AllDirectories))
            {
                editJSON = File.ReadAllText(JSON);
            }

            _ = Regex.Match(editJSON, @"""availWidth"":(.+?)},""").Groups[1].Value.Trim();
            _ = Regex.Match(editJSON, @"""userAgent"":""(.+?)"",""").Groups[1].Value.Trim();
            _ = Regex.Match(editJS, @"var deviceId1 = ""(.+?)"";").Groups[1].Value.Trim();
            _ = Regex.Match(editJS, @"var deviceId2 = ""(.+?)"";").Groups[1].Value.Trim();
            _ = Regex.Match(editJS, @"var deviceId3 = ""(.+?)"";").Groups[1].Value.Trim();

        }

        private void BtnChangeAgent_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("UA Has Changed");
            }
            if (cbbUserAgent.SelectedItem.ToString().Equals("Custom UserAgent"))
            {
                return;
            }
            foreach (string JSON in Directory.GetFiles($@"{destFolder}", "jsoverrider.json",
            SearchOption.AllDirectories))
            {
                string editJSON = File.ReadAllText(JSON);
                string UAofConfig = Regex.Match(editJSON, @"""userAgent"":""(.+?)"",""").Groups[1].Value.Trim();
                string UAofConfigNoMozilla = UAofConfig.Replace("Mozilla/", "");
                string UAChange = cbbUserAgent.Text.Replace("Mozilla/", "");
                
                string newText = editJSON.Replace(UAofConfigNoMozilla, UAChange);
                File.WriteAllText(JSON, newText);
            }
        }

     

        private void BtnFolder_Click_1(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $@"{destFolder}\App\Firefox\browser\jsoverrider.js");
        }

        private void cbbUserAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFolderName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

