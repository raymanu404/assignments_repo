using Decorator.Classes;
using Decorator.Abstractions;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBurger burger = new SimpleBurger();
            burger = new Bacon(burger);
            burger = new Salad(burger);
            burger = new Pickels(burger);
            burger = new Onion(burger);

            Console.WriteLine($"{burger.GetDescription()} with total price: {burger.GetCost()}");
        }
    }
}