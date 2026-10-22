using Microsoft.Data.SqlClient;
using TechStore.Entidades;
using TechStore.Logica;

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

        /* --------------------------------------------------
         * Limpia los campos del formulario y reinicia la 
         * selección de categoría.
         * -------------------------------------------------- */
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
                dgvCategorias.DataSource =
                    categoriaLogica.ObtenerCategorias();

                // El ID se usa internamente para modificar o eliminar no se ve a simple vista.
                dgvCategorias.Columns["IdCategoria"].Visible = false;

                dgvCategorias.Columns["Nombre"].HeaderText = "Nombre de categoría";

                dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";

                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        /* --------------------------------------------------
         * Carga las categorías al cargar el formulario.
         * -------------------------------------------------- */
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        /* --------------------------------------------------
         * Valida los datos de la categoría y devuelve un 
         * mensaje de error si es inválida.
         * -------------------------------------------------- */
        public bool ValidarCategoria(Categoria categoria, out string campoConError, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                campoConError = "Nombre";
                mensajeError = "El nombre de la categoría es obligatorio.";
                return false;
            }

            if (decimal.TryParse(categoria.Nombre, out decimal valorNumerico))
            {
                campoConError = "Nombre";
                mensajeError = "El nombre de la categoría no puede ser únicamente numérico.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
            {
                campoConError = "Descripcion";
                mensajeError = "La descripción de la categoría es obligatoria.";
                return false;
            }

            campoConError = string.Empty;
            mensajeError = string.Empty;
            return true;
        }

        /* --------------------------------------------------
         * Captura los datos del formulario y valida la 
         * categoría.
         * -------------------------------------------------- */
        private bool ObtenerCategoriaDelFormulario(out Categoria categoria)
        {
            errorProviderCategorias.Clear();

            categoria = new Categoria
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            bool categoriaEsValida = categoriaLogica.ValidarCategoria(categoria, out string campoConError, out string mensajeError);

            if (categoriaEsValida == false)
            {
                switch (campoConError)
                {
                    case "Nombre":
                        errorProviderCategorias.SetError(txtNombre, mensajeError);
                        break;

                    case "Descripcion":
                        errorProviderCategorias.SetError(txtDescripcion, mensajeError);
                        break;
                }

                return false;
            }

            return true;
        }

        /* --------------------------------------------------
         * Guarda una nueva categoría en la base de datos y 
         * actualiza.
         * -------------------------------------------------- */
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool categoriaValida = ObtenerCategoriaDelFormulario(out Categoria categoria);

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

                ActualizarVistaCategorias();
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

        /* --------------------------------------------------
         * Modifica la categoría seleccionada en la base de 
         * datos y actualiza.
         * -------------------------------------------------- */
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (HayCategoriaSeleccionada("modificar") == false)
            {
                return;
            }

            bool categoriaValida = ObtenerCategoriaDelFormulario(out Categoria categoria);

            if (categoriaValida == false)
            {
                return;
            }

            categoria.IdCategoria = idCategoriaSeleccionada;

            try
            {
                categoriaLogica.ActualizarCategoria(categoria);

                MessageBox.Show(
                    "La categoría se ha modificado correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ActualizarVistaCategorias();
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

        /* --------------------------------------------------
         * Elimina la categoría seleccionada de la base de 
         * datos y actualiza.
         * -------------------------------------------------- */
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (HayCategoriaSeleccionada("eliminar") == false)
            {
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

                ActualizarVistaCategorias();
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

        /* --------------------------------------------------
         * Limpia los campos del formulario y reinicia la 
         * selección de categoría.
         * -------------------------------------------------- */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool HayCategoriaSeleccionada(string accion)
        {
            if (idCategoriaSeleccionada != 0)
            {
                return true;
            }

            MessageBox.Show(
                $"Seleccione una categoría antes de {accion}.",
                "Categoría no seleccionada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return false;
        }

        private void ActualizarVistaCategorias()
        {
            CargarCategorias();
            LimpiarCampos();
        }

        /* --------------------------------------------------
         * Cuando se hace clic en una fila del DataGridView 
         * se selecciona la categoría correspondiente y 
         * se muestran sus detalles en los campos de texto.
         * -------------------------------------------------- */
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

            idCategoriaSeleccionada = Convert.ToInt32(fila.Cells["IdCategoria"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString();
        }
    }
}