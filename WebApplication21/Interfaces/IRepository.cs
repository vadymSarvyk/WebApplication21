using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication21.Models;

namespace WebApplication21.Interfaces
{
   public interface IRepository
    {
        List<Product> ShowAll();
        Product Details(int? id);
        void Edit(Product product);
        void Delete(int? id);
        void Add(Product product);
    }
}
