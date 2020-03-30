using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie");
            string zdanie = Console.ReadLine();
            zdanie = zdanie.Trim('.');
            string[] wyrazy = zdanie.Split(' ');
            foreach(string wyraz in wyrazy.Reverse())
            {
                Console.WriteLine(wyraz);
            }

            Console.ReadKey();
        }
    }
}
