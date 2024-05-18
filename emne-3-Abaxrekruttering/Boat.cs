using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Abaxrekruttering
{
    internal class Boat : MaxSpeedVehicle
    {
        public int Bruttotonnasje { get; private set; }
        public Boat(string kjennetegn, int kraft, int maxspeed, string speedunit, string type, int bruttotonnasje) : base(maxspeed, speedunit, kjennetegn, kraft, type)
        {
            Bruttotonnasje = bruttotonnasje;
        }

        public override void info()
        {
            Console.WriteLine($"type: {Type}");
            base.info();
            Console.WriteLine($"bruttotonnasje: {Bruttotonnasje}KG ");
        }
    }
}
