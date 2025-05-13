using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class KozlekedesiJarmu
    {
        public string Nev { get; private set; }
        public string Utvonal { get; private set; }
        public int Ferohely { get; private set; }
        public int Jegyar { get; private set; }
        private List<Lakos> utasok = new List<Lakos>();

        public KozlekedesiJarmu(string nev, string utvonal, int ferohely, int jegyar)
        {
            Nev = nev;
            Utvonal = utvonal;
            Ferohely = ferohely;
            Jegyar = jegyar;
        }

        public bool Felszallas(Lakos l)
        {
            if (utasok.Count < Ferohely && l.Fizet(Jegyar))
            {
                utasok.Add(l);
                return true;
            }
            return false;
        }

        public void Lepes()
        {
            // Egyszerű szimuláció: minden utas "utazik"
            Console.WriteLine($"{utasok.Count} utas utazik a(z) {Nev}-n.");
        }
    }
}
