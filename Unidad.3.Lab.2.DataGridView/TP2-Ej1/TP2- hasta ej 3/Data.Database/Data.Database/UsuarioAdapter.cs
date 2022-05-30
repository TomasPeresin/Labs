using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public SqlDataAdapter DaUsuarios { get; set; }
        public SqlConnection Conn { get; set; }
        public UsuarioAdapter()
        {
            this.Conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=academia;Integrated Security=true;");
            this.DaUsuarios = new SqlDataAdapter("SELECT * FROM usuarios", this.Conn);

            this.DaUsuarios.UpdateCommand =
            new SqlCommand("UPDATE usuarios SET tipo_doc=@tipo_doc, nro_doc = @nro_doc, " +
            "fecha_nac = @fecha_nac, apellido = @apellido, nombre = @nombre, direccion =" +
            "@direccion, telefono = @telefono, email = @email, celular = @celular," +
            "usuario = @usuario, clave = @clave WHERE id=@id ", this.Conn);
            this.DaUsuarios.UpdateCommand.Parameters.Add("@tipo_doc", SqlDbType.Int, 1, "tipo_doc");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@nro_doc", SqlDbType.Int, 1, "nro_doc");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 1, "fecha_nac");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar, 50, "telefono");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 50, "email");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@celular", System.Data.SqlDbType.VarChar, 50, "celular");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@clave", System.Data.SqlDbType.VarChar, 50, "clave");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@id", System.Data.SqlDbType.Int, 1, "id");
            
            this.DaUsuarios.InsertCommand =
            new SqlCommand("INSERT INTO usuarios(tipo_doc,nro_doc,fecha_nac,apellido,nombre,direccion,telefono,email,celular," +
            "usuario,clave VALUES (@tipo_doc,@nro_doc,@fecha_nac,@apellido,@nombre,@direccion,@telefono,@email,@celular," +
            "@usuario,@clave)", this.Conn);
            this.DaUsuarios.InsertCommand.Parameters.Add("@tipo_doc", System.Data.SqlDbType.Int, 1, "tipo_doc");
            this.DaUsuarios.InsertCommand.Parameters.Add("@nro_doc", System.Data.SqlDbType.Int, 1, "nro_doc");
            this.DaUsuarios.InsertCommand.Parameters.Add("@fecha_nac", System.Data.SqlDbType.DateTime, 1, "fecha_nac");
            this.DaUsuarios.InsertCommand.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar, 50, "apellido");
            this.DaUsuarios.InsertCommand.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre");
            this.DaUsuarios.InsertCommand.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion");
            this.DaUsuarios.InsertCommand.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar, 50, "telefono");
            this.DaUsuarios.InsertCommand.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 50, "email");
            this.DaUsuarios.InsertCommand.Parameters.Add("@celular", System.Data.SqlDbType.VarChar, 50, "celular");
            this.DaUsuarios.InsertCommand.Parameters.Add("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario");
            this.DaUsuarios.InsertCommand.Parameters.Add("@clave", System.Data.SqlDbType.VarChar, 50, "clave");
            this.DaUsuarios.InsertCommand.Parameters.Add("@id", System.Data.SqlDbType.Int, 1, "id");

            this.DaUsuarios.DeleteCommand =
                new SqlCommand("DELETE FROM usuarios WHERE id=@id ", this.Conn);
            this.DaUsuarios.DeleteCommand.Parameters.Add("@id", System.Data.SqlDbType.Int, 1, "id");
        }

        //Deberia devolver Usuario
        public bool GetUsuario(string usr, string pasw)
        {
            DataTable Cuentas = new DataTable();
            Cuentas = GetAll();
            foreach (DataRow cuenta in Cuentas.Rows)
            {
                if (cuenta["usuario"].ToString() == usr && cuenta["clave"].ToString() == pasw)
                {
                    return true;
                }
            }
            return false;

        }
        public DataTable GetAll()
        {
            DataTable dtUsuarios = new DataTable();
            this.DaUsuarios.Fill(dtUsuarios);
            return dtUsuarios;
        }

        //public Business.Entities.Usuario GetOne(int ID)
        //{
        //    return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
        //}

        //public void Delete(int ID)
        //{
        //    Usuarios.Remove(this.GetOne(ID));
        //}

        public void GuardarCambios(DataTable dtUsuarios)
        {
            this.DaUsuarios.Update(dtUsuarios);
            dtUsuarios.AcceptChanges();
        }

        //public void Save(Usuario usuario)
        //{
        //    if (usuario.State == BusinessEntity.States.New)
        //    {
        //        int NextID = 0;
        //        foreach (Usuario usr in Usuarios)
        //        {
        //            if (usr.ID > NextID)
        //            {
        //                NextID = usr.ID;
        //            }
        //        }
        //        usuario.ID = NextID + 1;
        //        Usuarios.Add(usuario);
        //    }
        //    else if (usuario.State == BusinessEntity.States.Deleted)
        //    {
        //        this.Delete(usuario.ID);
        //    }
        //    else if (usuario.State == BusinessEntity.States.Modified)
        //    {
        //        Usuarios[Usuarios.FindIndex(delegate(Usuario u) { return u.ID == usuario.ID; })]=usuario;
        //    }
        //    usuario.State = BusinessEntity.States.Unmodified;            
        //}
    }
}
