using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Beverage_System
{
    internal class Tea : IBeverage
    {
        public decimal GetCost()
        {
            return 4.00m;
        }

        public string GetDescribtion()
        {
            return "Tea";
        }
    }
}
