using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Store_CP
{
    interface IPaymentMethod
    {
        bool processPayment(double amount);

    }
}
