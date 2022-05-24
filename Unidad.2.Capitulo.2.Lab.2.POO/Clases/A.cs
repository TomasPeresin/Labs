using System;

namespace Clases
{
    public class A
    {
        public String NombreInstancia { get; set; }

        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }
        public A(string nom)
        {
            NombreInstancia = nom;
        }
        public string MostraNombre()
        {
            return NombreInstancia;
        }
        public void M1()
        {
            Console.WriteLine("Se invoco M1");
        }
        public void M2()
        {
            Console.WriteLine("Se invoco M2");
        }
        public void M3()
        {
            Console.WriteLine("Se invoco M3");
        }
    }
}
