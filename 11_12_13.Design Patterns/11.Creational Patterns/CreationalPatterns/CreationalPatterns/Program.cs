using Singleton.SingletonImplementation;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonNaiveImplemetantion();
            //MultipleThreadsNaiveImplementaion();
            //MultipleThreadsThreadSafeSingletonImplementation();
            //LazySingletonImplementation();
            //StaticContrusctorImplementation();

            StaticContrusctorNestedImplementation();
        }

        public static void SingletonNaiveImplemetantion()
        {
            //pentru abordarea asta ar trebui sa avem in vedere si threading safe.
            NaiveSingleton instance1 = NaiveSingleton.GetInstance;
            NaiveSingleton instance2 = NaiveSingleton.GetInstance;
            var instance3 = NaiveSingleton.GetInstance;

            Console.WriteLine(instance1 == instance2);
        }

        public static void MultipleThreadsNaiveImplementaion()
        {
            var strings = new List<string>() { "one", "two", "three", "four", "five" };
            var instances = new List<NaiveSingleton>();
            var options = new ParallelOptions { MaxDegreeOfParallelism = 5 };
           
            Parallel.ForEach (strings, options, instance =>
            {
                instances.Add(NaiveSingleton.GetInstance);            

            });

            //se apeleaza de mai multe ori constructorul in acest caz
        }

        public static void MultipleThreadsThreadSafeSingletonImplementation()
        {
            var strings = new List<string>() { "one", "two", "three", "four", "five" };
            var instances = new List<ThreadSafeSingleton>();
            var options = new ParallelOptions { MaxDegreeOfParallelism = 5};

            Parallel.ForEach(strings, options, instance =>
            {
                instances.Add(ThreadSafeSingleton.GetInstance());

            });

            //in acest caz este threadSafe si se apeleaza doar o singura data constructorul
        }

        public static void LazySingletonImplementation()
        {
            var instance1 = LazySingleton.GetInstance();
            var instance2 = LazySingleton.GetInstance();

            var instance3 = LazySingleton._instance;
            Console.WriteLine(instance1 == instance2);

        }

        public static void StaticContrusctorImplementation()
        {
            var instance1 = StaticConstructorSingleton.Instance;
            var instance2 = StaticConstructorSingleton._instance;

            Console.WriteLine(instance1 == instance2);
        }

        public static void StaticContrusctorNestedImplementation()
        {
            var instance1 = StaticConstructorSingletonNested.Instance;
            var instance2 = StaticConstructorSingletonNested.Instance;

            Console.WriteLine(instance1 == instance2);
        }



    }
}