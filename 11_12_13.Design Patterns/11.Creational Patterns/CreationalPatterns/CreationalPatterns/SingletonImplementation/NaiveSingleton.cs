using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.SingletonImplementation
{
    public class NaiveSingleton
    {
        private static NaiveSingleton _instance;

        private NaiveSingleton()
        {
            Console.WriteLine("Constructor");
        }
        public static NaiveSingleton GetInstance
        {
            get
            {
                Console.WriteLine("Call GetInstance");
                if (_instance == null)
                {
                    _instance = new NaiveSingleton();

                }
                return _instance;
            }
            set { }
        }
    }
}
