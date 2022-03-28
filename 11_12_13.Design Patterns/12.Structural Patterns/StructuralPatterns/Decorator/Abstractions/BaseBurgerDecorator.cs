

namespace Decorator.Abstractions
{
    public abstract class BaseBurgerDecorator : IBurger
    {
        protected IBurger _burger;
        public BaseBurgerDecorator(IBurger burger)
        {
            _burger = burger;
        }

        public abstract float GetCost();

        public abstract string GetDescription();
    }

}
