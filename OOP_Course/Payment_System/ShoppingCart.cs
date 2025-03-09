using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Payment_System
{
    internal class ShoppingCart
    {
        public decimal TotalAmount {  get; set; }
        private IPaymentStrategy _strategy;
        public void SetPaymentMethod(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Checkout()
        {

            _strategy.ProcessPayment(TotalAmount);
        }
    }
}
