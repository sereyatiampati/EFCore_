// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Data.Models;

// namespace EcomApp
// {
//     public class CommerceContext : DbContext
//     {
//         public DbSet<User> Users { get; set; }
//         public DbSet<Cart> Carts { get; set; }

//         public DbSet<Order> Orders { get; set; }

//         public DbSet<Payment> Payments { get; set; }

//         public DbSet<Product> Products { get; set; }

//         public DbSet<Shipment> Shipment { get; set; }

//          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         optionsBuilder.UseSqlServer("Server=localhost; Database=PubDatabase; User Id=sa; Password=Access@2023; Encrypt=False; TrustServerCertificate=True");
//     }
//     }
// }