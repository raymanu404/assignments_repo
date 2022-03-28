using Decorator.Abstractions;

namespace Decorator.Classes
{
    internal class Salad : BaseBurgerDecorator
    {
        public Salad(IBurger burger) : base(burger)
        {

        }

        public override float GetCost()
        {
            return _burger.GetCost() + 3.02f;
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + " with Salad";
        }
    }
}
