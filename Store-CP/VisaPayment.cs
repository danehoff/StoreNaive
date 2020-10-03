using System;
using System.Collections.Generic;
using System.Text;

namespace Store_CP
{
    class VisaPayment : IPaymentMethod
    {
        bool IPaymentMethod.processPayment(double amount)
        {
            Console.WriteLine("Processing payment with Credit Card (Naive)");

            return true;
        }
    }
}
