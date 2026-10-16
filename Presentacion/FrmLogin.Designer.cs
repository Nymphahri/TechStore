namespace TechStore.Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnIngresarSesion = new Button();
            btnCancelarSesion = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblUsuario = new Label();
            lblContrasena = new Label();
            errorProviderLogin = new ErrorProvider(components);
            lblSesion = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresarSesion
            // 
            btnIngresarSesion.BackColor = Color.White;
            btnIngresarSesion.Cursor = Cursors.Hand;
            btnIngresarSesion.FlatAppearance.BorderColor = Color.FromArgb(217, 222, 232);
            btnIngresarSesion.FlatAppearance.BorderSize = 0;
            btnIngresarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 230, 247);
            btnIngresarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 244, 252);
            btnIngresarSesion.FlatStyle = FlatStyle.Flat;
            btnIngresarSesion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnIngresarSesion.ForeColor = Color.FromArgb(31, 42, 68);
            btnIngresarSesion.Location = new Point(418, 290);
            btnIngresarSesion.Name = "btnIngresarSesion";
            btnIngresarSesion.Size = new Size(300, 40);
            btnIngresarSesion.TabIndex = 0;
            btnIngresarSesion.Text = "Ingresar";
            btnIngresarSesion.UseVisualStyleBackColor = false;
            btnIngresarSesion.Click += btnIngresar_Click;
            // 
            // btnCancelarSesion
            // 
            btnCancelarSesion.BackColor = Color.White;
            btnCancelarSesion.Cursor = Cursors.Hand;
            btnCancelarSesion.FlatAppearance.BorderColor = Color.FromArgb(217, 222, 232);
            btnCancelarSesion.FlatAppearance.BorderSize = 0;
            btnCancelarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 230, 247);
            btnCancelarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 244, 252);
            btnCancelarSesion.FlatStyle = FlatStyle.Flat;
            btnCancelarSesion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCancelarSesion.ForeColor = Color.FromArgb(31, 42, 68);
            btnCancelarSesion.Location = new Point(418, 358);
            btnCancelarSesion.Name = "btnCancelarSesion";
            btnCancelarSesion.Size = new Size(300, 36);
            btnCancelarSesion.TabIndex = 1;
            btnCancelarSesion.Text = "Cancelar";
            btnCancelarSesion.UseVisualStyleBackColor = false;
            btnCancelarSesion.Click += btnCancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.Hand;
            txtUsuario.ForeColor = Color.FromArgb(31, 42, 68);
            txtUsuario.Location = new Point(418, 140);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 25);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Cursor = Cursors.Hand;
            txtContrasena.ForeColor = Color.FromArgb(31, 42, 68);
            txtContrasena.Location = new Point(418, 210);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(300, 25);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.FromArgb(31, 42, 68);
            lblUsuario.Location = new Point(418, 117);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 17);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.ForeColor = Color.FromArgb(31, 42, 68);
            lblContrasena.Location = new Point(418, 187);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(77, 17);
            lblContrasena.TabIndex = 6;
            lblContrasena.Text = "Contraseña:";
            // 
            // errorProviderLogin
            // 
            errorProviderLogin.ContainerControl = this;
            // 
            // lblSesion
            // 
            lblSesion.AutoSize = true;
            lblSesion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSesion.ForeColor = Color.FromArgb(31, 42, 68);
            lblSesion.Location = new Point(492, 43);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(156, 30);
            lblSesion.TabIndex = 8;
            lblSesion.Text = "Inicio de sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 456);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(754, 446);
            Controls.Add(lblSesion);
            Controls.Add(pictureBox1);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelarSesion);
            Controls.Add(btnIngresarSesion);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechStore";
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresarSesion;
        private Button btnCancelarSesion;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label lblUsuario;
        private Label lblContrasena;
        private ErrorProvider errorProviderLogin;
        private Label lblSesion;
        private PictureBox pictureBox1;
    }
}