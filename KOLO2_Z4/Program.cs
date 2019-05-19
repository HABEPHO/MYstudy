using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KOLO2_Z4
{
    class Program
    {
        public static void Metoda(string plik, string nazwa)
        {
            Assembly a = Assembly.LoadFrom(plik);
            Type[] types = a.GetTypes();
            int z = 0;
            foreach (var type in types)
            {
                if (type.IsClass)
                {
                    MethodInfo[] metods = type.GetMethods();

                    foreach (var metod in metods)
                    {
                        if (metod.Name == nazwa)
                        {
                            MethodInfo metoda = type.GetMethod(nazwa);
                            z++;
                            metoda.Invoke(type, metoda.GetParameters());

                        }
                    }
                }
            }
            if (z == 0) Console.WriteLine("nie ma metody o nazwie : {0}", nazwa);
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
