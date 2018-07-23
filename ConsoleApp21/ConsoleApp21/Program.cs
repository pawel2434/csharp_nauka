using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            double w;

            Console.WriteLine("podaj swuj wiek");

            w = double.Parse(Console.ReadLine());

            if (w <= 18)
            {
                Console.WriteLine("jesteś niepełnoletni");
            }
            else if(w >= 18)
            {
                Console.WriteLine("jesteś pełnoletni");
            }
            Console.ReadKey();
                
               
            
        }
    }
}
