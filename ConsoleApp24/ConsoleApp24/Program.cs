using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        private static int choise;

        static void Main(string[] args)
        {
            {
                int liczba1 = 0, liczba2 = 0, promien;

                Console.WriteLine("Wybierz? 1 - dodawanie odejmowanie mnorzenie dzielenie, 2 - pozostałe");

                int wybor = 1, wybor1 = 2;

                wybor = int.Parse(Console.ReadLine());

                if  (wybor == 1)
                {
                    
                        Console.WriteLine("Co zrobić z liczbami 1 - dodawanie, 2 - odejmowanie, 3 - mnorzenie, 4 - dzielenie");
                       


                        double wybor3 = 1, wybor4 = 2, wybor5 = 3,wybor6 = 4;
                        double wynik = 0;

                        wybor = int.Parse(Console.ReadLine());
                    if (wybor3 == 1)
                    {
                        Console.WriteLine("Wynik = " + liczba1 + liczba2);
                    }
                                
                         else if (wybor4 == 2)
                    {
                        Console.WriteLine("Wynik = " + liczba1 - liczba2);
                    }
                         else if (wybor5 == 3)
                    {
                        Console.WriteLine("Wynik = " + liczba1 * liczba2);
                    }
                    else if (wybor6 == 4)
                    {
                        Console.WriteLine("Wynik = " + liczba1 / liczba2);
                    }



                        }
                        Console.WriteLine("podaj liczbę");
                        liczba1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("podaj następną liczbę");
                        liczba2 = int.Parse(Console.ReadLine());


                       
                        Console.ReadKey();

                    if (wybor1 == 2)
                        Console.WriteLine("1 - obliczyć obwód koła, 2 - obliczyć pole koła");
                       
                        Console.WriteLine("podaj promień koła");
                        promien = int.Parse(Console.ReadLine());

                        int wybor2;
                        double wynik2 = 0;

                        choise = int.Parse(Console.ReadLine());
                        switch (choise)
                        {
                            case 1:
                                wynik2 = ((2 * 3.14) * promien);
                                break;
                            case 2:
                                wynik2 = (3.14 * (promien * promien));
                                break;
                        }
                        Console.WriteLine($"Wynik2 = {wynik2}");
                       
                }

                Console.ReadKey();
            }
           
        }
    }
}
