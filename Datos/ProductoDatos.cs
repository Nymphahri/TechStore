using System.Data;
using Microsoft.Data.SqlClient;
using TechStore.Entidades;

namespace TechStore.Datos
{
    // Clase para manejar operaciones de datos relacionadas con productos
    public class ProductoDatos
    {
        // Instancia de la clase ConexionSql para manejar la conexión a la base de datos
        private readonly ConexionSql conexionSql = new ConexionSql();

        // Método privado para crear un parámetro SQL para el precio con precisión y escala específica
        private SqlParameter CrearParametroPrecio(decimal precio)
        {
            SqlParameter parametro = new SqlParameter("@Precio", SqlDbType.Decimal);
            parametro.Precision = 10;
            parametro.Scale = 2;
            parametro.Value = precio;
            return parametro;
        }

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
                    c.Nombre AS Categoria
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
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = producto.Nombre;

                comando.Parameters.Add(CrearParametroPrecio(producto.Precio));

                comando.Parameters.Add("@Stock", SqlDbType.Int).Value = producto.Stock;

                comando.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = producto.FechaRegistro;

                comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = producto.IdCategoria;

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public DataTable BuscarProductosPorNombre(string nombre)
        {
            DataTable tablaProductos = new DataTable();

            const string consulta =
                @"SELECT p.IdProducto,
                    p.Nombre,
                    p.Precio,
                    p.Stock,
                    p.FechaRegistro,
                    p.IdCategoria,
                    c.Nombre AS Categoria
                FROM Productos p
                INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
                WHERE p.Nombre LIKE @Nombre
                ORDER BY p.Nombre;";

            using (SqlConnection conexion = conexionSql.CrearConexion())
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = "%" + nombre + "%";

                conexion.Open();
                adaptador.Fill(tablaProductos);
            }

            return tablaProductos;
        }

        public void ActualizarProducto(Producto producto)
        {
            const string consulta =
                @"UPDATE Productos
                SET Nombre = @Nombre,
                    Precio = @Precio,
                    Stock = @Stock,
                    IdCategoria = @IdCategoria
                WHERE IdProducto = @IdProducto;";

            using (SqlConnection conexion = conexionSql.CrearConexion())
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.Add("@IdProducto", SqlDbType.Int).Value = producto.IdProducto;

                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = producto.Nombre;

                comando.Parameters.Add(CrearParametroPrecio(producto.Precio));

                comando.Parameters.Add("@Stock", SqlDbType.Int).Value = producto.Stock;

                comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = producto.IdCategoria;

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(int idProducto)
        {
            const string consulta =
                @"DELETE FROM Productos
                WHERE IdProducto = @IdProducto;";

            using (SqlConnection conexion = conexionSql.CrearConexion())
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.Add("@IdProducto", SqlDbType.Int).Value = idProducto;

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public (int TotalProductos, int ProductosStockBajo)ObtenerResumenInventario(int limiteStock)
        {
            const string consulta = @"
                SELECT
                    COUNT(*) AS TotalProductos,
                    COALESCE(
                        SUM(
                            CASE
                                WHEN Stock <= @LimiteStock THEN 1
                                ELSE 0
                            END
                        ), 0
                    ) AS ProductosStockBajo
                FROM Productos;";

            using SqlConnection conexion = conexionSql.CrearConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.Add("@LimiteStock", SqlDbType.Int).Value = limiteStock;

            conexion.Open();

            using SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                int total = Convert.ToInt32(lector["TotalProductos"]);
                int stockBajo = Convert.ToInt32(lector["ProductosStockBajo"]);

                return (total, stockBajo);
            }

            return (0, 0);
        }

        public DataTable ObtenerProductosStockBajo(int limiteStock)
        {
            DataTable tablaProductos = new DataTable();

            const string consulta = @"
                SELECT
                    p.Nombre,
                    p.Stock,
                    c.Nombre AS Categoria,
                    CASE
                        WHEN p.Stock <= @LimiteStock THEN 'Stock bajo'
                        ELSE 'Disponible'
                    END AS Estado
                FROM Productos p
                INNER JOIN Categorias c
                    ON p.IdCategoria = c.IdCategoria
                WHERE p.Stock <= @LimiteStock
                ORDER BY p.Stock ASC, p.Nombre;";

            using (SqlConnection conexion = conexionSql.CrearConexion())
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                comando.Parameters.Add("@LimiteStock", SqlDbType.Int).Value = limiteStock;

                conexion.Open();
                adaptador.Fill(tablaProductos);
            }

            return tablaProductos;
        }
    }
}