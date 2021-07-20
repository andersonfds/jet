using Commerce.CrossCutting.Consts;
using Commerce.Data.Core.DbContexts;
using Commerce.Data.EntityMap;
using Commerce.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Data.DbContexts
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Entity> GetEntity<Entity>() where Entity : class
        {
            return Set<Entity>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(SystemConsts.DbConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
