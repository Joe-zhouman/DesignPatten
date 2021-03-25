using System.Net;
using Joezhouman.DesignPattern.CSharpFeature.Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Joezhouman.DesignPattern.CSharpFeatureTests.Generics
{
    [TestClass()]
    public class StaticRawGenericFactoryTests
    {
        [TestMethod()]
        public void CreateATypeProductTest() {
            string typeName = typeof(ATypeProduct).AssemblyQualifiedName;
            IProduct product = StaticRawGenericFactory.Create<IProduct>(typeName);
            Assert.IsNotNull(product);
            Assert.AreEqual(typeName,product.GetType().AssemblyQualifiedName);
        }
        [TestMethod()]
        public void CreateBTypeProductTest()
        {
            string typeName = typeof(BTypeProduct).AssemblyQualifiedName;
            IProduct product = StaticRawGenericFactory.Create<IProduct>(typeName);
            Assert.IsNotNull(product);
            Assert.AreEqual(typeName, product.GetType().AssemblyQualifiedName);
        }
    }
    [TestClass()]
    public class NonStaticRawGenericFactoryTests
    {
        [TestMethod()]
        public void CreateProductTest()
        {
            string typeNameA = typeof(ATypeProduct).AssemblyQualifiedName;
            string typeNameB = typeof(BTypeProduct).AssemblyQualifiedName;
            NonStaticRawGenericFactory<IProduct> factory = new NonStaticRawGenericFactory<IProduct>();
            IProduct productA = factory.Create(typeNameA);
            IProduct productB = factory.Create(typeNameB);
            Assert.IsNotNull(productA);
            Assert.AreEqual(typeNameA, productA.GetType().AssemblyQualifiedName);
            Assert.IsNotNull(productB);
            Assert.AreEqual(typeNameB, productB.GetType().AssemblyQualifiedName);
        }
    }
}