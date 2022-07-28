using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication21.Interfaces;
using WebApplication21.Models;

namespace WebApplication21.Pages
{
    public class ProductModel : PageModel
    {
        IRepository repository = null;
        public List<Product> products { set; get; }
        public ProductModel(IRepository repository)
        {
            this.repository = repository;
        }
        public void OnGet()
        {
            products = repository.ShowAll();
           
        }
    }
}
