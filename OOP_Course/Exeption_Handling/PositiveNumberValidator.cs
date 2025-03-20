using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Exeption_Handling
{
    class PositiveNumberValidator
    {
        public static void ValidatePositiveNumber(double number)
        {
            if (number <= 0)
                throw new NotPositiveNumber(number.ToString());
            Console.WriteLine("Number is positive");
        }
    }
}
