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
        private DateTime m_timeGoingToSleep;

        public SleepController()
        {
            m_minsToTimeOut = 10;
            sleepTimer = new Timer();
            sleepTimer.Interval = minsToMilliseconds(m_minsToTimeOut);
            resetSleepTimer();
            sleepTimer.Elapsed += sleepTimer_Elapsed;
        }

        private long minsToMilliseconds(int mins)
        {
            return mins * 60 * 1000;
        }

        public DateTime TimeGoingToSleep
        {
            get
            {
                return m_timeGoingToSleep;
            }

            set
            {
                m_timeGoingToSleep = value;
            }
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
            TimeGoingToSleep = DateTime.Now.AddMinutes(m_minsToTimeOut);
        }
    }
}