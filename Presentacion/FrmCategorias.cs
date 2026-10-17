using Microsoft.Data.SqlClient;
using TechStore.Logica;
using TechStore.Entidades;

namespace TechStore.Presentacion
{
    public partial class FrmCategorias : Form
    {
        private readonly CategoriaLogica categoriaLogica = new CategoriaLogica();

        private int idCategoriaSeleccionada = 0;

        public FrmCategorias()
        {
            InitializeComponent();
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

        private void CargarCategorias()
        {
            try
            {
                dgvCategorias.DataSource = categoriaLogica.ObtenerCategorias();

                dgvCategorias.Columns["IdCategoria"].Visible = false;
                dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";

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

        private bool ValidarCategoriaFormulario(Categoria categoria)
        {
            bool categoriaEsValida =
                categoriaLogica.ValidarCategoria(categoria, out string mensajeError);

            if (categoriaEsValida == false)
            {
                bool nombreEstaVacio =
                    string.IsNullOrWhiteSpace(categoria.Nombre);

                bool nombreEsNumerico =
                    decimal.TryParse(categoria.Nombre, out _);

                bool errorEnNombre =
                    nombreEstaVacio || nombreEsNumerico;

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idCategoriaSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una categoría antes de eliminar.",
                    "La categoría no ha sido seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string nombreCategoria = txtNombre.Text;

            DialogResult respuesta = MessageBox.Show(
                $"¿Desea eliminar la categoría \"{nombreCategoria}\"?",
                "Confirmar la eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                categoriaLogica.EliminarCategoria(idCategoriaSeleccionada);

                MessageBox.Show(
                    "La categoría se eliminó correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarCategorias();
                LimpiarCampos();
            }
            catch (SqlException errorBaseDatos)
            {
                if (errorBaseDatos.Number == 547)
                {
                    MessageBox.Show(
                        "No es posible eliminar esta categoría porque tiene productos asociados.",
                        "La operación no puede ser permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible eliminar la categoría.",
                        "Error de base de datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}