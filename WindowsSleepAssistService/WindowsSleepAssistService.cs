using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WcfInterface;

namespace WindowsSleepAssistService
{
    public partial class WindowsSleepAssistService : ServiceBase
    {
        #region Fields

        private IContainer m_components;
        private EventLog m_eventLog;
        private ServiceStatus serviceStatus;
        private SleepAssist sleepAssistController;

        #endregion Fields

        #region Constructors

        public WindowsSleepAssistService()
        {
            InitializeComponent();

            if (!EventLog.SourceExists("WindowsSleepAssistService"))
            {
                EventLog.CreateEventSource("WindowsSleepAssistService", "WindowsSleepAssistEventLog");
            }
        }

        #endregion Constructors

        #region Methods

        protected override void OnStart(string[] args)
        {
            // Update the service state to Start Pending.
            serviceStatus = new ServiceStatus();
            serviceStatus.dwCurrentState = ServiceState.SERVICE_START_PENDING;
            serviceStatus.dwWaitHint = 100000;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);

            //m_eventLog.WriteEntry("WindowsSleepAssist Service Started");
            sleepAssistController = new SleepAssist();

            // Update the service state to Running.
            serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);
        }

        protected override void OnStop()
        {
            //m_eventLog.WriteEntry("WindowsSleepAssist Service Stopped");
            // Update the service state to Running.
            serviceStatus.dwCurrentState = ServiceState.SERVICE_STOPPED;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);
            //TODO add code to stop the service and release resources
        }

        #endregion Methods

        #region Enums

        public enum ServiceState
        {
            SERVICE_STOPPED = 0x00000001,
            SERVICE_START_PENDING = 0x00000002,
            SERVICE_STOP_PENDING = 0x00000003,
            SERVICE_RUNNING = 0x00000004,
            SERVICE_CONTINUE_PENDING = 0x00000005,
            SERVICE_PAUSE_PENDING = 0x00000006,
            SERVICE_PAUSED = 0x00000007,
        }

        #endregion Enums

        private static void handleServiceInstallation(string[] args)
        {
            string parameter = string.Concat(args);
            switch (parameter)
            {
                case "--install":
                    ManagedInstallerClass.InstallHelper(new[] { Assembly.GetExecutingAssembly().Location });
                    break;

                case "--uninstall":
                    ManagedInstallerClass.InstallHelper(new[] { "/u", Assembly.GetExecutingAssembly().Location });
                    break;
            }
        }

        private static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                handleServiceInstallation(args);
            }
            else
            {
                startService();
            }
        }

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool SetServiceStatus(IntPtr handle, ref ServiceStatus serviceStatus);

        private static void startService()
        {
            ServiceBase[] servicesToRun = new ServiceBase[]
                          {
                              new WindowsSleepAssistService()
                          };
            ServiceBase.Run(servicesToRun);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ServiceStatus
        {
            public long dwServiceType;
            public ServiceState dwCurrentState;
            public long dwControlsAccepted;
            public long dwWin32ExitCode;
            public long dwServiceSpecificExitCode;
            public long dwCheckPoint;
            public long dwWaitHint;
        };
    }
}