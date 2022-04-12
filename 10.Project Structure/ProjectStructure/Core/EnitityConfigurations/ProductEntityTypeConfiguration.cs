using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EnitityConfigurations
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> productConfiguration)
        {
            productConfiguration
                .HasOne(product => product.Cart)
                .WithMany(cart => cart.Products)
                .HasForeignKey(product => product.CartId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
