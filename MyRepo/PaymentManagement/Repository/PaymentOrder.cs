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
            /*
            * Data can be store in SQL/or any databases and can use EF easily to fetch
            * Here we are using static data with simple list
           */
            DateTime baseDate = new DateTime();
            var membership = new Membership()
            {
                MembershipId = 1,
                Owner = payment.OwnerEmail,
                Product = "New Product",/* We can maintain product list from the company*/
                ExpiraryDate = baseDate.AddYears(5)
            };
            return membership;
        }

        public List<PackingSlip> makePaymentOrder(Payment payment)
        {
            /*
            * Simple logic to implement different payment type
           */
            var paymentType = payment.PaymentType;
            switch (paymentType)
            {
                case "PhysicalProduct":
                    var payslipsForProd = new List<PackingSlip>() {
                    new PackingSlip(){ SlipId = 1, payment = payment, Status = "Payment Completed",Target = "General"}
                    };
                    return payslipsForProd;

                case "Book":
                    var payslipsForBooks = new List<PackingSlip>() {
                    new PackingSlip(){ SlipId = 1, payment = payment, Status = "Payment Completed",Target = "General"},
                    new PackingSlip(){ SlipId = 1, payment = payment, Status = "Payment Completed",Target = "RoyallityDepartment"},
                    };
                    return payslipsForBooks;

                case "Video":

                    if (payment.Video == "Learning To Ski")
                    {
                        var payslipsForVideoSpecial = new List<PackingSlip>() {
                    new PackingSlip(){ SlipId = 1, payment = payment, Status = "Payment Completed",Target = "General", VideoUrl = "Free Fist Aid Video"}
                    };
                        return payslipsForVideoSpecial;
                    }
                    else
                    {
                        var payslipsForVideoGeneral = new List<PackingSlip>() {
                    new PackingSlip(){ SlipId = 1, payment = payment, Status = "Payment Completed",Target = "General"}
                    };
                        return payslipsForVideoGeneral;
                    }


                default:

                    var payslips_ = new List<PackingSlip>() {
                    new PackingSlip(){ SlipId = 0, payment = payment, Status = "",Target = ""}
                    };
                    return payslips_;
            }
        }

        /*
           * Data logic can be relaced with any real time data base
        */

        public Membership updateMembership(Payment payment)
        {
            List<Membership> members = new List<Membership>()
            {
                new Membership(){MembershipId = 1, Owner = "", ExpiraryDate = DateTime.Now, Product ="Test Product"},
                new Membership(){MembershipId = 2, Owner = "", ExpiraryDate = DateTime.Now, Product ="Test Product "}
            };
            var membership = members.Find(p => p.Owner == payment.OwnerEmail);
            if (membership != null)
            {
                return membership;
            }
            else
            {
                return new Membership()
                {
                    MembershipId = 0,
                    Owner = "",
                    ExpiraryDate = DateTime.Now,
                    Product = ""
                };
            }
        }
    }
}
