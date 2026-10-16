using TechStore.Presentacion;

namespace TechStore
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (FrmLogin formularioLogin = new FrmLogin())
            {
                if (formularioLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmPrincipal());
                }
            }
        }
    }
}