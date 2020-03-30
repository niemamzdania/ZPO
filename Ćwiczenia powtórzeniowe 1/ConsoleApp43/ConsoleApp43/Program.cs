using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współczynniki a, b równania liniowego ax+b=0");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            if((a == 0 && b == 0))
            {
                Console.WriteLine("Rozwiązaniem są wszyskie liczby rzeczywiste.");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("Równanie sprzeczne. Brak rozwiązań");
            }
            else
            {
                float c = (-b) / a;
                Console.WriteLine("Rozwiązanie równania: x=" + c);
            }

            Console.ReadKey();
        }
    }
}
