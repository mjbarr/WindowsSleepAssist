using System;
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
        private SleepController m_SleepController;

        public SleepAssist()
        {
            m_SleepController = new SleepController();
            m_PowerSettings = new PowerSettings();
            m_PowerSettings.PowerCfgUpdated += m_PowerSettings_PowerCfgUpdated;
            m_NetworkInfo = new NetworkInfo();
            m_NetworkInfo.NetworkSpeedUpdated += m_NetworkInfo_NetworkSpeedUpdated;
        }

        private void m_PowerSettings_PowerCfgUpdated(object sender, PowerCfgEventArgs e)
        {
            OnPowerCfgChanged(e);
        }

        private void m_NetworkInfo_NetworkSpeedUpdated(object sender, NetworkSpeedEventArgs e)
        {
            OnNetworkSpeedChanged(e);
        }

        public string getPowerCfgRequests()
        {
            return m_PowerSettings.PowerCfgRequests;
        }

        public delegate void NetworkSpeedUpdatedEventHandler(object sender, NetworkSpeedEventArgs e);

        public event NetworkSpeedUpdatedEventHandler NetworkSpeedUpdated;

        // Invoke the Changed event; called whenever list changes
        protected virtual void OnNetworkSpeedChanged(NetworkSpeedEventArgs e)
        {
            if (NetworkSpeedUpdated != null)
                NetworkSpeedUpdated(this, e);
        }

        public delegate void PowerCfgUpdatedEventHandler(object sender, PowerCfgEventArgs e);

        public event PowerCfgUpdatedEventHandler PowerCfgUpdated;

        // Invoke the Changed event; called whenever list changes
        protected virtual void OnPowerCfgChanged(PowerCfgEventArgs e)
        {
            if (PowerCfgUpdated != null)
                PowerCfgUpdated(this, e);
        }
    }
}