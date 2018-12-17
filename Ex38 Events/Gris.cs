using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public class Gris
    {
        private double saldo = 0.0;
        private int bill = 0;

        public void InsertAmount(Metronome m, double amount)
        {
            do
            {
                m.Tick += new Metronome.dele(Saldo);
                m.Tick += new Metronome.dele(OB);
                saldo += amount;
            } while (amount != 0);
        }

        public void Saldo(Metronome m, EventArgs e)
        {
            Console.WriteLine("Grisens saldo er nu: " + saldo);
            bill = Convert.ToInt32(saldo / 595);
        }
        public void OB(Metronome m, EventArgs e)
        {
            switch (bill)
            {
                case 1:
                    Console.WriteLine("Tillykke – du har nu penge nok til " + bill + " sæsonkort til OBs kampe");
                    break;
                case 2:
                    Console.WriteLine("Tillykke – du har nu penge nok til " + bill + " sæsonkort til OBs kampe");
                    break;
                case 3:
                    Console.WriteLine("Tillykke – du har nu penge nok til " + bill + " sæsonkort til OBs kampe");
                    break;
            }
        }
    }
}
