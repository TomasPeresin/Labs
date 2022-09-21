using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"server=.\SQLEXPRESS;Initial Catalog=academia;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM usuarios;";

                    SqlDataReader dr = cmd.ExecuteReader();

                    while(dr.Read())
                    {
                        string nombre = dr["nombre"].ToString();
                        string apellido = dr["apellido"].ToString();

                        Console.WriteLine(nombre + " " + apellido);
                    }
                    dr.Close();
                }
            }
            Console.ReadKey();
        }

    }
}
