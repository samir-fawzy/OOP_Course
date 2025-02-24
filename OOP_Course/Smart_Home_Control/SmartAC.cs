using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Smart_Home_Control
{
    internal class SmartAC : SmartDivices
    {
        public SmartAC(string name) : base (name)
        {
            
        }
        public int Temperature { get; set; }
        public void SetTemperature(int temp)
        {
            if (temp >= 16 && temp <= 30)
            {
                Temperature = temp;
                Console.WriteLine($"{Name} temperature set to {Temperature}°C.");
            }
            else
            {
                Console.WriteLine("Invalid input tempurature");
            }
        }

        public override void Operate()
        {
            if (Temperature >= 16 && Temperature <= 30)
                Console.WriteLine($"{Name} is running at {Temperature}°C");
        }
    }
}
