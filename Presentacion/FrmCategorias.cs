using Microsoft.Data.SqlClient;
using TechStore.Logica;

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
    }
}