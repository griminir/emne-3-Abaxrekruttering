using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Abaxrekruttering
{
    internal class Airplane : Vehicle
    {
        public int Wingspan { get; private set; }
        public int CargoWeight { get; private set; }
        public int Weight { get; private set; }
        public Airplane(string reg, int kilowatt, string type, int vingspand, int cargo, int weight) : base(reg, kilowatt, type)
        {
            Wingspan = vingspand;
            CargoWeight = cargo;
            Weight = weight;
        }

        public override void info()
        {
            base.info();
            Console.WriteLine($"wingspan: {Wingspan}m");
            Console.WriteLine($"cargocapasity: {CargoWeight}tonn");
            Console.WriteLine($"weight: {Weight}tonn");
            Console.WriteLine($"flyklasse: {Type}");
        }

        public override void run()
        {
            Console.WriteLine($"airplane with the regnum {Kjennetegn} is taking off");
        }

    }
}
