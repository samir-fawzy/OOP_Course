using System;

namespace OOPCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bank Account
            /*
            Bank_Account.BankAccount customer1 = new Bank_Account.BankAccount("Samir Fawzy",21,"Shebin",1,"0123456789");

            customer1.DisplayAccountData();
            Console.WriteLine("***************************************");

            customer1.ModifyData("ahmed fawzy", 31, "Cairo", 2, "24879287");
            Console.WriteLine("***************************************");

            customer1.DisplayAccountData();
            Console.WriteLine("End Programe");
            */

            // Exeption Handling
            Exeption_Handle.Exception_Handling eh = new Exeption_Handle.Exception_Handling();
            eh.PrintDivid(10, 0);
            eh.Arr();

            Console.ReadKey();
        }
    }
}
