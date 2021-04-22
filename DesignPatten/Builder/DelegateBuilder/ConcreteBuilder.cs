// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-20-16:39
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.Builder.DelegateBuilder {
    public class ConcreteBuilder :BuilderBase {
        public ConcreteBuilder() : base() {
            //通过配置文件依赖注入
            steps.Add(car.AddEngine);
            steps.Add(car.AddWheel);
            steps.Add(car.AddBody);
        }
    }
}