using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO1_Z4
{
    class A { }
    class B : A { }
    class C : B { }
    class I { }
    class J : I { }
    class E : J { }
    class D : E { }

    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A(), c = new C();
            I i = new I(), k = new D();
            J j = new E(), d = new D();
            Console.WriteLine(c is B);
            Console.WriteLine(i is J);
            Console.WriteLine(b is A);
            Console.WriteLine(d is A);
            Console.WriteLine(d is E);
            Console.WriteLine(k is E);
            Console.WriteLine(c is I);
            Console.ReadKey();
        }
    }
}
