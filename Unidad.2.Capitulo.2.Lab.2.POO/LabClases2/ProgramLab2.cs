using System;
using Clases;

namespace LabClases2
{
    class ProgramLab2
    {
        static void Main(string[] args)
        {
            D d = new D();
            C c = d;
            c.F();
            d.F();
            c.G();
            d.G();

            Console.ReadKey();
        }
    }
}
