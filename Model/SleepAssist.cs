using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfInterface;

namespace Model
{
    public class SleepAssist
    {
        private PowerSettings m_PowerSettings;
        private NetworkInfo m_NetworkInfo;
        private SleepController m_SleepController;
        private SleepAssistData sleepAssistData;
        private SharedMemory m_sharedMem;
        private UserInputMonitor m_userInputMonitor;

        public SleepAssist()
        {
            sleepAssistData = new SleepAssistData();
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");

            m_SleepController = new SleepController();
            m_PowerSettings = new PowerSettings();
            m_NetworkInfo = new NetworkInfo();
            m_NetworkInfo.NetworkSpeedUpdated += m_NetworkInfo_NetworkSpeedUpdated;
            m_userInputMonitor = new UserInputMonitor();
        }

        private void m_NetworkInfo_NetworkSpeedUpdated(object sender, NetworkSpeedEventArgs e)
        {
            readFromSharedMemory();

            if (e.resetSleepTimer)
            {
                m_SleepController.resetSleepTimer();
                sleepAssistData.lastWakeTrigger = "Network Traffic";
            }

            DateTime lastInputTime = new DateTime(UserInputMonitor.GetLastInputTime());
            if (lastInputTime < DateTime.Now.AddSeconds(-15))
            {
                // m_SleepController.resetSleepTimer(); sleepAssistData.lastWakeTrigger = "User Input";
            }

            sleepAssistData.trafficIn = e.inboundSpeed;
            sleepAssistData.trafficOut = e.outboundSpeed;
            sleepAssistData.powerRequests = m_PowerSettings.PowerCfgRequests;
            sleepAssistData.timeGoingToSleep = m_SleepController.TimeGoingToSleep;
            writeToSharedMemory();
        }

        private void writeToSharedMemory()
        {
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");
            m_sharedMem.WriteObjectToMMF(@"Global\wsa_trafficIn", sleepAssistData);
        }

        private void readFromSharedMemory()
        {
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");
            sleepAssistData = (SleepAssistData)m_sharedMem.ReadObjectFromMMF(@"Global\wsa_trafficIn");
        }

        public string getPowerCfgRequests()
        {
            return m_PowerSettings.PowerCfgRequests;
        }
    }
}