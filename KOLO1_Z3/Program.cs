using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO1_Z3
{
    abstract class Maszyna
    {
        private int moc;
        private int cena;
        private string opis;
        public Maszyna(int moc, int cena, string opis)
        {
            this.moc = moc;
            this.cena = cena;
            this.opis = opis;
        }
        public abstract void Jazda();
        public abstract void Stop();
        public abstract void Start();
        abstract protected string Typ { get; }
        public override string ToString()
        {
            return moc + " " + cena + " " + opis;
        }
        public int Porownaj(Maszyna m)
        {
            if (this.moc > m.moc)
                return 1;
            if (this.moc < m.moc)
                return -1;
            else
                return 0;
        }


    }
    class Kombajn : Maszyna
    {
        public Kombajn(int moc, int cena, string opis) : base(moc, cena, opis)
        {
        }
        public override void Jazda()
        {
            Console.WriteLine("Kombajn Jedzie");
        }
        public override void Start()
        {
            Console.WriteLine("Kombajn Pojechal");
        }
        public override void Stop()
        {
            Console.WriteLine("Kombajn stal");
        }
        protected override string Typ
        {
            get { return "Kombajn"; }
        }
        public override string ToString()
        {
            return "Kombajn" + base.ToString();
        }

    }
    class Traktor : Maszyna
    {
        public Traktor(int moc, int cena, string opis) : base(moc, cena, opis)
        {
        }
        public override void Jazda()
        {
            Console.WriteLine("Traktor Jedzie");
        }
        public override void Start()
        {
            Console.WriteLine("Traktor Pojechal");
        }
        public override void Stop()
        {
            Console.WriteLine("Traktor stal");
        }
        public override string ToString()
        {
            return "Traktor" + base.ToString();
        }
        protected override string Typ
        {
            get { return "Traktor"; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Maszyna> l = new List<Maszyna>();
            Kombajn k1 = new Kombajn(200, 3000, "bialy");
            Maszyna k2 = new Kombajn(300, 8000, "czerwony");
            Traktor t1 = new Traktor(200, 2000, "bez dachu(kabri)");
            Maszyna t2 = new Traktor(500, 9000, "z przycepem");


            l.Add(k1);
            l.Add(k2);
            l.Add(t1);
            l.Add(t2);
            foreach (var maczyna in l)
            {
                Console.WriteLine(maczyna);
            }
            Console.WriteLine("k2 mocniejszy od t1? ");
            if (k2.Porownaj(t1) > 0)
            {
                Console.WriteLine("tak");
            }
            else
            {
                Console.WriteLine("nie");
            }

            Console.ReadKey();
        }
    }
}
