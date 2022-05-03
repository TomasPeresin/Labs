using System;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            String inputTexto = "";
            while (b) {
                Console.WriteLine("Ingresar texto: ");
                inputTexto = Console.ReadLine();
                if (inputTexto.Length > 0) {
                    Console.WriteLine(inputTexto);
                    b = false;
                }
            }
            // Menu
            //while (b == false)
            //{
            //    Console.WriteLine("Mostrar la frase ingresada como:");
            //    Console.WriteLine("1: mayuscula");
            //    Console.WriteLine("2: minuscula");
            //    Console.WriteLine("3: largo");

            //    ConsoleKeyInfo opcion = Console.ReadKey();
            //    Console.WriteLine(opcion);
            //    if (opcion.Key == ConsoleKey.D1)
            //        Console.WriteLine(inputTexto.ToUpper());
            //    else if (opcion.Key == ConsoleKey.D2)
            //        Console.WriteLine(inputTexto.ToLower());
            //    else if (opcion.Key == ConsoleKey.D3)
            //        Console.WriteLine("El largo es: {0}", inputTexto.Length);
            //    else
            //    {
            //        Console.WriteLine("Dame un valor valido conchudo");
            //        b = true;
            //    }
            //}
            // AHORA CON CASE

            Console.WriteLine("Mostrar la frase ingresada como:");
            Console.WriteLine("1: mayuscula");
            Console.WriteLine("2: minuscula");
            Console.WriteLine("3: largo");

            ConsoleKeyInfo opcion = Console.ReadKey();
            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine(inputTexto.ToUpper());
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine(inputTexto.ToLower());
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("El largo es: {0}", inputTexto.Length);
                    break;
                default:
                    Console.WriteLine("Escribime algo valido gil");
                    break;
            }

        }

        
    }
}
