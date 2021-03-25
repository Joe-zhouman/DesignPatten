using System;

namespace Joezhouman.DesignPattern.CSharpFeature.Generics {
    /// <summary>
    /// 泛型简单工厂，静态类
    /// </summary>
    public static class StaticRawGenericFactory {
        public static T Create<T>(string typeName) {
            return (T) Activator.CreateInstance(Type.GetType(typeName) ?? throw new InvalidOperationException());
        }
    }
    /// <summary>
    /// 泛型简单工厂，非静态类
    /// </summary>
    public class NonStaticRawGenericFactory<T>
    {
        public T Create(string typeName)
        {
            return (T)Activator.CreateInstance(Type.GetType(typeName) ?? throw new InvalidOperationException());
        }
    }
    public interface IProduct {
        
    }

    public class ATypeProduct : IProduct {
    }

    public class BTypeProduct : IProduct {

    }
}