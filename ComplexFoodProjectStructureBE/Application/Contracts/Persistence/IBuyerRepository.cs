using Domain.Models.Roles;

namespace Application.Contracts.Persistence;

public interface IBuyerRepository
{
    Task AddAsync(Buyer buyer);
    Task UpdateAsync(Buyer buyer);
    void DeleteAsync(Buyer buyer);
    Task<Buyer?> GetByIdAsync(int id);
    Task<List<Buyer>> GetAllAsync();
}