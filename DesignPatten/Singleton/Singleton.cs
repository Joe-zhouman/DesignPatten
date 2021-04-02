namespace Joezhouman.DesignPattern.Singleton
{
    /// <summary>
    /// 最基本的单例方法
    /// </summary>
    /// <remarks>
    /// 这段代码已经可以满足最初Singleton 模式的设计要求，在大多数情况下那段
    /// 代码也可以很好地工作。但在多线程环境下，这种实现方式存在很多潜在的缺陷，一个最直
    /// 接的问题就位于if 部分，当多个线程几乎同时调用Singleton 类的Instance 静态属性的时候，
    /// instance 成员可能还没有被实例化，因此它被创建了多次，而且最终Singleton 类中保存的是
    /// 最后创建的那个实例，各个线程引用的对象不同，这违背了我们“唯一实例”的初衷。
    /// </remarks>
    public class Singleton {
        /// <summary>
        /// 唯一实例
        /// </summary>
        private static Singleton _instance;
        /// <summary>
        /// 封闭直接实例化方法
        /// </summary>
        protected Singleton(){}

        public static Singleton Instance => _instance ??= new Singleton();
    }

    public class DoubleCheckSingleton {
        protected DoubleCheckSingleton(){}
        private static volatile DoubleCheckSingleton _instance = null;

        public static DoubleCheckSingleton Instance {
            get {
                if (_instance is null) {
                    lock (typeof(DoubleCheckSingleton)) {
                        if (_instance is null) {
                            _instance = new DoubleCheckSingleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
    /// <summary>
    /// 单例模式在C#中最简单的实现方式
    /// </summary>
    /// <remarks>
    /// <list type="note">
    /// <item>
    /// <discription> * 不要实现 ICloneable 接口或继承自其相关的子类，否则客户程序可以跳过已经隐蔽起来的类构造函数。
    /// </discription>
    /// </item>
    /// <item>
    /// <discription> * 严防序列化。
    /// </discription>
    /// </item>
    /// </list>
    /// </remarks>
    public class SingletonCSharp {
        private SingletonCSharp(){}
        public static readonly SingletonCSharp instance_ = new SingletonCSharp();
    }
}
