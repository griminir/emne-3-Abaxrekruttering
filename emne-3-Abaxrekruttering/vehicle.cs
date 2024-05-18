using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace emne_3_Abaxrekruttering
{
    internal abstract class  Vehicle
    {
        public string Kjennetegn { get; protected set;  }
        public int Kraft { get; protected set;  }
        public string Type { get; protected set; }

        public Vehicle(string kt, int K, string t)
        {
            Kjennetegn = kt;
            Kraft = K;
            Type = t;
        }

        public virtual void info()
        {
            Console.WriteLine($"regnum: {Kjennetegn}");
            Console.WriteLine($"kraft: {Kraft}KW");
        }

        public abstract void run();
    }
}
