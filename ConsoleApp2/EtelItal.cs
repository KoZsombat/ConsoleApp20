using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class EtelItal
    {
        public string Nev { get; set; }
        public double Ar { get; set; }
        public string Tipus { get; set; } // "etel" vagy "ital"
        public double Kaloria { get; set; }
        public double Mennyiseg { get; set; } // liter vagy gramm
        public EtelItal(string nev, double ar, string tipus, double kaloria, double mennyiseg)
        {
            Nev = nev;
            Ar = ar;
            Tipus = tipus;
            Kaloria = kaloria;
            Mennyiseg = mennyiseg;
        }
        public void Fogyaszt()
        {
            Console.WriteLine($"{Nev} elfogyasztva.");
        }
    }
}
