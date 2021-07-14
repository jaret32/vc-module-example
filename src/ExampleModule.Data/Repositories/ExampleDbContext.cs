using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;

namespace ExampleModule.Data.Repositories
{
    public class ExampleDbContext : DbContextWithTriggers
    {
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options)
          : base(options)
        {
        }

        protected ExampleDbContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<MyModuleEntity>().ToTable("MyModule").HasKey(x => x.Id);
            // modelBuilder.Entity<MyModuleEntity>().Property(x => x.Id).HasMaxLength(128);
            // base.OnModelCreating(modelBuilder);
        }
    }
}

