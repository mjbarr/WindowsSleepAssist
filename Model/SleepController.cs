using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Model
{
    internal class SleepController
    {
        private int m_minsToTimeOut;
        private Timer sleepTimer;

        public SleepController()
        {
            m_minsToTimeOut = 10;
            sleepTimer = new Timer();
            sleepTimer.Interval = 10 * 60 * 1000;
            sleepTimer.Start();
            sleepTimer.Elapsed += sleepTimer_Elapsed;
        }

        private void sleepTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Standby
            SetSuspendState(false, true, true);
        }

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public void resetSleepTimer()
        {
            sleepTimer.Stop();
            sleepTimer.Start();
        }
    }
}