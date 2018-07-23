using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Podaj liczbe całkowitą z zakresu -100 do 100");
            a = double.Parse(Console.ReadLine());
            if (a <= -90)
            {
                Console.WriteLine("jest to liczba ujemna z zakresu -90 do -100");

            }
             else if (a <= -80 )
            {
                Console.WriteLine("jest to liczba ujemna z zakresu -89 do -80");
            }
             else if (a <= -70 )
            {
               Console.WriteLine("jest to liczba ujemna z zakresu -79 do -70");
            }
            else if (a <= -60)
            {

                Console.WriteLine("jest to liczba ujemna z zakresu -69 do -60");


            }
            Console.ReadKey();
        }
    }
}
