using Microsoft.EntityFrameworkCore;
using InnoGotchi.DAL.Entities;

namespace InnoGotchi.DAL.EF
{
    public class InnoGotchiDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public InnoGotchiDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
