namespace Joezhouman.DesignPattern.Factory.FactoryMethod {
    /// <summary>
    /// 产品共有特征
    /// </summary>
    public interface IProduct {
        string Name { get; }
    }
    /// <summary>
    /// 具体产品A
    /// </summary>
    public class ProductA : IProduct {
        public string Name => "A";
    }
    /// <summary>
    /// 具体产品B
    /// </summary>
    public class ProductB : IProduct
    {
        public string Name => "B";
    }
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public interface IFactory {
        IProduct Create();
    }
    /// <summary>
    /// 具体工厂A
    /// </summary>
    public class FactoryA : IFactory {
        public IProduct Create() => new ProductA();
    }
    /// <summary>
    /// 具体工厂B
    /// </summary>
    public class FactoryB : IFactory
    {
        public IProduct Create() => new ProductB();
    }
    class Client
    {
        public void SomeMethod()
        {
            IFactory factory = new FactoryA();
            IProduct product = factory.Create();
        }
    }
}