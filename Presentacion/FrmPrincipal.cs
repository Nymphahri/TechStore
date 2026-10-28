using System.Data;
using Microsoft.Data.SqlClient;
using TechStore.Logica;

namespace TechStore.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private readonly ProductoLogica productoLogica = new ProductoLogica();

        public bool DebeVolverAlLogin {get; private set;} = false;

        public FrmPrincipal()
        {
            InitializeComponent();

            Load += FrmPrincipal_Load;

            AyudanteInterfaz.ColocarSobreFondo(
                picBackground,
                btnInicioPrincipal,
                btnCerrarSesion,
                pnlLogo2,
                pnlGradientTotalProductos,
                pnlGradientStockBajo,
                pnlGradientCategorias,
                pnlGradientProductos,
                pnlStock);

            dgvStockBajo.CellFormatting += dgvStockBajo_CellFormatting;
        }

        private void FrmPrincipal_Load(object? sender, EventArgs e)
        {
            
            CargarResumenInventario();
            CargarProductosStockBajo();
        }

        /* --------------------------------------------------
         * Resumen del inventario
         * -------------------------------------------------- */
        private void CargarResumenInventario()
        {
            try
            {
                var resumen = productoLogica.ObtenerResumenInventario();

                lblTotalProductos.Text = resumen.TotalProductos.ToString();

                lblStockBajo.Text = resumen.ProductosStockBajo.ToString();

                lblValorInventarios.Text = "₡" + resumen.ValorTotalInventario.ToString("N0");
            }

            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible cargar el resumen del inventario.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /* --------------------------------------------------
         * Productos con stock bajo
         * -------------------------------------------------- */
        private void CargarProductosStockBajo()
        {
            try
            {
                DataTable productos = productoLogica.ObtenerProductosStockBajo();

                dgvStockBajo.DataSource = productos;
            }

            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible cargar los productos con stock bajo.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /* --------------------------------------------------
         * Abrir formularios de categorías y productos
         * -------------------------------------------------- */
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            using FrmCategorias formularioCategorias = new FrmCategorias();

            formularioCategorias.ShowDialog(this);

            CargarResumenInventario();
            CargarProductosStockBajo();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            using FrmProductos formularioProductos = new FrmProductos();

            formularioProductos.ShowDialog(this);

            CargarResumenInventario();
            CargarProductosStockBajo();
        }

        /* --------------------------------------------------
         * Cerrar la sesión
         * -------------------------------------------------- */
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Desea cerrar la sesión actual?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            DebeVolverAlLogin = true;
            Close();
        }

        /* --------------------------------------------------
         * Pone en rojo el texto de la columna "Estado"
         * cuando el producto tiene stock bajo.
         * -------------------------------------------------- */
        private void dgvStockBajo_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dgvStockBajo.Columns[e.ColumnIndex].Name != "Estado")
            {
                return;
            }

            if (e.Value?.ToString() == "Stock bajo")
            {
                e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                e.CellStyle.SelectionForeColor = Color.FromArgb(220, 38, 38);
                e.CellStyle.Font = new Font(dgvStockBajo.Font, FontStyle.Bold);
            }
        }
    }
}
