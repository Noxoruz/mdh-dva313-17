using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentGateway.Models
{
    public class WebShop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        //public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}