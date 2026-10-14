using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace DB_Cine
{
    internal class Conexion
    {
        //Cambiar la cadena de conexion por la ruta de tu servidor
        readonly string connectionString = "Data Source=LAPTOP-T2IEASM2\\DS3;" +
            "Initial Catalog=Cine;Integrated Security=True;Encrypt=True;" +
            "TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            return conexion;
        }
    }
}
