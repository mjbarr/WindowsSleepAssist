using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Model
{
    public class PowerSettings
    {
        private string requests;

        public PowerSettings()
        {
        }

        public bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                isAdmin = false;
            }
            catch (Exception ex)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        public String PowerCfgRequests
        {
            get
            {
                if (IsUserAdministrator())
                {
                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.FileName = "powercfg";
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.Arguments = "/requests";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();

                    return output;
                }
                else
                {
                    return "Error: Administrator access required";
                }
            }
        }
    }
}