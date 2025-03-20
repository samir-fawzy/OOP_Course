using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Delegates
{
    class AuthenticationService
    {
        public static bool AuthenticateUser(string username, string password)
        {
            return username == "admin" && password == "admin";
        }
    }
}
