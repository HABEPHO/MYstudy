using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_Z1
{
    class Pracownik : ICloneable, IComparable<Pracownik>
    {
        string Imie;
        string Nazwisko;
        int Staż;
        public Pracownik(string Imie, string Nazwisko, int Staż)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Staż = Staż;
        }
        public override string ToString()
        {
            return Imie + " " + Nazwisko + " " + Staż;
        }

        public object Clone()
        {
            return new Pracownik(Imie, Nazwisko, Staż)
            {
                Imie = this.Imie,
                Nazwisko = this.Nazwisko,
                Staż = this.Staż
            };
        }

        public int CompareTo(Pracownik other)
        {
            return Imie.CompareTo(other.Imie) + Nazwisko.CompareTo(other.Nazwisko);
        }

        public string nazwisko
        {
            get { return Nazwisko; }
        }
        public virtual string Obowiązki()
        {
            return "Jakieś obowiązki";
        }
    }

    class Programista : Pracownik
    {
        string Pensja;
        public Programista(string Imie, string Nazwisko, int Staż, string Pensja) :
            base(Imie, Nazwisko, Staż)
        {
            this.Pensja = Pensja;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Pensja;
        }

        public override string Obowiązki()
        {
            return "Twożenie Bagów";
        }

    }

    class Firma : IComparable<Firma>
    {
        string Nazwa;
        List<Pracownik> Pracowniki;
        public Firma(string Nazwa, List<Pracownik> Pracowniki)
        {
            this.Nazwa = Nazwa;
            this.Pracowniki = Pracowniki;
        }
        public override string ToString()
        {
            string Wszystko = "";
            Wszystko += Nazwa + "\n";
            for (int i = 0; i < Pracowniki.Count; i++)
            {
                if (Pracowniki[i] != null)
                {
                    Wszystko += Pracowniki[i] + "\n";
                }
            }
            return Wszystko;
        }

        public void DodajPracownika(string Imie, string Nazwisko, int Staż)
        {
            Pracownik p1 = new Pracownik(Imie, Nazwisko, Staż);
            Pracowniki.Add(p1);
        }
        public void UsunPracownika(string Nazwisko)
        {
            for (int i = 0; i < Pracowniki.Count; i++)
            {
                if (Pracowniki[i].nazwisko == Nazwisko)
                {
                    Pracowniki.Remove(Pracowniki[i]);
                }
            }
        }

        public int CompareTo(Firma other)
        {
            return Pracowniki.Count.CompareTo(Pracowniki.Count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Egor", "Kozak", 1);
            Pracownik p2 = new Pracownik("Evgeni", "Mavlevich", 2);
            Pracownik p3 = new Pracownik("Pasza", "Sziszka", 0);
            Pracownik p5 = new Pracownik("Adam", "Adamcewicz", 3);

            List<Pracownik> l1 = new List<Pracownik>();
            l1.Add(p1);
            l1.Add(p2);
            l1.Add(p3);
            l1.Add(p5);
            foreach (Pracownik p in l1)
            {
                Console.WriteLine(p);
            }
            l1.Sort();
            Console.WriteLine();
            foreach (Pracownik p in l1)
            {
                Console.WriteLine(p);
            }
            Firma f1 = new Firma("SGGW", l1);
            Console.WriteLine(f1);
            f1.UsunPracownika("Mavlevich");
            Console.WriteLine(f1);

            Pracownik p4 = (Pracownik)p2.Clone();
            Console.WriteLine(p4);
            Console.ReadKey();
        }
    }
}
