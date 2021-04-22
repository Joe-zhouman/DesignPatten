// Administrator
// Joezhouman.DesignPatten
// Util
// 2021-04-21-10:55
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

using System;

namespace Joezhouman.DesignPattern.Util.ObjectBuilder {
    /// <summary>
    /// 简要实现
    /// </summary>
    public class TypeCreator : IObjectBuilder {
        public T BuildUp<T>(object[] args) {
            return (T) Activator.CreateInstance(typeof(T), args);
        }

        public T BuildUp<T>() where T : new() {
            return Activator.CreateInstance<T>();
        }

        public T BuildUp<T>(string typeName) {
            return (T) Activator.CreateInstance(Type.GetType(typeName) ??
                                                throw new NullReferenceException(nameof(typeName)));
        }

        public T BuildUp<T>(string typeName, object[] args) {
            return (T) Activator.CreateInstance(
                Type.GetType(typeName) ?? throw new NullReferenceException(nameof(typeName)), args);
        }
    }
}