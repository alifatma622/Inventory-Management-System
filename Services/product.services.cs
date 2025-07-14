using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Services
{
    class ProductService
    {
        InventoryDbContext context;
        public ProductService()
        {
            context = new InventoryDbContext();
        }
        public Product getProductByID(int id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }
       
        public Product getProductByName(string name)
        {
            return context.Products.FirstOrDefault(x => x.Name == name);
        }
        public List<Product> getAllProducts()
        {
            return context.Products.ToList();
        }
        public void addProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void updateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
        public void deleteProduct(Product product)
        {
            var productToRemove = context.Products.Find(product.Id);
            if (productToRemove != null)
            {
                context.Products.Remove(productToRemove);
                context.SaveChanges();
            }
        }
    }
}
