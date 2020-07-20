using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentManagement.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string Owner { get; set; }
        public string Product { get; set; }
        public DateTime ExpiraryDate { get; set; }
    }
}
