using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TechStore.Datos;

namespace TechStore
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSql conexionSql = new ConexionSql();

                using (SqlConnection conexion = conexionSql.CrearConexion())
                {
                    conexion.Open();

                    MessageBox.Show(
                        "La conexión con SQL Server fue exitosa.",
                        "La conexión ha sido enlazada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "No fue posible conectar con la base de datos. " +
                    "Verifica que SQL Server esté activo.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}