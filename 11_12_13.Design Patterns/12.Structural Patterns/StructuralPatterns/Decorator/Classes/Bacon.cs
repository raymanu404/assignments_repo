using Decorator.Abstractions;

namespace Decorator.Classes
{
    internal class Bacon : BaseBurgerDecorator
    {
        public Bacon(IBurger burger) : base(burger)
        {

        }

        public override float GetCost()
        {
           return _burger.GetCost() + 2; 
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + " with bacon";
        }
    }
}
