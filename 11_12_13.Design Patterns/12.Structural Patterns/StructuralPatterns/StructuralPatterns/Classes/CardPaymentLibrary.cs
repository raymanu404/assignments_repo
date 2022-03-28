using Proxy.Abstractions;
using System.Globalization;

namespace Proxy.Classes
{
    public class CardPaymentLibrary : ICardPaymentProvider
    {
        public bool CheckCardData(ClientData client)
        {
            if (client == null) return false;

            //Check Card Number
            string[] splitCardNumber = client.CardNumber.Split(" ");
            if (splitCardNumber.Length != 4) return false;

            foreach(var cardNumber in splitCardNumber)
            {
                if(cardNumber.Length != 4) return false;
                if(GetInteger(cardNumber) == -1)
                {                  
                    return false;
                }
            }


            //Check Expiration Date
            string[] splitExpirationDate = client.ExpirationDate.Split('/');
            foreach(var expirationDate in splitExpirationDate)
            {
                if (GetInteger(expirationDate) == -1)
                {
                    return false;
                }                
            }
            if(GetInteger(splitExpirationDate[0]) < 1 || GetInteger(splitExpirationDate[0]) > 12) return false;
            if (GetInteger(splitExpirationDate[1]) < (DateTime.Now.Year - 2000) || GetInteger(splitExpirationDate[1]) > 99) return false;


            //CheckFullName
            string[] splitFullName = client.FullName.Split(' ');
            if (splitFullName.Length != 2) return false;
            if (GetInteger(splitFullName[0]) != -1 || GetInteger(splitFullName[1]) != -1 ) return false; 

         
            //and more verifications for Card data

            return true;
        }

        public void GetAllTransactions()
        {
            //library logic
            Console.WriteLine("Your transactions are here!");
            
        }

        public void GetTransaction(int id)
        {
            //library logic
            //some map/hashset with transtactions by client id 
            Console.WriteLine($"Your transaction is here!");
        }

        public void MakePayment()
        {
            //library logic
            Console.WriteLine("Payment was submitted successfully!");
        }

        private int GetInteger(string s)
        {
            if (Int32.TryParse(s, out int number))
            {
                return number;
            }
            return -1;
        }
      
    }
}
