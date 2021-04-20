using System;
using System.Drawing.Drawing2D;
using System.IO;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Joezhouman.DesignPattern.CSharpFeature.Config;

namespace Joezhouman.DesignPattern.CSharpFeatureTests.Config {
    [TestClass()]
    public class ConfigTests
    {
        [TestMethod()]
        public void AppSettingTest() {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "App.config");
            var nodeList =  ConfigManager.GetSection("appSettings",filePath);

            XmlAttributeCollection xmlAttributeCollection = nodeList[0].Attributes;
            if (xmlAttributeCollection != null) Assert.AreEqual("Setting1", xmlAttributeCollection["key"].Value);
        }

    }
}