using Domain.Models.Shopping;

namespace Application.Contracts.Persistence
{
    public interface ICartRepository
    {
        Task AddAsync(ShoppingCart cart);
        Task UpdateAsync(ShoppingCart cart);
        void DeleteAsync(ShoppingCart cart);
        Task<ShoppingCart?> GetByIdAsync(int id);

        Task<ShoppingCart?> GetCartByBuyerId(int buyerId);
        Task<List<ShoppingCart>> GetAllAsync();
    }
}
