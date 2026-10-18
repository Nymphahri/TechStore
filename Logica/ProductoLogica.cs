using System.Data;
using TechStore.Datos;
using TechStore.Entidades;

namespace TechStore.Logica
{
    public class ProductoLogica
    {
        private readonly ProductoDatos productoDatos = new ProductoDatos();

        public DataTable ObtenerProductos()
        {
            return productoDatos.ObtenerProductos();
        }

        public bool ValidarProducto(Producto producto, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                mensajeError = "El nombre del producto es obligatorio.";
                return false;
            }

            if (producto.Precio <= 0)
            {
                mensajeError = "El precio debe ser mayor que cero.";
                return false;
            }

            if (producto.Stock < 0)
            {
                mensajeError = "El stock no puede ser negativo.";
                return false;
            }

            if (producto.IdCategoria <= 0)
            {
                mensajeError = "Debe seleccionar una categoría.";
                return false;
            }

            mensajeError = string.Empty;
            return true;
        }

        public void GuardarProducto(Producto producto)
        {
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

        public DataTable BuscarProductosPorNombre(string nombre)
        {
            return productoDatos.BuscarProductosPorNombre(nombre);
        }
    }
}