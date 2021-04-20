﻿// Administrator
// Joezhouman.DesignPatten
// AbstractFactory
// 2021-04-13-11:07
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

using Joezhouman.DesignPattern.AbstractFactory.Products;

namespace Joezhouman.DesignPattern.AbstractFactory.Assembler {
    public class ConcreteXTypeMapper:TypeMapperBase {
        public ConcreteXTypeMapper() {
            base.Add(typeof(IProductXA),typeof(ProductXA2));
            base.Add(typeof(IProductXB), typeof(ProductXB1));
        }
    }
}