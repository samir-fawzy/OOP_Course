using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Flight_Booking_System
{
    internal class BusinessFight : Fight
    {
        public BusinessFight(string flightnumber, string destination, double price) : base(flightnumber, destination, price)
        {
        }

        protected override double CalculateFinalPrice(double price)
        {
            price += price * 30 / 100;
            return price;
        }
    }
}
