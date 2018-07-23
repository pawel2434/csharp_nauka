using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        private static int newTemperatura;

        static void Main(string[] args)
        {
            int Temperatura = Temperatura(); 
            double Wynik = double(); 
           Console.WriteLine( "Podaj temperature w st cencjusza");
            Console.ReadLine();

            Wynik = ((Temperatura * 1.8) +32);
            Console.WriteLine("Jest " + Wynik + " Stopni F");
            Console.ReadKey();


        }
    }
}
