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
            btnCategorias = new Button();
            btnProductos = new Button();
            btnProbarConexion = new Button();
            panel2 = new Panel();
            picConexion = new PictureBox();
            picCategorias = new PictureBox();
            picProductos = new PictureBox();
            picLogoSharp = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblSubtitulo = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picConexion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogoSharp).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.Transparent;
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderColor = Color.White;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 12, 75);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(0, 235);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(218, 37);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Transparent;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderColor = Color.White;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 12, 75);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 80);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(218, 33);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.BackColor = Color.Transparent;
            btnProbarConexion.Cursor = Cursors.Help;
            btnProbarConexion.FlatAppearance.BorderColor = Color.White;
            btnProbarConexion.FlatAppearance.BorderSize = 0;
            btnProbarConexion.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProbarConexion.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 12, 75);
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnProbarConexion.ForeColor = Color.White;
            btnProbarConexion.Location = new Point(3, 391);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(228, 30);
            btnProbarConexion.TabIndex = 0;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.UseVisualStyleBackColor = false;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(picConexion);
            panel2.Controls.Add(picCategorias);
            panel2.Controls.Add(picProductos);
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnCategorias);
            panel2.Controls.Add(btnProbarConexion);
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 451);
            panel2.TabIndex = 7;
            // 
            // picConexion
            // 
            picConexion.BackColor = Color.Transparent;
            picConexion.Image = (Image)resources.GetObject("picConexion.Image");
            picConexion.Location = new Point(89, 345);
            picConexion.Name = "picConexion";
            picConexion.Size = new Size(42, 40);
            picConexion.TabIndex = 5;
            picConexion.TabStop = false;
            // 
            // picCategorias
            // 
            picCategorias.BackColor = Color.Transparent;
            picCategorias.Image = (Image)resources.GetObject("picCategorias.Image");
            picCategorias.Location = new Point(89, 189);
            picCategorias.Name = "picCategorias";
            picCategorias.Size = new Size(42, 40);
            picCategorias.TabIndex = 4;
            picCategorias.TabStop = false;
            // 
            // picProductos
            // 
            picProductos.BackColor = Color.Transparent;
            picProductos.Image = (Image)resources.GetObject("picProductos.Image");
            picProductos.Location = new Point(89, 34);
            picProductos.Name = "picProductos";
            picProductos.Size = new Size(42, 40);
            picProductos.TabIndex = 3;
            picProductos.TabStop = false;
            // 
            // picLogoSharp
            // 
            picLogoSharp.Image = Properties.Resources.TechStoreUisil2;
            picLogoSharp.Location = new Point(211, 39);
            picLogoSharp.Name = "picLogoSharp";
            picLogoSharp.Size = new Size(420, 488);
            picLogoSharp.TabIndex = 8;
            picLogoSharp.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 64);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 37);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(31, 42, 68);
            lblSubtitulo.Location = new Point(49, 15);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(330, 30);
            lblSubtitulo.TabIndex = 5;
            lblSubtitulo.Text = "Bienvenido al Sistema de Gestión";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(629, 485);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(picLogoSharp);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(31, 42, 68);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE GESTIÓN";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picConexion).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogoSharp).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCategorias;
        private Button btnProductos;
        private Button btnProbarConexion;
        private Panel panel2;
        private PictureBox picLogoSharp;
        private Panel panel1;
        private Label lblSubtitulo;
        private PictureBox pictureBox1;
        private PictureBox picConexion;
        private PictureBox picCategorias;
        private PictureBox picProductos;
    }
}
