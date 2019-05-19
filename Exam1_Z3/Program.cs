using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Z3
{
    class Program
    {
        static int Pomnoz(int[] tablica, int a, int b, int i = 0)
        {
            int wynik = 1;
            int j;
            if (i == 0)
            {
                for (j = 0; j < tablica.Length; j++)
                {
                    if (tablica[j] % a == 0 || tablica[j] % b != 0)
                    {
                        break;
                    }
                    if (j == tablica.Length)
                        return int.MaxValue;
                }
            }
            if (i == tablica.Length)
            {
                return wynik;
            }
            if (tablica[i] % a == 0 || tablica[i] % b != 0)
            {
                wynik = tablica[i];
            }
            return wynik * Pomnoz(tablica, a, b, i + 1);
        }
        // Wersja Pana Eugeniusza
        static double Iloczyn(double[] tabl, double x, double y, int i = 0)
        {
            if (tabl.Length == 0)
            {
                return double.NaN;
            }
            if (i == tabl.Length)
            {
                int k = 0, count = 0;
                while (k < tabl.Length)
                {
                    if (tabl[i] > x && tabl[i] < y)
                    {
                        count++;
                    }
                    k++;
                }
                if (count == 0)
                {
                    return double.NaN;
                }
                return 1;
            }
            if (tabl[i] > x && tabl[i] < y)
            {
                return tabl[i] * Iloczyn(tabl, x, y, i + 1);
            }

            return Iloczyn(tabl, x, y, i + 1);
        }
        static void Main(string[] args)
        {
        }
    }
}
