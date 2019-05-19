using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO1_Z2
{
    //Metody rozszerzone - статический класс, статический метод, в метод передаём значение через this
    //Вызывается в маине через первый параметр
    static class SuperString
    {
        public static string Odwroc(this string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            string newStr = "";
            for (int i = 0; i < array.Length; i++)
            {
                newStr += array[i];
            }
            return newStr;
        }
        public static int Ile(this string str, char ch)
        {
            int count = 0;
            char[] array = str.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ch)
                {
                    count++;
                }
            }
            return count;
        }
        //метод Replace Возвращает новую строку, в которой все вхождения заданной строки
        //в текущем экземпляре заменены другой заданной строкой. 
        public static string Usun(this string str, string toCut)
        {
            str = str.Replace(toCut, "");
            return str;
        }
        public static string Skroc(this string str, int n)
        {
            string newStr = "";
            char[] array = str.ToCharArray();
            for (int i = 0; i < n - n / 2; i++)
            {
                newStr += array[i];
            }
            for (int i = array.Length - n / 2; i < array.Length; i++)
            {
                newStr += array[i];
            }
            return newStr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "AblaKadabra";
            Console.WriteLine("Изначальный текст: " + str);
            Console.WriteLine(str.Odwroc());
            Console.WriteLine(str.Ile('a'));
            Console.WriteLine(str.Usun("Abra"));
            Console.WriteLine(str.Usun("Ka"));
            Console.WriteLine(str.Skroc(4));
            Console.ReadKey();
        }
    }
}
