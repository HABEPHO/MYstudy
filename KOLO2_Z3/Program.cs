using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO2_Z3
{
    public delegate void MyEventHandler(object sender, int n, string s);
    class Sklep
    {
        int liczbaKlientow;
        public event MyEventHandler Zmiana;
        public void wejscie()
        {
            liczbaKlientow++;
            Zmiana(this, liczbaKlientow, "Wejscie klienta ");
        }
        public void wyjscie()
        {
            if (liczbaKlientow >= 1)
            {
                liczbaKlientow--;
                Zmiana(this, liczbaKlientow, "Wyjscie klienta");
            }
            else
                Zmiana(this, 0, "W sklepie nie ma klientów");
        }
        public void Evencik(object sender, int n, string s)
        {
            Console.WriteLine(s);
            Console.WriteLine("Bierząca liczba klientów w sklepie: {0}", n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sklep s1 = new Sklep();
            s1.Zmiana += s1.Evencik;
            s1.wyjscie();
            s1.wejscie();
            s1.wejscie();
            s1.wejscie();
            s1.wyjscie();
            Console.ReadKey();
        }
    }
}
