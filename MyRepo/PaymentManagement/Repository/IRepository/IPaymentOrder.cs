using PaymentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentManagement.Repository.IRepository
{
    public interface IPaymentOrder
    {
        List<PackingSlip> makePaymentOrder(Payment payment);

        Membership createNewMembership(Payment payment);

        Membership updateMembership(Payment payment);
    }
}
