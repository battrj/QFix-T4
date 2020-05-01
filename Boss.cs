using xNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace Gekko
{
    public partial class FrmMain : Form
    {
        public int a;
        public string phone;
        public string[] txtRegArray;
        readonly Random random = new Random();
        public string email;
        public string sourcefolder;
        public string dest_folder;
        public string ein;
        public string time;
        public string ccmonthonenumber;
        public string Add2;
        public string password;
        public string startPage;

        public string[] areacoderandom = { "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "212", "213", "214", "215", "216", "217", "218", "219", "220", "223", "224", "225", "226", "228", "229", "231", "234", "236", "239", "240", "248", "250", "251", "252", "253", "254", "256", "260", "262", "267", "269", "270", "272", "276", "278", "281", "283", "289", "301", "302", "303", "304", "305", "307", "308", "309", "310", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "323", "325", "330", "331", "332", "334", "336", "337", "339", "340", "341", "343", "345", "346", "347", "351", "352", "360", "361", "365", "369", "380", "385", "386", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "412", "413", "414", "415", "416", "417", "418", "419", "423", "424", "425", "430", "431", "432", "434", "435", "437", "438", "440", "442", "443", "450", "458", "464", "469", "470", "475", "478", "479", "480", "481", "484", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "512", "513", "514", "515", "516", "517", "518", "519", "520", "530", "539", "540", "541", "548", "551", "557", "559", "561", "562", "563", "564", "567", "570", "571", "573", "574", "575", "579", "580", "581", "585", "586", "587", "601", "602", "603", "604", "605", "606", "607", "608", "609", "610", "612", "613", "614", "615", "616", "617", "618", "619", "620", "623", "626", "627", "628", "629", "630", "631", "636", "639", "641", "646", "647", "650", "651", "657", "660", "661", "662", "667", "669", "678", "679", "681", "682", "689", "701", "702", "703", "704", "705", "706", "707", "708", "709", "712", "713", "714", "715", "716", "717", "718", "719", "720", "724", "725", "727", "731", "732", "734", "737", "740", "743", "747", "754", "757", "760", "762", "763", "764", "765", "769", "770", "772", "773", "774", "775", "778", "779", "780", "781", "782", "785", "786", "787", "801", "802", "803", "804", "805", "806", "807", "810", "812", "813", "814", "815", "816", "817", "818", "819", "825", "828", "830", "831", "832", "835", "843", "845", "847", "848", "850", "856", "857", "858", "859", "860", "862", "863", "864", "865", "867", "870", "872", "873", "878", "901", "902", "903", "904", "905", "906", "907", "908", "909", "910", "912", "913", "914", "915", "916", "917", "918", "919", "920", "925", "927", "928", "929", "931", "935", "936", "937", "939", "940", "941", "947", "949", "951", "952", "954", "956", "957", "959", "970", "971", "972", "973", "975", "978", "979", "980" };
        readonly string pathTool = Directory.GetCurrentDirectory();
        public FrmMain()
        {
            InitializeComponent();
            AddItem();
            AddShipData();
        }

        public void AddShipData()
        {
            string pathData = pathTool + @"\Data";

            string savedInfoDir = $@"{pathData}\DataShip.txt";
            if (!File.Exists(savedInfoDir))
            {
                return;
            }

            string ShipData = File.ReadAllText(savedInfoDir);

            string[] txtEdit = Regex.Split(ShipData, "\r\n");
            foreach (string data in txtEdit)
            {
                if (data.Equals(""))
                {
                    break;
                }
                if (!cbbShipData.Items.Contains(data))
                {
                    cbbShipData.Items.Add(data);
                }

            }
        }


        List<string> lstAllUserAgents;
        
        public void AddItem()
        {
            lstAllUserAgents = new List<string>();
            
            string pathconfig = pathTool + @"\Config";
            foreach (string info in Directory.GetFiles($@"{pathconfig}", "jsoverrider.json",
            SearchOption.AllDirectories))
            {
                string directoryName = Path.GetDirectoryName(info);
                string UA = File.ReadAllText(info);
                string UARegex = Regex.Match(UA, @"""userAgent"":""(.+?)"",""").Groups[1].Value.Trim();
                string configUA = UARegex + $@"|{directoryName}";
                

                lstAllUserAgents.Add(configUA);
                cbbWebGL.Items.Add(UARegex);
            }
            
            cbbDevice.SelectedIndex = 1;
            cbbJS.SelectedIndex = 0;
            cbbWebGL.SelectedIndex = 0;
        }
      
 


        private void GunaImageButton1_Click(object sender, EventArgs e)
        {
            
            string[] JSselect = lstAllUserAgents.Where(x => x.Contains(cbbWebGL.SelectedItem.ToString())).FirstOrDefault().Split('|');
            string test = string.Empty;
            string device = string.Empty;
            

            string textReplace = string.Empty;
            string jsType = string.Empty;
            string time = "10000";
            string Add2 = string.Empty;
            string UA = cbbWebGL.SelectedItem.ToString().Trim();
            string startBusiness = "https://www.amazon.com/b2b/info/amazon-business?layout=landing/";
            sourcefolder = pathTool + $@"\Firefox";
            dest_folder = string.Empty;
            if (!cbbWebGL.SelectedItem.ToString().Contains("Mobile"))
            {
                device = "PC";
            }
            else
            {
                device = "Mobile";
            }

            txtRegArray = txtData.Text.Split('|');

            string areacode = areacoderandom[random.Next(areacoderandom.Length)];
            ein = $"{random.Next(10, 99)}-{random.Next(100, 999)}{random.Next(1000, 9999)}";

            phone = $"{areacode}-{random.Next(100, 999)}-{random.Next(1000, 9999)}";
            #region length12
            if (txtRegArray.Length == 12)
            {
                email = txtRegArray[0].Trim();
                password = txtRegArray[1].Trim();
                int ccmonth = Convert.ToInt32(txtRegArray[3]);
                ccmonthonenumber = txtRegArray[3].Trim();
                if (ccmonth < 10)
                {
                    ccmonthonenumber = txtRegArray[3].Remove(0, 1).Trim();
                }
                if (txtRegArray[4].Length == 2)
                {
                    a = Convert.ToInt32(txtRegArray[4]) + 2000;
                    txtRegArray[4] = a.ToString().Trim();

                }
                  startPage = txtRegArray[11].Trim();


                if (!Directory.Exists($@"{sourcefolder}") == true)
                {
                    MessageBox.Show("Failed Firefox");
                    return;
                }

                dest_folder = $@"{pathTool}\Profile\{txtRegArray[0].Trim()} {txtRegArray[2].Trim()} {txtRegArray[3].Trim()} {txtRegArray[4].Trim()}";
                foreach (string dirPath in Directory.GetDirectories($@"{sourcefolder}", "*",
                           SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace($@"{sourcefolder}", dest_folder));

                foreach (string newPath in Directory.GetFiles($@"{sourcefolder}", "*.*",
            SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace($@"{sourcefolder}", dest_folder), true);
                textReplace = $@"var quality = parseInt('{txtRegArray[10].Trim()}');
var email = '{txtRegArray[0].Trim()}';
var password = '{txtRegArray[1].Trim()}';


var name = '{txtRegArray[5].Trim()}';
var addr1 = '{txtRegArray[6].Trim()}';
var addr2 = '{Add2.Trim()}';
var city = '{txtRegArray[7].Trim()}';
var state = '{txtRegArray[8].Trim()}';
var zip = '{txtRegArray[9].Trim()}';
var phone = '{phone.Trim()}';
var item =  '{txtRegArray[11].Trim()}';
 var ccnum = '{txtRegArray[2].Trim()}';
var ccmonth = parseInt('{txtRegArray[3].Trim()}');
var ccyear = parseInt('{txtRegArray[4].Trim()}'); 
var time = parseInt('{time}');
var ccmonthonenumber = parseInt('{ccmonthonenumber}');
var ein ='{ein}';";
                #endregion
            }
            if (device == "PC")
            {
                jsType = cbbJS.SelectedItem.ToString().Trim();
                #region PC Business
                if (jsType == "Business")
                {
                    startPage = $@"{startBusiness}";
                    test = File.ReadAllText($@"{pathTool}/Data/PC_BUS.js");
                    #endregion
                }
                #region PC Normal
                if (jsType != "Business")
                {

                    test = File.ReadAllText($@"{pathTool}/Data/PC_NOR.js");
                    #endregion
            }
            }
            if (device != "PC")
            {
                #region Mobile Business
                jsType = cbbJS.SelectedItem.ToString().Trim();

                if (jsType == "Business")
                {
                    startPage = $@"{startBusiness}";
                    test = File.ReadAllText($@"{pathTool}/Data/MOB_BUS.js");
                }
                #endregion
                #region Mobile Normal
                if (jsType != "Business")
                {
                    test = File.ReadAllText($@"{pathTool}/Data/MOB_NOR.js");
                    if (cbbWebGL.SelectedItem.ToString().Contains("iPad"))
                    {
                        test = File.ReadAllText($@"{pathTool}/Data/PC_NOR.js");
                    }
                }
                #endregion
            }
            string newText = test.Replace($@"var quality = parseInt(""@Quality@"");
var email = ""@Email@"";
var password = '@Password@';
var name = ""@Name@"";
var addr1 = ""@Addr1@"";
var addr2 = '@Addr2@';
var city = '@City@';
var state = '@State@';
var zip = '@Zip@';
var ccnum = ""@CC@"";
var ccmonth = parseInt(""@Month@"");
var ccyear = parseInt(""@Year@"");
var time = parseInt('@Time@');", textReplace);
            string pathdirJS = $@"{dest_folder}\App\Firefox\browser\";
            string patholdJS = $@"{dest_folder}\App\Firefox\browser\jsoverrider.js";
            foreach (
            string newPath in Directory.GetFiles($@"{JSselect[1]}", "*.*",
            SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace($@"{JSselect[1]}", pathdirJS), true);
            string configJS = File.ReadAllText(patholdJS);
            string note = configJS.Replace($@"function() {{
var webglConfig =", $@"{newText}var webglConfig =");
            File.WriteAllText(patholdJS, note);
            
            if (pnlWorking1.Controls.Count < 100)
            {
                pnlLoading.Visible = true;
                DateTime Tthen = DateTime.Now;
                //do
                //{
                //    Application.DoEvents();
                //} while (Tthen.AddSeconds(2) > DateTime.Now);
                System.Threading.Tasks.Task.Factory.StartNew(() =>
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

                        string savedInfo = $@"{data}|{UA}|{startPage}|{email}|{password}";
                        File.WriteAllText($@"{dest_folder}\savedinfo.txt", savedInfo);
                        this.Invoke(new MethodInvoker(() =>
                        {
                            Rows profileRow = new Rows(data, UA, dest_folder, startPage, email, password);
                            pnlWorking1.Controls.Add(profileRow);
                            pnlLoading.Visible = false;
                            
                        }));
                    }
                    else
                    {
                        string data = "";
                        string savedInfo = $@"{data}|{UA}|{startPage}|{email}|{password}";
                        File.WriteAllText($@"{dest_folder}\savedinfo.txt", savedInfo);
                        this.Invoke(new MethodInvoker(() =>
                        {
                            Rows profileRow = new Rows(data, UA, dest_folder, startPage, email, password);
                            pnlWorking1.Controls.Add(profileRow);
                            pnlLoading.Visible = false;
                           
                        }));
                    }
                });

            }

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbWebGL.Items.Clear();
            lstAllUserAgents.Clear();
            if (cbbDevice.SelectedItem.ToString().Equals("Windows"))
            {
                string pathconfig = pathTool + @"\Config\Windows";
                foreach (string info in Directory.GetFiles($@"{pathconfig}", "jsoverrider.json",
                SearchOption.AllDirectories))
                {
                    string directoryName = Path.GetDirectoryName(info);
                    string UA = File.ReadAllText(info);
                    string UARegex = Regex.Match(UA, @"""userAgent"":""(.+?)"",""").Groups[1].Value.Trim();
                    string configUA = UARegex + $@"|{directoryName}";


                    lstAllUserAgents.Add(configUA);
                    cbbWebGL.Items.Add(UARegex);
                }
            }
            if (cbbDevice.SelectedItem.ToString().Equals("Macintosh"))
            {
                string pathconfig = pathTool + @"\Config\Macintosh";
                foreach (string info in Directory.GetFiles($@"{pathconfig}", "jsoverrider.json",
                SearchOption.AllDirectories))
                {
                    string directoryName = Path.GetDirectoryName(info);
                    string UA = File.ReadAllText(info);
                    string UARegex = Regex.Match(UA, @"""userAgent"":""(.+?)"",""").Groups[1].Value.Trim();
                    string configUA = UARegex + $@"|{directoryName}";


                    lstAllUserAgents.Add(configUA);
                    cbbWebGL.Items.Add(UARegex);
                }
            }
            if (cbbDevice.SelectedItem.ToString().Equals("Android"))
            {
                string pathconfig = pathTool + @"\Config\Android";
                foreach (string info in Directory.GetFiles($@"{pathconfig}", "jsoverrider.json",
                SearchOption.AllDirectories))
                {
                    string directoryName = Path.GetDirectoryName(info);
                    string UA = File.ReadAllText(info);
                    string UARegex = Regex.Match(UA, @"""userAgent"":""(.+?)"",""").Groups[1].Value.Trim();
                    string configUA = UARegex + $@"|{directoryName}";


                    lstAllUserAgents.Add(configUA);
                    cbbWebGL.Items.Add(UARegex);
                }
            }
            if (cbbDevice.SelectedItem.ToString().Equals("iPhone"))
            {
                string pathconfig = pathTool + @"\Config\iPhone";
                foreach (string info in Directory.GetFiles($@"{pathconfig}", "jsoverrider.json",
                SearchOption.AllDirectories))
                {
                    string directoryName = Path.GetDirectoryName(info);
                    string UA = File.ReadAllText(info);
                    string UARegex = Regex.Match(UA, @"""userAgent"":""(.+?)"",""").Groups[1].Value.Trim();
                    string configUA = UARegex + $@"|{directoryName}";


                    lstAllUserAgents.Add(configUA);
                    cbbWebGL.Items.Add(UARegex);
                }

            }
            if (cbbDevice.SelectedItem.ToString().Equals("iPad"))
            {
                string pathconfig = pathTool + @"\Config\iPad";
                foreach (string info in Directory.GetFiles($@"{pathconfig}", "jsoverrider.json",
                SearchOption.AllDirectories))
                {
                    string directoryName = Path.GetDirectoryName(info);
                    string UA = File.ReadAllText(info);
                    string UARegex = Regex.Match(UA, @"""userAgent"":""(.+?)"",""").Groups[1].Value.Trim();
                    string configUA = UARegex + $@"|{directoryName}";


                    lstAllUserAgents.Add(configUA);
                    cbbWebGL.Items.Add(UARegex);
                }

            }
        }

        private void BtnLoadProfile_Click(object sender, EventArgs e)
        {
            try
            {
                pnlWorking1.Controls.Clear();
                string profileFolder = pathTool + @"\Profile";
                foreach (string dirPath in Directory.GetDirectories($@"{profileFolder}", "*",
               SearchOption.TopDirectoryOnly))
                {
                    string savedInfoDir = $@"{dirPath}\savedinfo.txt";
                    if (!File.Exists(savedInfoDir))
                    {
                        break;
                    }
                    string savedInfo = File.ReadAllText($@"{savedInfoDir}");
                    string[] infoSplit = savedInfo.Split('|');
                    string data = infoSplit[0].Trim();
                    
                    string UA = infoSplit[1].Trim();
                    
                   
                    string startPage = infoSplit[2].Trim();
                    string email = infoSplit[3].Trim();
                    string password = infoSplit[4].Trim();
                    if (pnlWorking1.Controls.Count < 10)
                    {
                        this.Invoke(new MethodInvoker(() =>
                    {
                        Rows profileRow = new Rows(data, UA, dirPath, startPage, email, password);
                        pnlWorking1.Controls.Add(profileRow);
                        pnlLoading.Visible = false;
                    }));

                        this.Invoke(new MethodInvoker(() =>
                        {
                            Rows profileRow = new Rows(data, UA, dirPath, startPage, email, password);
                            pnlLoading.Visible = false;
                        }));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Profile Or Cant Load");
            }
        }

        private void TxtData_TextChanged(object sender, EventArgs e)
        {
            string[] txtArrayChange = txtData.Text.Split('|');
            if (txtArrayChange.Length == 12)
            {

                try
                {
                    txtLink.Text = txtData.Text.Trim().Split('|')[11];
                }
                catch (Exception)
                {
                    txtLink.Text = string.Empty;
                    return;
                }
                try
                {
                    txtEmail.Text = txtData.Text.Trim().Split('|')[0];
                }
                catch (Exception)
                {
                    txtEmail.Text = string.Empty;
                    return;
                }
                try
                {
                    txtPassword.Text = txtData.Text.Trim().Split('|')[1];
                }
                catch (Exception)
                {
                    txtPassword.Text = string.Empty;
                    return;
                }
                try
                {
                    txtCCNum.Text = txtData.Text.Trim().Split('|')[2];
                }
                catch (Exception)
                {
                    txtCCNum.Text = string.Empty;
                    return;
                }
                try
                {
                    txtMonth.Text = txtData.Text.Trim().Split('|')[3];
                }
                catch (Exception)
                {
                    txtLink.Text = string.Empty;
                    return;
                }
                try
                {
                    txtYear.Text = txtData.Text.Trim().Split('|')[4];
                }
                catch (Exception)
                {
                    txtYear.Text = string.Empty;
                    return;
                }
                try
                {
                    txtFullName.Text = txtData.Text.Trim().Split('|')[5];
                }
                catch (Exception)
                {
                    txtFullName.Text = string.Empty;
                    return;
                }

            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
                Environment.Exit(0);

            }
            catch (Exception)
            {

                throw;
            }
            
        }


        private void CbbShipData_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtData.Text += cbbShipData.Text.Trim();
        }

        private void LblPage1_Click(object sender, EventArgs e)
        {
            pnlWorking1.Visible = true;
        }



        private void BtnFolderData_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe",$@"{pathTool}\Data");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $@"{pathTool}\Profile");
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCCNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {

        }
        private void CbbWebGL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlWorking1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

