using System.Data;
using Microsoft.Data.SqlClient;
using TechStore.Entidades;

namespace TechStore.Datos
{
    public class ProductoDatos
    {
        private readonly ConexionSql conexionSql = new ConexionSql();

        public DataTable ObtenerProductos()
        {
            DataTable tablaProductos = new DataTable();

            const string consulta =
                @"SELECT p.IdProducto,
                        p.Nombre,
                        p.Precio,
                        p.Stock,
                        p.FechaRegistro,
                        p.IdCategoria,
                        c.Nombre AS Categoria,
                        p.Precio * p.Stock AS ValorInventario
                 FROM Productos p
                 INNER JOIN Categorias c
                        ON p.IdCategoria = c.IdCategoria
                 ORDER BY p.Nombre;";

            using (SqlConnection conexion = conexionSql.CrearConexion())
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                conexion.Open();
                adaptador.Fill(tablaProductos);
            }

            return tablaProductos;
        }

        public void GuardarProducto(Producto producto)
        {
            const string consulta =
                @"INSERT INTO Productos (Nombre, Precio, Stock, FechaRegistro, IdCategoria)
                 VALUES (@Nombre, @Precio, @Stock, @FechaRegistro, @IdCategoria);";

            using (SqlConnection conexion = conexionSql.CrearConexion())
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100)
                    .Value = producto.Nombre;

                comando.Parameters.Add("@Precio", SqlDbType.Decimal)
                    .Value = producto.Precio;

                comando.Parameters.Add("@Stock", SqlDbType.Int)
                    .Value = producto.Stock;

                comando.Parameters.Add("@FechaRegistro", SqlDbType.DateTime)
                    .Value = producto.FechaRegistro;

                comando.Parameters.Add("@IdCategoria", SqlDbType.Int)
                    .Value = producto.IdCategoria;

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}