using System;

namespace TechStore.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int IdCategoria { get; set; }

        public decimal CalcularValorInventario()
        {
            return Precio * Stock;
        }
    }
}