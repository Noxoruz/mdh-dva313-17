using PaymentGateway.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PaymentGateway.DAL
{
    public class PaymentGatewayContext : DbContext
    {
        public PaymentGatewayContext() : base("PaymentGatewayContext")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<WebShop> WebShops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}