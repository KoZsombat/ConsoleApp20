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
    }
}
