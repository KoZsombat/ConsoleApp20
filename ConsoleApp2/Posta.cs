using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Posta
    {
        private List<Csomag> csomagok = new List<Csomag>();

        public void Kuldes(Csomag c)
        {
            csomagok.Add(c);
            Console.WriteLine($"Csomag feladva: {c.Kuldo} → {c.Cimzett}, állapot: {c.Allapot}");
        }

        public void Atvetel(Lakos lakos)
        {
            var atveheto = csomagok.FindAll(c => c.Cimzett == lakos.Nev && c.Allapot == "Kézbesítve");
            if (atveheto.Count == 0)
            {
                Console.WriteLine($"{lakos.Nev} számára nincs átvehető csomag.");
                return;
            }
            foreach (var c in atveheto)
            {
                Console.WriteLine($"{lakos.Nev} átvette a csomagot ({c.Kuldo} → {c.Cimzett}, {c.Suly}kg, {c.Ar} Ft).");
                csomagok.Remove(c);
            }
        }

        public void SorbanAllas(Lakos lakos)
        {
            Console.WriteLine($"{lakos.Nev} sorban áll a postán.");
        }
    }
}
