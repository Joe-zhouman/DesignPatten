using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Configuration;
using System.IO;
using System.Xml;
using Joezhouman.DesignPattern.CSharpFeature.Config;
namespace Joezhouman.DesignPattern.Factory.FactoryMethod {
    

    public class Assembler {
        private const string _CONFIG_FILE_PATH = @"D:\windows\Documents\GitHub\DesignPatten\DesignPatten\Factory\App.config";
        private const string _SECTION_NAME = "Joezhouman.DesignPattern.Factory.FactoryMethod.CustomFactories";
        private const string _FACTORY_TYPE_NAME = "IFactory";
        private static Dictionary<Type, Type> _dictionary = new Dictionary<Type, Type>();

        static Assembler() {
            XmlNodeList nodeList =  ConfigManager.GetSection(_SECTION_NAME, _CONFIG_FILE_PATH);
            foreach (XmlNode node in nodeList) {
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