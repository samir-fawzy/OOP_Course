using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Pizza_Customization_System
{
    internal class PepperoniDecorator : PizzaDecorator
    {
        public PepperoniDecorator(IPizza _pizza) : base(_pizza)
        {
        }

        public override decimal GetCost()
        {
            return _pizza.GetCost() + 2.00m;
        }
        public override string GetDescription()
        {
            return _pizza.GetDescription() + ",Pepperoni";
        }
    }
}
