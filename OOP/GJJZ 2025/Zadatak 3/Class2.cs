using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dfsaf
{
    internal class Stavka
    {
        readonly int kolicina;
        readonly Proizvod artikal;

        public Stavka(int kolicina, Proizvod artikal)
        {
            this.kolicina = kolicina;
            this.artikal = artikal;
        }
        public Stavka(int kolicina, string sifra, string naziv, double cena)
        {
            this.kolicina = kolicina;
            artikal = new Proizvod(sifra, naziv, cena);

        }
        public double UkupnaCena()
        {
            return kolicina * artikal.Cena;
        }
        public string stampaj()
        {
            return artikal.stampaj() + "\n Broj komada: " + kolicina + "\n";
        }
    }
}
