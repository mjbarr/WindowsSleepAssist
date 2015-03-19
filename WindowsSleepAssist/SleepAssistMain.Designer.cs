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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCpuActive = new System.Windows.Forms.Label();
            this.lblCpuLastTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRequestsActive = new System.Windows.Forms.Label();
            this.lblRequestsLastTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNetworkActive = new System.Windows.Forms.Label();
            this.lblNetworkLastTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserActive = new System.Windows.Forms.Label();
            this.lblUserInputLastTime = new System.Windows.Forms.Label();
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
            this.notifyIconMenuViewDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupCpuActivity = new System.Windows.Forms.GroupBox();
            this.lblCpuActivity = new System.Windows.Forms.Label();
            this.gpBoxPowerCfg.SuspendLayout();
            this.requestsPanel.SuspendLayout();
            this.gpBoxNetworkInfo.SuspendLayout();
            this.gpBoxNetworkInfoOutbound.SuspendLayout();
            this.gpBoxNetworkInfoInbound.SuspendLayout();
            this.gpSleepTimer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.bpBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinsToSleep)).BeginInit();
            this.contextMenuNotifyIcon.SuspendLayout();
            this.groupCpuActivity.SuspendLayout();
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
            this.gpBoxNetworkInfo.Location = new System.Drawing.Point(291, 198);
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
            this.gpSleepTimer.Controls.Add(this.tableLayoutPanel1);
            this.gpSleepTimer.Controls.Add(this.lblLastWakeTrigger);
            this.gpSleepTimer.Controls.Add(this.lblSleepTimerValue);
            this.gpSleepTimer.Controls.Add(this.lblSleepTimer);
            this.gpSleepTimer.Location = new System.Drawing.Point(291, 12);
            this.gpSleepTimer.Name = "gpSleepTimer";
            this.gpSleepTimer.Size = new System.Drawing.Size(255, 180);
            this.gpSleepTimer.TabIndex = 4;
            this.gpSleepTimer.TabStop = false;
            this.gpSleepTimer.Text = "Time To Sleep";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 96);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblCpuActive, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblCpuLastTime, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(122, 52);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(109, 39);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // lblCpuActive
            // 
            this.lblCpuActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpuActive.AutoSize = true;
            this.lblCpuActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCpuActive.Location = new System.Drawing.Point(3, 0);
            this.lblCpuActive.Name = "lblCpuActive";
            this.lblCpuActive.Size = new System.Drawing.Size(103, 19);
            this.lblCpuActive.TabIndex = 6;
            this.lblCpuActive.Text = "CPU";
            this.lblCpuActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCpuLastTime
            // 
            this.lblCpuLastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpuLastTime.AutoSize = true;
            this.lblCpuLastTime.Location = new System.Drawing.Point(3, 19);
            this.lblCpuLastTime.Name = "lblCpuLastTime";
            this.lblCpuLastTime.Size = new System.Drawing.Size(103, 20);
            this.lblCpuLastTime.TabIndex = 7;
            this.lblCpuLastTime.Text = "lblCpuLastTime";
            this.lblCpuLastTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCpuLastTime.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblRequestsActive, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblRequestsLastTime, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 52);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(109, 39);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // lblRequestsActive
            // 
            this.lblRequestsActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequestsActive.AutoSize = true;
            this.lblRequestsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRequestsActive.Location = new System.Drawing.Point(3, 0);
            this.lblRequestsActive.Name = "lblRequestsActive";
            this.lblRequestsActive.Size = new System.Drawing.Size(103, 19);
            this.lblRequestsActive.TabIndex = 6;
            this.lblRequestsActive.Text = "Requests";
            this.lblRequestsActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRequestsLastTime
            // 
            this.lblRequestsLastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequestsLastTime.AutoSize = true;
            this.lblRequestsLastTime.Location = new System.Drawing.Point(3, 19);
            this.lblRequestsLastTime.Name = "lblRequestsLastTime";
            this.lblRequestsLastTime.Size = new System.Drawing.Size(103, 20);
            this.lblRequestsLastTime.TabIndex = 7;
            this.lblRequestsLastTime.Text = "lblRequestsLastTime";
            this.lblRequestsLastTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRequestsLastTime.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblNetworkActive, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNetworkLastTime, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(122, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(109, 39);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lblNetworkActive
            // 
            this.lblNetworkActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetworkActive.AutoSize = true;
            this.lblNetworkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetworkActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNetworkActive.Location = new System.Drawing.Point(3, 0);
            this.lblNetworkActive.Name = "lblNetworkActive";
            this.lblNetworkActive.Size = new System.Drawing.Size(103, 19);
            this.lblNetworkActive.TabIndex = 5;
            this.lblNetworkActive.Text = "Network";
            this.lblNetworkActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetworkLastTime
            // 
            this.lblNetworkLastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetworkLastTime.AutoSize = true;
            this.lblNetworkLastTime.Location = new System.Drawing.Point(3, 19);
            this.lblNetworkLastTime.Name = "lblNetworkLastTime";
            this.lblNetworkLastTime.Size = new System.Drawing.Size(103, 20);
            this.lblNetworkLastTime.TabIndex = 6;
            this.lblNetworkLastTime.Text = "lblNetworkLastTime";
            this.lblNetworkLastTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNetworkLastTime.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblUserActive, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblUserInputLastTime, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(109, 39);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lblUserActive
            // 
            this.lblUserActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserActive.AutoSize = true;
            this.lblUserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUserActive.Location = new System.Drawing.Point(3, 0);
            this.lblUserActive.Name = "lblUserActive";
            this.lblUserActive.Size = new System.Drawing.Size(103, 19);
            this.lblUserActive.TabIndex = 4;
            this.lblUserActive.Text = "User Input";
            this.lblUserActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserInputLastTime
            // 
            this.lblUserInputLastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInputLastTime.AutoSize = true;
            this.lblUserInputLastTime.Location = new System.Drawing.Point(3, 19);
            this.lblUserInputLastTime.Name = "lblUserInputLastTime";
            this.lblUserInputLastTime.Size = new System.Drawing.Size(103, 20);
            this.lblUserInputLastTime.TabIndex = 6;
            this.lblUserInputLastTime.Text = "lblUserInputLastTime";
            this.lblUserInputLastTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserInputLastTime.Visible = false;
            // 
            // lblLastWakeTrigger
            // 
            this.lblLastWakeTrigger.AutoSize = true;
            this.lblLastWakeTrigger.Location = new System.Drawing.Point(10, 62);
            this.lblLastWakeTrigger.Name = "lblLastWakeTrigger";
            this.lblLastWakeTrigger.Size = new System.Drawing.Size(214, 13);
            this.lblLastWakeTrigger.TabIndex = 3;
            this.lblLastWakeTrigger.Text = "Whats been keeping your computer awake:";
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
            // notifyIconMenuViewDashboard
            // 
            this.notifyIconMenuViewDashboard.Name = "notifyIconMenuViewDashboard";
            this.notifyIconMenuViewDashboard.Size = new System.Drawing.Size(159, 22);
            this.notifyIconMenuViewDashboard.Text = "View Dashboard";
            // 
            // notifyIconMenuExit
            // 
            this.notifyIconMenuExit.Name = "notifyIconMenuExit";
            this.notifyIconMenuExit.Size = new System.Drawing.Size(159, 22);
            this.notifyIconMenuExit.Text = "Exit";
            // 
            // groupCpuActivity
            // 
            this.groupCpuActivity.Controls.Add(this.lblCpuActivity);
            this.groupCpuActivity.Location = new System.Drawing.Point(295, 309);
            this.groupCpuActivity.Name = "groupCpuActivity";
            this.groupCpuActivity.Size = new System.Drawing.Size(123, 48);
            this.groupCpuActivity.TabIndex = 6;
            this.groupCpuActivity.TabStop = false;
            this.groupCpuActivity.Text = "Average CPU Usage";
            // 
            // lblCpuActivity
            // 
            this.lblCpuActivity.AutoSize = true;
            this.lblCpuActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuActivity.Location = new System.Drawing.Point(5, 16);
            this.lblCpuActivity.Name = "lblCpuActivity";
            this.lblCpuActivity.Size = new System.Drawing.Size(98, 20);
            this.lblCpuActivity.TabIndex = 1;
            this.lblCpuActivity.Text = "Calculating";
            // 
            // SleepAssistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 578);
            this.Controls.Add(this.groupCpuActivity);
            this.Controls.Add(this.bpBoxSettings);
            this.Controls.Add(this.gpSleepTimer);
            this.Controls.Add(this.gpBoxNetworkInfo);
            this.Controls.Add(this.gpBoxPowerCfg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SleepAssistMain";
            this.Text = "Windows Sleep Assist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SleepAssistMain_FormClosing);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.bpBoxSettings.ResumeLayout(false);
            this.bpBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinsToSleep)).EndInit();
            this.contextMenuNotifyIcon.ResumeLayout(false);
            this.groupCpuActivity.ResumeLayout(false);
            this.groupCpuActivity.PerformLayout();
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
        private System.Windows.Forms.Label lblUserActive;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNetworkActive;
        private System.Windows.Forms.Label lblRequestsActive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblNetworkLastTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUserInputLastTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblRequestsLastTime;
        private System.Windows.Forms.GroupBox groupCpuActivity;
        private System.Windows.Forms.Label lblCpuActivity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblCpuActive;
        private System.Windows.Forms.Label lblCpuLastTime;
    }
}

