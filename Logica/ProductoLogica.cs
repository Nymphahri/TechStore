using System.Data;
using TechStore.Datos;
using TechStore.Entidades;

namespace TechStore.Logica
{
    // Clase que contiene la lógica de negocio para la gestión de productos.
    public class ProductoLogica
    {
        private readonly ProductoDatos productoDatos = new ProductoDatos();

        public const int LimiteStockBajo = 5;

        // Método para obtener todos los productos, incluyendo una columna calculada para el valor del inventario.
        public DataTable ObtenerProductos()
        {
            DataTable tabla = productoDatos.ObtenerProductos();
            tabla.Columns.Add("ValorInventario", typeof(decimal), "Precio * Stock");
            return tabla;
        }

        // Método para obtener productos con stock bajo, según el límite definido.
        public DataTable ObtenerProductosStockBajo()
        {
            return productoDatos.ObtenerProductosStockBajo(
                LimiteStockBajo
            );
        }

        // Método para validar los datos de un producto antes de guardarlo o actualizarlo.
        public bool ValidarProducto(Producto producto, out string campoConError, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                campoConError = "Nombre";
                mensajeError = "El nombre del producto es obligatorio.";
                return false;
            }

            if (producto.Precio <= 0)
            {
                campoConError = "Precio";
                mensajeError = "El precio debe ser mayor que cero.";
                return false;
            }

            if (producto.Stock < 0)
            {
                campoConError = "Stock";
                mensajeError = "El stock no puede ser negativo.";
                return false;
            }

            if (producto.IdCategoria <= 0)
            {
                campoConError = "Categoria";
                mensajeError = "Debe seleccionar una categoría.";
                return false;
            }

            campoConError = string.Empty;
            mensajeError = string.Empty;
            return true;
        }

        // Método para buscar productos por nombre, incluyendo una columna calculada para el valor del inventario.
        public DataTable BuscarProductosPorNombre(string nombre)
        {
            DataTable tabla = productoDatos.BuscarProductosPorNombre(nombre);
            tabla.Columns.Add("ValorInventario", typeof(decimal), "Precio * Stock");
            return tabla;
        }

        // Método para obtener un resumen del inventario, incluyendo el total de productos y la cantidad de productos con stock bajo.
        public (int TotalProductos, int ProductosStockBajo)
            ObtenerResumenInventario()
        {
            return productoDatos.ObtenerResumenInventario(
                LimiteStockBajo
            );
        }

        public void GuardarProducto(Producto producto)
        {
            producto.FechaRegistro = DateTime.Now;
            productoDatos.GuardarProducto(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            productoDatos.ActualizarProducto(producto);
        }

        public void EliminarProducto(int idProducto)
        {
            productoDatos.EliminarProducto(idProducto);
        }
    }
}
