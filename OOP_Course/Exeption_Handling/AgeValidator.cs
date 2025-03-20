using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Exeption_Handling
{
    class AgeValidator
    {
        public static void ValidateAge(int age)
        {
            if (age < 18 || age > 60)
            {
                throw new InvalidAgeException(age.ToString());
            }
            Console.WriteLine("Age is valid");
        }
    }
}
