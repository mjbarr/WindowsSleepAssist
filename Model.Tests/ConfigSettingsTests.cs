using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Reflection;

namespace Model.Tests
{
    [TestClass]
    public class ConfigSettingsTests
    {
        [TestMethod]
        public void DeserializeProducesValidObject()
        {
            var instance = (ConfigSettings)Activator.CreateInstance(typeof(ConfigSettings), true)!;
            var versionField = typeof(ConfigSettings).GetField("m_Version", BindingFlags.NonPublic | BindingFlags.Instance);
            var minsField = typeof(ConfigSettings).GetField("m_minsUntilSleep", BindingFlags.NonPublic | BindingFlags.Instance);
            var hibernateField = typeof(ConfigSettings).GetField("m_hibernate", BindingFlags.NonPublic | BindingFlags.Instance);
            versionField!.SetValue(instance, 3);
            minsField!.SetValue(instance, 20);
            hibernateField!.SetValue(instance, true);

            using var ms = new System.IO.MemoryStream();
            var serializer = new System.Runtime.Serialization.DataContractSerializer(typeof(ConfigSettings));
            serializer.WriteObject(ms, instance);
            ms.Position = 0;
            string xml = System.Text.Encoding.UTF8.GetString(ms.ToArray());

            var obj = (ConfigSettings)ConfigSettings.Deserialize(xml, typeof(ConfigSettings));
            Assert.IsTrue(obj.Hibernate);
            Assert.AreEqual(20, obj.NoOfMinsUntilSleep);
            Assert.AreEqual(3, obj.Version);
        }
    }
}
