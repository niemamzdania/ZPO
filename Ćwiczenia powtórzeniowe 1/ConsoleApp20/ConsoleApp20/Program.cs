using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe dodatnia");
            int a = int.Parse(Console.ReadLine());
            int licznik = a;
            while (licznik > 0)
            {
                for (int i = licznik; i > 0; i--)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                licznik--;
            }
            Console.ReadKey();
        }
    }
}
