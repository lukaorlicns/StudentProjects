using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dfsaf
{

    internal class Proizvod
    {
      
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
    

        public Proizvod(string sifra, string naziv, double cena)
        {
            Sifra = sifra.ToString();
            Naziv = naziv.ToString();
            Cena = cena;
        }
        public string stampaj()
        {
            string poruka = "\n Sifra: " + Sifra + "\n Naziv: "+ Naziv + "\n Cena: "+ Cena + "";
            return poruka;
        }
     

     
    }
}
