using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication21.Models;

namespace WebApplication21.Pages
{
    public class ProductModel : PageModel
    {
        public Product product { get; set; }
        public List<Product> products { set; get; }
        public void OnGet()
        {
            product = new Product();
            products = new List<Product>() {
            new Product { Id = 1, Title = "Product1", Amount = 123 },
            new Product { Id = 2, Title = "Product2", Amount = 321 },
            new Product { Id = 3, Title = "Product3", Amount = 222 }
            };
        }
    }
}
