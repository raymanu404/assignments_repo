using Decorator.Abstractions;

namespace Decorator.Classes
{
    internal class Pickels : BaseBurgerDecorator
    {
        public Pickels(IBurger burger) : base(burger)
        {

        }

        public override float GetCost()
        {
            return _burger.GetCost() + 1.88f; 
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + " with Pickles";
        }


    }
}
