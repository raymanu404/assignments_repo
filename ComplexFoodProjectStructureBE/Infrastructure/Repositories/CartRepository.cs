using Application.Contracts.Persistence;
using Domain.Models.Shopping;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationContext _context;
        public CartRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ShoppingCart cart) => await _context.Carts.AddAsync(cart);

        public void DeleteAsync(ShoppingCart cart) => _context.Carts.Remove(cart);

        public async Task<List<ShoppingCart>> GetAllAsync() => await _context.Carts.ToListAsync();

        public async Task<ShoppingCart?> GetByIdAsync(int id) => await _context.Carts.Where(x => x.Id == id).FirstAsync();

        public async Task<ShoppingCart?> GetCartByBuyerId(int buyerId) => await _context.Carts.Where(x => x.BuyerId == buyerId).FirstAsync();

        public Task UpdateAsync(ShoppingCart cart)
        {
            throw new NotImplementedException();
        }
    }
}
