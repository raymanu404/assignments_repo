using Proxy.Classes;
using Proxy.Abstractions;

namespace Facade
{
    public class PaymentLibrary : CardPaymentLibrary
    {
        public void IniliazePayment()
        {
            Console.WriteLine("Iniliaze Payment");
        }
        public bool ValidateCard(ClientData client)
        {
            //validate logic
            if (CheckCardData(client))            
                 return true;
                    
           return false;
        }
        public void PayWithVisa(ClientData client, float totalPrice)
        {
           
             client.Balance = client.Balance - totalPrice;
             Console.WriteLine("You paid with Visa. Thank you ");
           
        }
        public void PayWithMasterCard(ClientData client, float totalPrice)
        {           
             client.Balance = client.Balance - totalPrice;
             Console.WriteLine("You paid with MasterCard. Thank you ");
           
        }
        public void PayWithMaestro(ClientData client, float totalPrice)
        {
             client.Balance = client.Balance - totalPrice;
             Console.WriteLine("You paid with Maestro. Thank you ");
           
        }

        public void SettleTransaction()
        {
            Console.WriteLine("Settle Transaction");
        }
    }
}
