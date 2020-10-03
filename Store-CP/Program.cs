using System;

namespace Store_CP
{
    class Program
    {
        static void Main(string[] args)
        {
            Order anOrder = new Order(1, "Headphones", 35.99);

            Console.WriteLine("*** O C P ***");
            Console.WriteLine();
            Console.WriteLine("  Select Methos of Payment");
            Console.WriteLine("  1- Cash");
            Console.WriteLine("  2- Credit Card");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {

                case 1:
                    anOrder.ProcessOrder(new CashPayment());
                    break;
                case 2:
                    anOrder.ProcessOrder(new VisaPayment());
                    break;
                default:
                    Console.WriteLine("Payment Method Not Accepted");
                    break;

            }
            ///anOrder.ProcessOrder(op);

            Console.ReadLine();
        }
    }
}
