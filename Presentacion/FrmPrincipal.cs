using System.Data;
using Microsoft.Data.SqlClient;
using TechStore.Logica;
using TechStore.Presentacion;

namespace TechStore
{
    public partial class FrmPrincipal : Form
    {
        private readonly ProductoLogica productoLogica = new ProductoLogica();

        public bool DebeVolverAlLogin {get; private set;} = false;

        public FrmPrincipal()
        {
            InitializeComponent();

            Load += FrmPrincipal_Load;
        }

        private void FrmPrincipal_Load(object? sender, EventArgs e)
        {
            ConfigurarTabla();
            CargarResumenInventario();
            CargarProductosStockBajo();
        }

        /* --------------------------------------------------
         * CONFIGURACIÓN VISUAL DE LA TABLA
         * -------------------------------------------------- */
        private void ConfigurarTabla()
        {
            dgvStockBajo.AutoGenerateColumns = true;
            dgvStockBajo.ReadOnly = true;
            dgvStockBajo.AllowUserToAddRows = false;
            dgvStockBajo.AllowUserToDeleteRows = false;
            dgvStockBajo.MultiSelect = false;
            dgvStockBajo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvStockBajo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvStockBajo.RowHeadersVisible = false;
            dgvStockBajo.BackgroundColor = Color.White;
            dgvStockBajo.BorderStyle = BorderStyle.None;

            dgvStockBajo.EnableHeadersVisualStyles = false;

            dgvStockBajo.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(238, 243, 250);

            dgvStockBajo.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(20, 25, 60);

            dgvStockBajo.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvStockBajo.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvStockBajo.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 234, 252);

            dgvStockBajo.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(20, 25, 60);
        }

        /* --------------------------------------------------
         * RESUMEN DEL INVENTARIO
         * -------------------------------------------------- */
        private void CargarResumenInventario()
        {
            try
            {
                var resumen = productoLogica.ObtenerResumenInventario();

                lblTotalProductos.Text =
                    resumen.TotalProductos.ToString();

                lblStockBajo.Text =
                    resumen.ProductosStockBajo.ToString();
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
         * PRODUCTOS CON STOCK BAJO
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
         * ABRIR LOS FORMULARIOS
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
         * CERRAR SESIÓN
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
    }
}
