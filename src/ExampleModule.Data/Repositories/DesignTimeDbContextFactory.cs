using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ExampleModule.Data.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ExampleDbContext>
    {
        public ExampleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ExampleDbContext>();

            builder.UseSqlServer("Data Source=(local);Initial Catalog=VirtoCommerce3;Persist Security Info=True;User ID=virto;Password=virto;MultipleActiveResultSets=True;Connect Timeout=30");

            return new ExampleDbContext(builder.Options);
        }
    }
}
