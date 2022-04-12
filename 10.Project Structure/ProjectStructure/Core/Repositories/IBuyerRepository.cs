using Domain.Models;

namespace Domain.Repositories
{
    public interface IBuyerRepository
    {
        void InsertBuyer(Buyer newBuyer);
        List<Buyer> GetAllBuyers();
        Buyer GetBuyerByEmail(string email);

        void DeleteBuyer(int id);
        void UpdateBuyer(Buyer updateBuyer);
        void Save();
    }
}
