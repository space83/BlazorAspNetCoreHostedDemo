using Microsoft.EntityFrameworkCore;
using BlazorAspNetCoreHostedDemo.Shared;
using BlazorAspNetCoreHostedDemo.Server.Authentication;
using System.Reflection;

namespace BlazorAspNetCoreHostedDemo.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        public DbSet<Product> Product { get; set; }

        public DbSet<UserAccount> UserAccount { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Mazda 3 MPS", Description = "The Mazdaspeed 3 is a sport compact hatchback introduced for the 2007 model year by Mazdaspeed and produced until 2013. The Mazdaspeed3 is a performance-enhanced version of the 5-door Mazda3. lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen", Pictures = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkzdAyIgacPSF3KGaUTMicrAxOkVozyC8-Hw&usqp=CAU", Price1 = 75888, Price2 = 85888 },
                new Product { Id = 2, Name = "Renault Megane RS 250 Cup", Description = "The Renault Mégane (French pronunciation: meɡan), also spelled without the acute accent as Megane,[1] especially in languages other than French, is a small family car produced by the French car manufacturer Renault for model year 1996, and was the successor to the Renault 19. lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen", Pictures = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWrOHHD-ATaYSkLdN6OxaVWQFWbdN_n-3MEw&usqp=CAU", Price1 = 69800, Price2 = 79800 },
                new Product { Id = 3, Name = "Volkswagen Golf GTI Mk6", Description = "lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen", Pictures = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRXbIRxw8xqxqHn0rvUx7EUsI_u4Mw2EmpZ-Q&usqp=CAU", Price1 = 71800, Price2 = 81800 }
                );

            modelBuilder.Entity<UserAccount>().HasData(
                new UserAccount { Id = 1, UserName = "admin", Password = "admin", Role = "Administrator", FirstName = "Admin", LastName = "System", Email = "admin@system.com", Gender = "", ContactNo = "", Country = "" },
                new UserAccount { Id = 2, UserName = "user", Password = "user", Role = "user", FirstName = "User", LastName = "System", Email = "user@system.com", Gender = "", ContactNo = "", Country = "" }
                );
        }


    }
}
