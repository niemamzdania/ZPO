using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class School : ICloneable
    {
        private List<Classroom> cls;
        private string address;

        public School()
        {
            cls = new List<Classroom>();
        }

        public School(string address, List<Classroom> cls)
        {
            this.address = address;
            this.cls = cls;
        }

        public Classroom GetFirstClassroom()
        {
            return this.cls[0];
        }

        public Object Clone()
        {
            return MemberwiseClone();
        }

        public School GlebokaKopia()
        {
            School temp = new School();
            temp.address = this.address;

            for (int i = 0; i < this.cls.Count; i++)
            {
                Classroom tempClassroom = this.cls[i].GlebokaKopia();
                temp.cls.Add(tempClassroom);
            }

            return temp;
        }
    }

    class Classroom : ICloneable
    {
        private List<Pupil> pupils;
        private string className;

        public Classroom()
        {
            pupils = new List<Pupil>();
        }

        public Classroom(string className, List<Pupil> pupils)
        {
            this.className = className;
            this.pupils = pupils;
        }

        public Object Clone()
        {
            return MemberwiseClone();
        }

        public Pupil GetFirstPupil()
        {
            return this.pupils[0];
        }

        public Classroom GlebokaKopia()
        {
            Classroom temp = new Classroom();
            temp.className = this.className;
           
            for(int i=0; i<this.pupils.Count; i++)
            {
                Pupil tempPupil = this.pupils[i].GlebokaKopia();
                temp.pupils.Add(tempPupil);
            }

            return temp;
        }
    }

    class Pupil : ICloneable
    {
        private string name;

        public Pupil() { }

        public Pupil(string name)
        {
            this.name = name;
        }

        public Object Clone()
        {
            return MemberwiseClone();
        }

        public Pupil GlebokaKopia()
        {
            Pupil temp = new Pupil();
            temp.name = this.name;
            return temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new Pupil("pupil1");
            Pupil pupil2 = (Pupil)pupil1.Clone();
            Pupil pupil3 = pupil1.GlebokaKopia();

            if (Object.ReferenceEquals(pupil1, pupil2))
                Console.WriteLine("Obiekty klasy Pupil po płytkiej kopii odwołują się do tego samego obiektu.");
            else Console.WriteLine("Obiekty klasy Pupil po płytkiej kopii nie odwołują się do tego samego obiektu.");

            if (Object.ReferenceEquals(pupil1, pupil3))
                Console.WriteLine("Obiekty klasy Pupil po głębokiej kopii odwołują się do tego samego obiektu.\n");
            else Console.WriteLine("Obiekty klasy Pupil po głębokiej kopii nie odwołują się do tego samego obiektu.\n");

            Pupil pupilek1 = new Pupil("pupilek1");
            List<Pupil> pupilki1 = new List<Pupil>();
            pupilki1.Add(pupilek1);

            Classroom classroom1 = new Classroom("classroom1", pupilki1);
            Classroom classroom2 = (Classroom)classroom1.Clone();
            Classroom classroom3 = classroom1.GlebokaKopia();

            Pupil pobranyPupil1 = classroom1.GetFirstPupil();
            Pupil pobranyPupil2 = classroom2.GetFirstPupil();
            Pupil pobranyPupil3 = classroom3.GetFirstPupil();


            if (Object.ReferenceEquals(pobranyPupil1, pobranyPupil2))
                Console.WriteLine("Obiekty klasy Pupil z klasy Classroom po płytkiej kopii odwołują się do tego samego obiektu.");
            else Console.WriteLine("Obiekty klasy Pupil z klasy Classroom po płytkiej kopii nie odwołują się do tego samego obiektu.");

            if (Object.ReferenceEquals(pobranyPupil1, pobranyPupil3))
                Console.WriteLine("Obiekty klasy Pupil z klasy Classroom po głębokiej kopii odwołują się do tego samego obiektu.\n");
            else Console.WriteLine("Obiekty klasy Pupil z klasy Classroom po głębokiej kopii nie odwołują się do tego samego obiektu.\n");

            Pupil pupilek2 = new Pupil("pupilek2");
            List<Pupil> pupilki2 = new List<Pupil>();
            pupilki2.Add(pupilek2);

            Classroom klasa1 = new Classroom("klasa1", pupilki2);
            List<Classroom> klasy = new List<Classroom>();
            klasy.Add(klasa1);

            School school1 = new School("school1", klasy);
            School school2 = (School)school1.Clone();
            School school3 = school1.GlebokaKopia();

            Classroom pobranaKlasa1 = school1.GetFirstClassroom();
            Classroom pobranaKlasa2 = school2.GetFirstClassroom();
            Classroom pobranaKlasa3 = school3.GetFirstClassroom();

            Pupil pobranyPupilek1 = pobranaKlasa1.GetFirstPupil();
            Pupil pobranyPupilek2 = pobranaKlasa2.GetFirstPupil();
            Pupil pobranyPupilek3 = pobranaKlasa3.GetFirstPupil();

            if (Object.ReferenceEquals(pobranaKlasa1, pobranaKlasa2))
                Console.WriteLine("Obiekty klasy Classroom z klasy School po płytkiej kopii odwołują się do tego samego obiektu.");
            else Console.WriteLine("Obiekty klasy Classroom z klasy School po płytkiej kopii nie odwołują się do tego samego obiektu.");

            if (Object.ReferenceEquals(pobranaKlasa1, pobranaKlasa3))
                Console.WriteLine("Obiekty klasy Classroom z klasy School po głębokiej kopii odwołują się do tego samego obiektu.\n");
            else Console.WriteLine("Obiekty klasy Classroom z klasy School po głębokiej kopii nie odwołują się do tego samego obiektu.\n");

            if (Object.ReferenceEquals(pobranyPupilek1, pobranyPupilek2))
                Console.WriteLine("Obiekty klasy Pupil z klasy School po płytkiej kopii odwołują się do tego samego obiektu.");
            else Console.WriteLine("Obiekty klasy Pupil z klasy School po płytkiej kopii nie odwołują się do tego samego obiektu.");

            if (Object.ReferenceEquals(pobranyPupilek1, pobranyPupilek3))
                Console.WriteLine("Obiekty klasy Pupil z klasy School po głębokiej kopii odwołują się do tego samego obiektu.");
            else Console.WriteLine("Obiekty klasy Pupil z klasy School po głębokiej kopii nie odwołują się do tego samego obiektu.");

            Console.ReadKey();
        }
    }
}
