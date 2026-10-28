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

        // Agrega a la tabla la columna calculada del valor del inventario (Precio × Stock).
        // Esta columna se calcula en la aplicación y no se guarda en la base de datos.
        private void AgregarColumnaValorInventario(DataTable tabla)
        {
            tabla.Columns.Add("ValorInventario", typeof(decimal), "Precio * Stock");
        }

        public DataTable ObtenerProductos()
        {
            DataTable tabla = productoDatos.ObtenerProductos();
            AgregarColumnaValorInventario(tabla);
            return tabla;
        }

        public DataTable BuscarProductosPorNombre(string nombre)
        {
            DataTable tabla = productoDatos.BuscarProductosPorNombre(nombre);
            AgregarColumnaValorInventario(tabla);
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

            if (producto.Precio > 99999999.99m)
            {
                campoConError = "Precio";
                mensajeError = "El precio no puede superar 99 999 999,99.";
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

        // Método para obtener un resumen del inventario: total de productos,
        // productos con stock bajo y valor total del inventario.
        public (int TotalProductos, int ProductosStockBajo, decimal ValorTotalInventario)
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
