// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-22-11:23
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

using System.Collections.Generic;

namespace Joezhouman.DesignPattern.Builder.AttributeBuilder {
    public class Car {
        public IList<string> log = new List<string>();

        [BuildStep(2)]
        public void AddWheel() {
            log.Add("wheel");
        }

        public void AddEngine() {
            log.Add("engine");
        }

        [BuildStep(1, 2)]
        public void AddBody() {
            log.Add("body");
        }
    }
}