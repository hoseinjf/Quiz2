using Microsoft.EntityFrameworkCore;
using Quiz2.Config;
using Quiz2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .HasMany(x => x.TransactionsAsSource)
                .WithOne(x => x.SourceCard)
                .HasForeignKey(x => x.SourceCardId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Card>()
                .HasMany(x => x.TransactionsAsDestination)
                .WithOne(x => x.DestinationCard)
                .HasForeignKey(x => x.DestinationCardId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Card>().HasData
                (
                    new Card
                    {
                        Id = 1,
                        CardNumber = "1234567891012345",
                        HolderName = "hasan",
                        Password = "123",
                        Balance = 100,
                        IsActive = true
                    },
                    new Card
                    {
                        Id = 2,
                        CardNumber = "1234567891012346",
                        HolderName = "ali",
                        Password = "123",
                        Balance = 200,
                        IsActive = true
                    }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
