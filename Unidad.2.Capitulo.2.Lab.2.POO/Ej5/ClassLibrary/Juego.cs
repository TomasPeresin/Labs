using System;

namespace ClassLibrary
{
    public class Juego
    {
        private int _record;

        public Juego()
        {
            _record = 0;
        }

        public void ComenzarJuego()
        {
            Console.WriteLine("Bienvenido al adivinar numero");
            Jugada j = PreguntarMaximo();
            while (j.Adivino && j.Intentos < 4)
            {
                j = PreguntarNumero(j);
                Continuar(j);
            }
            if (j.Adivino && j.Intentos == 4)
            {
                Console.WriteLine("Paso el numero maximo de intentos, el numero era {0}", j.Numero);
            }
            else if (j.Adivino == false)
            {
                Console.WriteLine("Felicidades acerto el numero {0}", j.Numero);
                CompararRecord(j);
            }
        }

        private void CompararRecord(Jugada j)
        {
            if (j.Intentos < _record)
            {
                _record = j.Intentos;
                Console.WriteLine("Felicidades por su nuevo record de {0} intentos", _record);
            }
            else
            {
                Console.WriteLine("No supero su record anterior de {0} intentos", _record);
            }
        }

        private void Continuar(Jugada j)
        {
            if (j.Adivino)
            {
                Console.WriteLine("No adivino el numero");
            }
            else
            {
                Console.WriteLine("Felicidades por adivinar el numero");
            }
        }

        private Jugada PreguntarMaximo()
        {
            Console.WriteLine("Ingrese valor maximo: ");
            int max = Int16.Parse((Console.ReadLine()));
            Jugada j = new Jugada(max); 
            return j;
        }

        private Jugada PreguntarNumero(Jugada j)
        {
            Console.WriteLine("Ingrese valor: ");
            int numero = Int16.Parse((Console.ReadLine()));
            j.Comparar(numero);
            return j;
        }
    }
}
