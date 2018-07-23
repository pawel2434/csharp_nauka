using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie25 // Zadanie 2.5
{
    class Program
    {
        private static int to;

        static void Main(string[] args)
        {
            double losuj_liczbe, zgadnij_liczbe;
            Console.WriteLine("Program losuje liczb od 0 do 9. Zgadnij ją.");
            Random r = new Random();
            losuj_liczbe = Math.Round(10 * (r.NextDouble()));
            zgadnij_liczbe = double.Parse(Console.ReadLine());
            if (zgadnij_liczbe == losuj_liczbe)
            {
                Console.WriteLine("Gratulacje! Zgadeś liczb!");
            }
            else
            {
                Console.WriteLine("Bardzo mi przykro, ale wylosowana liczba to {0};");
            }
            Console.Read(); // nacinij klawisz Enter
        }
    }
}