using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO2_Z2
{
    interface IStos<T>
    {
        int Rozmiar(); //podaje rozmiar
        T Poloz(T i); //kładzie element na stos zwraca położony element
        T Zdejmij(); // zdejmuje element z wierzchu stosu i zwraca zdjęty
        T Podejrzyj(); //odczytuje element z wierzchu stosu
    }
    [Serializable]
    class Stos<T> : IStos<T>, IEnumerable<T>
    {
        LinkedList<T> stos = new LinkedList<T>();
        int roz = 0;

        public T Podejrzyj()
        {
            if (roz < 1) throw new Exception("Za mały Rozmiar");
            return stos.Last<T>();
        }
        public T Poloz(T i)
        {
            stos.AddLast(i);
            roz++;
            return i;
        }
        public int Rozmiar()
        {
            if (roz < 0) throw new Exception("Za mały rozmiar");
            return roz;
        }
        public T Zdejmij()
        {
            if (roz < 1) throw new Exception("Za mały rozmiar");
            T s = stos.Last<T>();
            stos.RemoveLast();
            roz--;
            return s;
        }

        public static T operator +(Stos<T> stos, T i)
        {
            T g = stos.Poloz(i);
            return g;
        }
        public static T operator -(Stos<T> stos)
        {

            return stos.Zdejmij();

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < roz; i++)
            {
                T s = stos.Last<T>();
                stos.RemoveLast();
                yield return s;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        [Serializable]
        class Osoba
        {
            protected string imie;
            public Osoba(string imie)
            {
                this.imie = imie;
            }
            public override string ToString()
            {
                return imie;
            }
        }
        [Serializable]
        class Student : Osoba
        {
            private int index;

            public Student(string imie, int index) : base(imie)
            {

                this.index = index;
            }
            public override string ToString()
            {
                return imie + "," + index;
            }
        }

    }
    [Serializable]
    class Osoba
    {
        protected string imie;
        public Osoba(string imie)
        {
            this.imie = imie;
        }
        public override string ToString()
        {
            return imie;
        }
    }
    [Serializable]
    class Student : Osoba
    {
        private int index;

        public Student(string imie, int index) : base(imie)
        {

            this.index = index;
        }
        public override string ToString()
        {
            return imie + "," + index;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
