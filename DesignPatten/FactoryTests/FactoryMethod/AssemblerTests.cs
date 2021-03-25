using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Joezhouman.DesignPattern.Factory.FactoryMethod;
namespace FactoryTests.FactoryMethod
{
    public class AssemblerClient {
        private readonly IFactory _factory;

        public AssemblerClient(IFactory factory) {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }
        public IProduct GetProduct() => _factory.Create();
    }
    [TestClass()]
    public class AssemblerTests
    {
        [TestMethod()]
        public void CreateTest() {
            IFactory factory = (new Assembler()).Create<IFactory>();
            AssemblerClient client = new AssemblerClient(factory);
            IProduct product = client.GetProduct();
            Assert.AreEqual("A",product.Name);
        }

    }
}