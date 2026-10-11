using Microsoft.Data.SqlClient;

namespace TechStore.Datos
{
    public class ConexionSql
    {
        private readonly string cadenaConexion =
            @"Server=GRACY\SQLEXPRESS;
              Database=SistemaGestionProductosDB;
              Integrated Security=True;
              Encrypt=True;
              TrustServerCertificate=True;";

        public SqlConnection CrearConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}