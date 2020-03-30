using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<6; i++)
            {
                for(int j=0; j<6; j++)
                {
                    Console.WriteLine(i + "*" + j + "=" + i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
