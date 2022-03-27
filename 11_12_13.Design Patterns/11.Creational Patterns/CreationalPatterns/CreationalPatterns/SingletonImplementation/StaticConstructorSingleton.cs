
namespace Singleton.SingletonImplementation
{
    public class StaticConstructorSingleton
    {
        public static readonly StaticConstructorSingleton _instance = new StaticConstructorSingleton();

        static StaticConstructorSingleton()
        {
            Console.WriteLine("Constructor");
        }

        public static StaticConstructorSingleton Instance
        {
            get
            {
                return _instance;
            }

        }
    }
}
