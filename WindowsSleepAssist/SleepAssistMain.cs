using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;
using System.Security.Permissions;
namespace WindowsSleepAssist
{
    public partial class SleepAssistMain : Form
    {
        private SleepAssist sleepAssist;
        public SleepAssistMain()
        {
            sleepAssist = new SleepAssist();
            sleepAssist.NetworkSpeedUpdated += sleepAssist_NetworkSpeedUpdated;
            InitializeComponent();
        }

        void sleepAssist_NetworkSpeedUpdated(object sender, NetworkSpeedEventArgs e)
        {
            lblInboundTraffic.Invoke(new MethodInvoker(delegate { lblInboundTraffic.Text = BytesToString(e.inboundSpeed); }));
            lblOutboundTraffic.Invoke(new MethodInvoker(delegate { lblOutboundTraffic.Text = BytesToString(e.outboundSpeed).ToString(); }));
        }


        private void SleepAssistMain_Load(object sender, EventArgs e)
        {
            updateUI();
        }

        private void updateUI()
        {
            lblPowercfgOutput.Text = sleepAssist.getPowerCfgRequests();
        }

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

    }
}
