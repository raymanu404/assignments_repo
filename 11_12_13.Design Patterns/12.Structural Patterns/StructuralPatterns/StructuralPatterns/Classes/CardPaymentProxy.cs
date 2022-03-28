using Proxy.Abstractions;
using Proxy.Classes.ExtensionMethods;

namespace Proxy.Classes
{
    public class CardPaymentProxy : ICardPaymentProvider
    {
        private readonly CardPaymentLibrary _cardPaymentLibrary;
        private readonly ClientData _clientData;
        public CardPaymentProxy(ClientData client)
        {
            _cardPaymentLibrary = new CardPaymentLibrary();
            _clientData = client;
        }

       
        private bool CheckCardData()
        {
            //some extra logic
            if (_clientData == null) return false;
            return _cardPaymentLibrary.CheckCardData(_clientData);
        }

        public void GetAllTransactions()
        {
            //some extra logic
            if(IsAuthorized())
                _cardPaymentLibrary.GetAllTransactions();
            else
                throw new Exception("The current client is not authorized to get all transactions");
        }

        public void GetTransaction(int id)
        {
            //some extra logic
            if (IsAuthorized())
            {
                _cardPaymentLibrary.GetTransaction(id);
            }
            else throw new Exception("The current client is not authorized to get transaction");
;
            
        }

        public void MakePayment()
        {
            //some extra logic
            if (IsAuthorized())
            {
                _cardPaymentLibrary.MakePayment();
            }
            else 
                Console.WriteLine("The current client is not authorized to make payments");
            
        }

        private bool IsAuthorized()
        {
            //some extra logic
            return CheckCardData();
        }
    }
}
