using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace U4Lab4
{
    class ContactosMySQL : Contactos
    {
        private string connectionString
        {
            get
            {
                //return "server=localhost;database=academia;Integrated Security=true;";
                return @"DataSource=.\SQLEXPRESS;Initial Catalog=academia;uid=net;pwd=net;";
                //return @"Server=localhost;Database=academia;Integrated Security=SSPI;";
                //return @"Persist Security Info=False;Integrated Security=true;Initial Catalog=academia;Server=localhost";
            }
        }
        public override DataTable getTabla()
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmdSelect = new MySqlCommand("select * from usuarios", conn);
                conn.Open();
                MySqlDataReader reader = cmdSelect.ExecuteReader();
                DataTable contactos = new DataTable();
                if (reader != null)
                {
                    contactos.Load(reader);
                }
                conn.Close();
                return contactos;
            }
        }
        public override void aplicaCambios()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmdInsert = new MySqlCommand("insert into contactos" +
                "values(@id,@nombre,@apellido,@email,@telefono)", conn);
                cmdInsert.Parameters.Add("@id", MySqlDbType.Int32);
                cmdInsert.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@email", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@celular", MySqlDbType.VarChar);
                MySqlCommand cmdUpdate = new MySqlCommand(
                "update contactos set nombre=@nombre, apellido=@apellido, " +
                "email=@email,celular=@celular where id=@id", conn);
                cmdUpdate.Parameters.Add("@id", MySqlDbType.Int32);
                cmdUpdate.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@celular", MySqlDbType.VarChar);
                MySqlCommand cmdDelete = new MySqlCommand("delete from contactos where id=@id",
                conn);
                cmdDelete.Parameters.Add("@id", MySqlDbType.Int32);
                DataTable filasNuevas = this.misContactos.GetChanges(DataRowState.Added);
                DataTable filasBorradas = this.misContactos.GetChanges(DataRowState.Deleted);
                DataTable filasModificadas = this.misContactos.GetChanges(DataRowState.Modified);
                conn.Open();
                if (filasNuevas != null)
                {
                    foreach (DataRow fila in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value = fila["id"];
                        cmdInsert.Parameters["@nombre"].Value = fila["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = fila["apellido"];
                        cmdInsert.Parameters["@email"].Value = fila["email"];
                        cmdInsert.Parameters["@celular"].Value = fila["celular"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }
                if (filasBorradas != null)
                {
                    foreach (DataRow fila in filasBorradas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = fila["id", DataRowVersion.Original];
                        cmdDelete.ExecuteNonQuery();
                    }
                }
                if (filasModificadas != null)
                {
                    foreach (DataRow fila in filasModificadas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = fila["id"];
                        cmdUpdate.Parameters["@nombre"].Value = fila["nombre"];
                        cmdUpdate.Parameters["@apellido"].Value = fila["apellido"];
                        cmdUpdate.Parameters["@email"].Value = fila["email"];
                        cmdUpdate.Parameters["@celular"].Value = fila["celular"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                conn.Close();
                this.misContactos.AcceptChanges();
            }
        }
    }
}
