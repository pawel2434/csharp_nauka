using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            double wynik = 0, w = 0, w1 = 0, w2 = 0, w3 = 0, w4 = 0, w5 = 0;
            int wybor, wybor1, wybor2, liczba = 0, liczba1 = 0, liczba2 = 0;

           

            Console.WriteLine("1  +  -  *  / , 2 czy inne");
            wybor = int.Parse(Console.ReadLine());
            if (wybor == 1)
            {



                Console.WriteLine("1 dodawanie, 2 odejmowanie, 3 mnorzenie, 4 dzielenie");
                wybor1 = int.Parse(Console.ReadLine());

                Console.WriteLine("podaj 1 liczbe");
                liczba1 = int.Parse(Console.ReadLine());

                Console.WriteLine("podaj 2 liczbe");
                liczba2 = int.Parse(Console.ReadLine());

                if (wybor1 == 1)
                {
                    Console.WriteLine("wynik = " + (liczba1 + liczba2));
                }
                else if (wybor1 == 2)
                {
                    Console.WriteLine("wynik = " + (liczba1 - liczba2));
                }
                else if (wybor1 == 3)
                {
                    Console.WriteLine("wynik = " + (liczba1 * liczba2));
                }
                else if (wybor1 == 4)
                {
                    Console.WriteLine("wynik = " + (liczba1 / liczba2));

                }
            }
            else if (wybor == 2)
            {
                Console.WriteLine("1 pole koła , 2 obwud koła");
                wybor2 = int.Parse(Console.ReadLine());

                Console.WriteLine("podaj promoień");
                liczba = int.Parse(Console.ReadLine());

                if (wybor2 == 1)
                {
                    Console.WriteLine("wynik = " + (3.14 * (liczba * liczba)));
                }
                else if (wybor2 == 2)
                {
                    Console.WriteLine("wynik = " + ((2 * 3.14) * liczba));
                }
            }
            Console.ReadKey();
        }
    }
}
