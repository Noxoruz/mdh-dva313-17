using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentGateway.Models
{
    public enum PaymentMethod
    {
        Visa, Okapi
    }


    public class Transaction
    {
        public int ID { get; set; }
        public PaymentMethod? PaymentMethod { get; set; } // add enumeration later
        public double Fee { get; set; }
        public int UserId { get; set; }
        //public int WebShopId { get; set; }
        public int ProductId { get; set; }

        public virtual User User { get; set; }
        //public virtual WebShop WebShop { get; set; }
        public virtual Product Product { get; set; }
    }
}