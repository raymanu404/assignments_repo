using Decorator.Abstractions;

namespace Decorator.Classes
{
    internal class SimpleBurger : IBurger
    {
        public float GetCost()
        {
            return 10.99f;
        }

        public string GetDescription()
        {
            return $"Burger";
        }
    }
}
