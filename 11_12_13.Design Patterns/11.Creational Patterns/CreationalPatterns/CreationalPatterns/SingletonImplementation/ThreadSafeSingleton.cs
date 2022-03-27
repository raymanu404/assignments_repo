using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.SingletonImplementation
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton? _instance;
        private static readonly object _lock = new object();
        private ThreadSafeSingleton()
        {
            Console.WriteLine("Constructor");
        }

        public static ThreadSafeSingleton GetInstance()
        {
            Console.WriteLine("Call GetInstance"); 
            if (_instance == null) //double - check
            {

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                   
                }

            }
            return _instance;

        }
    }
}
