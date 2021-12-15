using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        class A
        {

        }
        class B:A
        {
            public object a;
        }
        class C:B
        {
            public object c;
            public object b;
        }
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            B b1 = new B();
            C c1 = new C();

            b1.a = a2;
            c1.a = a1;
            c1.b = b1;
            c1.c = a3;
        }
    }
}
