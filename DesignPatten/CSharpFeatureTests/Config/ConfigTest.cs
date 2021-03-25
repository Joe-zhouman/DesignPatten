using System;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Joezhouman.DesignPattern.CSharpFeature.Config;

namespace Joezhouman.DesignPattern.CSharpFeatureTests.Config {
    [TestClass()]
    public class ConfigTests
    {
        [TestMethod()]
        public void AppSettingTest() {
            const string FILE_PATH = @"D:\windows\Documents\GitHub\DesignPatten\DesignPatten\CSharpFeatureTests\App.config";
            var nodeList =  ConfigManager.GetSection("appSettings",FILE_PATH);

            XmlAttributeCollection xmlAttributeCollection = nodeList[0].Attributes;
            if (xmlAttributeCollection != null) Assert.AreEqual("Setting1", xmlAttributeCollection["key"].Value);
        }

    }
}