using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        private static int podaj;

        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int c;
           
            Console.Write("podaj c");
            c = int.Parse (Console.ReadLine());
            Console.WriteLine(value: a + (b * c));
            Console.ReadKey();

        }
    }
}
