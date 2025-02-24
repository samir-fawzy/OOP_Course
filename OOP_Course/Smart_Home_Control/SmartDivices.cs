using System;

namespace OOP_Course.Smart_Home_Control
{
    internal class SmartDivices
    {
        /*
         * properties {Name , isOn }
         * Function : print (operating nameMachine)
         */
        public string Name {  get; set; }
        public bool IsOn { get;private set; }
        public SmartDivices(string name) 
        {
            Name = name;
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} is now ON.");
        }

        public void TurnOff() 
        {
            IsOn=false;
            Console.WriteLine($"{Name} is now OFF.");
        }

        public virtual void Operate()
        {
            Console.WriteLine($"Operating {Name}...");
        }
    }
}
