using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioAdapter UsuarioData { get; set; }
        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }
        //public Usuario GetOne(int id)
        //{
        //    return UsuarioData.GetOne(id);
        //}

        public DataTable GetAll()
        {
            return UsuarioData.GetAll();
        }
        //public void Deleted(int id)
        //{
        //    UsuarioData.Delete(id);
        //}

        public void Guardarcambios(DataTable dtUsuarios)
        {
            UsuarioData.GuardarCambios(dtUsuarios);
        }
        public bool Ingreso(string usr, string pasw)
        {
            return UsuarioData.GetUsuario(usr, pasw);
        }
    }
}
