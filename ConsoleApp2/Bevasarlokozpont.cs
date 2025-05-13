using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bevasarlokozpont
    {
        public List<EtelItal> Termekek { get; set; }
        public Bevasarlokozpont()
        {
            Termekek = new List<EtelItal>();
        }
        public void HozzaadTermek(EtelItal etelital)
        {
            Termekek.Add(etelital);
            Console.WriteLine($"{etelital.Nev} hozzáadva a bevásárlóközpont termékeihez.");
        }
        public void Vasarlas(Lakos lakos, EtelItal etelital)
        {
            Console.WriteLine($"{lakos.Nev} vásárol egy {etelital.Nev}-t.");
        }
        public void Fizet(Lakos lakos, Bevasarlokozpont bevasarlokozpont, EtelItal etelital)
        {
            Console.WriteLine($"{lakos.Nev} kifizette a(z) {etelital.Nev} árát: {etelital.Ar} Ft.");
        }
    }
}
