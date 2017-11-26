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

        public IEnumerable<Product> GetAllProducts()
        {
            return null;
        }
    }
}
