using Application.Contracts.Persistence;

namespace Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationContext _context;

    public UnitOfWork(ApplicationContext context,
            IBuyerRepository buyers,
            ICouponRepository coupons,
            IProductRepository products,
            IAdminRepository admins,
            ICartRepository carts,
            IOrderRepository orders,
            IOrderItemsRepository items)
    {
        _context = context;
        Buyers = buyers;
        Coupons = coupons;
        Products = products;
        Admins = admins;
        Items = items;
        Carts = carts;
        Orders = orders;
    }

    public IBuyerRepository Buyers { get; }
    public ICouponRepository Coupons { get; }
    public IProductRepository Products { get; }

    public IAdminRepository Admins { get; }

    public IOrderItemsRepository Items { get; }

    public ICartRepository Carts { get; }

    public IOrderRepository Orders { get; }

    public async Task<int> CommitAsync(CancellationToken cancellationToken) =>
        await _context.SaveChangesAsync(cancellationToken);

    public ValueTask DisposeAsync() => _context.DisposeAsync();
}