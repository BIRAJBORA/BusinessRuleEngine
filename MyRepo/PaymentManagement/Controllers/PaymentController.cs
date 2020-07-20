using Microsoft.AspNetCore.Mvc;
using PaymentManagement.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentManagement.Controllers
{
    public class PaymentController : ControllerBase
    {
        private IPaymentOrder _paymentOrder;

        public PaymentController(IPaymentOrder paymentOrder)
        {
            _paymentOrder = paymentOrder;
        }
    }
}
