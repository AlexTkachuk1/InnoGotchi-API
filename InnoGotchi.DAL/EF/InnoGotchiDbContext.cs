﻿using Microsoft.EntityFrameworkCore;
using InnoGotchi.DAL.Entities;

namespace InnoGotchi.DAL.EF
{
    public class InnoGotchiDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Body> Bodys { get; set; }

        public InnoGotchiDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>()
                .HasOne(x => x.Body)
                .WithOne(x => x.Owner)
                .HasForeignKey<Body>(p => p.PetId);
            modelBuilder.Entity<Farm>()
                .HasMany(x => x.Pets)
                .WithOne(x => x.Farm);
            modelBuilder.Entity<User>()
                .HasMany(x => x.Farms)
                .WithMany(x => x.Users);

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
