using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        protected class Kwadrat
        {
            private float a;

            public Kwadrat(float a)
            {
                this.a = a;
            }

            public float ObliczObwod()
            {
                return 4 * this.a;
            }

            public float ObliczPole()
            {
                return Convert.ToSingle(Math.Pow(this.a, 2));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj bok kwadratu");
            float a = float.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Podano ujemną wartość boku. Wciśnij przycisk, aby zakończyć.");
                Console.ReadKey();
                return;
                //Environment.Exit(1);
            }

            Kwadrat kwa = new Kwadrat(a);
            float obw = kwa.ObliczObwod();
            float pole = kwa.ObliczPole();

            Console.WriteLine("Obwód: {0}, pole: {1}", obw, pole);
            Console.ReadKey();
        }
    }
}
