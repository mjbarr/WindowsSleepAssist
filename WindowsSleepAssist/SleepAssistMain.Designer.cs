namespace WindowsSleepAssist
{
    partial class SleepAssistMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPowerCfg = new System.Windows.Forms.Label();
            this.lblPowercfgOutput = new System.Windows.Forms.Label();
            this.gpBoxPowerCfg = new System.Windows.Forms.GroupBox();
            this.gpBoxNetworkInfo = new System.Windows.Forms.GroupBox();
            this.gpBoxNetworkInfoOutbound = new System.Windows.Forms.GroupBox();
            this.lblOutboundTraffic = new System.Windows.Forms.Label();
            this.gpBoxNetworkInfoInbound = new System.Windows.Forms.GroupBox();
            this.lblInboundTraffic = new System.Windows.Forms.Label();
            this.gpSleepTimer = new System.Windows.Forms.GroupBox();
            this.lblSleepTimer = new System.Windows.Forms.Label();
            this.lblSleepTimerValue = new System.Windows.Forms.Label();
            this.lblLastWakeTrigger = new System.Windows.Forms.Label();
            this.lblLastWakeTriggerValue = new System.Windows.Forms.Label();
            this.gpBoxPowerCfg.SuspendLayout();
            this.gpBoxNetworkInfo.SuspendLayout();
            this.gpBoxNetworkInfoOutbound.SuspendLayout();
            this.gpBoxNetworkInfoInbound.SuspendLayout();
            this.gpSleepTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPowerCfg
            // 
            this.lblPowerCfg.AutoSize = true;
            this.lblPowerCfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerCfg.Location = new System.Drawing.Point(6, 16);
            this.lblPowerCfg.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblPowerCfg.Name = "lblPowerCfg";
            this.lblPowerCfg.Size = new System.Drawing.Size(224, 13);
            this.lblPowerCfg.TabIndex = 0;
            this.lblPowerCfg.Text = "What\'s keeping your computer awake:";
            // 
            // lblPowercfgOutput
            // 
            this.lblPowercfgOutput.AutoSize = true;
            this.lblPowercfgOutput.Location = new System.Drawing.Point(6, 39);
            this.lblPowercfgOutput.Name = "lblPowercfgOutput";
            this.lblPowercfgOutput.Size = new System.Drawing.Size(87, 13);
            this.lblPowercfgOutput.TabIndex = 1;
            this.lblPowercfgOutput.Text = "Requesting Data";
            // 
            // gpBoxPowerCfg
            // 
            this.gpBoxPowerCfg.AutoSize = true;
            this.gpBoxPowerCfg.Controls.Add(this.lblPowerCfg);
            this.gpBoxPowerCfg.Controls.Add(this.lblPowercfgOutput);
            this.gpBoxPowerCfg.Location = new System.Drawing.Point(2, 12);
            this.gpBoxPowerCfg.Name = "gpBoxPowerCfg";
            this.gpBoxPowerCfg.Size = new System.Drawing.Size(276, 68);
            this.gpBoxPowerCfg.TabIndex = 2;
            this.gpBoxPowerCfg.TabStop = false;
            this.gpBoxPowerCfg.Text = "Active Requests";
            // 
            // gpBoxNetworkInfo
            // 
            this.gpBoxNetworkInfo.Controls.Add(this.gpBoxNetworkInfoOutbound);
            this.gpBoxNetworkInfo.Controls.Add(this.gpBoxNetworkInfoInbound);
            this.gpBoxNetworkInfo.Location = new System.Drawing.Point(285, 12);
            this.gpBoxNetworkInfo.Name = "gpBoxNetworkInfo";
            this.gpBoxNetworkInfo.Size = new System.Drawing.Size(335, 103);
            this.gpBoxNetworkInfo.TabIndex = 3;
            this.gpBoxNetworkInfo.TabStop = false;
            this.gpBoxNetworkInfo.Text = "Network Traffic In Previous 60 Seconds";
            // 
            // gpBoxNetworkInfoOutbound
            // 
            this.gpBoxNetworkInfoOutbound.Controls.Add(this.lblOutboundTraffic);
            this.gpBoxNetworkInfoOutbound.Location = new System.Drawing.Point(126, 20);
            this.gpBoxNetworkInfoOutbound.Name = "gpBoxNetworkInfoOutbound";
            this.gpBoxNetworkInfoOutbound.Size = new System.Drawing.Size(123, 77);
            this.gpBoxNetworkInfoOutbound.TabIndex = 1;
            this.gpBoxNetworkInfoOutbound.TabStop = false;
            this.gpBoxNetworkInfoOutbound.Text = "Outbound Traffic";
            // 
            // lblOutboundTraffic
            // 
            this.lblOutboundTraffic.AutoSize = true;
            this.lblOutboundTraffic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutboundTraffic.Location = new System.Drawing.Point(6, 20);
            this.lblOutboundTraffic.Name = "lblOutboundTraffic";
            this.lblOutboundTraffic.Size = new System.Drawing.Size(98, 20);
            this.lblOutboundTraffic.TabIndex = 1;
            this.lblOutboundTraffic.Text = "Calculating";
            // 
            // gpBoxNetworkInfoInbound
            // 
            this.gpBoxNetworkInfoInbound.Controls.Add(this.lblInboundTraffic);
            this.gpBoxNetworkInfoInbound.Location = new System.Drawing.Point(7, 20);
            this.gpBoxNetworkInfoInbound.Name = "gpBoxNetworkInfoInbound";
            this.gpBoxNetworkInfoInbound.Size = new System.Drawing.Size(113, 77);
            this.gpBoxNetworkInfoInbound.TabIndex = 0;
            this.gpBoxNetworkInfoInbound.TabStop = false;
            this.gpBoxNetworkInfoInbound.Text = "Inbound Traffic";
            // 
            // lblInboundTraffic
            // 
            this.lblInboundTraffic.AutoSize = true;
            this.lblInboundTraffic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInboundTraffic.Location = new System.Drawing.Point(6, 20);
            this.lblInboundTraffic.Name = "lblInboundTraffic";
            this.lblInboundTraffic.Size = new System.Drawing.Size(98, 20);
            this.lblInboundTraffic.TabIndex = 0;
            this.lblInboundTraffic.Text = "Calculating";
            // 
            // gpSleepTimer
            // 
            this.gpSleepTimer.Controls.Add(this.lblLastWakeTriggerValue);
            this.gpSleepTimer.Controls.Add(this.lblLastWakeTrigger);
            this.gpSleepTimer.Controls.Add(this.lblSleepTimerValue);
            this.gpSleepTimer.Controls.Add(this.lblSleepTimer);
            this.gpSleepTimer.Location = new System.Drawing.Point(627, 13);
            this.gpSleepTimer.Name = "gpSleepTimer";
            this.gpSleepTimer.Size = new System.Drawing.Size(200, 100);
            this.gpSleepTimer.TabIndex = 4;
            this.gpSleepTimer.TabStop = false;
            this.gpSleepTimer.Text = "Time To Sleep";
            // 
            // lblSleepTimer
            // 
            this.lblSleepTimer.AutoSize = true;
            this.lblSleepTimer.Location = new System.Drawing.Point(7, 20);
            this.lblSleepTimer.Name = "lblSleepTimer";
            this.lblSleepTimer.Size = new System.Drawing.Size(135, 13);
            this.lblSleepTimer.TabIndex = 0;
            this.lblSleepTimer.Text = "Computer going to sleep in:";
            // 
            // lblSleepTimerValue
            // 
            this.lblSleepTimerValue.AutoSize = true;
            this.lblSleepTimerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleepTimerValue.Location = new System.Drawing.Point(6, 38);
            this.lblSleepTimerValue.Name = "lblSleepTimerValue";
            this.lblSleepTimerValue.Size = new System.Drawing.Size(19, 20);
            this.lblSleepTimerValue.TabIndex = 2;
            this.lblSleepTimerValue.Text = "0";
            // 
            // lblLastWakeTrigger
            // 
            this.lblLastWakeTrigger.AutoSize = true;
            this.lblLastWakeTrigger.Location = new System.Drawing.Point(10, 62);
            this.lblLastWakeTrigger.Name = "lblLastWakeTrigger";
            this.lblLastWakeTrigger.Size = new System.Drawing.Size(138, 13);
            this.lblLastWakeTrigger.TabIndex = 3;
            this.lblLastWakeTrigger.Text = "Latest activity to reset timer:";
            // 
            // lblLastWakeTriggerValue
            // 
            this.lblLastWakeTriggerValue.AutoSize = true;
            this.lblLastWakeTriggerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastWakeTriggerValue.Location = new System.Drawing.Point(9, 77);
            this.lblLastWakeTriggerValue.Name = "lblLastWakeTriggerValue";
            this.lblLastWakeTriggerValue.Size = new System.Drawing.Size(145, 20);
            this.lblLastWakeTriggerValue.TabIndex = 4;
            this.lblLastWakeTriggerValue.Text = "Requesting Data";
            // 
            // SleepAssistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 578);
            this.Controls.Add(this.gpSleepTimer);
            this.Controls.Add(this.gpBoxNetworkInfo);
            this.Controls.Add(this.gpBoxPowerCfg);
            this.Name = "SleepAssistMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SleepAssistMain_Load);
            this.gpBoxPowerCfg.ResumeLayout(false);
            this.gpBoxPowerCfg.PerformLayout();
            this.gpBoxNetworkInfo.ResumeLayout(false);
            this.gpBoxNetworkInfoOutbound.ResumeLayout(false);
            this.gpBoxNetworkInfoOutbound.PerformLayout();
            this.gpBoxNetworkInfoInbound.ResumeLayout(false);
            this.gpBoxNetworkInfoInbound.PerformLayout();
            this.gpSleepTimer.ResumeLayout(false);
            this.gpSleepTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPowerCfg;
        private System.Windows.Forms.Label lblPowercfgOutput;
        private System.Windows.Forms.GroupBox gpBoxPowerCfg;
        private System.Windows.Forms.GroupBox gpBoxNetworkInfo;
        private System.Windows.Forms.GroupBox gpBoxNetworkInfoOutbound;
        private System.Windows.Forms.Label lblOutboundTraffic;
        private System.Windows.Forms.GroupBox gpBoxNetworkInfoInbound;
        private System.Windows.Forms.Label lblInboundTraffic;
        private System.Windows.Forms.GroupBox gpSleepTimer;
        private System.Windows.Forms.Label lblSleepTimerValue;
        private System.Windows.Forms.Label lblSleepTimer;
        private System.Windows.Forms.Label lblLastWakeTriggerValue;
        private System.Windows.Forms.Label lblLastWakeTrigger;
    }
}

