using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Csomag
    {
        public string Kuldo { get; private set; }
        public string Cimzett { get; private set; }
        public double Suly { get; private set; }
        public int Ar { get; private set; }
        public string Allapot { get; private set; }

        public Csomag(string kuldo, string cimzett, double suly, int ar)
        {
            Kuldo = kuldo;
            Cimzett = cimzett;
            Suly = suly;
            Ar = ar;
            Allapot = "Feladva";
        }

        public void Feladas()
        {
            Allapot = "Feladva";
        }

        public void Szallitas()
        {
            Allapot = "Szállítás alatt";
        }

        public void Kiszallitas()
        {
            Allapot = "Kézbesítve";
        }
    }
}
