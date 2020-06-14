using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54939
{
    class Program
    {
        static void Main(string[] args)
        {
            Gra g1 = new Gra("Cyberpunk2077", 199.99);
            Gra g2 = new Gra("Grand Theft Auto V", 109.9);

            GraPC gPC1 = new GraPC("FIFA20", 99.99, 12);
            GraPC gPC2 = new GraPC("Wiedźmin3: Dziki Gon", 234.99, 18);

            GraPlanszowa gP1 = new GraPlanszowa("Dixit", 94.9, 6);
            GraPlanszowa gP2 = new GraPlanszowa("Monopoly", 118.99, 8);

            Console.WriteLine("Czas rozgrywki 1. planszówki " + gP1.CzasRozgrywki());
            Console.WriteLine("Czas rozgrywki 2. planszówki " + gP2.CzasRozgrywki());

            if (gPC1.Multiplayer()) Console.WriteLine("1. PC posiada tryb multiplayer");
            else Console.WriteLine("1. PC nie posiada trybu multiplayer");
            
            if (gPC2.Multiplayer()) Console.WriteLine("2. PC posiada tryb multiplayer");
            else Console.WriteLine("2. PC nie posiada trybu multiplayer");
            

            Console.WriteLine(g1.Opis());
            Console.WriteLine(g2.Opis());
            Console.WriteLine(gPC1.Opis());
            Console.WriteLine(gPC2.Opis());
            Console.WriteLine(gP1.Opis());
            Console.WriteLine(gP2.Opis());

            Console.ReadKey();
        }
    }
}
