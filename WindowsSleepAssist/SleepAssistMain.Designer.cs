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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SleepAssistMain));
            this.lblPowerCfg = new System.Windows.Forms.Label();
            this.gpBoxPowerCfg = new System.Windows.Forms.GroupBox();
            this.requestsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDisplayRequests = new System.Windows.Forms.Label();
            this.listboxSystemRequests = new NishBox.MultiLineListBox();
            this.lblSystemRequests = new System.Windows.Forms.Label();
            this.listBoxDisplayRequests = new NishBox.MultiLineListBox();
            this.lblAwayModeRequests = new System.Windows.Forms.Label();
            this.listBoxExecutionRequests = new NishBox.MultiLineListBox();
            this.lblExecutionRequests = new System.Windows.Forms.Label();
            this.listBoxAwayModeRequests = new NishBox.MultiLineListBox();
            this.lblPerfBoostRequests = new System.Windows.Forms.Label();
            this.listBoxPerBoostRequests = new NishBox.MultiLineListBox();
            this.gpBoxNetworkInfo = new System.Windows.Forms.GroupBox();
            this.gpBoxNetworkInfoOutbound = new System.Windows.Forms.GroupBox();
            this.lblOutboundTraffic = new System.Windows.Forms.Label();
            this.gpBoxNetworkInfoInbound = new System.Windows.Forms.GroupBox();
            this.lblInboundTraffic = new System.Windows.Forms.Label();
            this.gpSleepTimer = new System.Windows.Forms.GroupBox();
            this.lblLastWakeTriggerValue = new System.Windows.Forms.Label();
            this.lblLastWakeTrigger = new System.Windows.Forms.Label();
            this.lblSleepTimerValue = new System.Windows.Forms.Label();
            this.lblSleepTimer = new System.Windows.Forms.Label();
            this.bpBoxSettings = new System.Windows.Forms.GroupBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.chkHibernate = new System.Windows.Forms.CheckBox();
            this.numMinsToSleep = new System.Windows.Forms.NumericUpDown();
            this.lblSettingsSleepTime = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIconMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMenuViewDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.gpBoxPowerCfg.SuspendLayout();
            this.requestsPanel.SuspendLayout();
            this.gpBoxNetworkInfo.SuspendLayout();
            this.gpBoxNetworkInfoOutbound.SuspendLayout();
            this.gpBoxNetworkInfoInbound.SuspendLayout();
            this.gpSleepTimer.SuspendLayout();
            this.bpBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinsToSleep)).BeginInit();
            this.contextMenuNotifyIcon.SuspendLayout();
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
            // gpBoxPowerCfg
            // 
            this.gpBoxPowerCfg.AutoSize = true;
            this.gpBoxPowerCfg.Controls.Add(this.requestsPanel);
            this.gpBoxPowerCfg.Controls.Add(this.lblPowerCfg);
            this.gpBoxPowerCfg.Location = new System.Drawing.Point(2, 12);
            this.gpBoxPowerCfg.Name = "gpBoxPowerCfg";
            this.gpBoxPowerCfg.Size = new System.Drawing.Size(283, 573);
            this.gpBoxPowerCfg.TabIndex = 2;
            this.gpBoxPowerCfg.TabStop = false;
            this.gpBoxPowerCfg.Text = "Active Requests";
            // 
            // requestsPanel
            // 
            this.requestsPanel.Controls.Add(this.lblDisplayRequests);
            this.requestsPanel.Controls.Add(this.listboxSystemRequests);
            this.requestsPanel.Controls.Add(this.lblSystemRequests);
            this.requestsPanel.Controls.Add(this.listBoxDisplayRequests);
            this.requestsPanel.Controls.Add(this.lblAwayModeRequests);
            this.requestsPanel.Controls.Add(this.listBoxExecutionRequests);
            this.requestsPanel.Controls.Add(this.lblExecutionRequests);
            this.requestsPanel.Controls.Add(this.listBoxAwayModeRequests);
            this.requestsPanel.Controls.Add(this.lblPerfBoostRequests);
            this.requestsPanel.Controls.Add(this.listBoxPerBoostRequests);
            this.requestsPanel.Location = new System.Drawing.Point(7, 39);
            this.requestsPanel.Name = "requestsPanel";
            this.requestsPanel.Size = new System.Drawing.Size(270, 515);
            this.requestsPanel.TabIndex = 1;
            // 
            // lblDisplayRequests
            // 
            this.lblDisplayRequests.AutoSize = true;
            this.lblDisplayRequests.Location = new System.Drawing.Point(3, 0);
            this.lblDisplayRequests.Name = "lblDisplayRequests";
            this.lblDisplayRequests.Size = new System.Drawing.Size(89, 13);
            this.lblDisplayRequests.TabIndex = 2;
            this.lblDisplayRequests.Text = "Display Requests";
            // 
            // listboxSystemRequests
            // 
            this.listboxSystemRequests.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listboxSystemRequests.FormattingEnabled = true;
            this.listboxSystemRequests.Location = new System.Drawing.Point(3, 16);
            this.listboxSystemRequests.Name = "listboxSystemRequests";
            this.listboxSystemRequests.ScrollAlwaysVisible = true;
            this.listboxSystemRequests.Size = new System.Drawing.Size(261, 70);
            this.listboxSystemRequests.TabIndex = 1;
            // 
            // lblSystemRequests
            // 
            this.lblSystemRequests.AutoSize = true;
            this.lblSystemRequests.Location = new System.Drawing.Point(3, 89);
            this.lblSystemRequests.Name = "lblSystemRequests";
            this.lblSystemRequests.Size = new System.Drawing.Size(89, 13);
            this.lblSystemRequests.TabIndex = 5;
            this.lblSystemRequests.Text = "System Requests";
            // 
            // listBoxDisplayRequests
            // 
            this.listBoxDisplayRequests.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxDisplayRequests.FormattingEnabled = true;
            this.listBoxDisplayRequests.Location = new System.Drawing.Point(3, 105);
            this.listBoxDisplayRequests.Name = "listBoxDisplayRequests";
            this.listBoxDisplayRequests.ScrollAlwaysVisible = true;
            this.listBoxDisplayRequests.Size = new System.Drawing.Size(261, 83);
            this.listBoxDisplayRequests.TabIndex = 0;
            // 
            // lblAwayModeRequests
            // 
            this.lblAwayModeRequests.AutoSize = true;
            this.lblAwayModeRequests.Location = new System.Drawing.Point(3, 191);
            this.lblAwayModeRequests.Name = "lblAwayModeRequests";
            this.lblAwayModeRequests.Size = new System.Drawing.Size(111, 13);
            this.lblAwayModeRequests.TabIndex = 6;
            this.lblAwayModeRequests.Text = "Away Mode Requests";
            // 
            // listBoxExecutionRequests
            // 
            this.listBoxExecutionRequests.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxExecutionRequests.FormattingEnabled = true;
            this.listBoxExecutionRequests.Location = new System.Drawing.Point(3, 207);
            this.listBoxExecutionRequests.Name = "listBoxExecutionRequests";
            this.listBoxExecutionRequests.ScrollAlwaysVisible = true;
            this.listBoxExecutionRequests.Size = new System.Drawing.Size(261, 83);
            this.listBoxExecutionRequests.TabIndex = 3;
            // 
            // lblExecutionRequests
            // 
            this.lblExecutionRequests.AutoSize = true;
            this.lblExecutionRequests.Location = new System.Drawing.Point(3, 293);
            this.lblExecutionRequests.Name = "lblExecutionRequests";
            this.lblExecutionRequests.Size = new System.Drawing.Size(102, 13);
            this.lblExecutionRequests.TabIndex = 7;
            this.lblExecutionRequests.Text = "Execution Requests";
            // 
            // listBoxAwayModeRequests
            // 
            this.listBoxAwayModeRequests.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxAwayModeRequests.FormattingEnabled = true;
            this.listBoxAwayModeRequests.Location = new System.Drawing.Point(3, 309);
            this.listBoxAwayModeRequests.Name = "listBoxAwayModeRequests";
            this.listBoxAwayModeRequests.ScrollAlwaysVisible = true;
            this.listBoxAwayModeRequests.Size = new System.Drawing.Size(261, 83);
            this.listBoxAwayModeRequests.TabIndex = 2;
            // 
            // lblPerfBoostRequests
            // 
            this.lblPerfBoostRequests.AutoSize = true;
            this.lblPerfBoostRequests.Location = new System.Drawing.Point(3, 395);
            this.lblPerfBoostRequests.Name = "lblPerfBoostRequests";
            this.lblPerfBoostRequests.Size = new System.Drawing.Size(101, 13);
            this.lblPerfBoostRequests.TabIndex = 8;
            this.lblPerfBoostRequests.Text = "PerfBoost Requests";
            // 
            // listBoxPerBoostRequests
            // 
            this.listBoxPerBoostRequests.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxPerBoostRequests.FormattingEnabled = true;
            this.listBoxPerBoostRequests.Location = new System.Drawing.Point(3, 411);
            this.listBoxPerBoostRequests.Name = "listBoxPerBoostRequests";
            this.listBoxPerBoostRequests.ScrollAlwaysVisible = true;
            this.listBoxPerBoostRequests.Size = new System.Drawing.Size(261, 83);
            this.listBoxPerBoostRequests.TabIndex = 4;
            // 
            // gpBoxNetworkInfo
            // 
            this.gpBoxNetworkInfo.Controls.Add(this.gpBoxNetworkInfoOutbound);
            this.gpBoxNetworkInfo.Controls.Add(this.gpBoxNetworkInfoInbound);
            this.gpBoxNetworkInfo.Location = new System.Drawing.Point(291, 118);
            this.gpBoxNetworkInfo.Name = "gpBoxNetworkInfo";
            this.gpBoxNetworkInfo.Size = new System.Drawing.Size(255, 103);
            this.gpBoxNetworkInfo.TabIndex = 3;
            this.gpBoxNetworkInfo.TabStop = false;
            this.gpBoxNetworkInfo.Text = "Average Network Speed in Previous 60 Seconds";
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
            this.gpSleepTimer.Location = new System.Drawing.Point(291, 12);
            this.gpSleepTimer.Name = "gpSleepTimer";
            this.gpSleepTimer.Size = new System.Drawing.Size(255, 100);
            this.gpSleepTimer.TabIndex = 4;
            this.gpSleepTimer.TabStop = false;
            this.gpSleepTimer.Text = "Time To Sleep";
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
            // lblLastWakeTrigger
            // 
            this.lblLastWakeTrigger.AutoSize = true;
            this.lblLastWakeTrigger.Location = new System.Drawing.Point(10, 62);
            this.lblLastWakeTrigger.Name = "lblLastWakeTrigger";
            this.lblLastWakeTrigger.Size = new System.Drawing.Size(138, 13);
            this.lblLastWakeTrigger.TabIndex = 3;
            this.lblLastWakeTrigger.Text = "Latest activity to reset timer:";
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
            // lblSleepTimer
            // 
            this.lblSleepTimer.AutoSize = true;
            this.lblSleepTimer.Location = new System.Drawing.Point(7, 20);
            this.lblSleepTimer.Name = "lblSleepTimer";
            this.lblSleepTimer.Size = new System.Drawing.Size(135, 13);
            this.lblSleepTimer.TabIndex = 0;
            this.lblSleepTimer.Text = "Computer going to sleep in:";
            // 
            // bpBoxSettings
            // 
            this.bpBoxSettings.Controls.Add(this.lblMinutes);
            this.bpBoxSettings.Controls.Add(this.chkHibernate);
            this.bpBoxSettings.Controls.Add(this.numMinsToSleep);
            this.bpBoxSettings.Controls.Add(this.lblSettingsSleepTime);
            this.bpBoxSettings.Location = new System.Drawing.Point(291, 462);
            this.bpBoxSettings.Name = "bpBoxSettings";
            this.bpBoxSettings.Size = new System.Drawing.Size(200, 100);
            this.bpBoxSettings.TabIndex = 5;
            this.bpBoxSettings.TabStop = false;
            this.bpBoxSettings.Text = "Settings";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(69, 38);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(43, 13);
            this.lblMinutes.TabIndex = 4;
            this.lblMinutes.Text = "minutes";
            // 
            // chkHibernate
            // 
            this.chkHibernate.AutoSize = true;
            this.chkHibernate.Location = new System.Drawing.Point(9, 57);
            this.chkHibernate.Name = "chkHibernate";
            this.chkHibernate.Size = new System.Drawing.Size(177, 17);
            this.chkHibernate.TabIndex = 3;
            this.chkHibernate.Text = "Use Hibernate instead of sleep?";
            this.chkHibernate.UseVisualStyleBackColor = true;
            this.chkHibernate.CheckedChanged += new System.EventHandler(this.chkHibernate_CheckedChanged);
            // 
            // numMinsToSleep
            // 
            this.numMinsToSleep.Location = new System.Drawing.Point(9, 31);
            this.numMinsToSleep.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numMinsToSleep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinsToSleep.Name = "numMinsToSleep";
            this.numMinsToSleep.Size = new System.Drawing.Size(54, 20);
            this.numMinsToSleep.TabIndex = 1;
            this.numMinsToSleep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinsToSleep.ValueChanged += new System.EventHandler(this.numMinsToSleep_ValueChanged);
            // 
            // lblSettingsSleepTime
            // 
            this.lblSettingsSleepTime.AutoSize = true;
            this.lblSettingsSleepTime.Location = new System.Drawing.Point(6, 15);
            this.lblSettingsSleepTime.Name = "lblSettingsSleepTime";
            this.lblSettingsSleepTime.Size = new System.Drawing.Size(150, 13);
            this.lblSettingsSleepTime.TabIndex = 0;
            this.lblSettingsSleepTime.Text = "Put my computer to sleep after";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Helping your computer to sleep when its supposed to.";
            this.notifyIcon.BalloonTipTitle = "Windows Sleep Assist";
            this.notifyIcon.ContextMenuStrip = this.contextMenuNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WindowsSleepAssistTray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuNotifyIcon
            // 
            this.contextMenuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyIconMenuViewDashboard,
            this.notifyIconMenuExit});
            this.contextMenuNotifyIcon.Name = "contextMenuNotifyIcon";
            this.contextMenuNotifyIcon.Size = new System.Drawing.Size(160, 48);
            // 
            // notifyIconMenuExit
            // 
            this.notifyIconMenuExit.Name = "notifyIconMenuExit";
            this.notifyIconMenuExit.Size = new System.Drawing.Size(159, 22);
            this.notifyIconMenuExit.Text = "Exit";
            // 
            // notifyIconMenuViewDashboard
            // 
            this.notifyIconMenuViewDashboard.Name = "notifyIconMenuViewDashboard";
            this.notifyIconMenuViewDashboard.Size = new System.Drawing.Size(159, 22);
            this.notifyIconMenuViewDashboard.Text = "View Dashboard";
            // 
            // SleepAssistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 578);
            this.Controls.Add(this.bpBoxSettings);
            this.Controls.Add(this.gpSleepTimer);
            this.Controls.Add(this.gpBoxNetworkInfo);
            this.Controls.Add(this.gpBoxPowerCfg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SleepAssistMain";
            this.Text = "Windows Sleep Assist";
            this.Load += new System.EventHandler(this.SleepAssistMain_Load);
            this.Resize += new System.EventHandler(this.SleepAssistMain_Resize);
            this.gpBoxPowerCfg.ResumeLayout(false);
            this.gpBoxPowerCfg.PerformLayout();
            this.requestsPanel.ResumeLayout(false);
            this.requestsPanel.PerformLayout();
            this.gpBoxNetworkInfo.ResumeLayout(false);
            this.gpBoxNetworkInfoOutbound.ResumeLayout(false);
            this.gpBoxNetworkInfoOutbound.PerformLayout();
            this.gpBoxNetworkInfoInbound.ResumeLayout(false);
            this.gpBoxNetworkInfoInbound.PerformLayout();
            this.gpSleepTimer.ResumeLayout(false);
            this.gpSleepTimer.PerformLayout();
            this.bpBoxSettings.ResumeLayout(false);
            this.bpBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinsToSleep)).EndInit();
            this.contextMenuNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPowerCfg;
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
        private System.Windows.Forms.FlowLayoutPanel requestsPanel;
        private System.Windows.Forms.Label lblDisplayRequests;
        private NishBox.MultiLineListBox listboxSystemRequests;
        private System.Windows.Forms.Label lblSystemRequests;
        private NishBox.MultiLineListBox listBoxDisplayRequests;
        private System.Windows.Forms.Label lblAwayModeRequests;
        private NishBox.MultiLineListBox listBoxExecutionRequests;
        private System.Windows.Forms.Label lblExecutionRequests;
        private NishBox.MultiLineListBox listBoxAwayModeRequests;
        private System.Windows.Forms.Label lblPerfBoostRequests;
        private NishBox.MultiLineListBox listBoxPerBoostRequests;
        private System.Windows.Forms.GroupBox bpBoxSettings;
        private System.Windows.Forms.NumericUpDown numMinsToSleep;
        private System.Windows.Forms.Label lblSettingsSleepTime;
        private System.Windows.Forms.CheckBox chkHibernate;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenuViewDashboard;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenuExit;
    }
}

