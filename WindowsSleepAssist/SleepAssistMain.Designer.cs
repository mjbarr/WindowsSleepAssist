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
            this.gpBoxNetworkInfoInbound = new System.Windows.Forms.GroupBox();
            this.gpBoxNetworkInfoOutbound = new System.Windows.Forms.GroupBox();
            this.lblInboundTraffic = new System.Windows.Forms.Label();
            this.lblOutboundTraffic = new System.Windows.Forms.Label();
            this.gpBoxPowerCfg.SuspendLayout();
            this.gpBoxNetworkInfo.SuspendLayout();
            this.gpBoxNetworkInfoInbound.SuspendLayout();
            this.gpBoxNetworkInfoOutbound.SuspendLayout();
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
            this.lblPowercfgOutput.Size = new System.Drawing.Size(35, 13);
            this.lblPowercfgOutput.TabIndex = 1;
            this.lblPowercfgOutput.Text = "label2";
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
            // lblInboundTraffic
            // 
            this.lblInboundTraffic.AutoSize = true;
            this.lblInboundTraffic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInboundTraffic.Location = new System.Drawing.Point(6, 20);
            this.lblInboundTraffic.Name = "lblInboundTraffic";
            this.lblInboundTraffic.Size = new System.Drawing.Size(57, 20);
            this.lblInboundTraffic.TabIndex = 0;
            this.lblInboundTraffic.Text = "label1";
            // 
            // lblOutboundTraffic
            // 
            this.lblOutboundTraffic.AutoSize = true;
            this.lblOutboundTraffic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutboundTraffic.Location = new System.Drawing.Point(6, 20);
            this.lblOutboundTraffic.Name = "lblOutboundTraffic";
            this.lblOutboundTraffic.Size = new System.Drawing.Size(57, 20);
            this.lblOutboundTraffic.TabIndex = 1;
            this.lblOutboundTraffic.Text = "label1";
            // 
            // SleepAssistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 578);
            this.Controls.Add(this.gpBoxNetworkInfo);
            this.Controls.Add(this.gpBoxPowerCfg);
            this.Name = "SleepAssistMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SleepAssistMain_Load);
            this.gpBoxPowerCfg.ResumeLayout(false);
            this.gpBoxPowerCfg.PerformLayout();
            this.gpBoxNetworkInfo.ResumeLayout(false);
            this.gpBoxNetworkInfoInbound.ResumeLayout(false);
            this.gpBoxNetworkInfoInbound.PerformLayout();
            this.gpBoxNetworkInfoOutbound.ResumeLayout(false);
            this.gpBoxNetworkInfoOutbound.PerformLayout();
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
    }
}

