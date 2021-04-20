// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-20-15:46
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.Builder.DiffBuilder {
    public class House {
        public bool Window { get; private set; }
        public bool Door { get; private set; }
        public bool Wall { get; private set; }
        public bool Floor { get; private set; }
        public bool Ceiling { get; private set; }
        public void AddWindowAndDoor() {
            Window = true;
            Door = true;
        }
        public void AddWallAndFloor(){
            Wall = true;
            Floor = true;
        }

        public void AddCeiling() {
            Ceiling = true;
        }
    }
}