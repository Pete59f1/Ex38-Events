using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public class Metronome
    {
        public delegate void dele(Metronome m, EventArgs e);
        public EventArgs e = null;
        public event dele Tick;

        public void Loop()
        {
            for (int i = 0; i < 5; i++)
            {
                if (Tick != null)
                {
                    System.Threading.Thread.Sleep(3000);
                    Tick(this, e);
                }
            }
        }

        public void LifeLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                if (Tick != null)
                {
                    System.Threading.Thread.Sleep(1000);
                    Tick(this, e);
                }
            }
        }
    }
}
