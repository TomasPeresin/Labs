using System;

namespace Lab2Ej4
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _dni;

        public Persona() { 
        }
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            Persona p = new Persona();
            _nombre = nombre;
            _apellido = apellido;
            _edad = edad;
            _dni = dni;
            Console.WriteLine("Creacion de objeto");
        }

        ~Persona()
        {
            Console.WriteLine("Destruccion de objeto");
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
            }
        }

        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public int DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public String GetFullName()
        {
            return (Nombre +" "+ Apellido);
        }

        public int GetAge()
        {
            return Edad;
        }
    }
}
