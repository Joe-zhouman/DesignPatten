using System;
using System.Collections.Generic;
using System.Xml;
using Joezhouman.DesignPattern.CSharpFeature.Config;

namespace Joezhouman.DesignPattern.AbstractFactory.Classic {
    

    public class Assembler {
        private const  string _CONFIG_FILE_PATH = "./App.Config";
        private const string _SECTION_NAME = "AbstractFactory.CustomFactories";
        private const string _FACTORY_TYPE_NAME = "IAbstractFactory";
        private static Dictionary<Type, Type> _dictionary = new Dictionary<Type, Type>();

        static Assembler() {
            //NameValueCollection collection = ConfigurationManager.GetSection(_SECTION_NAME) as NameValueCollection;
            //if (collection == null) throw new ArgumentNullException(nameof(collection));
            //for (int i = 0; i < collection.Count; i++) {
            //    string target = collection.GetKey(i);
            //    string source = collection[i];
            //    _dictionary.Add(Type.GetType(target) ?? throw new NullReferenceException("key is null"),
            //                Type.GetType(source) ?? throw new NullReferenceException("value is null"));
            //}
            XmlNodeList nodeList = ConfigManager.GetSection(_SECTION_NAME, _CONFIG_FILE_PATH);
            foreach (XmlNode node in nodeList)
            {
                if (node.Attributes != null)
                    _dictionary.Add(Type.GetType(node.Attributes["key"].Value) ?? throw new NullReferenceException("key is null"),
                        Type.GetType(node.Attributes["value"].Value) ?? throw new NullReferenceException("value is null"));
            }
        }
        public object Create(Type type) {
            if (type is null || !_dictionary.ContainsKey(type)) throw new NullReferenceException("dic is null");
            Type targetType = _dictionary[type];
            return Activator.CreateInstance(targetType);
        }
        public T Create<T>() => (T)Create(typeof(T));
    }
}