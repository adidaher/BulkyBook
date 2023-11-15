using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.DataAccess.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

     /*   protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Category { Id = 1, Name="Action", DisplayOrder=1},
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 });

            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Title = "Fortune of Time",
                   Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                   ISBN = "SWD9999001",
                   Author = "Billy Spark",
                   ListPrice = 99,
                   Price = 90,
                   Price50 = 85,
                   Price100 = 80,
                   CategoryId = 1,
               },
               new Product
               {
                   Id = 2,
                   Title = "Dark Skies",
                   Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                   ISBN = "CAW777777701",
                   Author = "Nancy Hoover",
                   ListPrice = 40,
                   Price = 30,
                   Price50 = 25,
                   Price100 = 20,
                   CategoryId = 2,
               },
               new Product
               {
                   Id = 3,
                   Title = "Vanish in the Sunset",
                   Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                   ISBN = "RITO5555501",
                   Author = "Julian Button",
                   ListPrice = 55,
                   Price = 50,
                   Price50 = 40,
                   Price100 = 35,
                   CategoryId = 3,
               },
               new Product
               {
                   Id = 4,
                   Title = "Cotton Candy",
                   Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                   ISBN = "WS3333333301",
                   Author = "Abby Muscles",
                   ListPrice = 70,
                   Price = 65,
                   Price50 = 60,
                   Price100 = 55,
                   CategoryId = 3,
               },
               new Product
               {
                   Id = 5,
                   Title = "Rock in the Ocean",
                   Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                   ISBN = "SOTJ1111111101",
                   Author = "Ron Parker",
                   ListPrice = 30,
                   Price = 27,
                   Price50 = 25,
                   Price100 = 20,
                   CategoryId = 3,
               },
               new Product
               {
                   Id = 6,
                   Title = "Leaves and Wonders",
                   Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                   ISBN = "FOT000000001",
                   Author = "Laura Phantom",
                   ListPrice = 25,
                   Price = 23,
                   Price50 = 22,
                   Price100 = 20,
                   CategoryId = 3,
               }
               );
        }*/
    }
}
