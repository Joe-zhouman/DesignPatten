﻿// Administrator
// Joezhouman.DesignPatten
// AbstractFactory
// 2021-04-09-14:54
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.AbstractFactory.Products {
    public class ProductXA2 : IProductXA
    {
        public int Id { get; set; } = 2;
        public string Type { get; set; } = "XA";
    }
}