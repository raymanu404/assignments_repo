

namespace Proxy.Abstractions
{
    public interface ICard
    {
        string FullName { get; set; }
        CardType CreditCard { get; set; }
        string CardNumber { get; set; }
        string ExpirationDate { get; set; }
        string CsvNumber { get; set; }

    }


    public enum CardType
    {
        Visa,
        MasterCard,
        Maestro,

    }
}
