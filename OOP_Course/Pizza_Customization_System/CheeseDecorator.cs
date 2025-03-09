using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Pizza_Customization_System
{
    internal class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza _pizza) : base(_pizza)
        {
        }

        public override decimal GetCost()
        {
            return _pizza.GetCost() + 1.50m;
        }
        public override string GetDescription()
        {
            return _pizza.GetDescription() + ",Cheese";
        }
    }
}
