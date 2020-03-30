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

        public override string ToString()
        {
            return "Przesłonięta metoda ToString() w klasie Osoba";
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

        public override string ToString()
        {
            string zmienna = base.ToString();
            return zmienna + "\nPrzesłonięta metoda ToString() w klasie Student";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba student1 = new Student();
            Console.WriteLine(student1.ToString());

            Console.ReadKey();
        }
    }
}
