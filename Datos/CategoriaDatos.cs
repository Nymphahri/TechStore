using System.Data;
using Microsoft.Data.SqlClient;

namespace TechStore.Datos
{
    public class CategoriaDatos
    {
        private readonly ConexionSql conexionSql = new ConexionSql();

        public DataTable ObtenerCategorias()
        {
            DataTable tablaCategorias = new DataTable();

            const string consulta =
                @"SELECT IdCategoria,
                         Nombre,
                         Descripcion
                  FROM Categorias
                  ORDER BY Nombre;";

            using (SqlConnection conexion = conexionSql.CrearConexion())
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                conexion.Open();
                adaptador.Fill(tablaCategorias);
            }

            return tablaCategorias;
        }
    }
}