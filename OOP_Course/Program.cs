using OOP_Course.Smart_Home_Control;
using System;

namespace OOPCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartAC myAC = new SmartAC("Smart AC");
            myAC.TurnOn();
            myAC.SetTemperature(25);
            myAC.Operate();
            myAC.TurnOff();

            Console.WriteLine("==========================");

            SmartTV myTV = new SmartTV("Smart TV");
            myTV.TurnOn();
            myTV.Operate();
            myTV.TurnOff();

            Console.WriteLine("==========================");

            SmartLight myLight = new SmartLight("Smart Light");
            myLight.TurnOn();
            myLight.Operate();
            myLight.TurnOff();


            Console.ReadKey();
        }
    }
}
