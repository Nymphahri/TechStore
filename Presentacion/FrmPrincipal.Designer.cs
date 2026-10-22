namespace TechStore
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCategorias = new Button();
            btnProductos = new Button();
            pnlMenu = new Panel();
            pnlLineaInicio = new Panel();
            btnCerrarSesion = new Button();
            lblLogoInicio = new Label();
            btnInicioPrincipal = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblInicioPrincipal = new Label();
            pnlTotalProductos = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            lblTotalProductos = new Label();
            lblStockBajo = new Label();
            lblResumenGeneral = new Label();
            pnlStockBajo = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pnlGestionarCategoria = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox1 = new PictureBox();
            lblCategoria = new Label();
            lblDescripcionCategoria = new Label();
            dgvStockBajo = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlStock = new Guna.UI2.WinForms.Guna2Panel();
            lblProductosStockBajo = new Label();
            pnlGestionarProductos = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox2 = new PictureBox();
            lblProducto = new Label();
            lblDescripcionProducto = new Label();
            pnlMenu.SuspendLayout();
            pnlTotalProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlStockBajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlGestionarCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).BeginInit();
            pnlStock.SuspendLayout();
            pnlGestionarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.FromArgb(17, 9, 64);
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderColor = Color.White;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 32, 112);
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 32, 112);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageAlign = ContentAlignment.MiddleRight;
            btnCategorias.Location = new Point(0, 88);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(396, 38);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Gestionar categorías";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(17, 9, 64);
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderColor = Color.White;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 32, 112);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 32, 112);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleRight;
            btnProductos.Location = new Point(0, 87);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(396, 38);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Gestionar productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(17, 9, 64);
            pnlMenu.Controls.Add(pnlLineaInicio);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Controls.Add(lblLogoInicio);
            pnlMenu.Controls.Add(btnInicioPrincipal);
            pnlMenu.Location = new Point(-2, -1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(907, 59);
            pnlMenu.TabIndex = 8;
            // 
            // pnlLineaInicio
            // 
            pnlLineaInicio.BackColor = Color.SteelBlue;
            pnlLineaInicio.Location = new Point(194, 53);
            pnlLineaInicio.Name = "pnlLineaInicio";
            pnlLineaInicio.Size = new Size(39, 10);
            pnlLineaInicio.TabIndex = 12;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderColor = Color.White;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 32, 112);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 32, 112);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.LightGray;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(726, 5);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(156, 52);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "       Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblLogoInicio
            // 
            lblLogoInicio.BackColor = Color.FromArgb(17, 9, 64);
            lblLogoInicio.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold);
            lblLogoInicio.ForeColor = Color.White;
            lblLogoInicio.ImageAlign = ContentAlignment.BottomLeft;
            lblLogoInicio.Location = new Point(20, 0);
            lblLogoInicio.Name = "lblLogoInicio";
            lblLogoInicio.Size = new Size(158, 56);
            lblLogoInicio.TabIndex = 0;
            lblLogoInicio.Text = "TechStore";
            lblLogoInicio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnInicioPrincipal
            // 
            btnInicioPrincipal.BackColor = Color.Transparent;
            btnInicioPrincipal.Cursor = Cursors.Hand;
            btnInicioPrincipal.FlatAppearance.BorderColor = Color.FromArgb(17, 9, 64);
            btnInicioPrincipal.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 32, 112);
            btnInicioPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 32, 112);
            btnInicioPrincipal.FlatStyle = FlatStyle.Flat;
            btnInicioPrincipal.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicioPrincipal.ForeColor = Color.White;
            btnInicioPrincipal.ImageAlign = ContentAlignment.TopLeft;
            btnInicioPrincipal.Location = new Point(184, 13);
            btnInicioPrincipal.Name = "btnInicioPrincipal";
            btnInicioPrincipal.Size = new Size(64, 38);
            btnInicioPrincipal.TabIndex = 10;
            btnInicioPrincipal.Text = "Inicio";
            btnInicioPrincipal.TextAlign = ContentAlignment.MiddleLeft;
            btnInicioPrincipal.UseVisualStyleBackColor = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lblInicioPrincipal
            // 
            lblInicioPrincipal.AutoSize = true;
            lblInicioPrincipal.Font = new Font("Segoe UI Variable Display Semib", 13F, FontStyle.Bold);
            lblInicioPrincipal.ForeColor = Color.FromArgb(17, 9, 64);
            lblInicioPrincipal.Location = new Point(23, 78);
            lblInicioPrincipal.Name = "lblInicioPrincipal";
            lblInicioPrincipal.Size = new Size(66, 24);
            lblInicioPrincipal.TabIndex = 12;
            lblInicioPrincipal.Text = "INICIO";
            // 
            // pnlTotalProductos
            // 
            pnlTotalProductos.BackColor = Color.AliceBlue;
            pnlTotalProductos.BorderColor = Color.FromArgb(213, 220, 230);
            pnlTotalProductos.BorderRadius = 8;
            pnlTotalProductos.BorderThickness = 1;
            pnlTotalProductos.Controls.Add(label1);
            pnlTotalProductos.Controls.Add(pictureBox3);
            pnlTotalProductos.Controls.Add(lblTotalProductos);
            pnlTotalProductos.CustomizableEdges = customizableEdges1;
            pnlTotalProductos.FillColor = Color.White;
            pnlTotalProductos.Location = new Point(23, 141);
            pnlTotalProductos.Name = "pnlTotalProductos";
            pnlTotalProductos.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlTotalProductos.Size = new Size(396, 97);
            pnlTotalProductos.TabIndex = 29;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label1.ForeColor = Color.SlateGray;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(85, 53);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 37;
            label1.Text = "Total de productos";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 38);
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.BackColor = Color.White;
            lblTotalProductos.Font = new Font("Segoe UI Variable Display Semib", 22F, FontStyle.Bold);
            lblTotalProductos.ForeColor = Color.FromArgb(17, 9, 64);
            lblTotalProductos.ImageAlign = ContentAlignment.TopLeft;
            lblTotalProductos.Location = new Point(85, 15);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(76, 38);
            lblTotalProductos.TabIndex = 23;
            lblTotalProductos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStockBajo
            // 
            lblStockBajo.BackColor = Color.White;
            lblStockBajo.Font = new Font("Segoe UI Variable Display Semib", 22F, FontStyle.Bold);
            lblStockBajo.ForeColor = Color.FromArgb(255, 128, 0);
            lblStockBajo.ImageAlign = ContentAlignment.TopLeft;
            lblStockBajo.Location = new Point(85, 15);
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(87, 38);
            lblStockBajo.TabIndex = 22;
            lblStockBajo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResumenGeneral
            // 
            lblResumenGeneral.AutoSize = true;
            lblResumenGeneral.BackColor = Color.Transparent;
            lblResumenGeneral.Font = new Font("Segoe UI Variable Display Semib", 10F);
            lblResumenGeneral.ForeColor = Color.FromArgb(17, 9, 64);
            lblResumenGeneral.Location = new Point(23, 102);
            lblResumenGeneral.Name = "lblResumenGeneral";
            lblResumenGeneral.Size = new Size(203, 19);
            lblResumenGeneral.TabIndex = 22;
            lblResumenGeneral.Text = "Resumen general del inventario";
            // 
            // pnlStockBajo
            // 
            pnlStockBajo.BackColor = Color.AliceBlue;
            pnlStockBajo.BorderColor = Color.FromArgb(213, 220, 230);
            pnlStockBajo.BorderRadius = 8;
            pnlStockBajo.BorderThickness = 1;
            pnlStockBajo.Controls.Add(label2);
            pnlStockBajo.Controls.Add(pictureBox4);
            pnlStockBajo.Controls.Add(lblStockBajo);
            pnlStockBajo.CustomizableEdges = customizableEdges3;
            pnlStockBajo.FillColor = Color.White;
            pnlStockBajo.Location = new Point(439, 141);
            pnlStockBajo.Name = "pnlStockBajo";
            pnlStockBajo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlStockBajo.Size = new Size(396, 97);
            pnlStockBajo.TabIndex = 30;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label2.ForeColor = Color.SlateGray;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(85, 53);
            label2.Name = "label2";
            label2.Size = new Size(87, 31);
            label2.TabIndex = 38;
            label2.Text = "Stock bajo";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 19);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 42);
            pictureBox4.TabIndex = 37;
            pictureBox4.TabStop = false;
            // 
            // pnlGestionarCategoria
            // 
            pnlGestionarCategoria.BackColor = Color.AliceBlue;
            pnlGestionarCategoria.BorderColor = Color.FromArgb(213, 220, 230);
            pnlGestionarCategoria.BorderRadius = 8;
            pnlGestionarCategoria.BorderThickness = 1;
            pnlGestionarCategoria.Controls.Add(pictureBox1);
            pnlGestionarCategoria.Controls.Add(lblCategoria);
            pnlGestionarCategoria.Controls.Add(lblDescripcionCategoria);
            pnlGestionarCategoria.Controls.Add(btnCategorias);
            pnlGestionarCategoria.CustomizableEdges = customizableEdges5;
            pnlGestionarCategoria.FillColor = Color.White;
            pnlGestionarCategoria.Location = new Point(23, 259);
            pnlGestionarCategoria.Name = "pnlGestionarCategoria";
            pnlGestionarCategoria.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlGestionarCategoria.Size = new Size(396, 134);
            pnlGestionarCategoria.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 38);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // lblCategoria
            // 
            lblCategoria.BackColor = Color.White;
            lblCategoria.Font = new Font("Segoe UI Variable Display", 15F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(17, 9, 64);
            lblCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            lblCategoria.Location = new Point(84, 19);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(250, 33);
            lblCategoria.TabIndex = 34;
            lblCategoria.Text = "Categorías";
            lblCategoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescripcionCategoria
            // 
            lblDescripcionCategoria.AutoSize = true;
            lblDescripcionCategoria.BackColor = Color.Transparent;
            lblDescripcionCategoria.Font = new Font("Segoe UI Variable Display Semib", 10F);
            lblDescripcionCategoria.ForeColor = Color.SlateGray;
            lblDescripcionCategoria.Location = new Point(85, 52);
            lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            lblDescripcionCategoria.Size = new Size(253, 19);
            lblDescripcionCategoria.TabIndex = 23;
            lblDescripcionCategoria.Text = "Administrar las categorías de productos";
            // 
            // dgvStockBajo
            // 
            dgvStockBajo.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvStockBajo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(17, 8, 61);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(17, 8, 61);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvStockBajo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvStockBajo.ColumnHeadersHeight = 36;
            dgvStockBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvStockBajo.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvStockBajo.DefaultCellStyle = dataGridViewCellStyle3;
            dgvStockBajo.GridColor = Color.FromArgb(226, 232, 240);
            dgvStockBajo.Location = new Point(18, 50);
            dgvStockBajo.MultiSelect = false;
            dgvStockBajo.Name = "dgvStockBajo";
            dgvStockBajo.ReadOnly = true;
            dgvStockBajo.RowHeadersVisible = false;
            dgvStockBajo.Size = new Size(771, 157);
            dgvStockBajo.TabIndex = 32;
            dgvStockBajo.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvStockBajo.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvStockBajo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dgvStockBajo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvStockBajo.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvStockBajo.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(17, 8, 61);
            dgvStockBajo.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvStockBajo.ThemeStyle.HeaderStyle.Height = 36;
            dgvStockBajo.ThemeStyle.ReadOnly = true;
            dgvStockBajo.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvStockBajo.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvStockBajo.ThemeStyle.RowsStyle.Height = 25;
            dgvStockBajo.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dgvStockBajo.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            // 
            // pnlStock
            // 
            pnlStock.BackColor = Color.AliceBlue;
            pnlStock.BorderColor = Color.FromArgb(213, 220, 230);
            pnlStock.BorderRadius = 8;
            pnlStock.BorderThickness = 1;
            pnlStock.Controls.Add(lblProductosStockBajo);
            pnlStock.Controls.Add(dgvStockBajo);
            pnlStock.CustomizableEdges = customizableEdges7;
            pnlStock.FillColor = Color.White;
            pnlStock.Location = new Point(23, 424);
            pnlStock.Name = "pnlStock";
            pnlStock.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlStock.Size = new Size(812, 223);
            pnlStock.TabIndex = 33;
            // 
            // lblProductosStockBajo
            // 
            lblProductosStockBajo.BackColor = Color.White;
            lblProductosStockBajo.Font = new Font("Segoe UI Variable Display", 15F, FontStyle.Bold);
            lblProductosStockBajo.ForeColor = Color.FromArgb(17, 9, 64);
            lblProductosStockBajo.Image = (Image)resources.GetObject("lblProductosStockBajo.Image");
            lblProductosStockBajo.ImageAlign = ContentAlignment.MiddleLeft;
            lblProductosStockBajo.Location = new Point(15, 14);
            lblProductosStockBajo.Name = "lblProductosStockBajo";
            lblProductosStockBajo.Size = new Size(285, 33);
            lblProductosStockBajo.TabIndex = 33;
            lblProductosStockBajo.Text = "Productos con stock bajo";
            lblProductosStockBajo.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlGestionarProductos
            // 
            pnlGestionarProductos.BackColor = Color.AliceBlue;
            pnlGestionarProductos.BorderColor = Color.FromArgb(213, 220, 230);
            pnlGestionarProductos.BorderRadius = 8;
            pnlGestionarProductos.BorderThickness = 1;
            pnlGestionarProductos.Controls.Add(pictureBox2);
            pnlGestionarProductos.Controls.Add(lblProducto);
            pnlGestionarProductos.Controls.Add(lblDescripcionProducto);
            pnlGestionarProductos.Controls.Add(btnProductos);
            pnlGestionarProductos.CustomizableEdges = customizableEdges9;
            pnlGestionarProductos.FillColor = Color.White;
            pnlGestionarProductos.Location = new Point(439, 259);
            pnlGestionarProductos.Name = "pnlGestionarProductos";
            pnlGestionarProductos.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlGestionarProductos.Size = new Size(396, 134);
            pnlGestionarProductos.TabIndex = 36;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 38);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // lblProducto
            // 
            lblProducto.BackColor = Color.White;
            lblProducto.Font = new Font("Segoe UI Variable Display", 15F, FontStyle.Bold);
            lblProducto.ForeColor = Color.FromArgb(17, 9, 64);
            lblProducto.ImageAlign = ContentAlignment.MiddleLeft;
            lblProducto.Location = new Point(84, 19);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(250, 33);
            lblProducto.TabIndex = 34;
            lblProducto.Text = "Productos";
            lblProducto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescripcionProducto
            // 
            lblDescripcionProducto.AutoSize = true;
            lblDescripcionProducto.BackColor = Color.Transparent;
            lblDescripcionProducto.Font = new Font("Segoe UI Variable Display Semib", 10F);
            lblDescripcionProducto.ForeColor = Color.SlateGray;
            lblDescripcionProducto.Location = new Point(85, 52);
            lblDescripcionProducto.Name = "lblDescripcionProducto";
            lblDescripcionProducto.Size = new Size(218, 19);
            lblDescripcionProducto.TabIndex = 23;
            lblDescripcionProducto.Text = "Registrar, buscar, editar y eliminar";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(888, 658);
            Controls.Add(pnlGestionarProductos);
            Controls.Add(pnlStock);
            Controls.Add(pnlGestionarCategoria);
            Controls.Add(pnlStockBajo);
            Controls.Add(lblResumenGeneral);
            Controls.Add(pnlTotalProductos);
            Controls.Add(lblInicioPrincipal);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(31, 42, 68);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TECHSTORE UISIL";
            pnlMenu.ResumeLayout(false);
            pnlTotalProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlStockBajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlGestionarCategoria.ResumeLayout(false);
            pnlGestionarCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).EndInit();
            pnlStock.ResumeLayout(false);
            pnlGestionarProductos.ResumeLayout(false);
            pnlGestionarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCategorias;
        private Button btnProductos;
        private Panel pnlMenu;
        private Label lblLogoInicio;
        private Button btnCerrarSesion;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnInicioPrincipal;
        private Panel pnlLineaInicio;
        private Label lblInicioPrincipal;
        private Guna.UI2.WinForms.Guna2Panel pnlTotalProductos;
        private Label lblStockBajo;
        private Label lblResumenGeneral;
        private Label lblTotalProductos;
        private Guna.UI2.WinForms.Guna2Panel pnlStockBajo;
        private Guna.UI2.WinForms.Guna2Panel pnlGestionarCategoria;
        private Label lblDescripcionCategoria;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStockBajo;
        private Guna.UI2.WinForms.Guna2Panel pnlStock;
        private Label lblProductosStockBajo;
        private PictureBox pictureBox1;
        private Label lblCategoria;
        private Guna.UI2.WinForms.Guna2Panel pnlGestionarProductos;
        private PictureBox pictureBox2;
        private Label lblProducto;
        private Label lblDescripcionProducto;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
    }
}
