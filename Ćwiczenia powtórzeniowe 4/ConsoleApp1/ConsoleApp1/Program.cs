using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Osoba
    {
        public string imie;
        public string nazwisko;

        public Osoba() { }
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imię: {0}, nazwisko: {1}", imie, nazwisko);
        }
    }

    class Student : Osoba
    {
        public int rokStudiow;
        public int numerGrupy;
        public int numerAlbumu;

        public Student() { }
        public Student(int rokStudiow, int numerGrupy, int numerAlbumu)
        {
            this.rokStudiow = rokStudiow;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok studiów: {0}, numer grupy: {1}, numer albumu: {2}", rokStudiow, numerGrupy, numerAlbumu);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba student1 = new Student();
            student1.WypiszInfo();

            Console.ReadKey();
        }
    }
}
