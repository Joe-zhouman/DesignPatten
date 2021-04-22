using Joezhouman.DesignPattern.Builder.AttributeBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Joezhouman.DesignPattern.BuilderTests.AttributeBuilder
{
    [TestClass()]
    public class BuilderTests
    {
        [TestMethod()]
        public void BuildUpTest() {
            Builder<Car> builder = new Builder<Car>();
            Car car = builder.BuildUp();
            Assert.IsNotNull(car);
            Assert.AreEqual(2+1,car.log.Count);
            Assert.AreEqual("body",car.log[0]);
            Assert.AreEqual("body", car.log[1]);
            Assert.AreEqual("wheel", car.log[2]);
        }
    }
}