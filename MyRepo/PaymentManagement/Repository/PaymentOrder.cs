using PaymentManagement.Models;
using PaymentManagement.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentManagement.Repository
{
    public class PaymentOrder : IPaymentOrder
    {
        public Membership createNewMembership(Payment payment)
        {
            throw new NotImplementedException();
        }

        public List<PackingSlip> makePaymentOrder(Payment payment)
        {
            throw new NotImplementedException();
        }

        public Membership updateMembership(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
