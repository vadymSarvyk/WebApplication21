using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication21.Interfaces;

namespace WebApplication21.Models
{
    public class Repository : IRepository
    {
        List<Product> products = null;
        public Repository()
        {
            /*product = new Product();
           products = new List<Product>() {
           new Product { Id = 1, Title = "Product1", Amount = 123 },
           new Product { Id = 2, Title = "Product2", Amount = 321 },
           new Product { Id = 3, Title = "Product3", Amount = 222 }
           };*/
            products = new List<Product>() { new Product { Id=1, Title="product1", Amount=111 }, new Product { Id = 2, Title = "product2", Amount = 112 } }
        }
        public void Add(Product product)
        {
           products.Add(product);
        }

        public void Delete(int? id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            if (product != null)
                products.Remove(product);

        }

        public Product Details(int? id)
        {
            return  products.FirstOrDefault(x => x.Id == id);
        }

        public void Edit(Product product)
        {
            Product edited = products.FirstOrDefault(x => x.Id == product.Id);
            if (edited != null)
                edited = product;
        }

        public List<Product> ShowAll()
        {
            return products;
        }
    }
}
