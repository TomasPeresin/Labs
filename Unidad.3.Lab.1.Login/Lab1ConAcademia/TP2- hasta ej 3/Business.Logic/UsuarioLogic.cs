using System;
using System.Collections.Generic;
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
        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public void Deleted(int id)
        {
            UsuarioData.Delete(id);
        }

        public void Save(Usuario usr)
        {
            UsuarioData.Save(usr);
        }
        public bool Ingreso(string usr, string pasw)
        {
            return UsuarioData.GetUsuario(usr, pasw);
        }
    }
}
