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
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarCategorias();
        }

        private void CargarProductos()
        {
            try
            {
                dgvProductos.DataSource = productoLogica.ObtenerProductos();
                dgvProductos.ClearSelection();
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

        private bool ObtenerProductoDelFormulario(out Producto producto)
        {
            producto = new Producto();

            errorProviderProductos.Clear();

            bool precioEsValido = decimal.TryParse(txtPrecioProducto.Text.Trim(), out decimal precio);

            if (precioEsValido == false)
            {
                errorProviderProductos.SetError(txtPrecioProducto,
                    "Ingrese un precio numérico válido.");

                return false;
            }

            bool stockEsValido = int.TryParse(txtStock.Text.Trim(), out int stock);

            if (stockEsValido == false)
            {
                errorProviderProductos.SetError(txtStock,
                    "Ingrese un stock entero válido.");

                return false;
            }

            if (cboCategorias.SelectedIndex == -1)
            {
                errorProviderProductos.SetError(cboCategorias,
                    "Seleccione una categoría.");

                return false;
            }

            producto.Nombre = txtNombreProducto.Text.Trim();
            producto.Precio = precio;
            producto.Stock = stock;

            producto.IdCategoria = Convert.ToInt32(cboCategorias.SelectedValue);

            bool productoValido = productoLogica.ValidarProducto(producto, out string mensajeError);

            if (productoValido == false)
            {
                if (string.IsNullOrWhiteSpace(producto.Nombre))
                {
                    errorProviderProductos.SetError(
                        txtNombreProducto,
                        mensajeError);
                }

                else if (producto.Precio <= 0)
                {
                    errorProviderProductos.SetError(
                        txtPrecioProducto,
                        mensajeError);
                }

                else if (producto.Stock < 0)
                {
                    errorProviderProductos.SetError(
                        txtStock,
                        mensajeError);
                }

                return false;
            }

            return true;
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
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCamposProducto();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            bool productoValido = ObtenerProductoDelFormulario(out Producto producto);

            if (productoValido == false)
            {
                return;
            }

            producto.FechaRegistro = DateTime.Now;

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

        private void btnEliminar_Click(object sender, EventArgs e)
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
        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
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

                dgvProductos.DataSource = productosEncontrados;
                dgvProductos.ClearSelection();

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

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
