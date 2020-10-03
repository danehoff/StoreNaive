using System;
using System.Collections.Generic;
using System.Text;

namespace Store_CP
{
    class CashPayment : IPaymentMethod
    {
        bool IPaymentMethod.processPayment(double amount)
        {
            Console.WriteLine("Processing payment with Cash (OCP)");
            return true;
        }
    }
}
