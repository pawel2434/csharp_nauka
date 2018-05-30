using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            var calkulator = new Calkulate();
            calkulator.Set(0).Add(5).Sub(2).Pow(4);

            Console.WriteLine(calkulator);
            Console.ReadKey();



        }
    }
}
