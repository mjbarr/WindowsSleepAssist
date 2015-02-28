using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfInterface
{
    [ServiceContract]
    public interface ISleepAssistClient
    {
        #region Methods

        [OperationContract]
        void setTrafficIn(long trafficIn);

        [OperationContract]
        void setTrafficOut(long trafficOut);

        #endregion Methods
    }

    [ServiceContract]
    public interface ISleepAssistService
    {
        #region Methods

        [OperationContract]
        long getTrafficIn();

        [OperationContract]
        long getTrafficOut();

        [OperationContract]
        void requestConnection();

        #endregion Methods
    }

    public class ServicePipeConfig
    {
        #region Fields

        public static string NamedPipeToClientString = "net.pipe://localhost/PipeWindowsSleepAssistToClient/";
        public static string NamedPipeToServerString = "net.pipe://localhost/PipeWindowsSleepAssistToServer/";

        #endregion Fields
    }
}