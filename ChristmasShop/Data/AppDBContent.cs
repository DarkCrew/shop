using ChristmasShop.Data.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ChristmasShop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        //public DbSet<Car> Car {get;set;}
        //public DbSet<Category> Category { get; set; }
        public DbSet<Tree> Tree { get; set; }
        public DbSet<CategoryTree> CategoryTree { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            var salt = new byte[64 / 8];
            rng.GetBytes(salt);
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: "123456",
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 128 / 8));


            modelBuilder.Entity<Role>().HasData(new Role[] { new Role { ID = 1, Name = "admin" }, new Role { ID = 2, Name = "user" } });
            modelBuilder.Entity<User>().HasData(new User[] { new User { ID = 1, Email = "admin", Password = hashed, RoleId = 1, Unblocked = true, salt = salt } });
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            base.OnModelCreating(modelBuilder);
        }
    }
}
