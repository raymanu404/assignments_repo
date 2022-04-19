using Domain.Models.Shopping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.ValueObjects;

namespace Infrastructure.EnitityConfigurations;

public class ShoppingCartItemEntityTypeConfiguration : IEntityTypeConfiguration<ShoppingCartItem>
{
    public void Configure(EntityTypeBuilder<ShoppingCartItem> shoppingCartItemBuilder)
    {
        shoppingCartItemBuilder
            .HasOne(x => x.Product)
            .WithOne()
            .HasForeignKey<ShoppingCartItem>();
    }
}