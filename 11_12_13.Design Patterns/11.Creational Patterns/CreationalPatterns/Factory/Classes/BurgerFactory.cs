using Factory.Abstractions;

namespace Factory.Classes
{
    public class BurgerFactory : IPrepareFoodFactory
    {
        public static  IPrepareFood CreateMenu(string title, string description, float price, int amount)
        {
            return new Burger
            {
                Title = title,
                Description = description,
                Price = price,
                Amount = amount,

            };
        }
    }
}
