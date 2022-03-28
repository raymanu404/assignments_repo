using Proxy.Classes;
using Proxy.Classes.ExtensionMethods;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {

            var clientProxy1 = new CardPaymentProxy(GetClients().ElementAt(0));
            clientProxy1.MakePayment();

            var clientProxy2 = new CardPaymentProxy(GetClients().ElementAt(1));
            clientProxy2.MakePayment();
            clientProxy2.GetTransaction(1);
            clientProxy2.GetAllTransactions();

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