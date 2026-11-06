using Microsoft.Data.SqlClient;
using System.Data;
using TechStore.Datos;
using TechStore.Entidades;

namespace TechStore.Logica
{
    // Clase que contiene la lógica de negocio para la gestión de productos.
    public class ProductoLogica
    {
        // SQL Server rechaza la relación cuando la categoría ya no existe.
        private const int ErrorRelacionConCategoria = 547;

        private readonly ProductoDatos productoDatos = new ProductoDatos();

        public const int LimiteStockBajo = 5;

        // Agrega a la tabla la columna calculada del valor del inventario Precio × Stock.
        // Esta columna se calcula en la aplicación de forma temporal y no se guarda en la base de datos.
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

            // Al convertir el precio a centavos, no debe quedar una fracción.
            if ((producto.Precio * 100) % 1 != 0)
            {
                campoConError = "Precio";
                mensajeError = "El precio debe tener como máximo dos decimales.";
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

        public bool GuardarProducto(Producto producto, out string campoConError, out string mensajeError)
        {
            if (ValidarProducto(producto, out campoConError, out mensajeError) == false)
            {
                return false;
            }

            producto.FechaRegistro = DateTime.Now;
            try
            {
                productoDatos.GuardarProducto(producto);
                return true;
            }

            catch (SqlException errorBaseDatos)
            {
                // Las reglas de precio y stock ya se comprobaron antes de guardar.
                if (errorBaseDatos.Number == ErrorRelacionConCategoria)
                {
                    campoConError = "Categoria";
                    mensajeError = "La categoría seleccionada ya no está disponible. " +
                        "Cierre y vuelva a abrir Productos para actualizar las categorías.";
                    return false;
                }

                // Los demás errores conservan el manejo general del formulario.
                throw;
            }
        }

        public bool ActualizarProducto(Producto producto, out string campoConError, out string mensajeError)
        {
            if (producto.IdProducto <= 0)
            {
                campoConError = "Seleccion";
                mensajeError = "Seleccione un producto antes de modificar.";
                return false;
            }

            if (ValidarProducto(producto, out campoConError, out mensajeError) == false)
            {
                return false;
            }

            try
            {
                int filasAfectadas = productoDatos.ActualizarProducto(producto);
                if (filasAfectadas == 0)
                {
                    campoConError = "Seleccion";
                    mensajeError = "El producto ya no existe. Actualice la lista antes de continuar.";
                    return false;
                }
                return true;
            }

            catch (SqlException errorBaseDatos)
            {
                // Las reglas de precio y stock ya se comprobaron antes de guardar.
                if (errorBaseDatos.Number == ErrorRelacionConCategoria)
                {
                    campoConError = "Categoria";
                    mensajeError = "La categoría seleccionada ya no está disponible. " +
                        "Cierre y vuelva a abrir Productos para actualizar las categorías.";
                    return false;
                }

                // Los demás errores conservan el manejo general del formulario.
                throw;
            }
        }

        public bool EliminarProducto(int idProducto, out string mensajeError)
        {
            mensajeError = string.Empty;
            if (idProducto <= 0)
            {
                mensajeError = "Seleccione un producto antes de eliminar.";
                return false;
            }

            int filasAfectadas = productoDatos.EliminarProducto(idProducto);
            if (filasAfectadas == 0)
            {
                mensajeError = "El producto ya no existe. Actualice la lista antes de continuar.";
                return false;
            }

            return true;
        }
    }
}
