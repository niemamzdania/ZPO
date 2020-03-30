using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            string a = Console.ReadLine();
            int suma = 0;
            foreach(char znak in a)
            {
                suma += int.Parse(znak.ToString());
            }
            Console.WriteLine("Suma: " + suma);
            Console.ReadKey();
        }
    }
}
