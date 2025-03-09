using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Beverage_System
{
    internal class WhippedCreamDecorator : BeverageDecorator
    {
        public WhippedCreamDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override decimal GetCost()
        {
            return _beverage.GetCost() + 2.00m;
        }

        public override string GetDescribtion()
        {
            return _beverage.GetDescribtion() + ",Whipped Cream";
        }
    }
}
