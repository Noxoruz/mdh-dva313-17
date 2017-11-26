using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PaymentGateway.DAL
{
    public class PaymentGatewayInitializer : DropCreateDatabaseIfModelChanges<PaymentGatewayContext>
    {
        protected override void Seed(PaymentGatewayContext context)
        {
            base.Seed(context);
        }
    }
}