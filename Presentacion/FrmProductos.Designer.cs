namespace TechStore.Presentacion
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            lblNombreProducto = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblCategoria = new Label();
            lblFechaRegistro = new Label();
            lblBuscarProducto = new Label();
            txtNombreProducto = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            cboCategorias = new ComboBox();
            btnGuardarProducto = new Button();
            btnModificarProducto = new Button();
            btnEliminarProducto = new Button();
            btnLimpiarProducto = new Button();
            txtBuscarProducto = new TextBox();
            btnBuscarProducto = new Button();
            dgvProductos = new DataGridView();
            errorProviderProductos = new ErrorProvider(components);
            pnlDerecho = new Panel();
            label1 = new Label();
            pnlIzquierdo = new Panel();
            btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            btnModificar = new Guna.UI2.WinForms.Guna2Button();
            gpbBotones = new GroupBox();
            lblDetalleCategorias = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductos).BeginInit();
            pnlDerecho.SuspendLayout();
            pnlIzquierdo.SuspendLayout();
            gpbBotones.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNombreProducto.Location = new Point(39, 105);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(75, 21);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPrecio.Location = new Point(40, 179);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 21);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStock.Location = new Point(40, 256);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(56, 21);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCategoria.Location = new Point(40, 338);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(85, 21);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFechaRegistro.Location = new Point(12, 656);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(141, 21);
            lblFechaRegistro.TabIndex = 4;
            lblFechaRegistro.Text = "Fecha: automática";
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblBuscarProducto.Location = new Point(15, 69);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(154, 21);
            lblBuscarProducto.TabIndex = 5;
            lblBuscarProducto.Text = "Buscar por nombre:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(39, 131);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(224, 23);
            txtNombreProducto.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(40, 203);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(224, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(40, 282);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(224, 23);
            txtStock.TabIndex = 8;
            // 
            // cboCategorias
            // 
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(40, 362);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(224, 23);
            cboCategorias.TabIndex = 9;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(8, 24);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(115, 44);
            btnGuardarProducto.TabIndex = 10;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(150, 24);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(115, 44);
            btnModificarProducto.TabIndex = 11;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(8, 79);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(115, 44);
            btnEliminarProducto.TabIndex = 12;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Location = new Point(150, 79);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(115, 44);
            btnLimpiarProducto.TabIndex = 13;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(15, 93);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(394, 23);
            txtBuscarProducto.TabIndex = 14;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(434, 71);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(115, 45);
            btnBuscarProducto.TabIndex = 15;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(15, 131);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(534, 464);
            dgvProductos.TabIndex = 16;
            // 
            // errorProviderProductos
            // 
            errorProviderProductos.ContainerControl = this;
            // 
            // pnlDerecho
            // 
            pnlDerecho.BackColor = Color.FromArgb(243, 245, 249);
            pnlDerecho.BorderStyle = BorderStyle.Fixed3D;
            pnlDerecho.Controls.Add(label1);
            pnlDerecho.Controls.Add(dgvProductos);
            pnlDerecho.Controls.Add(txtBuscarProducto);
            pnlDerecho.Controls.Add(btnBuscarProducto);
            pnlDerecho.Controls.Add(lblBuscarProducto);
            pnlDerecho.Location = new Point(364, 42);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(568, 611);
            pnlDerecho.TabIndex = 26;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(226, 230, 234);
            label1.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(568, 52);
            label1.TabIndex = 5;
            label1.Text = "     Búsqueda y Listado";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.BackColor = Color.FromArgb(242, 244, 246);
            pnlIzquierdo.BorderStyle = BorderStyle.Fixed3D;
            pnlIzquierdo.Controls.Add(btnLimpiar);
            pnlIzquierdo.Controls.Add(btnEliminar);
            pnlIzquierdo.Controls.Add(btnGuardar);
            pnlIzquierdo.Controls.Add(btnModificar);
            pnlIzquierdo.Controls.Add(gpbBotones);
            pnlIzquierdo.Controls.Add(cboCategorias);
            pnlIzquierdo.Controls.Add(lblDetalleCategorias);
            pnlIzquierdo.Controls.Add(txtStock);
            pnlIzquierdo.Controls.Add(txtNombreProducto);
            pnlIzquierdo.Controls.Add(txtPrecio);
            pnlIzquierdo.Controls.Add(lblNombreProducto);
            pnlIzquierdo.Controls.Add(lblPrecio);
            pnlIzquierdo.Controls.Add(lblStock);
            pnlIzquierdo.Controls.Add(lblCategoria);
            pnlIzquierdo.Location = new Point(16, 42);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(301, 611);
            pnlIzquierdo.TabIndex = 27;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.AliceBlue;
            btnLimpiar.BorderColor = Color.Lavender;
            btnLimpiar.BorderRadius = 8;
            btnLimpiar.BorderThickness = 1;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.CustomizableEdges = customizableEdges1;
            btnLimpiar.DisabledState.BorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLimpiar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLimpiar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLimpiar.FillColor = Color.White;
            btnLimpiar.FocusedColor = Color.FromArgb(210, 230, 247);
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.HoverState.FillColor = Color.FromArgb(210, 230, 247);
            btnLimpiar.ImageAlign = HorizontalAlignment.Left;
            btnLimpiar.Location = new Point(153, 306);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.PressedColor = Color.FromArgb(210, 230, 247);
            btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLimpiar.Size = new Size(118, 45);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "    Limpiar";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.AliceBlue;
            btnEliminar.BorderColor = Color.Lavender;
            btnEliminar.BorderRadius = 8;
            btnEliminar.BorderThickness = 1;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.CustomizableEdges = customizableEdges3;
            btnEliminar.DisabledState.BorderColor = Color.DarkGray;
            btnEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEliminar.FillColor = Color.FromArgb(242, 161, 161);
            btnEliminar.FocusedColor = Color.FromArgb(210, 230, 247);
            btnEliminar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.HoverState.FillColor = Color.FromArgb(210, 230, 247);
            btnEliminar.ImageAlign = HorizontalAlignment.Left;
            btnEliminar.Location = new Point(25, 306);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.PressedColor = Color.FromArgb(210, 230, 247);
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEliminar.Size = new Size(118, 45);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "     Eliminar";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.AliceBlue;
            btnGuardar.BorderColor = Color.Lavender;
            btnGuardar.BorderRadius = 8;
            btnGuardar.BorderThickness = 1;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.CustomizableEdges = customizableEdges5;
            btnGuardar.DisabledState.BorderColor = Color.DarkGray;
            btnGuardar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardar.FillColor = Color.FromArgb(17, 9, 64);
            btnGuardar.FocusedColor = Color.FromArgb(210, 230, 247);
            btnGuardar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.HoverState.FillColor = Color.FromArgb(210, 230, 247);
            btnGuardar.ImageAlign = HorizontalAlignment.Left;
            btnGuardar.Location = new Point(25, 255);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.PressedColor = Color.FromArgb(210, 230, 247);
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnGuardar.Size = new Size(118, 45);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "    Guardar";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.AliceBlue;
            btnModificar.BorderColor = Color.Lavender;
            btnModificar.BorderRadius = 8;
            btnModificar.BorderThickness = 1;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.CustomizableEdges = customizableEdges7;
            btnModificar.DisabledState.BorderColor = Color.DarkGray;
            btnModificar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnModificar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnModificar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnModificar.FillColor = Color.FromArgb(165, 192, 214);
            btnModificar.FocusedColor = Color.FromArgb(210, 230, 247);
            btnModificar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.Black;
            btnModificar.HoverState.FillColor = Color.FromArgb(210, 230, 247);
            btnModificar.ImageAlign = HorizontalAlignment.Left;
            btnModificar.Location = new Point(153, 255);
            btnModificar.Name = "btnModificar";
            btnModificar.PressedColor = Color.FromArgb(210, 230, 247);
            btnModificar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnModificar.Size = new Size(118, 45);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "       Modificar";
            // 
            // gpbBotones
            // 
            gpbBotones.Controls.Add(btnLimpiarProducto);
            gpbBotones.Controls.Add(btnEliminarProducto);
            gpbBotones.Controls.Add(btnModificarProducto);
            gpbBotones.Controls.Add(btnGuardarProducto);
            gpbBotones.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbBotones.ForeColor = Color.FromArgb(17, 9, 64);
            gpbBotones.Location = new Point(13, 457);
            gpbBotones.Name = "gpbBotones";
            gpbBotones.Size = new Size(271, 138);
            gpbBotones.TabIndex = 20;
            gpbBotones.TabStop = false;
            gpbBotones.Text = "Acciones";
            // 
            // lblDetalleCategorias
            // 
            lblDetalleCategorias.BackColor = Color.FromArgb(226, 230, 234);
            lblDetalleCategorias.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblDetalleCategorias.ForeColor = Color.FromArgb(44, 62, 80);
            lblDetalleCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            lblDetalleCategorias.Location = new Point(-2, 0);
            lblDetalleCategorias.Name = "lblDetalleCategorias";
            lblDetalleCategorias.Size = new Size(301, 52);
            lblDetalleCategorias.TabIndex = 5;
            lblDetalleCategorias.Text = "Detalles de Productos";
            lblDetalleCategorias.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(944, 680);
            Controls.Add(lblFechaRegistro);
            Controls.Add(pnlDerecho);
            Controls.Add(pnlIzquierdo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TECHSTORE UISIL";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductos).EndInit();
            pnlDerecho.ResumeLayout(false);
            pnlDerecho.PerformLayout();
            pnlIzquierdo.ResumeLayout(false);
            pnlIzquierdo.PerformLayout();
            gpbBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreProducto;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblCategoria;
        private Label lblFechaRegistro;
        private Label lblBuscarProducto;
        private TextBox txtNombreProducto;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private ComboBox cboCategorias;
        private Button btnGuardarProducto;
        private Button btnModificarProducto;
        private Button btnEliminarProducto;
        private Button btnLimpiarProducto;
        private TextBox txtBuscarProducto;
        private Button btnBuscarProducto;
        private DataGridView dgvProductos;
        private ErrorProvider errorProviderProductos;
        private Panel pnlDerecho;
        private Label label1;
        private Panel pnlIzquierdo;
        private GroupBox gpbBotones;
        private Label lblDetalleCategorias;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
    }
}