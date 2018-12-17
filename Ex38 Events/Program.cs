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
            TickListener l = new TickListener();
            //l.Sub(m);
            //m.Loop();
            m.Name = "James";
            l.LifeSub(m);
            m.LifeLoop();
        }
    }
}
