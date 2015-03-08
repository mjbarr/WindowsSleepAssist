using Model;
using System;
using System.Windows.Forms;
using WcfInterface;

namespace WindowsSleepAssist
{
    public partial class SleepAssistMain : Form
    {
        #region Fields

        private SleepAssistData sleepAssistData;

        //private SleepAssist sleepAssist;
        private SharedMemory m_sharedMem;

        private ConfigSettings m_ConfigSettings;

        #endregion Fields

        
        #region Constructors

        public SleepAssistMain()
        {
            //sleepAssist = new SleepAssist();
            //sleepAssist.NetworkSpeedUpdated += sleepAssist_NetworkSpeedUpdated;
            InitializeComponent();
            startTimer();
            m_ConfigSettings = ConfigSettings.getSettings();
            chkHibernate.Checked = m_ConfigSettings.Hibernate;
            numMinsToSleep.Value = m_ConfigSettings.NoOfMinsUntilSleep;

            notifyIconMenuExit.Click += notifyIconMenuExit_Click;
            notifyIconMenuViewDashboard.Click += notifyIconMenuViewDashboard_Click;
        
        }

        void notifyIconMenuViewDashboard_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        void notifyIconMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();

            Timer countDownTimer = new Timer();
            countDownTimer.Interval = 1000;
            countDownTimer.Tick += countDownTimer_Tick;
            countDownTimer.Start();
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            //if (sleepAssistData != null && sleepAssistData.timeGoingToSleep != null)
            //{
            //    TimeSpan timeSpan = sleepAssistData.timeGoingToSleep.Subtract(DateTime.Now);
            //    string minutes = timeSpan.Minutes.ToString();
            //    string seconds = timeSpan.Seconds.ToString();
            //    lblSleepTimerValue.Text = (minutes + ":" + seconds);
            //}

            //if (UserInputMonitor.GetIdleTime() < 1000)
            //{
            //    readFromSharedMemory();
            //    sleepAssistData.lastUserActivityTime = DateTime.Now.AddTicks(-UserInputMonitor.GetLastInputTime());
            //    writeToSharedMemory();
            //}
        }

        private long minsToMilliseconds(int mins)
        {
            return mins * 60 * 1000;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            readFromSharedMemory();
            if (sleepAssistData != null && sleepAssistData.timeGoingToSleep != null)
            {
                TimeSpan timeSpan = sleepAssistData.timeGoingToSleep.Subtract(DateTime.Now);
                lblSleepTimerValue.Text = (timeSpan.ToString(@"h\:mm\:ss"));
            }
            sleepAssistData.DesktopAppConnected = true;
            sleepAssistData.lastUserActivityTime = UserInputMonitor.GetLastInputTime();

            sleepAssistData.MinsBeforeSleep = (int)numMinsToSleep.Value;
            sleepAssistData.Hibernate = chkHibernate.Checked;

            writeToSharedMemory();
            lblInboundTraffic.Text = BytesToString(sleepAssistData.trafficIn);
            lblOutboundTraffic.Text = BytesToString(sleepAssistData.trafficOut);
            displayPowerCfgRequests();
            lblLastWakeTriggerValue.Text = sleepAssistData.lastWakeTrigger;
        }

        private void displayPowerCfgRequests()
        {
            if (sleepAssistData.powerRequests != null)
            {
                listBoxDisplayRequests.DataSource = sleepAssistData.powerRequests.DisplayRequests;
                listboxSystemRequests.DataSource = sleepAssistData.powerRequests.SystemRequests;
                listBoxAwayModeRequests.DataSource = sleepAssistData.powerRequests.AwayModeRequests;
                listBoxExecutionRequests.DataSource = sleepAssistData.powerRequests.ExecutionRequests;
                listBoxPerBoostRequests.DataSource = sleepAssistData.powerRequests.PerfBoostRequests;
            }
        }

        private void writeToSharedMemory()
        {
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");
            m_sharedMem.WriteObjectToMMF(@"Global\wsa_trafficIn", sleepAssistData, false);
        }

        private void readFromSharedMemory()
        {
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");
            sleepAssistData = (SleepAssistData)m_sharedMem.ReadObjectFromMMF(@"Global\wsa_trafficIn");
        }

        #endregion Constructors

        #region Methods

        private String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        private void sleepAssist_NetworkSpeedUpdated(object sender, NetworkSpeedEventArgs e)
        {
            //lblInboundTraffic.Invoke(new MethodInvoker( lblInboundTraffic.Text = BytesToString(e.inboundSpeed); }));
            //lblOutboundTraffic.Invoke(new MethodInvoker(delegate { lblOutboundTraffic.Text = BytesToString(e.outboundSpeed).ToString(); }));
        }

        private void SleepAssistMain_Load(object sender, EventArgs e)
        {
            updateUI();
        }

        private void updateUI()
        {
            // lblPowercfgOutput.Text = sleepAssist.getPowerCfgRequests();
        }

        #endregion Methods

        private void chkHibernate_CheckedChanged(object sender, EventArgs e)
        {
            m_ConfigSettings.Hibernate = chkHibernate.Checked;
        }

        private void numMinsToSleep_ValueChanged(object sender, EventArgs e)
        {
            m_ConfigSettings.NoOfMinsUntilSleep = (int)numMinsToSleep.Value;
        }

        private void SleepAssistMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }



     

        
    }
}