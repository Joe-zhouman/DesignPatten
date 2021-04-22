// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-22-10:37
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
using System.Reflection;

namespace Joezhouman.DesignPattern.Builder.AttributeBuilder {
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class BuildStepAttribute : Attribute, IComparable {
        public BuildStepAttribute(int sequence, int times = 1) {
            Sequence = sequence;
            Times = times;
        }

        public MethodInfo Handler { get; set; }
        public int Sequence { get; init; }
        public int Times { get; init; }

        public int CompareTo(object obj) {
            if (obj is null || obj.GetType() != typeof(BuildStepAttribute)) throw new ArgumentException(nameof(obj));

            return Sequence - ((BuildStepAttribute) obj).Sequence;
        }
    }
}