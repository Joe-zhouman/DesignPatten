// Administrator
// Joezhouman.DesignPatten
// Util
// 2021-04-21-16:00
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
using System.Configuration;
using Joezhouman.DesignPattern.Util.Cache;

namespace Joezhouman.DesignPattern.Util.Broker {
    public static class ConfigurationBroker {
        private static readonly GenericCache<Type, object> _cache_;

        static ConfigurationBroker() {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _cache_ = new GenericCache<Type, object>();
            foreach (ConfigurationSectionGroup group in config.SectionGroups)
                if (@group is IConfigurationSource)
                    (@group as IConfigurationSource).Load();
        }

        public static void Add(Type type, object item) {
            if (type is null || item is null) throw new NullReferenceException();
            _cache_.Add(type, item);
        }

        public static void Add(KeyValuePair<Type, object> item) {
            Add(item.Key, item.Value);
        }

        public static void Add(object item) {
            Add(item.GetType(), item);
        }

        public static T GetConfigurationObject<T>() where T : class {
            if (_cache_.Count <= 0) return null;
            if (_cache_.TryGetValue(typeof(T), out object result))
                return result as T;
            return null;
        }
    }
}