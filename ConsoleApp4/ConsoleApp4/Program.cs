using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int Liczba;
            Liczba = 0;
            for (var i = 0; i < 11; i++)
            {
                Console.WriteLine(a++);
            }
            Console.WriteLine("podaj jaką masz ocene");
            Console.ReadLine();
            if (Liczba <= 2)
            {
                Console.WriteLine("twoja ocena jest zła ");
            }
            else if (Liczba  <= 3)
            {
                Console.WriteLine("twoja ocena jest dostateczna");
            }

            Console.ReadKey();
        }
    }
}
