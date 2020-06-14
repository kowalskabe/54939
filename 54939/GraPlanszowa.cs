using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54939
{
    class GraPlanszowa : Gra
    {
        private int liczbaGraczy;


        public GraPlanszowa() { }

        public GraPlanszowa(string nazwa, double cena, int liczbaGraczy) : base(nazwa, cena)
        {
            this.liczbaGraczy = liczbaGraczy;
        }


        public double CzasRozgrywki() => liczbaGraczy * 45.2;
    }
}
