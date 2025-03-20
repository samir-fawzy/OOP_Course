using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course
{
    class NotPositiveNumber : Exception
    {
        public NotPositiveNumber(string number) : base($"number is not positve {number}"){ }
    }
}
