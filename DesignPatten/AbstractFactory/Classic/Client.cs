// Administrator
// Joezhouman.DesignPatten
// AbstractFactory
// 2021-04-07-19:57
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.AbstractFactory.Classic {
    public static class Client {
        public static void Produce() {
            IAbstractFactory factory = (new Assembler()).Create<IAbstractFactory>();//通过依赖注入，从配置文件生成
            factory.CreateProductA();
        }
    }
}