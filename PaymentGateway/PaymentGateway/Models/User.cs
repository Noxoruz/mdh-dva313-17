using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaymentGateway.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Role { get; set; }

        [Range(typeof(decimal), "0", "99999999.99")]
        public decimal Balance { get; set; }
        
        public DateTime RegistrationDate { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}