using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54939
{
    class GraPC : Gra
    {
        private int pegi;

        
        public GraPC() { }

        public GraPC(string nazwa, double cena, int pegi) : base(nazwa, cena)
        {
            this.pegi = pegi;
        }


        public bool Multiplayer() 
        {
            return true;
        }
    }
}
