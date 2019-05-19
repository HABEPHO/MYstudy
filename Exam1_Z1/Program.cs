using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Z1
{
    //Zad_1 Egzamin 2018
    //Найти кол-во чисел которые на нечётных индексах которые делятся на 3 но не делятся на 7(одновременно)
    //и они должны быть больше либо равны среднее от простых чисел
    class Program
    {
        static bool CzyProstoe(int liczba)
        {
            int ile = 0;
            if (liczba == 0 || liczba == 1)
                return false;
            for (int i = 1; i <= liczba; i++)
            {
                if (liczba % i == 0)
                    ile++;
            }
            if (ile == 2)
                return true;
            else
                return false;

        }
        static double SredneeProstych(int[] tab)
        {
            double SumaProst = 0;
            double SrProst = 0;
            int IleProst = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (CzyProstoe(tab[i]))
                {
                    SumaProst += tab[i];
                    IleProst++;
                }
            }
            //Console.WriteLine("Suma prostych chisel: " + SumaProst);
            SrProst = SumaProst / IleProst;
            //Console.WriteLine("Srednee prostych: " + SrProst);
            return SrProst;
        }
        static int OsnovaZad1(int[] tab)
        {
            int ileLiczb = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 3 == 0 && tab[i] % 7 != 0 && tab[i] >= SredneeProstych(tab) && i % 2 != 0)
                {
                    ileLiczb++;
                }
            }
            return ileLiczb;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyProstoe(13));
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            SredneeProstych(tab);
            Console.WriteLine("Chisel sootvetstwujuschich uslowiju: " + OsnovaZad1(tab));
            Console.ReadKey();
        }
    }
}
