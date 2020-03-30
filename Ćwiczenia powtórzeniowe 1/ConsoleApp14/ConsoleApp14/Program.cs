using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liczbyPierwsze = new List<int>();
            int liczba = 2;
            int ile_dzielnikow;
            while(true)
            {
                ile_dzielnikow = 0;
                for(int i=1; i<=liczba; i++)
                {
                    if (liczba % i == 0)
                        ile_dzielnikow++;
                }
                if (ile_dzielnikow == 2)
                    liczbyPierwsze.Add(liczba);
                if (liczbyPierwsze.Count() == 100)
                    break;
                liczba++;
            }
            foreach (var liczbaPierwsza in liczbyPierwsze)
                Console.Write(liczbaPierwsza + " ");
            Console.ReadKey();
        }
    }
}
