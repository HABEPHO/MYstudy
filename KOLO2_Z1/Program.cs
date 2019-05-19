using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO2_Z1
{
    interface IProporcyonalny
    {
        bool prop(Wektor w2);
    }
    class Wektor : IComparable<Wektor>, IProporcyonalny
    {
        int[] tablica = new int[4];
        public Wektor(int a, int b, int c, int d)
        {
            tablica[0] = a;
            tablica[1] = b;
            tablica[2] = c;
            tablica[3] = d;
        }
        public Wektor(int[] a)
        {
            tablica = a;
        }
        public override string ToString()
        {
            string s = "";
            foreach (int item in tablica)
            {
                s += item;
            }
            return s;
        }
        public int CompareTo(Wektor other)
        {
            return (int)(Math.Sqrt(Math.Pow(tablica[0], 2) + Math.Pow(tablica[1], 2) + Math.Pow(tablica[2], 2) + Math.Pow(tablica[3], 2)) -
                Math.Sqrt(Math.Pow(other.tablica[0], 2) + Math.Pow(other.tablica[1], 2) + Math.Pow(other.tablica[2], 2) + Math.Pow(other.tablica[3], 2)));
        }

        public bool prop(Wektor w2)
        {
            double a = ((double)tablica[0] / w2.tablica[0]);
            double b = ((double)tablica[0] / w2.tablica[0]);
            double c = ((double)tablica[0] / w2.tablica[0]);
            double d = ((double)tablica[0] / w2.tablica[0]);
            return (a == b) && (b == c) && (c == d);
        }
        public static bool operator ==(Wektor w1, Wektor w2)
        {
            return w1.CompareTo(w2) == 0;
        }
        public static bool operator !=(Wektor w1, Wektor w2)
        {
            return !(w1 == w2);
        }
        public static Wektor operator +(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.tablica[0] + w2.tablica[0], w1.tablica[1] + w2.tablica[1],
                w1.tablica[2] + w2.tablica[2], w1.tablica[3] + w2.tablica[3]);
        }
        public static Wektor operator -(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.tablica[0] - w2.tablica[0], w1.tablica[1] - w2.tablica[1],
                w1.tablica[2] - w2.tablica[2], w1.tablica[3] - w2.tablica[3]);
        }
        public static Wektor operator *(Wektor w1, int a)
        {
            if (a == 0)
                return null;
            return new Wektor(w1.tablica[0] * a, w1.tablica[1] * a, w1.tablica[2] * a, w1.tablica[3] * a);
        }
        public static Wektor operator /(Wektor w1, int a)
        {
            if (a == 0)
                return null;
            return new Wektor(w1.tablica[0] / a, w1.tablica[1] / a, w1.tablica[2] / a, w1.tablica[3] / a);
        }
        public static Wektor operator %(Wektor w1, int a)
        {
            if (a == 0)
                return null;
            return new Wektor(w1.tablica[0] % a, w1.tablica[1] % a, w1.tablica[2] % a, w1.tablica[3] % a);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Wektor w1 = new Wektor(1, 2, 3, 4);
            Wektor w2 = new Wektor(1, 2, 3, 4);
            Console.WriteLine(w1.prop(w2));
            Console.WriteLine(w2 % 3);
            Console.WriteLine(w2 / 0);
            Console.WriteLine(w1.CompareTo(w2));
            Console.WriteLine(w1 + w2);
            Console.ReadKey();
        }
    }
}
