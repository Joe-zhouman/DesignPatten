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

using System;
using System.Collections.Generic;

namespace Joezhouman.DesignPattern.Singleton.SingletonN {
    public class WorkItemCollection<T> where T : class, IWorkItem {
        protected readonly int max;
        protected IList<T> items = new List<T>();

        public WorkItemCollection(int max) {
            this.max = max;
        }

        public virtual bool CouldAddNewInstance => items.Count < max;

        public virtual T GetWorkItem() {
            if (items == null || items.Count == 0) return null;
            foreach (T item in items)
                if (item.Status == Status.FREE) {
                    item.Status = Status.BUSY;
                    return item;
                }

            return null;
        }

        public virtual void Add(T item) {
            if (item == null) throw new ArgumentNullException(nameof(item));

            if (!CouldAddNewInstance) throw new OverflowException();

            item.Status = Status.FREE;
            items.Add(item);
        }
    }
}