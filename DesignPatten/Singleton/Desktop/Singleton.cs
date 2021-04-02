// Administrator
// Joezhouman.DesignPatten
// Singleton
// 2021-04-02-14:54
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

namespace Joezhouman.DesignPattern.Singleton.Desktop {
    /// <summary>
    /// 每个线程有单独的Singleton实现
    /// </summary>
    public class Singleton {
        private Singleton(){}
        [ThreadStatic] // 说明每个Instance 仅在当前线程内为静态
        private static Singleton _instance;  

        public static Singleton Instance => _instance ??= new Singleton();
    }
}