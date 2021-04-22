// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-22-14:46
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.Builder.TearDownBuilder {
    public interface IBuilder<T> {  
        T BuildUp();
        T TearDown();
    }
}