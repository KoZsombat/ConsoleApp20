using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Lakos
    {
        public string Nev { get; private set; }
        public int Kor { get; private set; }
        public string Lakcim { get; private set; }
        public int Penz { get; private set; }

        public Lakos(string nev, int kor, string lakcim, int penz)
        {
            if (string.IsNullOrWhiteSpace(nev)) throw new ArgumentException("Név kötelező.");
            if (kor < 0) throw new ArgumentException("Életkor nem lehet negatív.");
            if (penz < 0) throw new ArgumentException("Pénz nem lehet negatív.");
            Nev = nev;
            Kor = kor;
            Lakcim = lakcim;
            Penz = penz;
        }

        public bool Fizet(int osszeg)
        {
            if (osszeg <= 0 || osszeg > Penz) return false;
            Penz -= osszeg;
            return true;
        }

        public void BelepSzolgaltatasba(string szolgaltatasNeve)
        {
            Console.WriteLine($"{Nev} belépett a(z) {szolgaltatasNeve} szolgáltatásba.");
        }

        public void HasznalKozlekedest(string jarmuNeve)
        {
            Console.WriteLine($"{Nev} használja a(z) {jarmuNeve} közlekedési járművet.");
        }

        public override string ToString()
        {
            return $"{Nev} ({Kor} éves, {Lakcim}, {Penz} Ft)";
        }
    }
}
