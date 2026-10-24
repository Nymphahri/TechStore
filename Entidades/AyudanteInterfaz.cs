namespace TechStore.Presentacion
{
    // Clase con métodos de apoyo para la interfaz gráfica, reutilizables en todos los formularios.
    public static class AyudanteInterfaz
    {
        public static void ColocarSobreFondo(Control fondo, params Control[] controles)
        {
            foreach (Control control in controles)
            {
                // Evita mover dos veces un control que ya está sobre el fondo.
                if (control.Parent == fondo)
                {
                    continue;
                }

                // Se guarda la posición antes de cambiar el padre.
                Point posicion = control.Location;

                control.Parent = fondo;

                // Se compensa el desplazamiento del fondo respecto al formulario.
                control.Location = new Point(
                    posicion.X - fondo.Left,
                    posicion.Y - fondo.Top);

                control.BackColor = Color.Transparent;
            }
        }
    }
}