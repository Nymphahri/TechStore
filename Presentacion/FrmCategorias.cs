using Microsoft.Data.SqlClient;
using TechStore.Logica;
using TechStore.Entidades;

namespace TechStore.Presentacion
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private readonly CategoriaLogica categoriaLogica = new CategoriaLogica();

        private void CargarCategorias()
        {
            try
            {
                dgvCategorias.DataSource = categoriaLogica.ObtenerCategorias();
                dgvCategorias.ClearSelection();
            }

            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible cargar las categorías.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            errorProviderCategorias.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProviderCategorias.Clear();

            Categoria categoria = new Categoria
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            if (!categoriaLogica.ValidarCategoria(categoria, out string mensajeError))
            {
                if (string.IsNullOrWhiteSpace(categoria.Nombre) ||
                    decimal.TryParse(categoria.Nombre, out _))
                {
                    errorProviderCategorias.SetError(txtNombre, mensajeError);
                }
                else
                {
                    errorProviderCategorias.SetError(txtDescripcion, mensajeError);
                }

                return;
            }

            try
            {
                categoriaLogica.Guardar(categoria);

                MessageBox.Show(
                    "La categoría se registró correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarCategorias();
                LimpiarCampos();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible guardar la categoría.",
                    "Error en la base de datos",
                    MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
            }
        }
    }
}