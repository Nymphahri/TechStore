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
            SuspendLayout();
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(12, 429);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(189, 23);
            btnProbarConexion.TabIndex = 0;
            btnProbarConexion.Text = "Probar conexión con SQL Server";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 464);
            Controls.Add(btnProbarConexion);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Productos TechStore";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProbarConexion;
    }
}
