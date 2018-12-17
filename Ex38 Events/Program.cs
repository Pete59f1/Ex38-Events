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
            //Metronome m = new Metronome();
            //Metronome m2 = new Metronome();
            //TickListener l = new TickListener();
            ////l.Sub(m);
            ////m.Loop();
            //Console.WriteLine("Write a name:");
            //m.Name = Console.ReadLine();
            //Console.WriteLine("\n");
            //Console.WriteLine("A second name:");
            //m2.Name = Console.ReadLine();
            //Console.WriteLine("\n");

            //l.LifeSub(m);
            //l.LifeSub(m2);
            //m.LifeLoop();
            //m2.LifeLoop();

            Metronome m = new Metronome();
            Gris g = new Gris();
            g.InsertAmount(m, double.Parse(Console.ReadLine()));
        }
    }
}
