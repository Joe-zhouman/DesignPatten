using Joezhouman.DesignPattern.AbstractFactory.Classic;
using Joezhouman.DesignPattern.AbstractFactory.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Joezhouman.DesignPattern.AbstractFactoryTests.Classic
{
    [TestClass()]
    public class ClientTests
    {
        [TestMethod()]
        public void ProduceTest()
        {
            IAbstractFactory factory = (new Assembler()).Create<IAbstractFactory>();//通过依赖注入，从配置文件生成
            IProductA product1 =  factory.CreateProductA();
            Assert.AreEqual("A1",product1.Type);
            IProductB product2 = factory.CreateProductB();
            Assert.AreEqual("B1", product2.Name);
        }
    }
}