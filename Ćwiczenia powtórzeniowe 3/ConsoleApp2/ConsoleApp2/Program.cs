using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Matematyka
    {
        public static float pi = (float)3.14;

        public static float ObliczObwod(float r)
        {
            float obwod = 2 * pi * r;

            return obwod;
        }

        public static float ObliczPole(float r)
        {
            float pole = pi * (float)Math.Pow(r, 2);

            return pole;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float promien = 5;
            Console.WriteLine("Promień koła: " + promien);
            Console.WriteLine("Obwód: {0}; pole: {1}", Matematyka.ObliczObwod(promien), Matematyka.ObliczPole(promien));
            Console.ReadKey();
        }
    }
}
