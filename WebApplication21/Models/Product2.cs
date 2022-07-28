using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication21.Interfaces;

namespace WebApplication21.Models
{
    public class Product2:IProduct
    {
        public int Id { get; set; } = 222;
        public int Amount { get; set; } = 2222;
        public string Title { get; set; } = "Product2";
        public int Sale { get; set; } = 12;
    }
}
