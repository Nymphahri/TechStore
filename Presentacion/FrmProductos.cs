using Microsoft.Data.SqlClient;
using TechStore.Entidades;
using TechStore.Logica;

namespace TechStore.Presentacion
{
    public partial class FrmProductos : Form
    {
        private readonly ProductoLogica productoLogica = new ProductoLogica();
        private readonly CategoriaLogica categoriaLogica = new CategoriaLogica();

        public FrmProductos()
        {
            InitializeComponent();
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

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarCategorias();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            errorProviderProductos.Clear();

            bool precioEsValido =
                decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio);

            if (precioEsValido == false)
            {
                errorProviderProductos.SetError(
                    txtPrecio,
                    "Ingrese un precio numérico válido.");

                return;
            }

            bool stockEsValido =
                int.TryParse(txtStock.Text.Trim(), out int stock);

            if (stockEsValido == false)
            {
                errorProviderProductos.SetError(
                    txtStock,
                    "Ingrese un stock entero válido.");

                return;
            }

            if (cboCategorias.SelectedIndex == -1)
            {
                errorProviderProductos.SetError(
                    cboCategorias,
                    "Seleccione una categoría.");

                return;
            }

            Producto producto = new Producto
            {
                Nombre = txtNombreProducto.Text.Trim(),
                Precio = precio,
                Stock = stock,
                FechaRegistro = DateTime.Now,
                IdCategoria = Convert.ToInt32(cboCategorias.SelectedValue)
            };

            bool productoValido =
                productoLogica.ValidarProducto(producto, out string mensajeError);

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
                    errorProviderProductos.SetError(txtPrecio, mensajeError);
                }
                else if (producto.Stock < 0)
                {
                    errorProviderProductos.SetError(txtStock, mensajeError);
                }
                else
                {
                    errorProviderProductos.SetError(cboCategorias, mensajeError);
                }

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

        private void LimpiarCamposProducto()
        {
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cboCategorias.SelectedIndex = -1;
            errorProviderProductos.Clear();
            dgvProductos.ClearSelection();
            txtNombreProducto.Focus();
        }
    }

}
