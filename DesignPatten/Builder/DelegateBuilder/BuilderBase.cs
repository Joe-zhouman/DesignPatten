// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-20-16:36
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
using Joezhouman.DesignPattern.Builder.DiffBuilder;

namespace Joezhouman.DesignPattern.Builder.DelegateBuilder {
    public delegate void BuildStepHandler();

    public abstract class BuilderBase : IBuilder {
        protected IList<BuildStepHandler> steps = new List<BuildStepHandler>();
        protected Car car = new();

        public virtual Car BuildUp() {
            foreach (var step in steps) {
                step();
            }

            return car;
        }
    }
}