// Administrator
// Joezhouman.DesignPatten
// Singleton
// 2021-04-02-17:09
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

namespace Joezhouman.DesignPattern.Singleton.SingletonN {
    public class WorkItemCollection<T> where T:class,IWorkItem {
        protected int max;
        protected IList<T> items = new List<T>();

        public WorkItemCollection(int max) {
            this.max = max;
        }

        public virtual T GetWorkItem() {
            if (items == null || items.Count == 0) return null;

        }
    }
}