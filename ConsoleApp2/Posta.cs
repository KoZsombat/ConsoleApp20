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
        }
    }
}
