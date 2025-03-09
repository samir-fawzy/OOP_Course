using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Beverage_System
{
    internal class SugarDecorator : BeverageDecorator
    {
        public SugarDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override decimal GetCost()
        {
            return _beverage.GetCost() + 1.00m;
        }

        public override string GetDescribtion()
        {
            return _beverage.GetDescribtion() +  ",Suger";
        }
    }
}
