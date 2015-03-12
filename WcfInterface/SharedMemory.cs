using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Threading;

namespace WcfInterface
{
    public class SharedMemory
    {
        
        // Constructor
        public SharedMemory(string name)
        {
            mmfFile = name;
        }

       
        public void WriteObjectToMMF(string mmfFile, object objectData, bool createNewMmf)
        {
            // Convert .NET object to byte array
            byte[] buffer = ObjectToByteArray(objectData);
            MemoryMappedFile mmf;
            if (createNewMmf)
            {
                var security = new MemoryMappedFileSecurity();

                security.AddAccessRule(new System.Security.AccessControl.AccessRule<MemoryMappedFileRights>(
                    new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                    MemoryMappedFileRights.FullControl, System.Security.AccessControl.AccessControlType.Allow));
                security.AddAccessRule(new System.Security.AccessControl.AccessRule<MemoryMappedFileRights>(
                    new SecurityIdentifier(WellKnownSidType.AnonymousSid, null),
                    MemoryMappedFileRights.FullControl, System.Security.AccessControl.AccessControlType.Allow));
                security.AddAccessRule(new System.Security.AccessControl.AccessRule<MemoryMappedFileRights>(
                    new SecurityIdentifier(WellKnownSidType.NullSid, null),
                    MemoryMappedFileRights.FullControl, System.Security.AccessControl.AccessControlType.Allow));

                // printing the SID from the screensaver shows that we are running as Local Service
                security.AddAccessRule(new System.Security.AccessControl.AccessRule<MemoryMappedFileRights>(
                    new SecurityIdentifier(WellKnownSidType.LocalServiceSid, null),
                    MemoryMappedFileRights.FullControl, System.Security.AccessControl.AccessControlType.Allow));
                // Create a new memory mapped file
                mmf = MemoryMappedFile.CreateOrOpen(mmfFile, buffer.Length, MemoryMappedFileAccess.ReadWriteExecute, MemoryMappedFileOptions.None, security, System.IO.HandleInheritability.Inheritable);
                
            }
            else
            {
                try
                {
                    mmf = MemoryMappedFile.OpenExisting(mmfFile, MemoryMappedFileRights.ReadWriteExecute, System.IO.HandleInheritability.Inheritable);
                }
                catch (FileNotFoundException)
                {
                    return;
                }
            }

            bool mutexCreated;
            Mutex mutex = new Mutex(true, "mmfMutex", out mutexCreated);
            // Create a view accessor into the file to accommmodate binary data size
            MemoryMappedViewAccessor mmfWriter = mmf.CreateViewAccessor(0, buffer.Length);

            // Write the data
            mmfWriter.WriteArray<byte>(0, buffer, 0, buffer.Length);
            mmfWriter.Flush();
            if (mutexCreated) mutex.ReleaseMutex();
        }

        public object ReadObjectFromMMF(string mmfFile)
        {
            Mutex mutex = null;
            try
            {
                // Get a handle to an existing memory mapped file
                MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(mmfFile, MemoryMappedFileRights.Read);

                bool mutexCreated;
                mutex = new Mutex(true, "mmfMutex", out mutexCreated);
                mutex.WaitOne();
                // Create a view accessor from which to read the data
                MemoryMappedViewAccessor mmfReader = mmf.CreateViewAccessor(0, 0, MemoryMappedFileAccess.Read);

                // Create a data buffer and read entire MMF view into buffer
                byte[] buffer = new byte[mmfReader.Capacity];
                mmfReader.ReadArray<byte>(0, buffer, 0, buffer.Length);
                mutex.ReleaseMutex();
                // Convert the buffer to a .NET object
                return ByteArrayToObject(buffer);
            }
            catch
            {
                try
                {
                    mutex.ReleaseMutex();
                }
                catch { }
                return (Object)new SleepAssistData();
            }
        }

        // Convert an object to a byte array
        private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        // Convert a byte array to an Object
        private Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }

        private string mmfFile;
    }

    [Serializable]
    public class SleepAssistData
    {
        public long trafficIn;
        public long trafficOut;
        public PowerCfgRequestsData powerRequests;
        public DateTime timeGoingToSleep;
        public string lastWakeTrigger;
        public long lastUserActivityTime;
        public bool DesktopAppConnected;
        public int MinsBeforeSleep;
        public bool Hibernate;
        public DateTime TimeOfUserInput;
        public DateTime TimeOfNetworkActivity;
        public DateTime TimeOfRequests;
    }

    [Serializable]
    public class PowerCfgRequestsData
    {
        public List<string> DisplayRequests { get; set; }

        public List<string> SystemRequests { get; set; }

        public List<string> AwayModeRequests { get; set; }

        public List<string> ExecutionRequests { get; set; }

        public List<string> PerfBoostRequests { get; set; }
    }
}