namespace Joezhouman.DesignPattern.Factory.SimpleFactory {

    /// <summary>
    /// 最简单的工厂模式
    /// </summary>
    /// <remarks>
    /// <list type="characteristic">
    /// <item>
    /// <description>1. </description>
    /// </item>
    /// <item>
    /// <description>2. </description>
    /// </item>
    /// </list>
    /// </remarks>
    public class SimplestFactory {
        //工厂决定实例化子类
        public IProduct Create() => new ProductA();
    }
}