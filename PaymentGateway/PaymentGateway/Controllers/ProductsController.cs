using PaymentGateway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PaymentGateway.Controllers
{
    public class ProductsController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1},
            new Product { Id = 1, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
            new Product { Id = 1, Name = "Hammer", Category = "Hardware", Price = 16.99M}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    }
}
