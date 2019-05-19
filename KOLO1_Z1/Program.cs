using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO1_Z1
{
    class Program
    {
        class Student
        {
            string Imie;
            string Nazwisko;
            int Index;
            public Student(string Imie, string Nazwisko, int Index)
            {
                this.Imie = Imie;
                this.Nazwisko = Nazwisko;
                this.Index = Index;
            }
            public int index
            {
                get { return Index; }
            }
            public override string ToString()
            {
                return Imie + " " + Nazwisko + " " + Index;
            }
        }
        class Grupa
        {
            string Nazwa;
            static Student[] ArrayOfStudents;
            private static int counter = 0;
            public Grupa(string Nazwa, int rozmiar)
            {
                this.Nazwa = Nazwa;
                ArrayOfStudents = new Student[rozmiar];
            }
            public override string ToString()
            {
                string Wszystko = "";
                for (int i = 0; i < ArrayOfStudents.Length; i++)
                {
                    if (ArrayOfStudents[i] != null)
                        Wszystko += ArrayOfStudents[i] + "\n";
                }
                return Wszystko;
            }

            public static void DodajStudenta(string Imie, string Nazwisko, int Index)
            {
                Student st = new Student(Imie, Nazwisko, Index);
                ArrayOfStudents[counter] = st;
                counter++;
            }

            public void UsunStudenta(int index)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (ArrayOfStudents[i].index == index)
                    {
                        ArrayOfStudents[i] = null;
                    }
                }

            }
            //Чтобы метод работал как статический, статическим также должен быть массив
            public static void Zapish(string plik)
            {
                StreamWriter sw = new StreamWriter(plik);
                for (int i = 0; i < ArrayOfStudents.Length; i++)
                {
                    if (ArrayOfStudents[i] != null)
                    {
                        sw.WriteLine(ArrayOfStudents[i]);
                    }
                }
                sw.Close();
            }
            public static void Zczytaj(string plik)
            {
                //Считывает из файла 
                StreamReader sr = new StreamReader(plik);
                //Метод StreamReader.Peek() Возвращает следующий доступный символ, но не использует его.
                while (sr.Peek() > -1)
                {
                    string buf = sr.ReadLine();
                    string[] sep = buf.Split(' ');
                    DodajStudenta(sep[0], sep[1], Convert.ToInt32(sep[2]));
                }
                sr.Close();
            }
        }
        static void Main(string[] args)
        {
            Grupa g1 = new Grupa("Grupawuszeczka", 10);
            //g1.DodajStudenta("Ivan", "Durak", 6969);
            //g1.DodajStudenta("Egor", "Kozak", 18);
            Grupa.DodajStudenta("Evgeni", "Mavlevich", 13);
            Grupa.DodajStudenta("Egor", "Kozak", 228);
            Console.WriteLine(g1);
            g1.UsunStudenta(000001);
            Console.WriteLine("Prowerka");
            Console.WriteLine(g1);
            Grupa.Zapish("Students");
            //g1.Zapish("Fail");
            //g1.DodajStudenta("Evgeni", "Mavlevich", 17);
            //g1.Zapish("Fail");
            Grupa.Zczytaj("Plik.txt");
            Console.WriteLine("Kontrolnaja tochka");
            Console.WriteLine(g1);
            Console.ReadKey();
        }
    }
}
