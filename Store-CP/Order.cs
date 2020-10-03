using System;
using System.Collections.Generic;
using System.Text;

namespace Store_CP
{
    class Order
    {

        private int id;
        private String item;
        private double amount;
        private bool paid;

        public Order(int id, String item, double amount)
        {
            this.id = id;
            this.item = item;
            this.amount = amount;
            paid = false;
        }

        public void ProcessOrder(IPaymentMethod pm)
        {
            // 1- Get founds from payment method
            bool success = pm.processPayment(amount);

            //2- If enough founds, mark order as paid
            paid = success;

        }

    }
}
