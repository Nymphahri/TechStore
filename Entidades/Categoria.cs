/* --------------------------------------------------
 * Clase Categoria
 * -------------------------------------------------- */

namespace TechStore.Entidades
{
    public class Categoria
    {
        private string nombre = string.Empty;
        private string descripcion = string.Empty;

        public int IdCategoria { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.Trim(); }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value.Trim(); }
        }
    }
}