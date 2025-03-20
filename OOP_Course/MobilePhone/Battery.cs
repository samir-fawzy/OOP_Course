using OOP_Course.MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.MobilePhone
{
    class Battery : IBattery
    {
        public string Model { get; set; }
        public int IdleTime { get; set; }
        public int HoursTalk { get; set; }
        public BatteryType Type { get; set; }


    }
}
