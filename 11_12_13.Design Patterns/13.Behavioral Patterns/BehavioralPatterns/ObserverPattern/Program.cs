using BehavioralPatterns.Domain;
using BehavioralPatterns.ExtensionMethods;
using ObserverPattern.Core;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Ad ad = new Ad();

            List<ClientData> clientList = new List<ClientData>();
            clientList.GetClients();

            Subscriber subscriber1 = new Subscriber(clientList.ElementAt(0));
            Subscriber subscriber2 = new Subscriber(clientList.ElementAt(1));
            Subscriber subscriber3 = new Subscriber(clientList.ElementAt(2));
            Subscriber subscriber4 = new Subscriber(clientList.ElementAt(4));

            ad.Subscribe(subscriber1);
            ad.Subscribe(subscriber2);
            ad.Subscribe(subscriber3);
            ad.Subscribe(subscriber4);

            var offerPizza = new Offer("Pizza Family Diavola", "Pizza family with 2 doses( at your choices) and 2 sauces( at your choices)", DateTime.Now, 30.99f, 0.25f);
            var offerBurger = new Offer("Extreme Burger", "Extreme burger with sauce(at your choice)", DateTime.Now, 20.33f, 0.30f);

            ad.PublishOffer(offerPizza);

            ad.Unsubscribe(subscriber3);
            ad.PublishOffer(offerBurger);

        }

       
    }
}