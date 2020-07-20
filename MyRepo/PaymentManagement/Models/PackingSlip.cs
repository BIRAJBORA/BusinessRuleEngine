using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentManagement.Models
{
    public class PackingSlip
    {
        public int SlipId { get; set; }
        public Payment payment { get; set; }
        public string Status { get; set; }
        public string Target { get; set; }
        public string VideoUrl { get; set; }
    }
}
