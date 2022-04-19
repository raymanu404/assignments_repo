namespace Application.Contracts.Persistence;

public interface IUnitOfWork : IAsyncDisposable
{
    IAdminRepository Admins { get; }
    IBuyerRepository Buyers { get; }
    ICouponRepository Coupons { get; }
    IProductRepository Products { get; }

    IOrderItemsRepository Items { get; }

    ICartRepository Carts { get; }
    IOrderRepository Orders { get; }
    Task<int> CommitAsync(CancellationToken cancellationToken);
}