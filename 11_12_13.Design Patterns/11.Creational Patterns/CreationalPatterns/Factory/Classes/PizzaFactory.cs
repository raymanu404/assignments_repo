using Factory.Abstractions;

namespace Factory.Classes
{
    public class PizzaFactory : IPrepareFoodFactory
    {
        public static IPrepareFood CreateMenu(string title, string description, float price, int amount)
        {
            return new Pizza
            {
                Title = title,
                Description = description,
                Price = price,
                Amount = amount,

            };
        }
    }
}
