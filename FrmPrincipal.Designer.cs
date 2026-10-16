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
            btnProbarConexion = new Button();
            btnCategorias = new Button();
            btnProductos = new Button();
            SuspendLayout();
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(268, 246);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(189, 23);
            btnProbarConexion.TabIndex = 0;
            btnProbarConexion.Text = "Probar conexión con SQL Server";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(270, 39);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(187, 23);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Gestionar categorías";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(270, 90);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(187, 23);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Gestionar productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 370);
            Controls.Add(btnProductos);
            Controls.Add(btnCategorias);
            Controls.Add(btnProbarConexion);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProbarConexion;
        private Button btnCategorias;
        private Button btnProductos;
    }
}
