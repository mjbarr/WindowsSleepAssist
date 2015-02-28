﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{


    public class SleepAssist
    {
        private PowerSettings m_PowerSettings;
        private NetworkInfo m_NetworkInfo;

        public SleepAssist()
        {
            m_PowerSettings = new PowerSettings();
            m_NetworkInfo = new NetworkInfo();
            m_NetworkInfo.NetworkSpeedUpdated += m_NetworkInfo_NetworkSpeedUpdated;
        }

        private void m_NetworkInfo_NetworkSpeedUpdated(object sender, NetworkSpeedEventArgs e)
        {
            OnChanged(e);
        }

        public string getPowerCfgRequests()
        {
            return m_PowerSettings.PowerCfgRequests;
        }

        public delegate void NetworkSpeedUpdatedEventHandler(object sender, NetworkSpeedEventArgs e);
        public event NetworkSpeedUpdatedEventHandler NetworkSpeedUpdated;
        // Invoke the Changed event; called whenever list changes
        protected virtual void OnChanged(NetworkSpeedEventArgs e)
        {
            if (NetworkSpeedUpdated != null)
                NetworkSpeedUpdated(this, e);
        }

    }


}