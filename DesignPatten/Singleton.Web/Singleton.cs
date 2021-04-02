using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Joezhouman.DesignPattern.Singleton.Web
{
    public class Singleton
    {
        private const string Key = "Joezhouman.DesignPattern.Singleton.Web";
        private Singleton() { }

        public static Singleton Instance;
        //{
        //    get
        //    {
        //        Singleton instance = (Singleton) HttpContext
        //        if
        //    }
        //}
    }
}
