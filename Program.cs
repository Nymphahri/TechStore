using TechStore.Presentacion;

namespace TechStore
{
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