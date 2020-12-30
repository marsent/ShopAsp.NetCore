using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAsp.NetCore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Cart>().ToTable("Carts");
            modelBuilder.Entity<Bill>().ToTable("Bills");
            modelBuilder.Entity<BillDetail>().ToTable("BillDetails");

            modelBuilder.Entity<Cart>()
                .HasOne(u => u.Users)
                .WithMany(c => c.Carts)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Cart>()
               .HasOne(p => p.Products)
               .WithMany(c => c.Carts)
               .HasForeignKey(c => c.ProductId)
               .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Bill>()
                .HasOne(u => u.User)
                .WithMany(b => b.Bills)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BillDetail>()
                .HasOne(b => b.Bills)
                .WithMany(bd => bd.BillDetails)
                .HasForeignKey(bd => bd.BillId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BillDetail>()
                .HasOne(p => p.Products)
                .WithMany(bd => bd.BillDetails)
                .HasForeignKey(bd => bd.ProductId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
