using System.Collections;
using System.Xml;

namespace Joezhouman.DesignPattern.CSharpFeature.Config {
    public static class ConfigManager {
        public static XmlNodeList GetSection(string sectionName, string filePath) {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            return doc.SelectNodes($"configuration/{sectionName}/add");
        }
    }
}