using PaymentManagement.Models;
using PaymentManagement.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestPaymentManagement
{
    public class FakePaymentOrder : IPaymentOrder
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
