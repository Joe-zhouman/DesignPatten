// Administrator
// Joezhouman.DesignPatten
// AbstractFactory
// 2021-04-09-9:40
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

namespace Joezhouman.DesignPattern.AbstractFactory.TypeMapper {
    public abstract class AbstractFactoryBase : IAbstractFactory {
        protected IDictionary<Type, Type> mapper;

        public AbstractFactoryBase(IDictionary<Type, Type> mapper) {
            this.mapper = mapper;
        }

        public T Create<T>() where T : class {
            if (mapper is null || mapper.Count == 0||!mapper.ContainsKey(typeof(T))) {
                throw new ArgumentNullException(nameof(mapper));
            }

            return Activator.CreateInstance(mapper[typeof(T)]) as T;
        }
    }
}