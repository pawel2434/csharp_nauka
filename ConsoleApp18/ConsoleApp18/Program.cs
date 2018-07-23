using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int F, C;
            Console.WriteLine("Podaj temp w st F");
            F = int.Parse(Console.ReadLine());
            C = 5 / 9 * (F - 32);
            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}
