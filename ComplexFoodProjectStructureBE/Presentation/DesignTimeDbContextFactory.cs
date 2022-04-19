using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Presentation;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<ApplicationContext>();
        builder.UseSqlServer(@"Server=DESKTOP-T4A7BVN;Database=ComplexFoodDatabase;Trusted_Connection=True;");
        return new ApplicationContext(builder.Options);
    }
}