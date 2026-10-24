using System.Data;
using TechStore.Datos;
using TechStore.Entidades;

namespace TechStore.Logica
{
    // Clase que contiene la lógica de negocio para la gestión de categorías.
    public class CategoriaLogica
    {
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

        public void GuardarCategoria(Categoria categoria)
        {
            categoriaDatos.GuardarDatos(categoria);
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            categoriaDatos.ActualizarDatos(categoria);
        }

        public void EliminarCategoria(int idCategoria)
        {
            categoriaDatos.Eliminar(idCategoria);
        }
    }
}