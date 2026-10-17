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
            pnlGestion = new Panel();
            lblUISIL = new Label();
            pictureBox1 = new PictureBox();
            pnlGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnProbarConexion.Location = new Point(302, 390);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(240, 49);
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
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 230, 247);
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 244, 252);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.FromArgb(17, 9, 64);
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(302, 302);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(183, 37);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = " Categorías";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Transparent;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderColor = Color.White;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 230, 247);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 244, 252);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnProductos.ForeColor = Color.FromArgb(17, 9, 64);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(302, 195);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(183, 50);
            btnProductos.TabIndex = 2;
            btnProductos.Text = " Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(117, 18);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(353, 31);
            lblSubtitulo.TabIndex = 5;
            lblSubtitulo.Text = "Bienvenido al sistema de gestión";
            // 
            // pnlGestion
            // 
            pnlGestion.BackColor = Color.FromArgb(17, 9, 64);
            pnlGestion.Controls.Add(lblSubtitulo);
            pnlGestion.Location = new Point(-2, 45);
            pnlGestion.Name = "pnlGestion";
            pnlGestion.Size = new Size(579, 70);
            pnlGestion.TabIndex = 8;
            // 
            // lblUISIL
            // 
            lblUISIL.AutoSize = true;
            lblUISIL.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUISIL.ForeColor = Color.FromArgb(17, 9, 64);
            lblUISIL.Location = new Point(12, 9);
            lblUISIL.Name = "lblUISIL";
            lblUISIL.Size = new Size(65, 30);
            lblUISIL.TabIndex = 9;
            lblUISIL.Text = "UISIL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-68, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 405);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(575, 522);
            Controls.Add(lblUISIL);
            Controls.Add(btnProbarConexion);
            Controls.Add(btnCategorias);
            Controls.Add(btnProductos);
            Controls.Add(pnlGestion);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(31, 42, 68);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TECHSTORE UISIL";
            pnlGestion.ResumeLayout(false);
            pnlGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProbarConexion;
        private Button btnCategorias;
        private Button btnProductos;
        private Label lblSubtitulo;
        private Panel pnlGestion;
        private Label lblUISIL;
        private PictureBox pictureBox1;
    }
}
