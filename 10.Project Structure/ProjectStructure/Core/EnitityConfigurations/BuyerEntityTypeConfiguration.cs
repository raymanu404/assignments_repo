using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EnitityConfigurations
{
    public class BuyerEntityTypeConfiguration : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> buyerBuilder)
        {
            buyerBuilder
                .Property(c => c.PhoneNumber)
                .HasColumnName("Phone")
                .HasMaxLength(14);
        }
    }
}
