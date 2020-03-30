using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            double a = double.Parse(Console.ReadLine());
            if (a % 4 == 0 && a > 0)
                Console.WriteLine("Liczba {0} może być rokiem przestępnym.", a);
            else Console.WriteLine("Liczba {0} nie może być rokiem przestępnym.", a);
            Console.ReadKey();
        }
    }
}
