using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Varos varos = new Varos();
            var lakosok = new List<Lakos>
            {
                new Lakos("Ádám", 17, "Alma utca 10", 100000),
                new Lakos("Béla", 25, "Körte utca 5", 80000),
                new Lakos("Cecília", 30, "Barack tér 2", 120000),
                new Lakos("Dániel", 22, "Szilva köz 8", 95000),
                new Lakos("Eszter", 19, "Meggy utca 1", 70000),
                new Lakos("Ferenc", 40, "Diófa utca 12", 150000),
                new Lakos("Gábor", 28, "Cseresznye sor 3", 110000),
                new Lakos("Hanna", 35, "Mogyoró utca 7", 130000),
                new Lakos("Ilona", 27, "Füge utca 4", 90000),
                new Lakos("János", 32, "Mandula tér 6", 105000)
            };
            foreach (var l in lakosok)
                varos.HozzaadLakos(l);

            Konyvtar konyvtar = new Konyvtar(20);
            konyvtar.Konyvek.Add(new Konyv("Egri csillagok", "Gárdonyi Géza", 600, 5000, 3));
            konyvtar.Konyvek.Add(new Konyv("Pál utcai fiúk", "Molnár Ferenc", 250, 3000, 2));
            konyvtar.Konyvek.Add(new Konyv("Tüskevár", "Fekete István", 320, 3500, 1));
            konyvtar.Konyvek.Add(new Konyv("A kőszívű ember fiai", "Jókai Mór", 400, 4000, 2));
            konyvtar.Konyvek.Add(new Konyv("A Pendragon legenda", "Szerb Antal", 280, 4500, 1));

            varos.SzolgaltatasInditasa(konyvtar);

            konyvtar.Belepes(lakosok[0]);
            konyvtar.Kolcsonoz(lakosok[0], "Egri csillagok");
            konyvtar.Belepes(lakosok[1]);
            konyvtar.Kolcsonoz(lakosok[1], "Pál utcai fiúk");
            konyvtar.Belepes(lakosok[2]);
            konyvtar.Kolcsonoz(lakosok[2], "Tüskevár");

            KozlekedesiJarmu busz = new KozlekedesiJarmu("Városi Busz", "Belváros-Külváros", 30, 350);
            for (int i = 0; i < 5; i++)
                busz.Felszallas(lakosok[i]);
            varos.SzolgaltatasInditasa(busz);

            Kavezo kavezo = new Kavezo();
            EtelItal kave = new EtelItal("Espresso", 600, "ital", 80, 5);
            EtelItal suti = new EtelItal("Sajttorta", 900, "etel", 0, 350);
            kavezo.HozzaadMenu(kave);
            kavezo.HozzaadMenu(suti);
            varos.SzolgaltatasInditasa(kavezo);

            kavezo.Rendel(lakosok[3], kave);
            kavezo.Fizet(lakosok[3], kavezo, kave);
            kavezo.Fogyaszt(lakosok[3], kave);

            kavezo.Rendel(lakosok[3], suti);
            kavezo.Fizet(lakosok[3], kavezo, suti);
            kavezo.Fogyaszt(lakosok[3], suti);

            Posta posta = new Posta();
            Csomag csomag = new Csomag("Ádám", "János", 2.5, 2500);
            posta.Kuldes(csomag);
            csomag.Szallitas();
            csomag.Kiszallitas();
            varos.SzolgaltatasInditasa(posta);

            Console.WriteLine("Reggel: 5 lakos busszal utazik.");
            for (int i = 0; i < 5; i++)
                busz.Lepes();

            Console.WriteLine("Napközben: 3 lakos könyvtárba megy és kölcsönöz.");
            for (int i = 0; i < 3; i++)
            {
                konyvtar.Belepes(lakosok[i]);
                konyvtar.Kolcsonoz(lakosok[i], konyvtar.Konyvek[i].Cim);
            }

            Console.WriteLine("Este: 1 lakos kávézóban rendel és fogyaszt.");
            kavezo.Rendel(lakosok[3], kave);
            kavezo.Fizet(lakosok[3], kavezo, kave);
            kavezo.Fogyaszt(lakosok[3], kave);

            Console.WriteLine("Tesztfázis vége.");
        }
    }
}
