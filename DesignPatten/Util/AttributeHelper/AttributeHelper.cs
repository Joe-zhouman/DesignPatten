// Administrator
// Joezhouman.DesignPatten
// Util
// 2021-04-21-20:33
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
using System.Collections.Generic;
using System.Reflection;

namespace Joezhouman.DesignPattern.Util.AttributeHelper {
    public static class AttributeHelper {
        /// <summary>
        /// 获取某个模型包括指定属性的集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IList<T> GetCustomAttributes<T>(Type type) where T : Attribute {
            if (type is null) {
                throw new ArgumentException(nameof(type));
            }

            T[] attributes = type.GetCustomAttributes(typeof(T), false) as T[];
            return attributes is null ? null : attributes.Length == 0 ? null : new List<T>(attributes);
        }
        /// <summary>
        /// 获得某个类型包括指定属性的所有方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IList<MethodInfo> GetMethodWithCustomAttributes<T>(Type type) where T:Attribute{
            if (type is null) {
                throw new ArgumentException(nameof(type));
            }

            MethodInfo[] methods = type.GetMethods();
            if (methods.Length == 0) {
                return null;
            }

            IList<MethodInfo> result = new List<MethodInfo>();
            foreach (MethodInfo method in methods) {
                if (method.IsDefined(typeof(T),false)) {
                    result.Add(method);
                }
            }

            return result.Count == 0 ? null : result;
        }
        /// <summary>
        /// 获取某方法指定类型属性的集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <returns></returns>
        public static IList<T> GetMethodCustomAttributes<T>(MethodInfo method) where T : Attribute {
            if (method is null) {
                throw new ArgumentException(nameof(method));
            }

            T[] attributes = method.GetCustomAttributes(typeof(T), false) as T[];
            return attributes is null ? null : attributes.Length == 0 ? null : new List<T>(attributes);
        }
        /// <summary>
        /// 获取某方法指定类型的属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <returns></returns>
        public static T GetMethodCustomAttribute<T>(MethodInfo method) where T : Attribute {
            IList<T> attributes = GetMethodCustomAttributes<T>(method);
            return attributes?[0];
        }
    }
}