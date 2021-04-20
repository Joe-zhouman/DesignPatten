// Administrator
// Joezhouman.DesignPatten
// AbstractFactory
// 2021-04-13-11:25
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

namespace Joezhouman.DesignPattern.AbstractFactory.Assembler {
    public static class AssemblyMechanism {
        private static TypeMapperDictionary _dictionary = new TypeMapperDictionary();
        /// <summary>
        /// 加载TypeMapper--Factory相关信息，实际通过依赖注入
        /// </summary>
        static AssemblyMechanism() {
            _dictionary.Add(typeof(ConcreteFactoryX),new ConcreteXTypeMapper());
            _dictionary.Add(typeof(ConcreteFactoryY), new ConcreteYTypeMapper());
        }

        public static void Assembly(IAbstractFactoryWithTypeMapper factory) {
            TypeMapperBase mapper = _dictionary[factory.GetType()];
            factory.Mapper = mapper;
        }
    }
}