using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Joezhouman.DesignPattern.SingletonTests.SingletonN
{
    [TestClass()]
    public class SingletonNTests
    {
        [TestMethod()]
        public void DeActivateTest()
        {
            Singleton.SingletonN.SingletonN s1 = Singleton.SingletonN.SingletonN.Instance;
            Singleton.SingletonN.SingletonN s2 = Singleton.SingletonN.SingletonN.Instance;
            Singleton.SingletonN.SingletonN s3 = Singleton.SingletonN.SingletonN.Instance;

            Assert.IsNull(s3);
            Assert.AreNotEqual(s1.GetHashCode(), s2.GetHashCode());
            s1.DeActivate();

            s3 = Singleton.SingletonN.SingletonN.Instance;
            Assert.IsNotNull(s3);
            Assert.AreEqual(s3.GetHashCode(),s1.GetHashCode());
            
        }
    }

}