using System.Data;
using TechStore.Datos;
using TechStore.Entidades;

namespace TechStore.Logica
{
    public class CategoriaLogica
    {
        private readonly CategoriaDatos categoriaDatos = new CategoriaDatos();

        public DataTable ObtenerCategorias()
        {
            return categoriaDatos.ObtenerCategorias();
        }

        public bool ValidarCategoria(Categoria categoria, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                mensajeError = "El nombre de la categoría es obligatorio.";
                return false;
            }

            if (decimal.TryParse(categoria.Nombre, out _))
            {
                mensajeError = "El nombre de la categoría no puede ser únicamente numérico.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
            {
                mensajeError = "La descripción en la categoría es obligatoria.";
                return false;
            }

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