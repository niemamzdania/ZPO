using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 3 boki trójkąta");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("Podano ujemną wartość boku. Wciśnij przycisk, aby zakończyć.");
                Console.ReadKey();
                return;
                //Environment.Exit(1);
            }
            if((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                Console.WriteLine("Podano boki o złych długościach. Wciśnij przycisk, aby zakończyć.");
                Console.ReadKey();
                return;
            }
            float obw = a + b + c;
            double pole = Math.Sqrt((obw / 2) * (obw / 2 - a) * (obw / 2 - b) * (obw / 2 - c));
            Console.WriteLine("Obwód: {0}, pole: {1}", obw, pole);
            Console.ReadKey();
        }
    }
}
