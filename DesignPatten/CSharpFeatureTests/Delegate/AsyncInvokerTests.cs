using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Joezhouman.DesignPattern.CSharpFeature.Delegate;
namespace Joezhouman.DesignPattern.CSharpFeatureTests.Delegate
{
    [TestClass()]
    public class AsyncInvokerTests
    {
        /// <summary>
        /// 测试时间足够两个<c>Timer</c>调用一次的情形
        /// </summary>
        /// <remarks>
        /// <list type="state">
        /// <item>
        /// <description>t = 0, "method" -> Output"</description>
        /// </item>
        /// </list>
        /// </remarks>
        [TestMethod()]
        public void AsyncInvokerEnoughTimeTest() {

            AsyncInvoker asyncInvoker = new AsyncInvoker();
            Thread.Sleep(3000);
            Assert.AreEqual(3, asyncInvoker.Output.Count);
            Assert.AreEqual("method", asyncInvoker.Output[0]);
            Assert.AreEqual("fast", asyncInvoker.Output[1]);
            Assert.AreEqual("slow", asyncInvoker.Output[2]);
        }
        [TestMethod()]
        public void AsyncInvokerNotEnoughTimeTest() {

            AsyncInvoker asyncInvoker = new AsyncInvoker();
            Thread.Sleep(2200);
            Assert.AreEqual(2,asyncInvoker.Output.Count);
            Assert.AreEqual("method", asyncInvoker.Output[0]);
            Assert.AreEqual("fast", asyncInvoker.Output[1]);
        }
        [TestMethod()]
        public void AsyncInvokerLimitTimeTest()
        {

            AsyncInvoker asyncInvoker = new AsyncInvoker();
            Thread.Sleep(1500);
            Assert.AreEqual(1, asyncInvoker.Output.Count);
            Assert.AreEqual("method", asyncInvoker.Output[0]);
        }
        [TestMethod()]
        public void AsyncInvokerTwoTimeTest()
        {

            AsyncInvoker asyncInvoker = new AsyncInvoker();
            Thread.Sleep(5500);
            Assert.AreEqual(5, asyncInvoker.Output.Count);
            Assert.AreEqual("method", asyncInvoker.Output[0]);

            Assert.AreEqual("fast", asyncInvoker.Output[1]);
            Assert.AreEqual("slow", asyncInvoker.Output[2]);

            Assert.AreEqual("fast", asyncInvoker.Output[3]);
            Assert.AreEqual("slow", asyncInvoker.Output[4]);
        }
    }
}