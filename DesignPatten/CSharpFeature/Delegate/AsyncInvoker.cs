// Administrator
// DesignPatten
// CSharpFeature
// 2021-03-23-20:42
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
using System.Threading;

namespace Joezhouman.DesignPattern.CSharpFeature.Delegate {
    /// <summary>
    /// 委托与异步调用
    /// </summary>
    /// <remarks>
    /// Timer的第一个参数<c>TimerCallBack</c>就是一个委托
    /// </remarks>
    public class AsyncInvoker {
        public AsyncInvoker() {
            Timer slowTimer = new Timer(OnTimeInterval, "slow", 2500, 2500);
            Timer fastTimer = new Timer(OnTimeInterval, "fast", 2000, 2000);
            Output.Add("method");
        }

        private void OnTimeInterval(object state) {
            Output.Add(state as string);
        }

        public IList<string> Output { get; } = new List<string>();
    }
}