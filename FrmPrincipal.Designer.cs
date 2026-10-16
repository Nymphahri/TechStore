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
            btnProbarConexion = new Button();
            btnCategorias = new Button();
            btnProductos = new Button();
            lblSubtitulo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.BackColor = Color.White;
            btnProbarConexion.Cursor = Cursors.Help;
            btnProbarConexion.FlatAppearance.BorderColor = Color.FromArgb(217, 222, 232);
            btnProbarConexion.FlatAppearance.BorderSize = 0;
            btnProbarConexion.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 230, 247);
            btnProbarConexion.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 244, 252);
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnProbarConexion.ForeColor = Color.FromArgb(31, 42, 68);
            btnProbarConexion.Location = new Point(567, 407);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(121, 30);
            btnProbarConexion.TabIndex = 0;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.UseVisualStyleBackColor = false;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.White;
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderColor = Color.FromArgb(217, 222, 232);
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 230, 247);
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 244, 252);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.FromArgb(31, 42, 68);
            btnCategorias.Location = new Point(656, 190);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(143, 77);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.White;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderColor = Color.FromArgb(217, 222, 232);
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 230, 247);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 244, 252);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnProductos.ForeColor = Color.FromArgb(31, 42, 68);
            btnProductos.Location = new Point(456, 190);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(143, 77);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(31, 42, 68);
            lblSubtitulo.Location = new Point(399, 69);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(448, 30);
            lblSubtitulo.TabIndex = 5;
            lblSubtitulo.Text = "Bienvenido al Sistema de Gestión de Productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 456);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(859, 449);
            Controls.Add(pictureBox1);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnProductos);
            Controls.Add(btnProbarConexion);
            Controls.Add(btnCategorias);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(31, 42, 68);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechStore";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProbarConexion;
        private Button btnCategorias;
        private Button btnProductos;
        private Label lblSubtitulo;
        private PictureBox pictureBox1;
    }
}
