using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Data.Models;

namespace Assessment.Data{
    public class ApplicationDbContext : DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            optionBuilder.UseSqlServer("Server=localhost; Database=Ecomm; User id=sa; Password=Access@2023!; Encrypt=True; TrustServerCertificate=True");
        }
        public DbSet<User> Users {get; set; }
        public DbSet<Product> Products {get; set; }
        public DbSet<Order> Orders {get; set; }
        public DbSet<Shipment> Shipments {get; set; }
        public DbSet<Payment> Payments {get; set; }
        public DbSet<Cart> Carts {get; set; }
    }
}