using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba % 2 == 0)
                Console.WriteLine("Liczba parzysta");
            else Console.WriteLine("Liczba nieparzysta");

            Console.ReadKey();
        }
    }
}
