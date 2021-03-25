// Administrator
// Joezhouman.DesignPatten
// Factory
// 2021-03-24-17:41
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
using System.Runtime.InteropServices.ComTypes;

namespace Joezhouman.DesignPattern.Factory.SimpleFactory {
    public enum ProductType {
        A,
        B
    }
    public static class StaticFactory {
        public static IProduct Create(ProductType type) =>
            type switch {
                ProductType.A => new ProductA(),
                ProductType.B => new ProductB(),
                _ => throw new ArgumentException()
            };
    }
}