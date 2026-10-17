namespace TechStore.Presentacion
{
    public partial class FrmLogin : Form
    {
        private readonly string usuarioValido = "uisil";
        private readonly string contrasenaValida = "1234";

        private int intentosFallidos = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresarSesion_Click(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();

            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                errorProviderLogin.SetError(txtUsuario, "Ingrese el usuario.");
                return;
            }

            if (string.IsNullOrEmpty(contrasena))
            {
                errorProviderLogin.SetError(txtContrasena, "Ingrese la contraseña.");
                return;
            }

            bool credencialesCorrectas =
                usuario == usuarioValido && contrasena == contrasenaValida;

            if (credencialesCorrectas)
            {
                DialogResult = DialogResult.OK;
                return;
            }

            intentosFallidos++;

            if (intentosFallidos >= 3)
            {
                MessageBox.Show(
                    "Se superó el número máximo de intentos.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                DialogResult = DialogResult.Cancel;
                return;
            }

            MessageBox.Show(
                $"Usuario o contraseña incorrectos. Intento {intentosFallidos} de 3.",
                "Acceso denegado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            txtContrasena.Clear();
            txtContrasena.Focus();
        }

        private void btnSalirSesion_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}