using ExampleProject.Back.Core.Domain;
using ExampleProject.Back.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ExampleProject.Back.Persistance.Context
{
    public class ExampleProjectContext:DbContext
    {
        public ExampleProjectContext(DbContextOptions<ExampleProjectContext> options):base(options)
        {

        }

        public DbSet<Product> Products => this.Set<Product>();
        public DbSet<Category> Categories => this.Set<Category>();

        public DbSet<AppUser> AppUsers => this.Set<AppUser>();

        public DbSet<AppRole> AppRole => this.Set<AppRole>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
