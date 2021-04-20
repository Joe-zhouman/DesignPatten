// Administrator
// Joezhouman.DesignPatten
// AbstractFactory
// 2021-04-13-10:57
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

namespace Joezhouman.DesignPattern.AbstractFactory.Assembler {
    public abstract class AbstractFactoryBase:IAbstractFactoryWithTypeMapper {
        protected TypeMapperBase mapper;
        public virtual T Create<T>() => (T)Activator.CreateInstance(mapper[typeof(T)]);

        public virtual TypeMapperBase Mapper {
            get => mapper;
            set => mapper = value;
        }
    }
}