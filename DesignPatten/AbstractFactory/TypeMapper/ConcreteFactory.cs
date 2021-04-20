// Administrator
// Joezhouman.DesignPatten
// AbstractFactory
// 2021-04-13-11:23
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
    public class ConcreteFactory:AbstractFactoryBase {
        public ConcreteFactory(IDictionary<Type, Type> mapper) : base(mapper) {
        }
    }
}