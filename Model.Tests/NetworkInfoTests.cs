using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Collections.Generic;
using System.Reflection;
using System.Timers;

namespace Model.Tests
{
    [TestClass]
    public class NetworkInfoTests
    {
        [TestMethod]
        public void CalculatesInboundOutboundSpeedCorrectly()
        {
            var ni = new NetworkInfo();

            // Stop internal timer to avoid interference
            var timerField = typeof(NetworkInfo).GetField("timer", BindingFlags.NonPublic | BindingFlags.Instance);
            var timer = (System.Timers.Timer)timerField!.GetValue(ni)!;
            timer.Stop();

            var inboundField = typeof(NetworkInfo).GetField("inboundTraffic", BindingFlags.NonPublic | BindingFlags.Instance);
            var outboundField = typeof(NetworkInfo).GetField("outboundTraffic", BindingFlags.NonPublic | BindingFlags.Instance);

            var inboundList = (List<long>)inboundField!.GetValue(ni)!;
            var outboundList = (List<long>)outboundField!.GetValue(ni)!;
            inboundList.Clear();
            outboundList.Clear();

            // Set predetermined traffic samples
            inboundList.AddRange(new long[] { 1000, 2000, 3000 });
            outboundList.AddRange(new long[] { 500, 1500, 2500 });

            var inboundSpeedProp = typeof(NetworkInfo).GetProperty("InboundSpeed", BindingFlags.NonPublic | BindingFlags.Instance);
            var outboundSpeedProp = typeof(NetworkInfo).GetProperty("OutboundSpeed", BindingFlags.NonPublic | BindingFlags.Instance);

            long inboundSpeed = (long)inboundSpeedProp!.GetValue(ni)!;
            long outboundSpeed = (long)outboundSpeedProp!.GetValue(ni)!;

            Assert.AreEqual(666, inboundSpeed);
            Assert.AreEqual(666, outboundSpeed);
        }
    }
}
