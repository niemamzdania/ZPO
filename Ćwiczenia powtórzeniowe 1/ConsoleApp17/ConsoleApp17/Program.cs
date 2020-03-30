using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę w systemie sesnastkowym");
            string liczba = Console.ReadLine();
            Console.WriteLine("Liczba w systemie dziesiętnym: " + Convert.ToInt32(liczba, 16));
            Console.ReadKey();
        }
    }
}
