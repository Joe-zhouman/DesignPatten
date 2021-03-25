using System;
using System.Collections.Generic;

namespace Joezhouman.DesignPattern.CSharpFeature.Delegate {
    public delegate void MemoHandler(int x, int y, IDictionary<string, int> data);
    
    public class OverloadableDelegateInvoker {
        private MemoHandler _handler;

        public OverloadableDelegateInvoker() {
            Type type = typeof(MemoHandler);
            System.Delegate d = System.Delegate.CreateDelegate(type, typeof(AddMethod),"Add");
            d = System.Delegate.Combine(d, System.Delegate.CreateDelegate(type, typeof(SubMethod), "Sub"));
            d = System.Delegate.Combine(d, System.Delegate.CreateDelegate(type, typeof(MulMethod), "Mul"));
            _handler = d as MemoHandler;
        }

        public void Memo(int x, int y, IDictionary<string, int> data) {
            _handler(x, y, data);
        }
    }

    public static class AddMethod {
        public static void Add(int x, IDictionary<string, int> data) {
            data.Add("A",x);

        }
        public static void Add(int x, int y, IDictionary<string, int> data) {
            data.Add("A", x + y);
        }
    }
    public static class SubMethod
    {
        public static void Sub(int x, IDictionary<string, int> data)
        {
            data.Add("S", x);

        }
        public static void Sub(int x, int y, IDictionary<string, int> data)
        {
            data.Add("S", x - y);
        }
    }
    public static class MulMethod
    {
        public static void Mul(int x, int y, IDictionary<string, int> data)
        {
            data.Add("M", x * y);
        }
    }
}