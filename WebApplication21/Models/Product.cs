using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication21.Interfaces;

namespace WebApplication21.Models
{
    public class Product : IProduct
    {
        public int Id { get; set; } = 111;
        public int Amount { get; set; } = 111;
        public string Title { get; set; } = "Product";
    }
}
