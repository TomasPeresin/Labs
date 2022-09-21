using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int a = 0; static int b;

        public static void Main(string[] args)
        {
            if (HacerA() || HacerB())
                Console.Write(" (Suma) a + b = " + (a + b).ToString());

            if (HacerA() && HacerB())
                Console.Write(" (Resta) a - b = " + (a - b).ToString());
            Console.ReadLine();
        }

        static bool HacerA() { a++; return (a > b); }

        static bool HacerB() { b++; return (a > b); }
    }


}
