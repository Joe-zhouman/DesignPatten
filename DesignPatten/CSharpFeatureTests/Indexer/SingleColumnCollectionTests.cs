using Joezhouman.DesignPattern.CSharpFeature.Indexer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Joezhouman.DesignPattern.CSharpFeatureTests.Indexer
{
    [TestClass()]
    public class SingleColumnCollectionTests
    {
        [TestMethod()]
        public void IndexerTest()
        {
            SingleColumnCollection collection = new SingleColumnCollection(new []{ "China", "Chile", "UK" });
            Assert.AreEqual("China", collection[0]);
            string[] candidates = collection["Ch"];
            Assert.AreEqual(2, candidates.Length);
            Assert.AreEqual("China", candidates[0]);
            Assert.AreEqual("Chile", candidates[1]);
        }
    }
}