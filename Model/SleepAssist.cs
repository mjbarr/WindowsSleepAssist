﻿using System;
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
        private long oldUserInputTime;
        
        public SleepAssist()
        {
            sleepAssistData = new SleepAssistData();
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");

            m_SleepController = new SleepController();
            m_PowerSettings = new PowerSettings();
            m_NetworkInfo = new NetworkInfo();
            m_NetworkInfo.NetworkSpeedUpdated += m_NetworkInfo_NetworkSpeedUpdated;
            m_userInputMonitor = new UserInputMonitor();
            oldUserInputTime = 0;
        }
        
        private void m_NetworkInfo_NetworkSpeedUpdated(object sender, NetworkSpeedEventArgs e)
        {
            readFromSharedMemory();

            if (e.resetSleepTimer)
            {
                m_SleepController.resetSleepTimer();
                sleepAssistData.lastWakeTrigger = "Network Traffic";
            }

            long newUserInputTime = sleepAssistData.lastUserActivityTime;
            if (newUserInputTime != oldUserInputTime)
            {
                m_SleepController.resetSleepTimer();
                sleepAssistData.lastWakeTrigger = "User Input";
                oldUserInputTime = newUserInputTime;
            }

            m_SleepController.AllowSleep = allowSleep();

            sleepAssistData.DesktopAppConnected = false;
            sleepAssistData.trafficIn = e.inboundSpeed;
            sleepAssistData.trafficOut = e.outboundSpeed;
            sleepAssistData.powerRequests = m_PowerSettings.PowerCfgRequests;
            sleepAssistData.timeGoingToSleep = m_SleepController.TimeGoingToSleep;
            sleepAssistData.MinsBeforeSleep = m_SleepController.MinsBeforeSleep;
            writeToSharedMemory();
        }

        private bool allowSleep()
        {
            return m_PowerSettings.AllowSleep && sleepAssistData.DesktopAppConnected;
        }

        private void writeToSharedMemory()
        {
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");
            m_sharedMem.WriteObjectToMMF(@"Global\wsa_trafficIn", sleepAssistData, true);
        }

        private void readFromSharedMemory()
        {
            m_sharedMem = new SharedMemory(@"Global\wsa_trafficIn");
            sleepAssistData = (SleepAssistData)m_sharedMem.ReadObjectFromMMF(@"Global\wsa_trafficIn");
        }

        public PowerCfgRequestsData getPowerCfgRequests()
        {
            return m_PowerSettings.PowerCfgRequests;
        }
    }
}