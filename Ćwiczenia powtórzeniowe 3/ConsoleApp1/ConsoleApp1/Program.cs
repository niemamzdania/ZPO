using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        public static readonly int iloscKol;
        public const int iloscDrzwi = 4;

        private Car() { }

        private Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }

        static Car()
        {
            iloscKol = 4;
        }

        public static Car Create(double pojemnoscSilnika, string marka)
        {
            return new Car(pojemnoscSilnika, marka);
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car samochod = Car.Create(1896, "Skoda");
            int iloscDrzwi = Car.iloscDrzwi;
            int iloscKol = Car.iloscKol;
            Console.WriteLine("Ilość drzwi: {0}, ilość kół: {1}", iloscDrzwi, iloscKol);

            Console.ReadKey();
        }
    }
}

