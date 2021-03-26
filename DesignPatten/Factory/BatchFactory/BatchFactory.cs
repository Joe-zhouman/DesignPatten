using System;
using System.Collections.Generic;
using Joezhouman.DesignPattern.Factory.FactoryMethod;

namespace Joezhouman.DesignPattern.Factory.BatchFactory {
    /// <summary>
    /// 产品容器
    /// </summary>
    public class ProductCollection {
        private readonly IList<IProduct> _products = new List<IProduct>();

        /// <summary>
        ///     获取当前的product内容
        /// </summary>
        /// <remarks>深拷贝</remarks>
        public IProduct[] Products {
            get {
                if (_products is null || _products.Count == 0) return null;

                IProduct[] products = new IProduct[_products.Count];
                _products.CopyTo(products, 0);
                return products;
            }
        }

        public int Count => _products.Count;

        public void Insert(IProduct product) {
            _products.Add(product);
        }

        public void Insert(ICollection<IProduct> products) {
            if (products is null || products.Count == 0) return;
            foreach (IProduct product in products) _products.Add(product);
        }

        public void Remove(IProduct product) {
            _products.Remove(product);
        }

        public void Clear() {
            _products.Clear();
        }

        public static ProductCollection operator +(ProductCollection collection, IProduct[] item) {
            ProductCollection products = new ProductCollection();
            if (collection != null && collection.Count > 0) products.Insert(collection.Products);

            if (item != null && item.Length > 0) products.Insert(item);
            return products;
        }

        public static ProductCollection operator +(ProductCollection source, ProductCollection target) {
            return source + target.Products;
        }
    }
    /// <summary>
    /// 批量工厂接口
    /// </summary>
    public interface IBatchFactory {
        /// <summary>
        /// 创建产品集合
        /// </summary>
        /// <param name="quantity">待加工的产品数量</param>
        /// <returns></returns>
        ProductCollection Create(int quantity);
    }
    /// <summary>
    /// 批量工厂基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BatchProductFactoryBase<T> : IBatchFactory where T : IProduct,new() {
        public virtual ProductCollection Create(int quantity) {
            if (quantity <= 0) throw new ArgumentException();
            ProductCollection collection = new ProductCollection();
            for (int i = 0; i < quantity; i++) {
                collection.Insert(new T());
            }

            return collection;
        }
    }
    /// <summary>
    /// A产品批量工厂
    /// </summary>
    public class BatchProductAFactory : BatchProductFactoryBase<ProductA> {

    }
    /// <summary>
    /// B产品批量工厂
    /// </summary>
    public class BatchProductBFactory : BatchProductFactoryBase<ProductB>
    {

    }
    /// <summary>
    /// 生产决策
    /// </summary>
    public abstract class DecisionBase {
        protected IBatchFactory factory;
        protected int quantity;

        public DecisionBase(IBatchFactory factory, int quantity) {
            this.factory = factory;
            this.quantity = quantity;
        }

        public virtual IBatchFactory Factory => factory;
        public virtual int Quantity => quantity;
    }
}