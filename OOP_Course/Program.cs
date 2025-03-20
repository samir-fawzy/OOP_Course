using System;
using OOP_Course.Event_Management_Sytstem;
using OOP_Course.Linear_System_;
using System.Collections.Generic;
using OOP_Course.Beverage_System;
using OOP_Course.Flight_Booking_System;
using OOP_Course.Notification_System;
using OOP_Course.Payment_System;
using OOP_Course.Pizza_Customization_System;
using OOP_Course.Exeption_Handling;
using OOP_Course.Delegates;
using OOP_Course.Student_System;
using System.ComponentModel;
using System.Reflection;
using System.Security.Policy;
using System.Threading.Tasks;
using OOP_Course.MobilePhone;


namespace OOPCourse
{
    internal class Program
    {
        delegate void Operation(int a, int b);
        delegate bool AuthenticationDelegate(string username, string password);
        delegate void AuthenticationNotify(string message);
        static void Main(string[] args)
        {
            #region Implementaion

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

            #region Exeption Handling
            //try
            //{
            //    Console.Write("Enter your email: ");
            //    string email = Console.ReadLine();
            //    EmailValidator.ValidateEmail(email);
            //}
            //catch(InvalidMailExecption ex)
            //{
            //    Console.WriteLine("Error : " + ex.Message);
            //}

            //try
            //{
            //    Console.Write("Enter a positive number: ");
            //    double number = double.Parse(Console.ReadLine());
            //    PositiveNumberValidator.ValidatePositiveNumber(number);
            //}
            //catch(NotPositiveNumber ex)
            //{
            //    Console.WriteLine("Error : " + ex.Message);
            //}

            //try
            //{
            //    Console.Write("Enter your age: ");
            //    int age = int.Parse(Console.ReadLine());
            //    //AgeValidator.ValidateAge(age);
            //    if (age < 18 || age > 60)
            //    {
            //        throw new InvalidAgeException(age.ToString());
            //    }
            //    Console.WriteLine("Age is valid");
            //}
            //catch(InvalidAgeException ex)
            //{
            //    Console.WriteLine("Error : " + ex.Message);
            //}

            #endregion

            #region Delegate
            //Console.WriteLine("Enter choice: 1 - add , 2 - multiply ");
            //Console.Write("Choice: ");
            //string choice = Console.ReadLine();

            //Operation op;

            //if (choice == "1")
            //{
            //    op = Add;
            //}
            //else if (choice == "2")
            //{
            //    op = Multiply;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice");
            //    return;
            //}
            //op(10, 20);

            //string username = "admin";
            //string password = "admin";

            //AuthenticationDelegate auth = AuthenticationService.AuthenticateUser;
            //AuthenticationNotify notify = NotificatoinService.SendEmail;
            //notify += NotificatoinService.LogToFile;
            //if (auth(username, password))
            //{
            //    notify("User authenticated successfully");
            //}
            //else
            //{
            //    notify("User authentication failed");
            //}
            #endregion

            #region Student System
            //StudentTest.CreateStudent();

            //foreach (var student in StudentTest.Students)
            //{
            //    student.DisplayStudentInfo();
            //}
            //Console.WriteLine($"Total students : {Student.studentCount}");
            #endregion

            #region Mobile Phone
            //MobilePhone NokiaN95 = new MobilePhone("Nokia N95", "Nokia", "John Doe", 1000, new Battery { Model = "N95", IdleTime = 100, HoursTalk = 10, Type = BatteryType.LiIon }, new Screen { Size = "5", Colors = "256" });

            //MobilePhone OppoA9 = new MobilePhone("Oppo A9", "Oppo", "Ahmed", 2000, new Battery { Model = "A9", IdleTime = 200, HoursTalk = 20, Type = BatteryType.NiMH }, new Screen { Size = "6", Colors = "16M" });

            //Console.WriteLine(NokiaN95);
            //Console.WriteLine();
            //Console.WriteLine(OppoA9);
            #endregion
            #endregion


            Console.WriteLine("Press any key to exist");
            Console.ReadKey();
        }

        static void Add(int a,int b) => Console.WriteLine($"Result : {a + b}");
        static void Multiply(int a,int b) => Console.WriteLine($"Result : {a * b}");
    }

}
