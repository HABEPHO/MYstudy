using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_Z4
{
    public delegate void MyDelegate(int n, string m);
    class Nadzorca
    {
        public static void Eventic(int n, string m)
        {
            Console.WriteLine(m);
            Console.WriteLine("Liczba towaru: {0}", n);
        }
    }
    class Magazyn
    {
        int Stan;
        int Pojemnosc;
        public Magazyn(int Stan, int Pojemnosc)
        {
            this.Stan = Stan;
            this.Pojemnosc = Pojemnosc;
        }
        public event MyDelegate Operacja;
        public event MyDelegate Alarm;

        public void Dostawa(int n, string m)
        {
            if (Stan + n <= Pojemnosc)
            {
                Stan += n;
                Operacja(Stan, "Dostawa");
            }
            else
            {
                Alarm(Stan, "Brak mejsca");
            }

        }
        public void Wydanie(int n, string m)
        {
            if (Stan >= n)
            {
                Stan -= n;
                Operacja(Stan, "Wydanie");
            }
            else
            {
                Alarm(Stan, "Brak towaru");
            }

        }

        //public void Eventic(int n, string m)
        //{
        //    Console.WriteLine(m);
        //    Console.WriteLine("Liczba towaru: {0}",n);
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Magazyn m1 = new Magazyn(5, 10);
            m1.Operacja += Nadzorca.Eventic;
            m1.Alarm += Nadzorca.Eventic;
            m1.Dostawa(11, "Cos");
            m1.Wydanie(3, "Cos");
            m1.Wydanie(3, "Cos");
            Console.ReadKey();
        }
    }
}
