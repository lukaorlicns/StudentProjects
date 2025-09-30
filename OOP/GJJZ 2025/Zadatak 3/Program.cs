using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dfsaf
{ 
    internal class Program
    {
      


        static void Main(string[] args)
        {
            Proizvod p1 = new Proizvod("#001","Milka",149.98);
            Proizvod p2 = new Proizvod("#002", "Banana", 119.98);

            Stavka s1 = new Stavka(20, p1); //20 komada milki
            Stavka s2 = new Stavka(16, p2); //16 komada banana
            Stavka s3 = new Stavka(14, "#003", "Lubenica", 259.98);

            //Console.WriteLine(s3.stampaj());
            Stavka[] korpa = new Stavka[2] {s1,s2};


            Console.WriteLine(StampajRacun(korpa));


        }
        static double IznosRacuna(Stavka[] a)
        {
            double racun_iznos = 0;
            for (int i = 0; i < a.Length; i++)
            {
                racun_iznos += a[i].UkupnaCena();
            }
            return racun_iznos;
        }
        static string StampajRacun(Stavka[] a)
        {
            double racun_iznos = IznosRacuna(a);
            string racun = "Maxi Prodavnica by Luka \r\n"+System.DateTime.Now+" \r\n====================== \r\n";
            for (int i = 0; i < a.Length; i++)
            {
                racun += a[i].stampaj()+ " ";
            }
            racun += "\r\n";
            racun += "====================== \r\n";
            racun += "Ukupno: "+racun_iznos+ "\r\n";
            racun += "Ukupno sa 20% popusta: " + Popust(racun_iznos,20)+ "\r\n";
            return racun;
        }
        static double Popust(double ukupno, double popust)
        {
            return Math.Round(ukupno * (1 - popust*0.01),2);
        }

    }
}
