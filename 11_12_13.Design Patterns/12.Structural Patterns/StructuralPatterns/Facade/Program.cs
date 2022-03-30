using Proxy.Classes.ExtensionMethods;
using Proxy.Classes;
using Facade.Domain;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var client1 = new CommandOrderFacade(GetClients().ElementAt(0));
            var client2 = new CommandOrderFacade(GetClients().ElementAt(1));
            var client3= new CommandOrderFacade(GetClients().ElementAt(2));

            var burger = new Menu() { Id = 1, Category = Categories.FastFood, Title = "Burger Crispy", Description = "Burger with Cripsy and hot chilly", Price = 20.99f };
            var pizza = new Menu() { Id = 2, Category = Categories.FastFood, Title = "Pizza Diavola", Description = "Pizza Diavola with tomatos sauce", Price = 28.99f };
            var soup = new Menu() { Id = 3, Category = Categories.Soup, Title = "Chicken Soup", Description = "Chicken Soup with vegetables", Price = 9.99f };

            client1.ChooseMenu(menu: burger, amount: 2);
            client1.PayYourMenu();

            client2.ChooseMenu(pizza, 2);
            client2.ChooseMenu(soup, 1);
            client2.PayYourMenu();

            client3.ChooseMenu(burger, 4);
            client3.ChooseMenu(pizza, 3);
            client3.PayYourMenu();

        }

        private static IEnumerable<ClientData> GetClients()
        {
            var currentTextFile = Path.Combine(Directory.GetCurrentDirectory(), "clients.txt");
            IEnumerable<ClientData> listOfClients = currentTextFile.ReadFromFileMethod();

            foreach (ClientData client in listOfClients)
            {
                yield return client;
            }
        }


    }
}