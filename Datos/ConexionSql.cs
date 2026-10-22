using Microsoft.Data.SqlClient;

namespace TechStore.Datos
{
    // Clase para manejar la conexión a la base de datos SQL Server
    public class ConexionSql
    {
        // Cadena de conexión a la base de datos
        private readonly string cadenaConexion =
            @"Server=.\SQLEXPRESS;Database=TechStoreDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public SqlConnection CrearConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                using SqlConnection conexion = CrearConexion();
                conexion.Open();
                return true;
            }

            catch (SqlException)
            {
                return false;
            }
        }

    }
}