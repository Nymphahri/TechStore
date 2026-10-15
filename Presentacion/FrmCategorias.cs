using Microsoft.Data.SqlClient;
using TechStore.Logica;
using TechStore.Entidades;

namespace TechStore.Presentacion
{
    public partial class FrmCategorias : Form
    {
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private int idCategoriaSeleccionada = 0;

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

            idCategoriaSeleccionada =
                Convert.ToInt32(fila.Cells["IdCategoria"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString();
        }

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

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            errorProviderCategorias.Clear();
            idCategoriaSeleccionada = 0;
            dgvCategorias.ClearSelection();
            txtNombre.Focus();
        }

        private bool ValidarCategoriaFormulario(Categoria categoria)
        {
            errorProviderCategorias.Clear();

            if (!categoriaLogica.ValidarCategoria(categoria, out string mensajeError))
            {
                bool errorEnNombre =
                    string.IsNullOrWhiteSpace(categoria.Nombre) ||
                    decimal.TryParse(categoria.Nombre, out _);

                if (errorEnNombre)
                {
                    errorProviderCategorias.SetError(txtNombre, mensajeError);
                }
                else
                {
                    errorProviderCategorias.SetError(txtDescripcion, mensajeError);
                }

                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProviderCategorias.Clear();

            Categoria categoria = new Categoria
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            bool categoriaValida = ValidarCategoriaFormulario(categoria);

            if (categoriaValida == false)
            {
                return;
            }

            try
            {
                categoriaLogica.GuardarCategoria(categoria);

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idCategoriaSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una categoría antes de modificar.",
                    "Categoría no ha sido seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Categoria categoria = new Categoria
            {
                IdCategoria = idCategoriaSeleccionada,
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            bool categoriaValida = ValidarCategoriaFormulario(categoria);

            if (categoriaValida == false)
            {
                return;
            }

            try
            {
                categoriaLogica.ActualizarCategoria(categoria);

                MessageBox.Show(
                    "La categoría se ha modificado correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarCategorias();
                LimpiarCampos();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible modificar una categoría.",
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}