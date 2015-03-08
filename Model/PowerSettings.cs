using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WcfInterface;

namespace Model
{
    public class PowerSettings
    {
        private PowerCfgRequestsData powerData;

        public PowerSettings()
        {
            powerData = new PowerCfgRequestsData();
        }

        private void processRequests()
        {
            string requests = getPowerCfgRequests();
            string[] lines = requests.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            powerData.DisplayRequests = getRequestsSection(lines, "DISPLAY:");
            powerData.SystemRequests = getRequestsSection(lines, "SYSTEM:");
            powerData.AwayModeRequests = getRequestsSection(lines, "AWAYMODE:");
            powerData.ExecutionRequests = getRequestsSection(lines, "EXECUTION");
            powerData.PerfBoostRequests = getRequestsSection(lines, "PERFBOOST");
        }

        private List<string> getRequestsSection(string[] lines, string section)
        {
            int i = 0;
            List<string> results = new List<string>();
            while (!lines[i].ToUpper().Contains(section.ToUpper())) i++;
            i++; //go to line after title
            while (!String.IsNullOrEmpty(lines[i]) && i < lines.Count())
            {
                results.Add(lines[i]);
                i++;
            }

            return results;
        }

        private string getPowerCfgRequests()
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
                throw new InvalidProgramException("Application must be run with elevated priviledges.");
            }
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
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        public PowerCfgRequestsData PowerCfgRequests
        {
            get
            {
                processRequests();
                return powerData;
            }
        }

        public bool AllowSleep
        {
            get
            {
                try
                {
                    bool displayRequest = powerData.DisplayRequests[0].ToUpper().Contains("NONE.");
                    bool systemRequest = powerData.SystemRequests[0].ToUpper().Contains("NONE.");
                    bool awayModeRequest = powerData.AwayModeRequests[0].ToUpper().Contains("NONE.");
                    bool executionRequest = powerData.ExecutionRequests[0].ToUpper().Contains("NONE.");
                    bool perfBoostRequest = powerData.PerfBoostRequests[0].ToUpper().Contains("NONE.");
                    return (displayRequest && systemRequest && awayModeRequest && executionRequest && perfBoostRequest);
                }
                catch (NullReferenceException)
                {
                    return true;
                }
            }
        }
    }
}