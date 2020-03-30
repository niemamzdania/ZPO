using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby");
            int dzielna = int.Parse(Console.ReadLine());
            int dzielnik = int.Parse(Console.ReadLine());

            try
            {
                int iloraz = dzielna / dzielnik;
                Console.WriteLine("Iloraz tych liczb wynosi: " + iloraz);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
