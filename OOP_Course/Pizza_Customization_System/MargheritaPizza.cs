using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Pizza_Customization_System
{
    internal class MargheritaPizza : IPizza
    {
        public decimal GetCost()
        {
            return 8.00m;
        }
        public string GetDescription()
        {
            return "Margherita Pizza";
        }
    }
}
