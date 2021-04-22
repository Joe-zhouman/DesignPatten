// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-20-15:53
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
    public class Car {
        public bool Wheel { get; private set; }
        public bool Engine { get; private set; }
        public bool Body { get; private set; }

        public void AddWheel() {
            Wheel = true;
        }

        public void AddEngine() {
            Engine = true;
        }

        public void AddBody() {
            Body = true;
        }
    }
}