using System.Data;
using Microsoft.Data.SqlClient;
using TechStore.Entidades;

namespace TechStore.Datos
{
    public class CategoriaDatos
    {
        private readonly ConexionSql conexionSql = new ConexionSql();

        public DataTable ObtenerCategorias()
        {
            DataTable tablaCategorias = new DataTable();

            const string consulta =
                @"SELECT IdCategoria, Nombre, Descripcion
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

        public void Guardar(Categoria categoria)
        {
            const string consulta =
                @"INSERT INTO Categorias (Nombre, Descripcion)
                VALUES (@Nombre, @Descripcion);";

            using (SqlConnection conexion = conexionSql.CrearConexion())
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100)
                    .Value = categoria.Nombre;

                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 250)
                    .Value = categoria.Descripcion;

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}