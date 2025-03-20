using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course
{
    class InvalidMailExecption : Exception
    {
        public InvalidMailExecption(string email) : base($"Invalid email format {email}")
        { }
    }
}
