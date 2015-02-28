using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfInterface;

namespace WindowsSleepAssist
{
    public partial class SleepAssistMain : Form, ISleepAssistClient
    {
        #region Fields

        private ISleepAssistService serviceProxy;
        //private SleepAssist sleepAssist;

        #endregion Fields

        #region Constructors

        public SleepAssistMain()
        {
            //sleepAssist = new SleepAssist();
            //sleepAssist.NetworkSpeedUpdated += sleepAssist_NetworkSpeedUpdated;
            InitializeComponent();
            initInboundPipe();
            initOutboundPipe();
        }

        private static void initInboundPipe()
        {
            using (ServiceHost host = new ServiceHost(
                typeof(SleepAssistMain),
                 new Uri[]
                    {
                       new Uri( "net.pipe://localhost")
                    }))
            {
                host.AddServiceEndpoint(typeof(ISleepAssistClient),
                    new NetNamedPipeBinding(),
                    "ToClient");

                host.Open();
                //host.Close();
            }
        }

        private void initOutboundPipe()
        {
            ChannelFactory<ISleepAssistService> pipeFactory =
                new ChannelFactory<ISleepAssistService>(
                    new NetNamedPipeBinding(),
                    new EndpointAddress(
                        "net.pipe://localhost/ToServer"));

            serviceProxy = pipeFactory.CreateChannel();
            // serviceProxy.requestConnection();
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

        void ISleepAssistClient.setTrafficIn(long trafficIn)
        {
            lblInboundTraffic.Invoke(new MethodInvoker(delegate { lblInboundTraffic.Text = BytesToString(trafficIn).ToString(); }));
        }

        void ISleepAssistClient.setTrafficOut(long trafficOut)
        {
            lblOutboundTraffic.Invoke(new MethodInvoker(delegate { lblOutboundTraffic.Text = BytesToString(trafficOut).ToString(); }));
        }
    }
}