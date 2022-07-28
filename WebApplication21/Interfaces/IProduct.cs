using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication21.Interfaces
{
   public interface IProduct
    {
         int Id { get; set; }
         int Amount { get; set; }
         string Title { get; set; }
    }
}
