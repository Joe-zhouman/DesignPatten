// Administrator
// Joezhouman.DesignPatten
// Singleton
// 2021-04-06-21:25
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.Singleton.GenericSingleton {
    public abstract class SingletonBase<T> : ISingleton where T:ISingleton,new() {
        protected static T instance = new T();
        public static T Instance => instance;
    }
}