using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj szerokosc gwiazdy");
            int a = int.Parse(Console.ReadLine());

            int licznik;
            int liczbaPrzejsc;
            if (a % 2 == 0)
            {
                licznik = 2;
                liczbaPrzejsc = a - 1;
            }
            else
            {
                licznik = 1;
                liczbaPrzejsc = a;
            }
            
            int liczbaSpacji = (a - licznik) / 2;

            for(int i=0; i<liczbaPrzejsc; i++)
            {
                for (int j = 0; j < liczbaSpacji; j++)
                    Console.Write(" ");
                for (int j = 0; j < licznik; j++)
                    Console.Write("*");

                if(a % 2 == 0)
                {
                    if (i < a / 2 - 1)
                    {
                        liczbaSpacji--;
                        licznik += 2;
                    }
                    else
                    {
                        liczbaSpacji++;
                        licznik -= 2;
                    }
                }
                else if(a % 2 != 0)
                {
                    if(i < a / 2)
                    {
                        liczbaSpacji--;
                        licznik += 2;
                    }
                    else
                    {
                        liczbaSpacji++;
                        licznik -= 2;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
