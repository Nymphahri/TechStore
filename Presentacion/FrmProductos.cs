using Microsoft.Data.SqlClient;
using System.Data;
using TechStore.Entidades;
using TechStore.Logica;

namespace TechStore.Presentacion
{
    public partial class FrmProductos : Form
    {
        private readonly ProductoLogica productoLogica = new ProductoLogica();
        private readonly CategoriaLogica categoriaLogica = new CategoriaLogica();

        private int idProductoSeleccionado = 0;

        public FrmProductos()
        {
            InitializeComponent();

            AyudanteInterfaz.ColocarSobreFondo(
                picBannerProductos,
                lblTitulo,
                pnlGradientDatos,
                pnlGradientBusqueda,
                pnlGradientLista);

            txtBuscarProducto.KeyDown += txtBuscarProducto_KeyDown;
        }

        /* --------------------------------------------------
         * Al presionar Enter en la caja de búsqueda se activa
         * el botón Buscar.
         * -------------------------------------------------- */
        private void txtBuscarProducto_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido de error de Windows al presionar Enter.
                e.SuppressKeyPress = true;
                btnBuscarProducto.PerformClick();
            }
        }

        /* --------------------------------------------------
         * Limpiar campos del formulario de productos
         * -------------------------------------------------- */
        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            CargarProductos();
            LimpiarCamposProducto();
        }

        private void LimpiarCamposProducto()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtStock.Clear();
            cboCategorias.SelectedIndex = -1;
            errorProviderProductos.Clear();
            idProductoSeleccionado = 0;
            dgvProductos.ClearSelection();
            txtNombreProducto.Focus();
            txtBuscarProducto.Clear();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarCategorias();
        }

        /* --------------------------------------------------
         * Carga los productos desde la base de datos y los 
         * muestra en el DataGridView
         * -------------------------------------------------- */
        private void CargarProductos()
        {
            try
            {
                MostrarProductosEnGrid(productoLogica.ObtenerProductos());
            }

            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible cargar los productos.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /* --------------------------------------------------
         * Configura el DataGridView para mostrar los 
         * productos de manera clara y legible
         * -------------------------------------------------- */
        private void ConfigurarGridProductos()
        {
            // IdCategoria es de uso interno, no se muestra al usuario.
            dgvProductos.Columns["IdCategoria"].Visible = false;

            // Encabezados más claros para el usuario.
            dgvProductos.Columns["FechaRegistro"].HeaderText = "Fecha de registro";
            dgvProductos.Columns["ValorInventario"].HeaderText = "Valor inventario";

            // Formato visual de los valores numéricos y la fecha.
            dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgvProductos.Columns["ValorInventario"].DefaultCellStyle.Format = "N2";
            dgvProductos.Columns["FechaRegistro"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Ajusta el ancho de las columnas al espacio disponible.
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /* --------------------------------------------------
         * Mostrar productos en el DataGridView
         * -------------------------------------------------- */
        private void MostrarProductosEnGrid(DataTable productos)
        {
            dgvProductos.DataSource = productos;
            ConfigurarGridProductos();

            // Evita que una fila quede seleccionada automáticamente.
            dgvProductos.ClearSelection();
        }

        /* --------------------------------------------------
         * Cargar categorías en el ComboBox de categorías
         * -------------------------------------------------- */
        private void CargarCategorias()
        {
            try
            {
                cboCategorias.DataSource = categoriaLogica.ObtenerCategorias();
                cboCategorias.DisplayMember = "Nombre";
                cboCategorias.ValueMember = "IdCategoria";
                cboCategorias.SelectedIndex = -1;
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
         * Obtener producto del formulario y validarlo
         * -------------------------------------------------- */
        private bool ObtenerProductoDelFormulario(out Producto producto)
        {
            producto = new Producto();

            errorProviderProductos.Clear();

            bool formularioValido = true;

            // Nombre obligatorio
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errorProviderProductos.SetError(txtNombreProducto,
                    "El nombre del producto es obligatorio.");

                formularioValido = false;
            }

            // Precio: debe ser un número
            bool precioEsValido = decimal.TryParse(txtPrecioProducto.Text.Trim(), out decimal precio);

            if (precioEsValido == false)
            {
                errorProviderProductos.SetError(txtPrecioProducto,
                    "Ingrese un precio numérico válido.");

                formularioValido = false;
            }

            // Stock: debe ser un número entero
            bool stockEsValido = int.TryParse(txtStock.Text.Trim(), out int stock);

            if (stockEsValido == false)
            {
                errorProviderProductos.SetError(txtStock,
                    "Ingrese un stock entero válido.");

                formularioValido = false;
            }

            // Categoría obligatoria
            if (cboCategorias.SelectedIndex == -1)
            {
                errorProviderProductos.SetError(cboCategorias,
                    "Seleccione una categoría.");

                formularioValido = false;
            }

            // Si algún campo falló, ya quedaron todos marcados.
            if (formularioValido == false)
            {
                return false;
            }

            // Todos los campos tienen el formato correcto: se arma el objeto.
            producto.Nombre = txtNombreProducto.Text.Trim();
            producto.Precio = precio;
            producto.Stock = stock;
            producto.IdCategoria = Convert.ToInt32(cboCategorias.SelectedValue);

            // La lógica revisa las reglas (precio > 0, stock >= 0, etc.)
            bool productoValido = productoLogica.ValidarProducto(producto, out string campoConError, out string mensajeError);

            if (productoValido == false)
            {
                switch (campoConError)
                {
                    case "Nombre":
                        errorProviderProductos.SetError(txtNombreProducto, mensajeError);
                        break;

                    case "Precio":
                        errorProviderProductos.SetError(txtPrecioProducto, mensajeError);
                        break;

                    case "Stock":
                        errorProviderProductos.SetError(txtStock, mensajeError);
                        break;

                    case "Categoria":
                        errorProviderProductos.SetError(cboCategorias, mensajeError);
                        break;
                }

                return false;
            }

            return true;
        }

        /* --------------------------------------------------
         * Guardar producto
         * -------------------------------------------------- */
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            bool productoValido = ObtenerProductoDelFormulario(out Producto producto);

            if (productoValido == false)
            {
                return;
            }

            try
            {
                productoLogica.GuardarProducto(producto);

                MessageBox.Show(
                    "El producto se registró correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarProductos();
                LimpiarCamposProducto();
            }

            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible guardar el producto.",
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /* --------------------------------------------------
         * Modificar producto
         * -------------------------------------------------- */
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto antes de modificar.",
                    "Producto no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool productoValido = ObtenerProductoDelFormulario(out Producto producto);

            if (productoValido == false)
            {
                return;
            }

            producto.IdProducto = idProductoSeleccionado;

            try
            {
                productoLogica.ActualizarProducto(producto);

                MessageBox.Show(
                    "El producto se modificó correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarProductos();
                LimpiarCamposProducto();
            }

            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible modificar el producto.",
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /* --------------------------------------------------
         * Eliminar producto
         * -------------------------------------------------- */
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto antes de eliminar.",
                    "Producto no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar el producto seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
            {
                return;
            }

            try
            {
                productoLogica.EliminarProducto(idProductoSeleccionado);

                MessageBox.Show(
                    "El producto se eliminó correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarProductos();
                LimpiarCamposProducto();
            }

            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible eliminar el producto.",
                    "Error en la base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /* --------------------------------------------------
         * Buscar producto
         * -------------------------------------------------- */
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txtBuscarProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreBuscado))
            {
                CargarProductos();
                return;
            }

            try
            {
                DataTable productosEncontrados = productoLogica.BuscarProductosPorNombre(nombreBuscado);

                MostrarProductosEnGrid(productosEncontrados);

                if (productosEncontrados.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron productos con ese nombre.",
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

        /* --------------------------------------------------
         * Seleccionar producto del grid
         * -------------------------------------------------- */
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            idProductoSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);

            txtNombreProducto.Text = fila.Cells["Nombre"].Value?.ToString();

            txtPrecioProducto.Text = Convert.ToDecimal(fila.Cells["Precio"].Value).ToString("0.00");

            txtStock.Text = fila.Cells["Stock"].Value?.ToString();

            cboCategorias.SelectedValue = Convert.ToInt32(fila.Cells["IdCategoria"].Value);
        }
    }
}
