// Administrator
// Joezhouman.DesignPatten
// Builder
// 2021-04-20-16:15
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
    public class HouseBuilder : IBuilder {
        private House _house = new();
        public void BuildPart1()
        {
            _house.AddWallAndFloor();
        }

        public void BuildPart2()
        {
            _house.AddWindowAndDoor();
        }

        public void BuildPart3()
        {
            _house.AddCeiling();
        }

        public House GetResult() => _house;
    }
}