using BlazorAspNetCoreHostedDemo.Client.Pages;
using BlazorAspNetCoreHostedDemo.Server.Data;
using BlazorAspNetCoreHostedDemo.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorAspNetCoreHostedDemo.Server
{
    public class ProductService 
    {
        private readonly DataContext _context;

        public ProductService(DataContext context) 
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Product.ToList();
        }

        public Product GetProduct(int Id)
        {
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

        public void UpdateProduct(Product product)
        {
            _context.Product.Add(product);
            _context.Product.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }


    }
}
