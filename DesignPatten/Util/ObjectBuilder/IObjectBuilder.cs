// Administrator
// Joezhouman.DesignPatten
// Util
// 2021-04-21-10:21
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.Util.ObjectBuilder {
    /// <summary>
    /// 根据类型名称生成类型实例
    /// </summary>
    public interface IObjectBuilder {
        /// <summary>
        /// 用特定构造函数创建实例
        /// </summary>
        /// <typeparam name="T">返回类型</typeparam>
        /// <param name="args">构造参数</param>
        /// <returns>T的实例</returns>
        T BuildUp<T>(object[] args);
        /// <summary>
        /// 用无参构造函数创建实例
        /// </summary>
        /// <typeparam name="T">返回类型</typeparam>
        /// <returns>T的实例</returns>
        T BuildUp<T>() where T : new();
        /// <summary>
        /// 按照目标返回的类型，加工指定类型名称对应的实例
        /// </summary>
        /// <typeparam name="T">目标类型<remarks>可以为接口，抽象类</remarks></typeparam>
        /// <param name="typeName">创建类型<remarks>一般为实体类</remarks></param>
        /// <returns>目标类型的实例</returns>
        T BuildUp<T>(string typeName);
        /// <summary>
        /// 按照目标返回的类型，用特定构造函数加工指定类型名称对应的实例
        /// </summary>
        /// <typeparam name="T">目标类型<remarks>可以为接口，抽象类</remarks></typeparam>
        /// <param name="typeName">创建类型<remarks>一般为实体类</remarks></param>
        /// <param name="args">构造函数参数</param>
        /// <returns>目标类型的实例</returns>
        T BuildUp<T>(string typeName, object[] args);
    }
}