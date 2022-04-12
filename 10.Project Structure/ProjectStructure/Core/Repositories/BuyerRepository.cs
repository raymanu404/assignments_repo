using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class BuyerRepository : IBuyerRepository
    {
        private ComplexFoodContext _context;

        public BuyerRepository(ComplexFoodContext context)
        {
            _context = context;
        }
        public void DeleteBuyer(int id)
        {

            var buyer = _context.Buyers.Where(x => x.Id == id).First();
            _context.Buyers.Remove(buyer);
           
        }

        public List<Buyer> GetAllBuyers()
        {
            return _context.Buyers.ToList();
        }

        public Buyer GetBuyerByEmail(string email)
        {
            return _context.Buyers.Where(x => x.Email.Equals(email)).First();
        }

        public void InsertBuyer(Buyer newBuyer)
        {
            _context.Buyers.AddAsync(newBuyer);
           
        }

        public void UpdateBuyer(Buyer updateBuyer)
        {
           
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
