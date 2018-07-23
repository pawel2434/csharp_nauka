using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1 = 0.0, l2 = 0.0, wynik = 0.0;
            string dzialanie = "";
            int index = 1;

            while (true)
            {
                l1 = Convert.ToDouble(args[0]);
                dzialanie = Convert.ToString(args[index]);
                l2 = Convert.ToDouble(args[index + 1]);
                index = index + 2;

                if (dzialanie == "+")
                {
                    Console.Clear();
                    Console.WriteLine();
                    wynik = wynik = l1;


                }
                else if (dzialanie == "-")
                {
                    Console.Clear();
                    wynik = wynik + l1;
                    l1 = 0 - l2;
                }
                else if (dzialanie == "*")
                {
                    Console.Clear();
                    l1 = l1 * l2;
                }
                else if (dzialanie == "/")
                {
                    Console.Clear();
                    l1 = l1 / l2;

                }
                else
                {
                    break;
                }
                wynik = wynik + l1;
                Console.WriteLine("Answer : {0}", wynik);
                NewMethod(args);
                return;

            }
            return ;
           
        }

        private static void NewMethod(string[] args)
        {
            return ;
        }
    }
}
