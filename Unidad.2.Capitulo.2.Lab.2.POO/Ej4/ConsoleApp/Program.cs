using System;
using Lab2Ej4;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Tomas", "Pereisn", 22, 42126550);
            Console.WriteLine("Nombre: {0}", p.Nombre);
            Console.WriteLine("Apellido: {0}", p.Apellido);
            Console.WriteLine("Edad: {0}", p.Edad);
            Console.WriteLine("Dni: {0}", p.DNI);
            Console.WriteLine("Nombre y apellido: {0}", p.GetFullName());
            Console.WriteLine("Edad calculada: {0}", p.GetAge());
            p = new Persona();
            Console.ReadKey();
        }
    }
}
