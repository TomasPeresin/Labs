using System;
using Clases;

namespace LabClases1
{
    class ProgramLab1
    {
        static void Main(string[] args)
        {
            A a = new A();
            A aotro = new A("Otro");
            B b = new B();
            a.M1();
            a.M2();
            a.M3();
            b.M1();
            b.M2();
            b.M3();
            b.M4();
            Console.WriteLine(a.MostraNombre());
            Console.WriteLine(aotro.MostraNombre());
            Console.WriteLine(b.MostraNombre());
        }
    }
}
