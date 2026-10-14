using System.Data;
using TechStore.Datos;

namespace TechStore.Logica
{
    public class CategoriaLogica
    {
        private readonly CategoriaDatos categoriaDatos = new CategoriaDatos();

        public DataTable ObtenerCategorias()
        {
            return categoriaDatos.ObtenerCategorias();
        }
    }
}