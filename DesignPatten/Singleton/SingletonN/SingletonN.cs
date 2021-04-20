// Administrator
// Joezhouman.DesignPatten
// Singleton
// 2021-04-06-20:19
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.Singleton.SingletonN {
    public class SingletonN:IWorkItem {
        private const int _MAX_INSTANCE = 2;
        public Status Status { get; set; } = Status.FREE;
        public void DeActivate() {
            this.Status = Status.FREE;
        }

        private static WorkItemCollection<SingletonN> _collection = new WorkItemCollection<SingletonN>(_MAX_INSTANCE);
        private SingletonN(){}

        public static SingletonN Instance {
            get {
                SingletonN instance = _collection.GetWorkItem();
                if (instance == null) {
                    if (!_collection.CouldAddNewInstance) {
                        return null;
                    }

                    instance = new SingletonN();
                    _collection.Add(instance);
                }

                instance.Status = Status.BUSY;
                return instance;
            }
        }
    }
}