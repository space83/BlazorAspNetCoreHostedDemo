using BlazorAspNetCoreHostedDemo.Client.Pages;
using BlazorAspNetCoreHostedDemo.Server.Data;
using BlazorAspNetCoreHostedDemo.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorAspNetCoreHostedDemo.Server
{
    public class ProductService 
    {
        private readonly DataContext _context;
        //private List<Product> _products;

        public ProductService(DataContext context) 
        {
            _context = context;
            //_products = new List<Product>
            //{
            //    new Product { Id = 1, Name = "Mazda 3 MPS", Description = "The Mazdaspeed 3 is a sport compact hatchback introduced for the 2007 model year by Mazdaspeed and produced until 2013. The Mazdaspeed3 is a performance-enhanced version of the 5-door Mazda3. lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen", Pictures="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkzdAyIgacPSF3KGaUTMicrAxOkVozyC8-Hw&usqp=CAU", Price1=75888, Price2=85888 },
            //    new Product { Id = 2, Name = "Renault Megane RS 250 Cup", Description = "The Renault Mégane (French pronunciation: meɡan), also spelled without the acute accent as Megane,[1] especially in languages other than French, is a small family car produced by the French car manufacturer Renault for model year 1996, and was the successor to the Renault 19. lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen", Pictures="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWrOHHD-ATaYSkLdN6OxaVWQFWbdN_n-3MEw&usqp=CAU", Price1=69800, Price2=79800 },
            //    new Product { Id = 3, Name = "Volkswagen Golf GTI Mk6", Description = "lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen", Pictures="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRXbIRxw8xqxqHn0rvUx7EUsI_u4Mw2EmpZ-Q&usqp=CAU", Price1=71800, Price2=81800 }
            //};
        }

        public List<Product> GetProducts()
        {
            //return _products;
            return _context.Product.ToList();
        }

        public Product GetProduct(int Id)
        {
            //return _products.Where(a => a.Id == Id).Single();
            return _context.Product.Where(a => a.Id == Id).Single();
        }

        public void AddProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = new Product { Id = productId };
            _context.Product.Entry(product).State = EntityState.Deleted;
            _context.SaveChanges();
        }


    }
}
