using System.Collections.Generic;
using Joezhouman.DesignPattern.CSharpFeature.Delegate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Joezhouman.DesignPattern.CSharpFeatureTests.Delegate
{
    [TestClass()]
    public class OverloadableDelegateInvokerTests
    {
        [TestMethod()]
        public void OverloadableDelegateInvokerTest() {
            OverloadableDelegateInvoker invoker = new OverloadableDelegateInvoker();
            IDictionary<string, int> data = new Dictionary<string, int>();
            invoker.Memo(1,2,data);
            Assert.AreEqual(1 + 2, data["A"]);
            Assert.AreEqual(1 - 2, data["S"]);
            Assert.AreEqual(1 * 2, data["M"]);
        }
    }
}