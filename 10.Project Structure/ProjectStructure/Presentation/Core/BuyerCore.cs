
using Domain.Models;

namespace Presentation.Core
{
    public class BuyerCore 
    {
        private static readonly List<Buyer> _buyers = new List<Buyer>();

        public static void RegisterBuyer(Buyer buyer)
        {
            _buyers.Add(buyer);
            _buyers.First(x => x.Id == buyer.Id).Confirmed  = true;
            Console.WriteLine("Registration was completed successfully!");
        }

        public static Buyer GetBuyerById(int id)
        {
            return _buyers.Where(x => x.Id == id).First();
        }

        public static IEnumerable<Buyer> GetBuyers()
        {
           return _buyers;
        }

        public static  void DeleteBuyer(int id)
        {
            var buyerToRemove = GetBuyerById(id);
            _buyers.Remove(buyerToRemove);

            Console.WriteLine("Your account was deleted!");
        }
    }
}
