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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductos).BeginInit();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(49, 51);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(54, 15);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(49, 122);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(49, 177);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(49, 227);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Location = new Point(49, 283);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(104, 15);
            lblFechaRegistro.TabIndex = 4;
            lblFechaRegistro.Text = "Fecha: automática";
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(411, 51);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(111, 15);
            lblBuscarProducto.TabIndex = 5;
            lblBuscarProducto.Text = "Buscar por nombre:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(132, 43);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(208, 23);
            txtNombreProducto.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(132, 114);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(208, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(132, 169);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(208, 23);
            txtStock.TabIndex = 8;
            // 
            // cboCategorias
            // 
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(132, 219);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(151, 23);
            cboCategorias.TabIndex = 9;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(435, 332);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(115, 44);
            btnGuardarProducto.TabIndex = 10;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(556, 332);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(115, 44);
            btnModificarProducto.TabIndex = 11;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(677, 332);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(115, 44);
            btnEliminarProducto.TabIndex = 12;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Location = new Point(799, 333);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(115, 44);
            btnLimpiarProducto.TabIndex = 13;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(547, 43);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(208, 23);
            txtBuscarProducto.TabIndex = 14;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(787, 36);
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
            dgvProductos.Location = new Point(411, 122);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(521, 195);
            dgvProductos.TabIndex = 16;
            // 
            // errorProviderProductos
            // 
            errorProviderProductos.ContainerControl = this;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 594);
            Controls.Add(dgvProductos);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Controls.Add(btnLimpiarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnGuardarProducto);
            Controls.Add(cboCategorias);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblBuscarProducto);
            Controls.Add(lblFechaRegistro);
            Controls.Add(lblCategoria);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombreProducto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTIÓN DE PRODUCTOS";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductos).EndInit();
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
    }
}