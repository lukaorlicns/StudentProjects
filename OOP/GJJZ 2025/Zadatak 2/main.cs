using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektno
{
    internal class Program
    {
        enum Žanr
        {
            Komedija, Akcija, Triler, SF, Horor, Drama
        }
        class Film
        {
            private string naziv_filma;
            private string ime_prezime_režisera;
            private int godina_prikazivanja;
            private Žanr žanr_filma;

            public string Ime_prezime_režisera
            {
                get { return ime_prezime_režisera; }
                set { ime_prezime_režisera = value; }
            }
            public int Godina_prikazivanja
            {
                get { return godina_prikazivanja; }
                set { godina_prikazivanja = value; }
            }
            public Žanr Žanr_filma
            {
                get { return žanr_filma; }
                set { žanr_filma = value; }
            }
            public string Naziv_filma
            {
                get { return naziv_filma; }
                set { naziv_filma = value; }
            }
            
            
        }
        static void Main(string[] args)
        {
            
        }
    }
}
