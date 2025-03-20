using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Delegates
{
    class NotificatoinService
    {
        public static void SendEmail(string message)
        {
            Console.WriteLine("Email Sent : " + message);
        }

        public static void LogToFile(string message)
        {
            Console.WriteLine("Log Saved : " + message);
        }
    }
}
