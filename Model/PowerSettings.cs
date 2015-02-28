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
        private Timer timer;
        private string requests;

        public PowerSettings()
        {
            timer = new Timer();
            timer.Interval = 15000;
            timer.Elapsed += timer_Elapsed;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PowerCfgEventArgs eventArgs = new PowerCfgEventArgs();
            eventArgs.powerRequests = PowerCfgRequests;
            OnChanged(eventArgs);
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

        internal delegate void PowerCfgUpdatedEventHandler(object sender, PowerCfgEventArgs e);

        internal event PowerCfgUpdatedEventHandler PowerCfgUpdated;

        // Invoke the Changed event; called whenever list changes
        internal virtual void OnChanged(PowerCfgEventArgs e)
        {
            if (PowerCfgUpdated != null)
                PowerCfgUpdated(this, e);
        }
    }

    public class PowerCfgEventArgs : EventArgs
    {
        public string powerRequests { get; set; }
    }
}