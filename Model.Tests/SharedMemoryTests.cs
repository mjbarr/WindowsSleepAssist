using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfInterface;
using System.Reflection;

namespace Model.Tests
{
    [TestClass]
    public class SharedMemoryTests
    {
        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            AppContext.SetSwitch("System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization", true);
        }

        [TestMethod]
        public void ByteArrayRoundTripPreservesData()
        {
            var sm = new SharedMemory("test");
            var original = new SleepAssistData { trafficIn = 5, trafficOut = 7 };
            var toBytes = typeof(SharedMemory).GetMethod("ObjectToByteArray", BindingFlags.NonPublic | BindingFlags.Instance);
            var toObj = typeof(SharedMemory).GetMethod("ByteArrayToObject", BindingFlags.NonPublic | BindingFlags.Instance);
            var bytes = (byte[])toBytes!.Invoke(sm, new object[] { original });
            var result = (SleepAssistData)toObj!.Invoke(sm, new object[] { bytes });
            Assert.AreEqual(original.trafficIn, result.trafficIn);
            Assert.AreEqual(original.trafficOut, result.trafficOut);
        }
    }
}
