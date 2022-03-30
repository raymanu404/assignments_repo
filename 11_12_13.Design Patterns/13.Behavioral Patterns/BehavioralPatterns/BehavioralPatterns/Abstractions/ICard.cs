using BehavioralPatterns.Domain.Enums;

namespace BehavioralPatterns.Abstractions
{
    public interface ICard
    {
        string FullName { get; set; }
        CardType CreditCard { get; set; }
        string CardNumber { get; set; }
        string ExpirationDate { get; set; }
        string CsvNumber { get; set; }

        void ShowCardClientInfo();
    }

}
