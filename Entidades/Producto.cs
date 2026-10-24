/* --------------------------------------------------
 * Clase Producto
 * -------------------------------------------------- */

namespace TechStore.Entidades
{
    public class Producto
    {
        // Campos privados: solo se acceden por medio de las propiedades.
        private string nombre = string.Empty;
        private decimal precio;
        private int stock;

        public int IdProducto { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.Trim(); }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public DateTime FechaRegistro { get; set; }

        public int IdCategoria { get; set; }
    }
}