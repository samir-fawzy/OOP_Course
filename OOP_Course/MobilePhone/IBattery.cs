using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.MobilePhone
{
    interface IBattery
    {
        string Model { get; }
        int IdleTime { get; }
        int HoursTalk { get; }
        BatteryType Type { get; }
    }
}
