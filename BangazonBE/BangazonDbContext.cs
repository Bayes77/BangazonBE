using Microsoft.EntityFrameworkCore;
using BangazonBE.Models.cs;
using BangazonBE;


namespace BangazonBE
{
    public class BangazonDbContext : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }

        public BangazonDbContext(DbContextOptions<BangazonDbContext> context) : base(context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Orders>().HasData(new Orders[]
            {
                new Orders { Id = 1, CustomerId = 1, PaymentType = "creditCard", ProductId = 1, SellerId =1, Sold = true, TotalPrice = 100 },

            });

            modelBuilder.Entity<Seller>().HasData(new Seller[]
            {
                new Seller { Id = 1, Name = "John Doe", Address = "123 Main St", Email = "123test.com", ProductId = 1, StoreName = "John's Store" },


            });

            modelBuilder.Entity<Products>().HasData(new Products[]
            {
                new Products { Id = 1, Name = "Shoes", Price = 100, Description = "Shoes for sale", Quantity = 1, SellerId = 1, Cataegory = "clothing" },
            });

            modelBuilder.Entity<Customer>().HasData(new Customer[]
            {
                new Customer { Id = 1, Name = "Jane Doe", Address = "123 Main St", Email = "123test.com" },
            });

            modelBuilder.Entity<Users>().HasData(new Users[]
            {
                new Users { Id = 1, Name = "JohnDoe", Address = "123test ", Email = "123test@gmail.com"},
            });
        }
    }
}
