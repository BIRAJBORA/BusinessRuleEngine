using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentManagement.Models
{
    public class Payment
    {
        public string OwnerEmail { get; set; }
        public string PaymentType { get; set; }
        public Double Amount { get; set; }
        public string Video { get; set; }
    }
}
