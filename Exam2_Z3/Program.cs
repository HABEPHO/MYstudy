using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_Z3
{
    interface IKolejka<T>
    {
        int Rozmiar(); //podaje rozmiar
        void Dodaj(T i); //dodaje element
        bool Usuń(); //usuwa element z początku
        T Pokaz(); //pokazuje element na początku
    }
    class KolejkaPriorytowa<T> : IKolejka<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        List<T> MyList = new List<T>();


        public void Dodaj(T a)
        {
            if (Rozmiar() > 0)
            {
                for (int i = 0; i < MyList.Count; i++)
                {
                    if (a.CompareTo(MyList[i]) < 1)
                    {
                        MyList.Insert(i, a);
                        return;
                    }

                }
            }
            MyList.Add(a);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in MyList)
            {
                yield return item;
            };
        }

        public T Pokaz()
        {
            if (MyList.Count < 1)
            {
                throw new Exception("Brak elementów");
            }
            else
            {
                return MyList.First();
            }
        }

        public int Rozmiar()
        {
            return MyList.Count;
        }

        public bool Usuń()
        {
            if (MyList.Count == 0)
            {
                throw new Exception("Brak elementów");
            }
            MyList.RemoveAt(0);

            return true;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            KolejkaPriorytowa<int> kolejka = new KolejkaPriorytowa<int>();

            kolejka.Dodaj(7);
            kolejka.Dodaj(3);
            kolejka.Dodaj(9);
            kolejka.Dodaj(5);
            kolejka.Dodaj(0);


            foreach (var item in kolejka)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
