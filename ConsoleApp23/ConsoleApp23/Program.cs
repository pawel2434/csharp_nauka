using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        private static int choise;

        static void Main(string[] args)
        {

            {
                int liczba1 = 0, liczba2 = 0, liczba3 = 0,liczba4 = 0;
                

              


                Console.WriteLine("Co zrobić z liczbami? 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie, 5 - pole koła, 6 - obwód koła");

               

                int wybor1;
                double wynik = 0;


                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        wynik = (liczba1 + liczba2);
                        break;
                    case 2:
                        wynik = (liczba1 - liczba2);
                        break;
                    case 3:
                        wynik = (liczba1 * liczba2);
                        break;
                    case 4:
                        wynik = (liczba1 / liczba2);
                        break;
                    case 5:
                        wynik = (3.14 * (liczba1 * liczba1));
                        break;
                        
                    case 6:
                        wynik = (2 * 3.14 * liczba1);
                        break;
                    default:
                        Console.WriteLine("Nie wybrałeś numeru");
                        break;

                }
                Console.WriteLine("Podaj liczbe");
                liczba1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj kolejną liczbę");
                liczba2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Wynik = {wynik}");

                Console.WriteLine("Podaj kolejną liczbe");
                liczba3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Co zrobić z liczbami? 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie");



                int wybor2;
                double wynik1 = wynik;


                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        wynik1 = (wynik + liczba3);
                        break;
                    case 2:
                        wynik1 = (wynik - liczba3);
                        break;
                    case 3:
                        wynik1 = (wynik * liczba3);
                        break;
                    case 4:
                        wynik1 = (wynik / liczba3);
                        break;
                    default:
                        Console.WriteLine("Nie wybrałeś numeru");
                        break;

                }
                Console.WriteLine($"Wynik1 = {wynik1}");

                Console.WriteLine("Podaj kolejną liczbe");
                liczba4 = int.Parse(Console.ReadLine());

                Console.WriteLine("Co zrobić z liczbami? 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie");



                int wybor3;
                double wynik2 = wynik;


                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        wynik2 = (wynik1 + liczba4);
                        break;
                    case 2:
                        wynik2 = (wynik1 - liczba4);
                        break;
                    case 3:
                        wynik2 = (wynik1 * liczba4);
                        break;
                    case 4:
                        wynik2 = (wynik1 / liczba4);
                        break;
                    default:
                        Console.WriteLine("Nie wybrałeś numeru");
                        break;

                }
                Console.WriteLine($"Wynik2 = {wynik2}");
                Console.ReadKey();
            }
        }
    }
}

