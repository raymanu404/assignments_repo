﻿using Domain.Models.Roles;
using Domain.Models.Ordering;
using Domain.Models.Shopping;
using Infrastructure.EnitityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<Buyer> Buyers => Set<Buyer>();
    public DbSet<Coupon> Coupons => Set<Coupon>();
    public DbSet<ShoppingCart> Carts => Set<ShoppingCart>();
    public DbSet<Admin> Admins => Set<Admin>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<ShoppingCartItem> ShoppingItems => Set<ShoppingCartItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //daca nu specificam nimic aici, inseamna ca se creeaza ori by convention ori pe tipul de adnotari

        modelBuilder.ApplyConfiguration(new AdminEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BuyerEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CartEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CouponEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new OrderItemEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new OrderEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ShoppingCartItemEntityTypeConfiguration());

        //sau varianta a doua, aplica toate configurariile
        //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}