using Proxy.Abstractions;

namespace Proxy.Classes
{
    public class ClientData : ICard, IClientData
    {

        public int UserId { get; set; } = 0;

        // Card Data info
        public string FullName { get; set; }
        public CardType CreditCard { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CsvNumber { get; set; }


        //Client Data Info
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        //Balance
        public float Balance { get; set; } = 0;


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
