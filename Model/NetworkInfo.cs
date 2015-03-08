using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Model
{
    internal class NetworkInfo
    {
        private Timer timer;
        private List<long> inboundTraffic;
        private List<long> outboundTraffic;

        internal NetworkInfo()
        {
            inboundTraffic = new List<long>();
            outboundTraffic = new List<long>();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            inboundTraffic.Add(TrafficIn);
            outboundTraffic.Add(TrafficOut);

            while (inboundTraffic.Count > 60)
            {
                inboundTraffic.RemoveAt(0);
            }

            while (outboundTraffic.Count > 60)
            {
                outboundTraffic.RemoveAt(0);
            }

            NetworkSpeedEventArgs eventArgs = new NetworkSpeedEventArgs();
            eventArgs.inboundSpeed = InboundSpeed;
            eventArgs.outboundSpeed = OutboundSpeed;
            eventArgs.resetSleepTimer = shouldResetSleep();
            OnChanged(eventArgs);
        }

        private bool shouldResetSleep()
        {
            if ((InboundSpeed > 100000) || (OutboundSpeed > 100000))
            {
                return true;
            }
            return false;
        }

        private long InboundSpeed
        {
            get
            {
                long speed = 0;
                if (inboundTraffic.Count > 2)
                {
                    speed = (inboundTraffic[outboundTraffic.Count - 1] - inboundTraffic[0]) / inboundTraffic.Count;
                }
                if (speed < 0)
                {
                    inboundTraffic.Clear();
                    speed = 0;
                }
                return speed;
            }
        }

        private long OutboundSpeed
        {
            get
            {
                long speed = 0;
                if (outboundTraffic.Count > 2)
                {
                    speed = (outboundTraffic[outboundTraffic.Count - 1] - outboundTraffic[0]) / inboundTraffic.Count;
                }

                if (speed < 0)
                {
                    outboundTraffic.Clear();
                    speed = 0;
                }
                return speed;
            }
        }

        private long TrafficIn
        {
            get
            {
                long totalIn = 0;
                foreach (NetworkInterface ni in getNetworkInterfaces())
                {
                    totalIn += ni.GetIPv4Statistics().BytesReceived;
                }

                return totalIn;
            }
        }

        private long TrafficOut
        {
            get
            {
                long totalOut = 0;
                foreach (NetworkInterface ni in getNetworkInterfaces())
                {
                    totalOut += ni.GetIPv4Statistics().BytesSent;
                }
                return totalOut;
            }
        }

        private NetworkInterface[] getNetworkInterfaces()
        {
            return NetworkInterface.GetAllNetworkInterfaces();
        }

        internal delegate void NetworkSpeedUpdatedEventHandler(object sender, NetworkSpeedEventArgs e);

        internal event NetworkSpeedUpdatedEventHandler NetworkSpeedUpdated;

        // Invoke the Changed event; called whenever list changes
        internal virtual void OnChanged(NetworkSpeedEventArgs e)
        {
            if (NetworkSpeedUpdated != null)
                NetworkSpeedUpdated(this, e);
        }
    }

    public class NetworkSpeedEventArgs : EventArgs
    {
        public long inboundSpeed { get; set; }

        public long outboundSpeed { get; set; }

        public bool resetSleepTimer { get; set; }
    }
}