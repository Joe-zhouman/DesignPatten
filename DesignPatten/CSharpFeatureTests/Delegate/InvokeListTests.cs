using Joezhouman.DesignPattern.CSharpFeature.Delegate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Joezhouman.DesignPattern.CSharpFeatureTests.Delegate
{
    [TestClass()]
    public class InvokeListTests
    {
        [TestMethod()]
        public void InvokeListTest() {
            InvokeList list = new InvokeList();
            Assert.AreEqual("Hello World",list[0]+list[1]+list[2]);
        }
    }
}