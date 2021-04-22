// Administrator
// Joezhouman.DesignPatten
// Util
// 2021-04-21-15:51
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.Util.Broker {
    public interface IConfigurationSource {
        /// <summary>
        /// 加载配置节缓存对象
        /// </summary>
        void Load();
    }
}