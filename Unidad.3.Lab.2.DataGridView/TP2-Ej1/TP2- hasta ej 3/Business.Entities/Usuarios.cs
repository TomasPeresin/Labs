using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuarios
    {
        public Usuarios()
        {
            
        }
        public int ID { get; set; }
        public int Tipo_Doc { get; set; }
        public int Nro_Doc { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }
        public string Celular { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        //public bool Habilitado { get; set; }
        //public BusinessEntity.States State { get; set; }
    }
}
