// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-20-15:57
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.Builder.DiffBuilder {
    public class CarBuilder:IBuilder {
        private Car _car = new();
        public void BuildPart1() {
            _car.AddEngine();
        }

        public void BuildPart2() {
            _car.AddWheel();
        }

        public void BuildPart3() {
            _car.AddBody();
        }

        public Car GetResult() => _car;
    }
}