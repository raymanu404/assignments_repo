using ObserverPattern.Abstractions;
using BehavioralPatterns.Domain;

namespace ObserverPattern.Core
{
    public class Subscriber : ISubscriber<Offer> //subscriber
    {
        public ClientData ClientData { get; set; }
        public bool HasOffers { get; set; }


        public Subscriber(ClientData clientData)
        {
            ClientData = clientData;
        }

        public void Notify(Offer item)
        {

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Hi  {ClientData.FullName}, The Offer of Week is : {item.Title}");
            Console.WriteLine($"{item.Description}      Old Price: {item.Price} RON     new Price: {item.TotalPrice} RON        {item.DateTime.ToShortDateString()}");
        }

    }
}
