using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_Z2
{
    [AttributeUsage(AttributeTargets.Class)]
    class dekor : Attribute
    {
        string name;
        public string Name
        {
            get { return name; }
        }
        public dekor(string name)
        {
            this.name = name;
        }

    }
    [dekor("Co kolwiek")]
    //[Serializable]
    class Pracownik
    {
        string Imie;
        string Nazwisko;
        int StażPracy;
        public Pracownik(string Imie, string Nazwisko, int StażPracy)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.StażPracy = StażPracy;
        }
        public override string ToString()
        {
            return Imie + " " + Nazwisko + " " + StażPracy;
        }
    }
    class Programista : Pracownik
    {
        string Specjalizacja;
        public Programista(string Imie, String Nazwisko, int StażPracy, string Specjalizacja) :
            base(Imie, Nazwisko, StażPracy)
        {
            this.Specjalizacja = Specjalizacja;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Pracownik p1 = new Pracownik("Ivan", "Durak", 7);
            //Pracownik p2 = new Pracownik("Boris", "Britwa", 4);
            //Pracownik p3 = new Pracownik("Toni", "Montana", 8);
            //List<Pracownik> l1 = new List<Pracownik>();
            //l1.Add(p1);
            //l1.Add(p2);
            //l1.Add(p3);

            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream fs = new FileStream("Pracownicy.dat", FileMode.Create);
            //bf.Serialize(fs, l1);
            //fs.Close();

            //List<Pracownik> l2 = new List<Pracownik>();
            //BinaryFormatter ds = new BinaryFormatter();
            //FileStream fd = new FileStream("Pracownicy.dat", FileMode.Open);
            //l2 = (List<Pracownik>)ds.Deserialize(fd);
            //fs.Close();

            //Console.WriteLine("Prowerka");
            //foreach (Pracownik item in l2)
            //{
            //    Console.WriteLine(item);
            //}
            Type type = typeof(Pracownik);

            object[] atr = type.GetCustomAttributes(false);

            foreach (dekor item in atr)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
