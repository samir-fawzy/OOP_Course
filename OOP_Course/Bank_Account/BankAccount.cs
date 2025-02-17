using System;

namespace OOPCourse.Bank_Account
{
    internal class BankAccount
    {

        // Constructor
        public BankAccount(string name,int age,string address,int accountNumber,string phone)
        {
            Name = name;
            Age = age;
            Address = address;
            AccountNumber = accountNumber;
            Phone = phone;
        }

        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int AccountNumber { get; set; }
        public string Phone { get; set; }

        // Method to display customer account data
        public void DisplayAccountData()
        {
            Console.WriteLine("******************** Display Account Information ********************");
            Console.WriteLine($"Name           : {Name}");
            Console.WriteLine($"Age            : {Age}");
            Console.WriteLine($"Address        : {Address}");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Phone          : {Phone}");
        }

        // Method to modify data account
        public void ModifyData(string name, int age, string address, int accountNumber, string phone)
        {
            Name = name;
            Age = age;
            Address = address;
            AccountNumber = accountNumber;
            Phone = phone;
            Console.WriteLine("Data Modified Successfully");
        }
    }
}
