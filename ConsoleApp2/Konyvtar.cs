using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Konyvtar
    {
        private List<Konyv> konyvek = new List<Konyv>();
        private int maxKapacitas;
        private HashSet<Lakos> bentLevoLakosok = new HashSet<Lakos>();

        public Konyvtar(int kapacitas)
        {
            maxKapacitas = kapacitas;
        }

        public List<Konyv> Konyvek => konyvek;

        public void Belepes(Lakos l)
        {
            bentLevoLakosok.Add(l);
        }

        public bool Kolcsonoz(Lakos l, string cim)
        {
            if (!bentLevoLakosok.Contains(l)) return false;
            var konyv = konyvek.Find(k => k.Cim == cim && k.Peldanyszam > 0);
            if (konyv != null)
            {
                konyv.Peldanyszam--;
                return true;
            }
            return false;
        }

        public void Visszahoz(Lakos l, string cim)
        {
            var konyv = konyvek.Find(k => k.Cim == cim);
            if (konyv != null)
                konyv.Peldanyszam++;
        }
    }
}
