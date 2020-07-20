using Microsoft.AspNetCore.Mvc;
using PaymentManagement.Controllers;
using PaymentManagement.Models;
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

        public void TestForMembership()
        {
            Payment payment = new Payment()
            {
                OwnerEmail = "test@gmail.com",
                PaymentType = "Membership",
                Amount = 1000
            };
            var createdResponse = _controller.Pay(payment);

            // Assert
            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }
    }
}
