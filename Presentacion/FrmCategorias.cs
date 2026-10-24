using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using System.Data;
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

            AyudanteInterfaz.ColocarSobreFondo(
                picBackground,
                lblTitulo,
                pnlGradient1,
                pnlGradient2);

            txtBuscarCategoria.KeyDown += txtBuscarCategoria_KeyDown;
        }

        private void txtBuscarCategoria_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnBuscarCategoria.PerformClick();
            }
        }

        /* --------------------------------------------------
         * Limpia los campos del formulario y reinicia la 
         * selección de categoría.
         * -------------------------------------------------- */
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtBuscarCategoria.Clear();
            errorProviderCategorias.Clear();
            idCategoriaSeleccionada = 0;
            dgvCategorias.ClearSelection();
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ActualizarVistaCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                MostrarCategoriasEnGrid(categoriaLogica.ObtenerCategorias());
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
         * Mostrar categorías en el DataGridView
         * -------------------------------------------------- */
        private void MostrarCategoriasEnGrid(DataTable categorias)
        {
            dgvCategorias.DataSource = categorias;

            // El ID se usa internamente para modificar o eliminar no se ve a simple vista.
            dgvCategorias.Columns["IdCategoria"].Visible = false;

            dgvCategorias.Columns["Nombre"].HeaderText = "Nombre de categoría";

            dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";

            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCategorias.ClearSelection();
        }

        /* --------------------------------------------------
         * Carga las categorías al cargar el formulario.
         * -------------------------------------------------- */
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
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
            catch (SqlException errorBaseDatos)
            {
                // Error en la base de datos: nombre repetido.
                if (errorBaseDatos.Number == 2627)
                {
                    errorProviderCategorias.SetError(
                        txtNombre,
                        "Ya existe una categoría con ese nombre.");
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible guardar la categoría.",
                        "Error en la base de datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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
            catch (SqlException errorBaseDatos)
            {
                // 2627 = se violó la restricción UNIQUE (nombre repetido).
                if (errorBaseDatos.Number == 2627)
                {
                    errorProviderCategorias.SetError(
                        txtNombre,
                        "Ya existe una categoría con ese nombre.");
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible modificar la categoría.",
                        "Error de base de datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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

        /* --------------------------------------------------
         * Buscar categoría por nombre
         * -------------------------------------------------- */
        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txtBuscarCategoria.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreBuscado))
            {
                CargarCategorias();
                return;
            }

            try
            {
                DataTable categoriasEncontradas = categoriaLogica.BuscarCategoriasPorNombre(nombreBuscado);

                MostrarCategoriasEnGrid(categoriasEncontradas);

                if (categoriasEncontradas.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron categorías con ese nombre.",
                        "Búsqueda sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible realizar la búsqueda.",
                    "Error en la base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}