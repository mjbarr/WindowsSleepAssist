using Model;
using NishBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.ServiceProcess;
using System.Windows.Forms;
using WcfInterface;

namespace WindowsSleepAssist
{
    public partial class SleepAssistMain : Form
    {

        #region Fields

        private ConfigSettings m_ConfigSettings;
        //private SleepAssist sleepAssist;
        private SharedMemory m_sharedMem;

        private SleepAssistData sleepAssistData;

        #endregion Fields

        #region Constructors

        public SleepAssistMain()
        {
            InitializeComponent();
            startTimer();

            m_ConfigSettings = ConfigSettings.getSettings();
            chkHibernate.Checked = m_ConfigSettings.Hibernate;
            numMinsToSleep.Value = m_ConfigSettings.NoOfMinsUntilSleep;

            notifyIconMenuExit.Click += notifyIconMenuExit_Click;
            notifyIconMenuViewDashboard.Click += notifyIconMenuViewDashboard_Click;
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

        private void chkHibernate_CheckedChanged(object sender, EventArgs e)
        {
            m_ConfigSettings.Hibernate = chkHibernate.Checked;
        }


        private void displayPowerCfgRequests()
        {
            if (sleepAssistData.powerRequests != null)
            {
                syncItemsInListBox(listBoxDisplayRequests, sleepAssistData.powerRequests.DisplayRequests);
                syncItemsInListBox(listboxSystemRequests, sleepAssistData.powerRequests.SystemRequests);
                syncItemsInListBox(listBoxAwayModeRequests, sleepAssistData.powerRequests.AwayModeRequests);
                syncItemsInListBox(listBoxExecutionRequests, sleepAssistData.powerRequests.ExecutionRequests);
                syncItemsInListBox(listBoxPerBoostRequests, sleepAssistData.powerRequests.PerfBoostRequests);
            }
        }


        private void syncItemsInListBox(MultiLineListBox listbox, List<string> items)
        {
            try
            {
                List<string> list = new List<string>(items);
                foreach (string item in listbox.Items)
                {
                    if (!list.Contains(item))
                    {
                        listbox.Items.Remove(item);
                    }
                }

                foreach (string item in list)
                {
                    if (!listbox.Items.Contains(item))
                    {
                        listbox.Items.Add(item);
                    }
                }
            }
            catch (InvalidOperationException) { }
        }


        private long minsToMilliseconds(int mins)
        {
            return mins * 60 * 1000;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        void notifyIconMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void notifyIconMenuViewDashboard_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void numMinsToSleep_ValueChanged(object sender, EventArgs e)
        {
            m_ConfigSettings.NoOfMinsUntilSleep = (int)numMinsToSleep.Value;
        }

        private void readFromSharedMemory()
        {
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");
            sleepAssistData = (SleepAssistData)m_sharedMem.ReadObjectFromMMF(@"Global\wsa_trafficIn");
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

        private void startTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();

            Timer countDownTimer = new Timer();
            countDownTimer.Interval = 1000;
            countDownTimer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            readFromSharedMemory();

            sleepAssistData.DesktopAppConnected = true;
            sleepAssistData.lastUserActivityTime = UserInputMonitor.GetLastInputTime();

            sleepAssistData.MinsBeforeSleep = (int)numMinsToSleep.Value;
            sleepAssistData.Hibernate = chkHibernate.Checked;

            updateUI();


            writeToSharedMemory();

        }
        private void updateUI()
        {
            if (sleepAssistData != null)
            {
                if (sleepAssistData.timeGoingToSleep != null)
                {
                    TimeSpan timeSpan = sleepAssistData.timeGoingToSleep.Subtract(DateTime.Now);
                    lblSleepTimerValue.Text = (timeSpan.ToString(@"h\:mm\:ss"));
                }
                lblInboundTraffic.Text = BytesToString(sleepAssistData.trafficIn);
                lblOutboundTraffic.Text = BytesToString(sleepAssistData.trafficOut);
                displayPowerCfgRequests();

                lblCpuActivity.Text = sleepAssistData.CpuActivity.ToString() + "%";

                setActivityIndicator(lblUserActive, lblUserInputLastTime, sleepAssistData.TimeOfUserInput);
                setActivityIndicator(lblNetworkActive, lblNetworkLastTime, sleepAssistData.TimeOfNetworkActivity);
                setActivityIndicator(lblRequestsActive, lblRequestsLastTime, sleepAssistData.TimeOfRequests);
                setActivityIndicator(lblCpuActive, lblCpuLastTime, sleepAssistData.TimeOfCpuActivity);
            }
        }

        private void setActivityIndicator(Label lblComponentActive, Label lblLastTime, DateTime lastActivityTime)
        {
            if (DateTime.Now.Subtract(lastActivityTime).Minutes < sleepAssistData.MinsBeforeSleep)
            {
                lblLastTime.Text = getNumberOfMinutesAgo(lastActivityTime);
                lblComponentActive.ForeColor = Color.Black;
                lblLastTime.Visible = true;
            }
            else
            {
                lblLastTime.Visible = false;
                lblComponentActive.ForeColor = Color.DarkGray;
            }
        }

        private string getNumberOfMinutesAgo(DateTime time)
        {
            int minutes = DateTime.Now.Subtract(time).Minutes;
            int seconds = DateTime.Now.Subtract(time).Seconds;
            string result;
            if (minutes < 1)
            {
                if (seconds < 15)
                {
                    result = "Just Now";
                }
                else if (seconds < 30)
                {
                    result = "15 seconds ago";
                }
                else
                {
                    result = "30 seconds ago";
                }
            }
            else if (minutes == 1)
            {
                result = "1 minute ago";
            }
            else
            {
                result = minutes + " minutes ago";
            }

            return result;
        }

        private void writeToSharedMemory()
        {
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");
            m_sharedMem.WriteObjectToMMF(@"Global\wsa_trafficIn", sleepAssistData, false);
        }

        #endregion Methods

        private void SleepAssistMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            DialogResult result = (MessageBox.Show("Closing this application means your computer may not go to sleep.  Are you sure you want to do this?", "Exit Windows Sleep Assist",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            switch (result)
            {
                case DialogResult.Yes:
                    break;

                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }

        }
    }


}