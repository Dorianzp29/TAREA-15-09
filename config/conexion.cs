using System;
using System.Data.SqlClient;

namespace _06Publicaciones.config
{
    public static class Conexion
    {
        private static readonly string connectionString;

        static Conexion()
        {
            // Aquí puedes establecer tu cadena de conexión. Se recomienda obtenerla de un archivo de configuración o variables de entorno.
            connectionString = "Server=DORIAN;Database=pubs;User Id=sa;Password=12345;";
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
