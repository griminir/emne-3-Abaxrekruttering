using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace emne_3_Abaxrekruttering
{
    internal class Car : MaxSpeedVehicle
    {
        public string Color { get; private set; }

        public Car(string kjennetegn, int kraft, int maxspeed, string speedunit, string type, string farge) : base(maxspeed, speedunit, kjennetegn, kraft, type)
        {
            Color = farge;
        }

        public override void info()
        {
            base.info();
            Console.WriteLine($"{Color} farge av typen {Type}");
        }

        public override void run()
        {
            Console.WriteLine($"this {Type} is running at maxspeed: {MaxSpeed}{SpeedUnit}");
        }

        public void sameCar(Car check)
        {
            var sameCar = check == this;
            Console.WriteLine($"is this the same car? {sameCar}");
        }
    }
}
