using System;

namespace OOP_Course.Notification_System
{
    internal class Customer : IObserver 
    {
        public string Name {  get; }
        public Customer(string name) 
        {
            Name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"{Name} : {message}");
        }
    }
}
