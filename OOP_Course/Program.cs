using System;
using OOP_Course.Event_Management_Sytstem;
using OOP_Course.Linear_System_;
using System.Collections.Generic;
using OOP_Course.Beverage_System;
using OOP_Course.Flight_Booking_System;
using OOP_Course.Notification_System;
using OOP_Course.Payment_System;
using OOP_Course.Pizza_Customization_System;


namespace OOPCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Flight Booking System
            //Fight f = new Fight("1", "2", 100);
            //f.Main01();

            //EconomyFight f2 = new EconomyFight("2", "3", 100);
            //f2.Main01();

            //BusinessFight f3 = new BusinessFight("3", "4", 100);
            //f3.Main01();
            #endregion

            #region Payment System
            //ShoppingCart cart = new ShoppingCart();
            //cart.TotalAmount = 1000;

            //cart.SetPaymentMethod(new CreditCardPayment());
            //cart.Checkout();

            //cart.SetPaymentMethod(new PaypalPayment());
            //cart.Checkout();

            //cart.SetPaymentMethod(new BitCoinPayment());
            //cart.Checkout();
            #endregion

            #region Notification System
            //Customer c1 = new Customer("samir");
            //Customer c2 = new Customer("ahmed");
            //Customer c3 = new Customer("nada");

            //Order o = new Order();

            //o.Attach(c1);
            //o.Attach(c2);
            //o.Attach(c3);

            //o.Detach(c2);

            //o.Notify("Welcome");
            #endregion

            #region Beverage System
            //IBeverage mycoffe = new Coffe();
            //Console.WriteLine($"{mycoffe.GetCost()} - {mycoffe.GetDescribtion()}");

            //mycoffe = new MilkDecorator(mycoffe);
            //Console.WriteLine($"{mycoffe.GetCost()} - {mycoffe.GetDescribtion()}");

            //mycoffe = new SugarDecorator(mycoffe);
            //Console.WriteLine($"{mycoffe.GetCost()} - {mycoffe.GetDescribtion()}");

            //IBeverage mytea = new Tea();
            //Console.WriteLine($"{mytea.GetCost()} - {mytea.GetDescribtion()}");

            //mytea = new CaramelDecorator(mytea);
            //Console.WriteLine($"{mytea.GetCost()} - {mytea.GetDescribtion()}");

            //mytea = new WhippedCreamDecorator(mytea);
            //Console.WriteLine($"{mytea.GetCost()} - {mytea.GetDescribtion()}");
            #endregion

            #region Pizze Customiztion System
            //IPizza mypizza = new MargheritaPizza();
            //Console.WriteLine($"{mypizza.GetCost()} - {mypizza.GetDescription()}");

            //mypizza = new CheeseDecorator(mypizza);
            //Console.WriteLine($"{mypizza.GetCost()} - {mypizza.GetDescription()}");

            //mypizza = new OlivesDecorator(mypizza);
            //Console.WriteLine($"{mypizza.GetCost()} - {mypizza.GetDescription()}");

            //mypizza = new PepperoniDecorator(mypizza);
            //Console.WriteLine($"{mypizza.GetCost()} - {mypizza.GetDescription()}");
            #endregion

            Console.WriteLine("Press any key to exist");
            Console.ReadKey();
        }

    }
}
