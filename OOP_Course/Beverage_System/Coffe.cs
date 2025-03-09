using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Beverage_System
{
    internal class Coffe : IBeverage
    {
        public decimal GetCost()
        {
            return 5.00m;
        }

        public string GetDescribtion()
        {
            return "Basic Coffe";
        }
    }
}
