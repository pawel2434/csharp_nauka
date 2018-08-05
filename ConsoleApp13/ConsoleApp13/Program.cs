using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        private static object nazwyPrzedmiotuw;

        public static int Przedmiotuw { get; private set; }

        static void Main(string[] args)
        {
            int iloscPrzedmiotuw = 0;
            double suma = 0;
            Console.Write("Ile Przedmiotów chcesz zawrzeć w średniej: ");
            iloscPrzedmiotuw = Int32.Parse(Console.ReadLine());

            

            for (int i = 0; i < iloscPrzedmiotuw; i++)
            {
                Console.WriteLine("podaj nazwe przedmiotu");
                Console.Write("Podaj  ocene: ");

                suma += double.Parse(Console.ReadLine());
            }
            

            Console.WriteLine("Średnia arytmetyczna z podanych liczb wynosi: " + suma / iloscPrzedmiotuw);
            Console.ReadKey();

        }

        private static string ToString(ConsoleKeyInfo consoleKeyInfo)
        {
            throw new NotImplementedException();
        }
    }
}

