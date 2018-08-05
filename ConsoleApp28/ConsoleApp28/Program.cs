using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1 = 0.0, l2 = 0.0;
            string dzialanie = "";


            try
            {
                Console.Write("ppodaj l1:  ");
                l1 = double.Parse(Console.ReadLine());
                Console.Write("ppodaj l2:  ");
                l2 = double.Parse(Console.ReadLine());
                Console.Write("ppodaj dzialanie:  ");
                dzialanie = Console.ReadLine();
            }
            catch(Exception e)
            {

            }

            if (dzialanie =="+")
            {
                Console.Clear();
                Console.WriteLine("wynik = " + (l1 + l2));
                
            }
            else if (dzialanie == "-")
            {
                Console.Clear();
                Console.WriteLine("wynik = " + (l1 - l2));
                
            }
            else if (dzialanie == "*")
            {
                Console.Clear();
                Console.WriteLine("wynik = " + (l1 * l2));
            }
            else if (dzialanie == "/")
            {
                Console.Clear();
                Console.WriteLine("wynik = " + (l1 / l2));
            }


           
           

            Console.ReadKey();
        }
        
    }
    
}
