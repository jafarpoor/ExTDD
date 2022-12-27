using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{


    public interface IProductService
    {
        int GetProductPrice(int Id);
        void GetProductPrice(int Id ,out int Price);
        int ProductCount { get; set; }
        Product AddProduct(Product product);
    }
}
