using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Beverage_System
{
    internal class BeverageDecorator : IBeverage
    {
        protected IBeverage _beverage;
        public BeverageDecorator(IBeverage beverage) 
        {
            _beverage = beverage;
        }
        public virtual decimal GetCost()
        {
            return _beverage.GetCost();
        }

        public virtual string GetDescribtion()
        {
            return _beverage.GetDescribtion();
        }
    }
}
