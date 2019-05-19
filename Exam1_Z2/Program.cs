using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Z2
{
    //Zad_2 Egzamin 2018

    //Mamy podany tekst w którym są jak duże tak i małe litery oddzielone dowolnym znakiem. 
    //Należy zwrócić wyraz, który ma więcej spółgłosek niż samogłosek.
    //A jeżeli takich jest więcej, to zwraca ostatni wyraz w napisie, 
    //który to zawiera, w dodatku jeśli nie ma takiego wyrazu - zwraca spację

    class Program
    {
        static bool Czy_z_Alfabetu(char a)
        {
            if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z')
                return true;
            return false;
        }
        static bool Czy_Samogloska(char a)
        {
            if (a == 'e' || a == 'E' ||
                a == 'y' || a == 'Y' ||
                a == 'u' || a == 'U' ||
                a == 'i' || a == 'I' ||
                a == 'o' || a == 'O' ||
                a == 'a' || a == 'A')
            {
                return true;
            }
            return false;
        }
        static string Znajdz(string wyraz)
        {
            wyraz += " ";
            string Ostatni = " ";
            string Slowo = "";
            int samoG = 0;
            int wsplG = 0;
            for (int i = 0; i < wyraz.Length; i++)
            {
                if (Czy_z_Alfabetu(wyraz[i]))
                {
                    if (Czy_Samogloska(wyraz[i]))
                    {
                        Slowo += wyraz[i];
                        samoG++;
                    }
                    else
                    {
                        Slowo += wyraz[i];
                        wsplG++;
                    }
                }
                else
                {
                    if (wsplG > samoG)
                    {
                        Ostatni = Slowo;
                    }
                    Slowo = "";
                    wsplG = 0;
                    samoG = 0;
                }


            }
            return Ostatni;
        }
        static void Main(string[] args)
        {
            string Wyraz = "aaaa rtrtrtrtrtrt";
            Console.WriteLine(Znajdz(Wyraz));
            Console.ReadKey();
        }
    }
}
