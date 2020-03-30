using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0)
                Console.WriteLine("Liczba {0} jest podzielna przez {1}", a, b);
            else Console.WriteLine("Liczba {0} nie jest podzielna przez {1}", a, b);

            Console.ReadKey();
        }
    }
}
