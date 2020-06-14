using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54939
{
    class Gra
    {
        internal protected string nazwa;
        internal protected double cena;

        public Gra() { }
        public Gra (string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }

        public string Opis() => (nazwa + " " + cena.ToString());
      
    }
}
