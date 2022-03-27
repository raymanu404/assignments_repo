using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.SingletonImplementation
{

    //cea mai buna abordare cand doresti singleton
    //thread safe
    //perfomanta ridicata - nu se mai fac lock-uri cand ai multithreading
    //complex si non-intuitiv

    public class StaticConstructorSingletonNested
    {
        private StaticConstructorSingletonNested()
        {
            Console.WriteLine("Constructor");
        }

        private class Nested
        {
            internal static readonly StaticConstructorSingletonNested _instance = new StaticConstructorSingletonNested();
            static Nested()
            {
                Console.WriteLine("Nested Constructor");
            }
        }

        public static StaticConstructorSingletonNested Instance { get { return Nested._instance; } }
    }
}
