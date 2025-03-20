using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.MobilePhone
{
    class MobilePhone
    {
        public string Model        { get;  set; }
        public string Manufacturer { get;  set; }
        public string Owner        { get;  set; }
        public double Price        { get;  set; }
        public IBattery BatteryInfo { get;  set; }
        public IScreen ScreenInfo { get; set; }


        public MobilePhone(string model, string manufacturer, string owner, double price, IBattery batteryInfo, IScreen screenInfo)
        {
            Model = model;
            Manufacturer = manufacturer;
            Owner = owner;
            Price = price;
            BatteryInfo = batteryInfo;
            ScreenInfo = screenInfo;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Manufacturer: {Manufacturer}, Owner: {Owner}, Price: {Price}\n" +
                   $"Battery: {BatteryInfo.Model}, Type: {BatteryInfo.Type}, Idle Time: {BatteryInfo.IdleTime}h, Talk Time: {BatteryInfo.HoursTalk}h\n" +
                   $"Screen Size: {ScreenInfo.Size}, Colors: {ScreenInfo.Colors}";
        }


        //public static MobilePhone NokiaN95 = new MobilePhone
        //{
        //    Model = "Nokia N95",
        //    Manufacturer = "Nokia",
        //    Owner = "John Doe",
        //    Price = 1000,
        //    BatteryInfo = new Battery
        //    {
        //        Model = "N95",
        //        IdleTime = 100,
        //        HoursTalk = 10,
        //        Type = BatteryType.LiIon
        //    },
        //    ScreenInfo = new Screen
        //    {
        //        Size = "5",
        //        Colors = "256"
        //    }
        //};

        //public static void DisplayPhoneInfo()
        //{
        //    Console.WriteLine($"Model : {NokiaN95.Model}");
        //    Console.WriteLine($"Manufacturer : {NokiaN95.Manufacturer}");
        //    Console.WriteLine($"Owner : {NokiaN95.Owner}");
        //    Console.WriteLine($"Price : {NokiaN95.Price}");
        //    Console.WriteLine($"Battery Model : {NokiaN95.BatteryInfo.Model}");
        //    Console.WriteLine($"Battery Idle Time : {NokiaN95.BatteryInfo.IdleTime}");
        //    Console.WriteLine($"Battery Hours Talk : {NokiaN95.BatteryInfo.HoursTalk}");
        //    Console.WriteLine($"Battery Type : {NokiaN95.BatteryInfo.Type}");
        //    Console.WriteLine($"Screen Size : {NokiaN95.ScreenInfo.Size}");
        //    Console.WriteLine($"Screen Colors : {NokiaN95.ScreenInfo.Colors}");
        //}

    }
}
