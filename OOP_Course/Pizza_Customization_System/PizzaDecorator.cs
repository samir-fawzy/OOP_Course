using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Pizza_Customization_System
{
    internal class PizzaDecorator : IPizza
    {
        protected IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual decimal GetCost()
        {
            return _pizza.GetCost();
        }
        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}
