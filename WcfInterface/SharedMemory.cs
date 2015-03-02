using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace WcfInterface
{
    public class SharedMemory
    {
        private bool clientMode;

        // Constructor
        public SharedMemory(string name)
        {
            mmfFile = name;
        }

        // Methods
        //public bool Open()
        //{
        //    try
        //    {
        //        // Create named MMF
        //        if (!clientMode)
        //        {
        //            mmf = MemoryMappedFile.CreateOrOpen(smName, smSize);
        //            // Create accessors to MMF
        //            accessor = mmf.CreateViewAccessor(0, smSize,
        //                           MemoryMappedFileAccess.ReadWrite);
        //        }
        //        else
        //        {
        //            mmf = MemoryMappedFile.CreateOrOpen(smName, smSize);
        //            //mmf = MemoryMappedFile.OpenExisting(smName);
        //            // Create accessors to MMF
        //            accessor = mmf.CreateViewAccessor(0, smSize,
        //                           MemoryMappedFileAccess.Read);
        //        }

        // // Create lock smLock = new Mutex(true, @"Global\SM_LOCK", out locked); } catch { return
        // false; }

        //    return true;
        //}

        //public void Close()
        //{
        //    accessor.Dispose();
        //    mmf.Dispose();
        //    smLock.Close();
        //}

        public void WriteObjectToMMF(string mmfFile, object objectData)
        {
            // Convert .NET object to byte array
            byte[] buffer = ObjectToByteArray(objectData);

            // Create a new memory mapped file
            MemoryMappedFile mmf =
                    MemoryMappedFile.CreateOrOpen(mmfFile, buffer.Length, MemoryMappedFileAccess.ReadWriteExecute);

            bool mutexCreated;
            Mutex mutex = new Mutex(true, "mmfMutex", out mutexCreated);
            // Create a view accessor into the file to accommmodate binary data size
            MemoryMappedViewAccessor mmfWriter = mmf.CreateViewAccessor(0, buffer.Length);

            // Write the data
            mmfWriter.WriteArray<byte>(0, buffer, 0, buffer.Length);
            mmfWriter.Flush();

            mutex.ReleaseMutex();
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
                MemoryMappedViewAccessor mmfReader = mmf.CreateViewAccessor();

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

        //public T Data
        //{
        //    get
        //    {
        //        T dataStruct;
        //        accessor.Read<T>(0, out dataStruct);
        //        return dataStruct;
        //    }
        //    set
        //    {
        //        smLock.WaitOne();
        //        accessor.Write<T>(0, ref value);
        //        smLock.ReleaseMutex();
        //    }
        //}

        // Data
        private string mmfFile;

        private Mutex smLock;
        private int smSize;
        private bool locked;
        private MemoryMappedFile mmf;
        private MemoryMappedViewAccessor accessor;
    }

    [Serializable]
    public class SleepAssistData
    {
        public long trafficIn;
        public long trafficOut;
        public String powerRequests;
    }
}