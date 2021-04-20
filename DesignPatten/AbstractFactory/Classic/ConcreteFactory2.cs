// Administrator
// Joezhouman.DesignPatten
// AbstractFactory
// 2021-04-07-19:56
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

namespace Joezhouman.DesignPattern.AbstractFactory.Classic {
    public class ConcreteFactory2:IAbstractFactory{
        public IProductA CreateProductA() {
            return new ProductA2X();
        }

        public IProductB CreateProductB() {
            return new ProductB2();
        }
    }
}