using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
           double a, b, c;

            Console.WriteLine("Podaj a");
            a = double.Parse (Console.ReadLine());

            Console.WriteLine("Podaj b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c");
            c = double.Parse (Console.ReadLine());

            
            Console.WriteLine("a + b + c = "+(a + b + c));
            Console.WriteLine("a * b * c = "+(a * b * c));
            Console.WriteLine("a - b - c = "+(a - b - c));
            Console.WriteLine("a / b / c = "+(a / b / c));
            Console.ReadKey();
        }
    }
}
