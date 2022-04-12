using Domain.EnitityConfigurations;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;

namespace Domain
{
    public class ComplexFoodContext : DbContext
    {
        //Roles
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        
        //Shopping
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }

        //Ordering
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OdersItem { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-T4A7BVN;Database=ComplexFoodDatabase;Trusted_Connection=True;")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name},
                 LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //daca nu specificam nimic aici, inseamna ca se creeaza ori by convention ori pe tipul de adnotari

            modelBuilder.ApplyConfiguration(new BuyerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CouponEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemEntityTypeConfiguration());

            //sau varianta a doua, aplica toate configurariile
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
