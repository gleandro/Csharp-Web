using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Conexion
    {
        static SqlConnection conn;

        public void conectar()
        {
            conn = new SqlConnection("Data Source=localhost;Initial Catalog=empresa;User ID=sa;Password=sql");

            conn.Open();
        }

        public void salir()
        {
            conn.Close();
        }

        public static void ejecutar(string sql)
        {
            SqlCommand sql_c = new SqlCommand();
            sql_c.CommandText = sql;
            sql_c.Connection = conn;
            sql_c.ExecuteNonQuery();

        }


    }
}