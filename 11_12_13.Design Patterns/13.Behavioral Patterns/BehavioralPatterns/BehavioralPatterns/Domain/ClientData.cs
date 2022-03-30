using BehavioralPatterns.Abstractions;
using BehavioralPatterns.Domain.Enums;

namespace BehavioralPatterns.Domain
{
    public class ClientData : ICard, IClientData
    {

        public int UserId { get; set; } = 0;

        // Card Data info
        public string FullName { get; set; } = null!;
        public CardType CreditCard { get; set; }
        public string CardNumber { get; set; } = null!;
        public string ExpirationDate { get; set; } = null!;
        public string CsvNumber { get; set; } = null!;


        //Client Data Info
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string Country { get; set; } = null!;

        //Other Info
        public float Balance { get; set; } = 0;
        public bool HasOffers { get; set; } = false;

        public void ShowClientInfo()
        {
            Console.WriteLine("------------------------------ Client Info ----------------------------------");
            Console.WriteLine($" Address: {Address}, City: {City}, Province: {Province}, Postal Code: {PostalCode}, Country: {Country}, Balance: {Balance}");
        }
        public void ShowCardClientInfo()
        {
            Console.WriteLine("============================== Card Info =====================================");
            Console.WriteLine($"FullName: {FullName}, CreditCard: {CreditCard}, Card Number: {CardNumber}, Expiration Date: {ExpirationDate}, CSV: {CsvNumber} \n\n");
        }
        public void ShowClientAllInfo()
        {
            ShowClientInfo();
            ShowCardClientInfo();
        }


    }
}
