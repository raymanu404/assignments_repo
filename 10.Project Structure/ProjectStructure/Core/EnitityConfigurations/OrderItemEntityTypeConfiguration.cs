using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EnitityConfigurations
{
    public class OrderItemEntityTypeConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> orderItemConfiguration)
        {
            orderItemConfiguration
               .HasOne(orderItem => orderItem.Order)
               .WithMany(order => order.Items)
               .HasForeignKey(orderItem => orderItem.OrderId)
               .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
