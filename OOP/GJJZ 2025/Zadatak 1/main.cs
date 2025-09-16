using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektno
{
    internal class Program
    {
        class Učenik
        {
            public string ime = "Ime";
            public string prezime = "Prezime";
            public double prosek_prethodne_godine;

            public Učenik(string ime, string prezime, double prosek_prethodne_godine)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.prosek_prethodne_godine = prosek_prethodne_godine;
            }
            public void štampaj()
            {
                Console.WriteLine();
                Console.WriteLine("Štampanje Podataka na zahtev:");
                Console.WriteLine("Učenik: " + ime + " " + prezime);
                Console.WriteLine("Prosek iz prethodne godine: " + prosek_prethodne_godine);
            }
            
        }
        static void Main(string[] args)
        {
            Učenik a1 = new Učenik("Luka","Orlić",4.82);
            Učenik a2 = new Učenik("Andrej", "Monar", 4.92);
            Učenik a3 = new Učenik("Relja", "Kanović", 5.00);
            Učenik a4 = new Učenik("Andrej", "Veselinović", 4.70);
            a1.štampaj();
            a2.štampaj();
            a3.štampaj();
            a4.štampaj();
        }
    }
}
