using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        private static int choose;
        private static int c;

        static void Main(string[] args)
        {
            int choose = 0, a = 0, b = 0;
            double c = 0;
           
            

            Console.WriteLine("Podaj rodzaj działania");

            while (choose != 4)
            {
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");

                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Podaj liczbe 1:");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj liczbe 2:");
                            b = int.Parse(Console.ReadLine());
                            c = a + b;
                            Console.WriteLine("Wynik = "+ c);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Podaj liczbe 1:");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj liczbe 2:");
                            b = int.Parse(Console.ReadLine());
                            c = a - b;
                            Console.WriteLine("Wynik = "+ c);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Podaj liczbe 1:");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj liczbe 2:");
                            b = int.Parse(Console.ReadLine());
                            c = a * b;
                            Console.WriteLine("Wynik = "+ c);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Podaj liczbe 1:");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj liczbe 2:");
                            b = int.Parse(Console.ReadLine());
                            c = a / b;
                            Console.WriteLine("Wynik = "+ c);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("nie");
                            break;
                        }

                }
            }
           
           

            
        }
    }
}
