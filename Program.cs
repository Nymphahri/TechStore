using TechStore.Presentacion;

namespace TechStore
{
    // El punto de entrada principal para la aplicación.
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            bool continuarAplicacion = true;

            while (continuarAplicacion)
            {
                using (FrmLogin formularioLogin = new FrmLogin())
                {
                    DialogResult resultadoLogin =
                        formularioLogin.ShowDialog();

                    if (resultadoLogin != DialogResult.OK)
                    {
                        continuarAplicacion = false;
                        continue;
                    }
                }

                // Si el usuario ha iniciado sesión correctamente, se muestra el formulario principal
                using (FrmPrincipal formularioPrincipal = new FrmPrincipal())
                {
                    formularioPrincipal.ShowDialog();

                    if (formularioPrincipal.DebeVolverAlLogin == false)
                    {
                        continuarAplicacion = false;
                    }
                }
            }
        }
    }
}