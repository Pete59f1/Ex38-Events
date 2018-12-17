using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Metronome m = new Metronome();
            Metronome m2 = new Metronome();
            TickListener l = new TickListener();
            //l.Sub(m);
            //m.Loop();
            m.Name = "James";
            m2.Name = "Peter";
            l.LifeSub(m, m2);
            m.LifeLoop();
            m2.LifeLoop();
        }
    }
}
