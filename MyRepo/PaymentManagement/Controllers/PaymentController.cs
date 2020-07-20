using Microsoft.AspNetCore.Mvc;
using PaymentManagement.Models;
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

        [HttpPost("/Pay")]
        public IActionResult Pay([FromBody] Payment payment)
        {
            if (payment == null)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (payment.PaymentType.ToString() == "Membership")
                {
                    var result = _paymentOrder.createNewMembership(payment);
                    return Ok(result);
                }
                else if (payment.PaymentType.ToString() == "UpgradToMembership")
                {
                    var result = _paymentOrder.updateMembership(payment);
                    return Ok(result);
                }
                else
                {
                    var result = _paymentOrder.makePaymentOrder(payment);
                    return Ok(result);
                }
            }
        }
    }
}
