using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentGateway.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public string Category { get; set; }
        public decimal Price { get; set; }
        public int WebShopId { get; set; }

        public virtual WebShop WebShop { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}