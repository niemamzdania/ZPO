using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 3 liczby, oddziel je przecinkiem");
            int[] liczby = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if (liczby[0] >= liczby[1] && liczby[0] >= liczby[2] && liczby[1] >= liczby[2])
                Console.WriteLine("Liczby posortowane malejąco: {0}, {1}, {2}", liczby[0], liczby[1], liczby[2]);
            else if(liczby[0] >= liczby[1] && liczby[0] >= liczby[2] && liczby[2] >= liczby[1])
                Console.WriteLine("Liczby posortowane malejąco: {0}, {1}, {2}", liczby[0], liczby[2], liczby[1]);
            else if (liczby[1] >= liczby[0] && liczby[1] >= liczby[2] && liczby[0] >= liczby[2])
                Console.WriteLine("Liczby posortowane malejąco: {0}, {1}, {2}", liczby[1], liczby[0], liczby[2]);
            else if (liczby[1] >= liczby[0] && liczby[1] >= liczby[2] && liczby[2] >= liczby[0])
                Console.WriteLine("Liczby posortowane malejąco: {0}, {1}, {2}", liczby[1], liczby[2], liczby[0]);
            else if (liczby[2] >= liczby[0] && liczby[2] >= liczby[1] && liczby[0] >= liczby[1])
                Console.WriteLine("Liczby posortowane malejąco: {0}, {1}, {2}", liczby[2], liczby[0], liczby[1]);
            else if (liczby[2] >= liczby[0] && liczby[2] >= liczby[1] && liczby[1] >= liczby[0])
                Console.WriteLine("Liczby posortowane malejąco: {0}, {1}, {2}", liczby[2], liczby[1], liczby[0]);
            Console.ReadKey();
        }
    }
}
