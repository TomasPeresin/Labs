using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Jugada
    {
        private int _numero;
        private int _intentos;
        private bool _adivino = true;
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        internal bool Adivino
        {
            get { return _adivino; }
            set { _adivino = value; }
        }

        internal int Intentos
        {
            get { return _intentos; }
            set { _intentos = value; }
        }

        internal int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public void Comparar(int num)
        {
            if (Numero == num)
                Adivino = false;
            else
            {
                Intentos = Intentos + 1;
                Adivino = true;
            }
        }
    }
}