using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Collections.Generic;
using System.Reflection;
using WcfInterface;

namespace Model.Tests
{
    [TestClass]
    public class PowerSettingsTests
    {
        [TestMethod]
        public void GetRequestsSectionParsesCorrectly()
        {
            var ps = new PowerSettings();
            string[] lines = new string[]
            {
                "DISPLAY:",
                "None.",
                "",
                "SYSTEM:",
                "Process1",
                "",
            };
            var method = typeof(PowerSettings).GetMethod("getRequestsSection", BindingFlags.NonPublic | BindingFlags.Instance);
            var result = (List<string>)method!.Invoke(ps, new object[] { lines, "DISPLAY:" });
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("None.", result[0]);
        }

        [TestMethod]
        public void AllowSleepReturnsTrueWhenNoRequests()
        {
            var ps = new PowerSettings();
            var field = typeof(PowerSettings).GetField("powerData", BindingFlags.NonPublic | BindingFlags.Instance);
            var data = new PowerCfgRequestsData
            {
                DisplayRequests = new List<string> { "None." },
                SystemRequests = new List<string> { "None." },
                AwayModeRequests = new List<string> { "None." },
                ExecutionRequests = new List<string> { "None." },
                PerfBoostRequests = new List<string> { "None." }
            };
            field!.SetValue(ps, data);
            Assert.IsTrue(ps.AllowSleep);
        }
    }
}
