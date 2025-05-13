using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Varos
    {
        private List<Lakos> lakosok = new List<Lakos>();
        private List<object> szolgaltatasok = new List<object>();

        public void HozzaadLakos(Lakos l)
        {
            lakosok.Add(l);
        }

        public void SzolgaltatasInditasa(object szolgaltatas)
        {
            szolgaltatasok.Add(szolgaltatas);
        }

        public void NapFutasa()
        {
            Console.WriteLine("A nap elkezdődött a városban!");
            if (szolgaltatasok.Count > 0)
            {
                foreach (var lakos in lakosok)
                {
                    string szolgaltatasNev = szolgaltatasok[0].GetType().Name;
                    lakos.BelepSzolgaltatasba(szolgaltatasNev);
                }
            }
            Console.WriteLine("A nap véget ért.");
        }

        public void VarosStatusza()
        {
            Console.WriteLine("Város lakói:");
            foreach (var l in lakosok)
            {
                Console.WriteLine($"- {l}");
            }
            Console.WriteLine("Szolgáltatások:");
            foreach (var sz in szolgaltatasok)
            {
                Console.WriteLine($"- {sz.GetType().Name}");
            }
        }
    }
}
