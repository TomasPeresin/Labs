using System;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            String[] arreglo = new String[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("Ingresar coso: ");
                arreglo[i] = Console.ReadLine();
            }

            for (int i = cantIteraciones - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}", arreglo[i]);
            }
        }
    }
}
