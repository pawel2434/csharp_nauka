using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo entered;

            do
            {
                Console.WriteLine("ile spałeś? a");

                entered = Console.ReadKey();
                int CzasSnu = 0;

                if (!int.TryParse(entered.KeyChar.ToString(), out CzasSnu))
                {
                    Console.WriteLine("Zły znak");
                    continue;
                }

                Console.Clear();
                Console.WriteLine($"wpisałeś :{entered.KeyChar}");

                Show(CzasSnu);

            }
            while (entered.Key != ConsoleKey.Enter);

            Console.ReadKey();

        }

        private static void Show(int CzasSnu)
        {
            if (CzasSnu <= 3)
                Console.WriteLine("To była mała drzemka.Musze więcej spać.");
            else if (CzasSnu <= 5)
                Console.WriteLine("Czuje się wciąż zmęczony");
            else if (CzasSnu <= 7)
                Console.WriteLine("To był dobry sen.Ale mam mały ból głowy.");
            else if (CzasSnu <= 9)
                Console.WriteLine("Czuje się silniejszy");
            else if (CzasSnu <= 12)
                Console.WriteLine("Za długo spałem");
            else Console.WriteLine("Nie zrozumiała komenda");
        }

        private static int NewMethod()
        {
            return 0;
        }
    }
}
