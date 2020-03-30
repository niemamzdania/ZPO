using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj godzinę, minuty i sekundy.");
            int godzina = int.Parse(Console.ReadLine());
            int minuta = int.Parse(Console.ReadLine());
            int sekunda = int.Parse(Console.ReadLine());

            int[] godziny = new int[24];
            int[] minutySekundy = new int[60];

            for (int i = 0; i < 24; i++)
                godziny[i] = i + 1;
            for (int i = 0; i < 60; i++)
                minutySekundy[i] = i + 1;

            if (godziny.Contains(godzina) && minutySekundy.Contains(minuta) && minutySekundy.Contains(sekunda))
                Console.WriteLine("{0}:{1}:{2} - poprawna godzina", godzina, minuta, sekunda);
            else Console.WriteLine("Błędna godzina");
            
            Console.ReadKey();
        }
    }
}
