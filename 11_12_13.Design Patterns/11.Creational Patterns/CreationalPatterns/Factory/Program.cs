using Factory.Classes;
using Factory.Abstractions;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrepareFood burger = BurgerFactory.CreateMenu(
                title:"The Extreme Burger",
                description: "180g	beeg patty,	lettuce,French’s mustard",
                price: 10.99f,
                amount: 2
                );

            burger.PrepareFood();    
            burger.ShowMenu();

            IPrepareFood pizza = PizzaFactory.CreateMenu(
                title: "Pizza Diavola",
                description: " Pizza diavola with tomatos sauce",
                price: 17.45f,
                amount: 2
                );

            pizza.PrepareFood();
            pizza.ShowMenu();

            IPrepareFood soup = SoupFactory.CreateMenu(
                title: "Chicken Soup",
                description: "More chicken in your soup",
                price: 9.2f,
                amount:3
                );

            soup.PrepareFood(); 
            soup.ShowMenu();

        }
    }
}
