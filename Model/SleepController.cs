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
        #region Fields

        private int m_minsToTimeOut;
        private DateTime m_timeGoingToSleep;
        private Timer sleepTimer;

        #endregion Fields

        #region Constructors

        public SleepController()
        {
            m_minsToTimeOut = 15;
            sleepTimer = new Timer();
            sleepTimer.Interval = minsToMilliseconds(m_minsToTimeOut);
            resetSleepTimer();
            sleepTimer.Elapsed += sleepTimer_Elapsed;
        }

        #endregion Constructors

        #region Properties

        public bool AllowSleep { get; set; }
        public int MinsBeforeSleep
        {
            get
            {
                return m_minsToTimeOut;
            }
            set
            {
                m_minsToTimeOut = value;
            }
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

        #endregion Properties

        #region Methods

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public void resetSleepTimer()
        {
            sleepTimer.Stop();
            sleepTimer.Interval = minsToMilliseconds(m_minsToTimeOut);
            sleepTimer.Start();
            TimeGoingToSleep = DateTime.Now.AddMinutes(m_minsToTimeOut);
        }

        private long minsToMilliseconds(int mins)
        {
            return mins * 60 * 1000;
        }
        private void sleepTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Standby
            if (AllowSleep)
            {
                SetSuspendState(true, true, false);
            }
            else
            {
                sleepTimer.Stop();
                sleepTimer.Interval = minsToMilliseconds(1);
                sleepTimer.Start();
                TimeGoingToSleep = DateTime.Now.AddMinutes(1);
            }
        }

        #endregion Methods

        public bool Hibernate { get; set; }
    }
}