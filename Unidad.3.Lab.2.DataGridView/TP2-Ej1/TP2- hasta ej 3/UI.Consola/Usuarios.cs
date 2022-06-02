using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios : BusinessLogic
    {
        public UsuarioLogic UsuarioNegocio { get; set; }
        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();
        }
        public void Menu()
        {
            Boolean ope = true;
            while (ope)
            {
                Console.WriteLine("1) Listado General");
                Console.WriteLine("2) Consulta");
                Console.WriteLine("3) Agregar");
                Console.WriteLine("4) Modificar");
                Console.WriteLine("5) Eliminar");
                Console.WriteLine("6) Salir");
                ConsoleKeyInfo opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        ListadoGeneral();
                        break;
                    case ConsoleKey.D2:
                        Consultar();
                        break;
                    case ConsoleKey.D3:
                        Agregar();
                        break;
                    case ConsoleKey.D4:
                        Modificar();
                        break;
                    case ConsoleKey.D5:
                        Eliminar();
                        break;
                    case ConsoleKey.D6:
                        ope = false;
                        Console.Clear();
                        break;
                }
            }
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Business.Entities.Usuarios usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void MostrarDatos(Business.Entities.Usuarios usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tapellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.EMail);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            // \t dentro de un string representa un TAB
            Console.WriteLine();
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Business.Entities.Usuarios usuario = UsuarioNegocio.GetOne(ID);
                Console.Write("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.Write("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese Email: ");
                usuario.EMail = Console.ReadLine();
                Console.Write("Ingrese Habilitación de Usuario (1-Si/otro-No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Agregar()
        {
            Business.Entities.Usuarios usuario = new Business.Entities.Usuarios();

            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese Clave: ");
            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese Email: ");
            usuario.EMail = Console.ReadLine();
            Console.Write("Ingrese Habilitación de Usuario (1-Si/otro-No): ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario); Console.WriteLine();
            Console.WriteLine("ID: {0}", usuario.ID);
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Deleted(ID);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
