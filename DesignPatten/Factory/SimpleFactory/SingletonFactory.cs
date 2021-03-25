using System.Runtime.ConstrainedExecution;

namespace Joezhouman.DesignPattern.Factory.SimpleFactory {
    public class SingletonFactory {
        private static SimplestFactory factory = new SimplestFactory();
        public static SimplestFactory Factory => factory;
    }
}