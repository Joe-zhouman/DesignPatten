// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-22-11:22
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
using Joezhouman.DesignPattern.Util.AttributeHelper;

namespace Joezhouman.DesignPattern.Builder.AttributeBuilder {
    public class Builder<T> : IBuilder<T> where T : class, new() {
        /// <summary>
        /// 缓存
        /// <list type="explanation">
        /// <item>TODO 参考Enterprise Library自动发现存储过程参数列表</item>
        /// <item>保证获取IList&lt;BuildStepAttribute&gt;的过程仅发生一次</item>
        /// <item>非线程安全，实际可以把cache设计成独立的单例对象</item>
        /// </list>
        /// </summary>
        private static IDictionary<Type, IList<BuildStepAttribute>> _cache = new Dictionary<Type, IList<BuildStepAttribute>>();
        public virtual T BuildUp() {
            IList<BuildStepAttribute> attributes = DiscoveryBuildSteps();
            if (attributes is null) {
                return new T();
            }

            T target = new();
            foreach (var attribute in attributes) {
                for (int i = 0; i < attribute.Times; i++) {
                    attribute.Handler.Invoke(target, null);
                }
            }

            return target;
        }

        protected virtual IList<BuildStepAttribute> DiscoveryBuildSteps() {
            if (_cache.ContainsKey(typeof(T))) return _cache[typeof(T)];
            IList<MethodInfo> methods = AttributeHelper.GetMethodWithCustomAttributes<BuildStepAttribute>(typeof(T));
            if (methods is null || methods.Count == 0) {
                return null;
            }

            BuildStepAttribute[] attributes = new BuildStepAttribute[methods.Count];
            for (int i = 0; i < methods.Count; i++) {
                BuildStepAttribute attribute = AttributeHelper.GetMethodCustomAttribute<BuildStepAttribute>(methods[i]);
                attribute.Handler = methods[i];
                attributes[i] = attribute;
            }
            Array.Sort<BuildStepAttribute>(attributes);
            return new List<BuildStepAttribute>(attributes);
        }
    }
}