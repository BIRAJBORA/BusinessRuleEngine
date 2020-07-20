using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentManagement.Models
{
    public enum PaymentType
    {
        PhysicalProduct = 1,
        Book = 2,
        Membership = 3,
        UpgradToMembership = 4,
        Video = 5

    }
    public class Payment
    {
        public string OwnerEmail { get; set; }
        public PaymentType PaymentType { get; set; }
        public Double Amount { get; set; }
        public string Video { get; set; }
    }
}
