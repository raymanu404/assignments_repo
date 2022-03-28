using Proxy.Classes;

namespace Proxy.Abstractions
{
    public interface ICardPaymentProvider
    {      
        void MakePayment();
        void GetAllTransactions();
        void GetTransaction( int id);

    }
}
