using Microsoft.Data.SqlClient;
using System.Data;
using TechStore.Datos;
using TechStore.Entidades;

namespace TechStore.Logica
{
    // Clase que contiene la lógica de negocio para la gestión de categorías.
    public class CategoriaLogica
    {
        // Códigos definidos por SQL Server para restricciones de la base de datos.
        private const int ErrorRegistroDuplicado = 2627;
        private const int ErrorRelacionConProductos = 547;

        private readonly CategoriaDatos categoriaDatos = new CategoriaDatos();

        public DataTable ObtenerCategorias()
        {
            return categoriaDatos.ObtenerCategorias();
        }

        public DataTable BuscarCategoriasPorNombre(string nombre)
        {
            return categoriaDatos.BuscarCategoriasPorNombre(nombre);
        }

        // Método para validar los datos de una categoría antes de guardarla o actualizarla.
        public bool ValidarCategoria(Categoria categoria, out string campoConError, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                campoConError = "Nombre";
                mensajeError = "El nombre de la categoría es obligatorio.";
                return false;
            }

            if (decimal.TryParse(categoria.Nombre, out decimal valorNumerico))
            {
                campoConError = "Nombre";
                mensajeError = "El nombre de la categoría no puede ser únicamente numérico.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
            {
                campoConError = "Descripcion";
                mensajeError = "La descripción de la categoría es obligatoria.";
                return false;
            }

            campoConError = string.Empty;
            mensajeError = string.Empty;
            return true;
        }

        public bool GuardarCategoria(Categoria categoria, out string campoConError, out string mensajeError)
        {
            if (ValidarCategoria(categoria, out campoConError, out mensajeError) == false)
            {
                return false;
            }

            try
            {
                categoriaDatos.GuardarCategoria(categoria);
                return true;
            }
            catch (SqlException errorBaseDatos)
            {
                if (errorBaseDatos.Number == ErrorRegistroDuplicado)
                {
                    campoConError = "Nombre";
                    mensajeError = "Ya existe una categoría con ese nombre.";
                    return false;
                }

                // Otros errores siguen hasta el manejo general del formulario.
                throw;
            }
        }

        public bool ActualizarCategoria(Categoria categoria, out string campoConError, out string mensajeError)
        {
            if (categoria.IdCategoria <= 0)
            {
                campoConError = "Seleccion";
                mensajeError = "Seleccione una categoría antes de modificar.";
                return false;
            }

            if (ValidarCategoria(categoria, out campoConError, out mensajeError) == false)
            {
                return false;
            }

            try
            {
                int filasAfectadas = categoriaDatos.ActualizarCategoria(categoria);
                if (filasAfectadas == 0)
                {
                    campoConError = "Seleccion";
                    mensajeError = "La categoría ya no existe. Actualice la lista antes de continuar.";
                    return false;
                }
                return true;
            }
            catch (SqlException errorBaseDatos)
            {
                if (errorBaseDatos.Number == ErrorRegistroDuplicado)
                {
                    campoConError = "Nombre";
                    mensajeError = "Ya existe una categoría con ese nombre.";
                    return false;
                }

                // Otros errores siguen hasta el manejo general del formulario.
                throw;
            }
        }

        public bool EliminarCategoria(int idCategoria, out string mensajeError)
        {
            mensajeError = string.Empty;
            if (idCategoria <= 0)
            {
                mensajeError = "Seleccione una categoría antes de eliminar.";
                return false;
            }

            try
            {
                int filasAfectadas = categoriaDatos.EliminarCategoria(idCategoria);
                if (filasAfectadas == 0)
                {
                    mensajeError = "La categoría ya no existe. Actualice la lista antes de continuar.";
                    return false;
                }
                return true;
            }
            catch (SqlException errorBaseDatos)
            {
                if (errorBaseDatos.Number == ErrorRelacionConProductos)
                {
                    mensajeError = "No es posible eliminar esta categoría porque tiene productos asociados.";
                    return false;
                }

                throw;
            }
        }
    }
}