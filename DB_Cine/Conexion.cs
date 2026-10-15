using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DB_Cine
{
    internal class Conexion
    {   //Creen su App.config
        //Cambiar la cadena de conexion por la ruta de tu servidor en App.config
        readonly string connectionString = ConfigurationManager.ConnectionStrings["CadenaCine"].ConnectionString;


        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            return conexion;
        }
    }
}
