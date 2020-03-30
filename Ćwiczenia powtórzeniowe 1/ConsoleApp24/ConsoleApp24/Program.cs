using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę stopni kąta");
            float stopnie = float.Parse(Console.ReadLine());
            float radiany = stopnie * ((float)Math.PI / 180);
            Console.WriteLine("Kąt w radianach: " + radiany);
            Console.ReadKey();
        }
    }
}
