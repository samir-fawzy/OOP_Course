using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Flight_Booking_System
{
    internal class EconomyFight : Fight
    {
        public EconomyFight(string flightnumber, string destination, double price) : base(flightnumber, destination, price)
        {
        }

        protected override double CalculateFinalPrice(double price)
        {
            price -= price * 10 / 100;
            return price;
        }
    }
}
