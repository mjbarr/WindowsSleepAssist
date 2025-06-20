using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Reflection;

namespace Model.Tests
{
    [TestClass]
    public class SleepControllerTests
    {
        [TestMethod]
        public void ResetSleepTimerUpdatesIntervalAndTime()
        {
            var sc = new SleepController();
            sc.MinsBeforeSleep = 1;
            sc.resetSleepTimer();

            var timerField = typeof(SleepController).GetField("sleepTimer", BindingFlags.NonPublic | BindingFlags.Instance);
            var timer = (System.Timers.Timer)timerField!.GetValue(sc)!;

            Assert.AreEqual(60000, timer.Interval, 1);
            var expected = DateTime.Now.AddMinutes(1);
            Assert.IsTrue(Math.Abs((sc.TimeGoingToSleep - expected).TotalSeconds) < 5);
        }

        [TestMethod]
        public void SleepTimerElapsedWhenNotAllowedReschedules()
        {
            var sc = new SleepController();
            sc.MinsBeforeSleep = 2;
            sc.resetSleepTimer();
            sc.AllowSleep = false;

            var elapsedMethod = typeof(SleepController).GetMethod("sleepTimer_Elapsed", BindingFlags.NonPublic | BindingFlags.Instance);
            elapsedMethod!.Invoke(sc, new object?[] { null, null });

            var timerField = typeof(SleepController).GetField("sleepTimer", BindingFlags.NonPublic | BindingFlags.Instance);
            var timer = (System.Timers.Timer)timerField!.GetValue(sc)!;

            Assert.AreEqual(60000, timer.Interval, 1);
            var expected = DateTime.Now.AddMinutes(1);
            Assert.IsTrue(Math.Abs((sc.TimeGoingToSleep - expected).TotalSeconds) < 5);
        }

        [TestMethod]
        public void MinsToMillisecondsCalculates()
        {
            var sc = new SleepController();
            var method = typeof(SleepController).GetMethod("minsToMilliseconds", BindingFlags.NonPublic | BindingFlags.Instance);
            long result = (long)method!.Invoke(sc, new object[] { 2 });
            Assert.AreEqual(120000, result);
        }
    }
}
