using Application.Contracts.Persistence;
using Domain.Models.Roles;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BuyerRepository : IBuyerRepository
{
    private readonly ApplicationContext _context;
        
    public BuyerRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Buyer buyer) => await _context.Buyers.AddAsync(buyer);

    public  Task UpdateAsync(Buyer buyer) => throw new NotImplementedException();

    public void DeleteAsync(Buyer buyer) =>  _context.Buyers.Remove(buyer); //momentan doar void fara async

    public async Task<Buyer?> GetByIdAsync(int id) => await _context.Buyers.FindAsync(id);

    public async Task<List<Buyer>> GetAllAsync() => await _context.Buyers.ToListAsync();
}