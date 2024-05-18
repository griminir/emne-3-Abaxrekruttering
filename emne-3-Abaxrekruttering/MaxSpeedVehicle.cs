using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace emne_3_Abaxrekruttering
{
    internal abstract class MaxSpeedVehicle : Vehicle
    {
        public int MaxSpeed { get; protected set; }
        public string SpeedUnit { get; protected set; }

        protected MaxSpeedVehicle(int maxspeed, string speedunit, string kjennetegn, int kraft, string type) : base(kjennetegn, kraft, type)
        {
            MaxSpeed = maxspeed;
            SpeedUnit = speedunit;
        }

        public override void info()
        {
            base.info();
            Console.WriteLine($"Top speed: {MaxSpeed}{SpeedUnit}");
        }

        public override void run()
        {

        }
    }
}
