using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Beverage_System
{
    internal class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage) { }

        public override decimal GetCost()
        {
            return _beverage.GetCost() + 2.00m;
        }

        public override string GetDescribtion() 
        {
            return _beverage.GetDescribtion() + ",Milk";
        }

    }


}
