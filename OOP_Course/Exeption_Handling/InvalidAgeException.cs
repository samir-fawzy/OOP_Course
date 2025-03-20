using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Exeption_Handling
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string age) : base($"Invalid age {age}") { }
    }
}
