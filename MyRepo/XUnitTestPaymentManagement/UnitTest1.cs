using PaymentManagement.Controllers;
using PaymentManagement.Repository.IRepository;
using System;
using Xunit;

namespace XUnitTestPaymentManagement
{
    public class UnitTest1
    {
        PaymentController _controller;
        IPaymentOrder _service;
        public UnitTest1()
        {
            _service = new FakePaymentOrder();
            _controller = new PaymentController(_service);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
