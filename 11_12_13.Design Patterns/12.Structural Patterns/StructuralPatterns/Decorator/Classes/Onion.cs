using Decorator.Abstractions;

namespace Decorator.Classes
{
    internal class Onion : BaseBurgerDecorator
    {
        public Onion(IBurger burger) : base(burger)
        {
        }

        public override float GetCost()
        {
            return  _burger.GetCost() + 1.50f; 
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + " with Onion"; 
        }
    }
}
