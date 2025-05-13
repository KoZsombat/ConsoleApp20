using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Kavezo
    {
        public List<EtelItal> Menu { get; set; }
        public Kavezo()
        {
            Menu = new List<EtelItal>();
        }
        public void HozzaadMenu(EtelItal etelital)
        {
            Menu.Add(etelital);
            Console.WriteLine($"{etelital.Nev} hozzáadva a kávézó menüjéhez.");
        }
        public void Rendel(Lakos lakos, EtelItal etelital)
        {
            Console.WriteLine($"{lakos.Nev} rendel egy {etelital.Nev}-t.");
        }
        public void Fizet(Lakos lakos, Kavezo kavezo, EtelItal etelital)
        {
            Console.WriteLine($"{lakos.Nev} kifizette a(z) {etelital.Nev} árát: {etelital.Ar} Ft.");
        }
        public void Fogyaszt(Lakos lakos, EtelItal etelital)
        {
            Console.WriteLine($"{lakos.Nev} elfogyasztotta a(z) {etelital.Nev}-t.");
        }
    }
}
