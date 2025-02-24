using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Smart_Home_Control
{
    internal class SmartTV : SmartDivices
    {
        public SmartTV(string name) : base(name)
        {
            
        }

        public override void Operate()
        {
            Console.WriteLine($"{Name} is running now.");
        }
    }
}
