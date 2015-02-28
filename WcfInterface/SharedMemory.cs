using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;

namespace WcfInterface
{
    public class SharedMemory<T> where T : struct
    {
        private bool clientMode;

        // Constructor
        public SharedMemory(string name, int size, bool clientMode = false)
        {
            smName = name;
            smSize = size;
            this.clientMode = clientMode;
        }

        // Methods
        public bool Open()
        {
            try
            {
                // Create named MMF
                if (!clientMode)
                {
                    mmf = MemoryMappedFile.CreateOrOpen(smName, smSize);
                    // Create accessors to MMF
                    accessor = mmf.CreateViewAccessor(0, smSize,
                                   MemoryMappedFileAccess.ReadWrite);
                }
                else
                {
                    mmf = MemoryMappedFile.CreateOrOpen(smName, smSize);
                    //mmf = MemoryMappedFile.OpenExisting(smName);
                    // Create accessors to MMF
                    accessor = mmf.CreateViewAccessor(0, smSize,
                                   MemoryMappedFileAccess.Read);
                }

                // Create lock
                smLock = new Mutex(true, @"Global\SM_LOCK", out locked);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public void Close()
        {
            accessor.Dispose();
            mmf.Dispose();
            smLock.Close();
        }

        public T Data
        {
            get
            {
                T dataStruct;
                accessor.Read<T>(0, out dataStruct);
                return dataStruct;
            }
            set
            {
                smLock.WaitOne();
                accessor.Write<T>(0, ref value);
                smLock.ReleaseMutex();
            }
        }

        // Data
        private string smName;

        private Mutex smLock;
        private int smSize;
        private bool locked;
        private MemoryMappedFile mmf;
        private MemoryMappedViewAccessor accessor;
    }

    public struct SleepAssistData
    {
        public long trafficIn;
        public long trafficOut;
        public String powerRequests;
    }
}