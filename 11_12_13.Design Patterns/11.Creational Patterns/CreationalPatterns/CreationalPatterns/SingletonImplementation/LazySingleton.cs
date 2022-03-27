using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.SingletonImplementation
{
    public class LazySingleton
    {
        //crearea este amandata pana la prima utilizare
        public static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());  

        public static LazySingleton GetInstance()
        {
            Console.WriteLine("Get Instance");
            return _instance.Value; 
        }
        private LazySingleton()
        {
            Console.WriteLine("Constructor");
        }
    }
}
