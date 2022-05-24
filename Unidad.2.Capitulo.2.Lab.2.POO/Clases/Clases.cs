using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Clases
    {
        public class C
        {
            public void F() { Console.WriteLine("C.F"); }
            public virtual void G() { Console.WriteLine("C.G"); }
        }
        public class D : C
        {
            new public void F() { Console.WriteLine("D.F"); }
            public override void G() { Console.WriteLine("D.G"); }
        }
    }
}
