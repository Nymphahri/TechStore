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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnProbarConexion = new Button();
            btnCategorias = new Button();
            btnProductos = new Button();
            pnlMenu = new Panel();
            btnCerrarSesion = new Button();
            btnInicioPrincipal = new Button();
            lblLogoInicio = new Label();
            lblUISIL = new Label();
            lblResumenInventario = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.BackColor = Color.Transparent;
            btnProbarConexion.Cursor = Cursors.Help;
            btnProbarConexion.FlatAppearance.BorderColor = Color.White;
            btnProbarConexion.FlatAppearance.BorderSize = 0;
            btnProbarConexion.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 230, 247);
            btnProbarConexion.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 244, 252);
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnProbarConexion.ForeColor = Color.FromArgb(17, 9, 64);
            btnProbarConexion.Image = (Image)resources.GetObject("btnProbarConexion.Image");
            btnProbarConexion.ImageAlign = ContentAlignment.MiddleLeft;
            btnProbarConexion.Location = new Point(15, 552);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(245, 49);
            btnProbarConexion.TabIndex = 0;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.UseVisualStyleBackColor = false;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.Transparent;
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderColor = Color.White;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 32, 112);
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 32, 112);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 10F);
            btnCategorias.ForeColor = Color.FromArgb(201, 198, 232);
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(32, 242);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(183, 37);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "          Categorías";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Transparent;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderColor = Color.White;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 32, 112);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 32, 112);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 10F);
            btnProductos.ForeColor = Color.FromArgb(201, 198, 232);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(29, 168);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(183, 50);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "           Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(17, 9, 64);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Controls.Add(btnInicioPrincipal);
            pnlMenu.Controls.Add(lblLogoInicio);
            pnlMenu.Controls.Add(btnProductos);
            pnlMenu.Controls.Add(btnCategorias);
            pnlMenu.Location = new Point(-2, -1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(236, 547);
            pnlMenu.TabIndex = 8;
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
            btnCerrarSesion.Font = new Font("Segoe UI", 10F);
            btnCerrarSesion.ForeColor = Color.FromArgb(201, 198, 232);
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(28, 459);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(156, 52);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "            Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnInicioPrincipal
            // 
            btnInicioPrincipal.BackColor = Color.Transparent;
            btnInicioPrincipal.Cursor = Cursors.Hand;
            btnInicioPrincipal.FlatAppearance.BorderColor = Color.FromArgb(17, 9, 64);
            btnInicioPrincipal.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 32, 112);
            btnInicioPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 32, 112);
            btnInicioPrincipal.FlatStyle = FlatStyle.Flat;
            btnInicioPrincipal.Font = new Font("Segoe UI", 10F);
            btnInicioPrincipal.ForeColor = Color.FromArgb(201, 198, 232);
            btnInicioPrincipal.Image = (Image)resources.GetObject("btnInicioPrincipal.Image");
            btnInicioPrincipal.ImageAlign = ContentAlignment.TopLeft;
            btnInicioPrincipal.Location = new Point(31, 105);
            btnInicioPrincipal.Name = "btnInicioPrincipal";
            btnInicioPrincipal.Size = new Size(183, 50);
            btnInicioPrincipal.TabIndex = 10;
            btnInicioPrincipal.Text = "          Inicio";
            btnInicioPrincipal.TextAlign = ContentAlignment.MiddleLeft;
            btnInicioPrincipal.UseVisualStyleBackColor = false;
            // 
            // lblLogoInicio
            // 
            lblLogoInicio.BackColor = Color.FromArgb(17, 9, 64);
            lblLogoInicio.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblLogoInicio.ForeColor = Color.White;
            lblLogoInicio.Image = (Image)resources.GetObject("lblLogoInicio.Image");
            lblLogoInicio.ImageAlign = ContentAlignment.BottomLeft;
            lblLogoInicio.Location = new Point(14, 30);
            lblLogoInicio.Name = "lblLogoInicio";
            lblLogoInicio.Size = new Size(222, 56);
            lblLogoInicio.TabIndex = 0;
            lblLogoInicio.Text = "         TechStore";
            // 
            // lblUISIL
            // 
            lblUISIL.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUISIL.ForeColor = Color.FromArgb(17, 9, 64);
            lblUISIL.Image = (Image)resources.GetObject("lblUISIL.Image");
            lblUISIL.ImageAlign = ContentAlignment.TopLeft;
            lblUISIL.Location = new Point(833, 29);
            lblUISIL.Name = "lblUISIL";
            lblUISIL.Size = new Size(106, 36);
            lblUISIL.TabIndex = 9;
            lblUISIL.Text = "      uisil";
            // 
            // lblResumenInventario
            // 
            lblResumenInventario.AutoSize = true;
            lblResumenInventario.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblResumenInventario.Location = new Point(264, 28);
            lblResumenInventario.Name = "lblResumenInventario";
            lblResumenInventario.Size = new Size(297, 37);
            lblResumenInventario.TabIndex = 10;
            lblResumenInventario.Text = "Resumen de inventario";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 42, 68);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(264, 241);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(675, 176);
            guna2DataGridView1.TabIndex = 11;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(31, 42, 68);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(965, 603);
            Controls.Add(guna2DataGridView1);
            Controls.Add(lblResumenInventario);
            Controls.Add(lblUISIL);
            Controls.Add(btnProbarConexion);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(31, 42, 68);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TECHSTORE UISIL";
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProbarConexion;
        private Button btnCategorias;
        private Button btnProductos;
        private Panel pnlMenu;
        private Label lblUISIL;
        private Label lblLogoInicio;
        private Button btnCerrarSesion;
        private Button btnInicioPrincipal;
        private Label lblResumenInventario;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
