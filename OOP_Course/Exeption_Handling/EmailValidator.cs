using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course
{
    class EmailValidator
    {
        public static void ValidateEmail(string email)
        {
            if (!email.Contains('@')||!email.Contains('.'))
                throw new InvalidMailExecption(email);
            Console.WriteLine("Email is valid");
        }
    }
}
