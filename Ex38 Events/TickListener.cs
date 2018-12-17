using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public class TickListener
    {
        public void Sub(Metronome m)
        {
            m.Tick += new Metronome.dele(Listen);
        }
        public void Listen(Metronome m , EventArgs e)
        {
            Console.WriteLine("Heard You");
        }

        public void LifeSub(Metronome m, Metronome m2)
        {
            m.Tick += new Metronome.dele(PersonIsAlive);
            m.Tick += new Metronome.dele(BIIIP);
            m2.Tick += new Metronome.dele(PersonIsAlive);
            m2.Tick += new Metronome.dele(BIIIP);
        }
        public void IAmAlive(Metronome m , EventArgs e)
        {
            Console.WriteLine("For the record: I'm alive!");
        }
        public void BIIIP(Metronome m, EventArgs e)
        {
            Console.WriteLine("BIIIIP");
        }
        public void PersonIsAlive(Metronome m, EventArgs e)
        {
            Console.WriteLine("For the record: " + m.Name + " is alive!");
        }
    }
}
