using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Payment_System
{
    internal interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
