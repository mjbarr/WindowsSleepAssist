using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class CpuMonitor
    {
        List<float> cpuStats;
        public float CpuThreshold { get; set; }

        public CpuMonitor()
        {
            cpuStats = new List<float>();
        }
        public bool isCpuMonitorOverThreshold(out double cpuActivity)
        {

            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
            cpuCounter.NextValue();
            cpuStats.Add(cpuCounter.NextValue());

            while (cpuStats.Count > 60)
            {
                cpuStats.RemoveAt(0);
            }

            cpuActivity = Math.Round((double)(cpuStats.Sum() / cpuStats.Count));

            return (cpuActivity > CpuThreshold);
        }

    }
}
