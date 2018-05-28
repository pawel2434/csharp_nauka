using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int CzasSnu;
            Console.WriteLine("ile spałeś");
            CzasSnu = 8;

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

            Console.ReadKey();
        }
    }
}
