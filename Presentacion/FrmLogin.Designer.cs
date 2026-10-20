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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblUsuario = new Label();
            lblContrasena = new Label();
            errorProviderLogin = new ErrorProvider(components);
            lblSesion = new Label();
            picLogo = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblCreadoPara = new Label();
            picCopyRights = new PictureBox();
            picLogo2 = new PictureBox();
            btnIngresarSesion = new Guna.UI2.WinForms.Guna2Button();
            btnSalirSesion = new Guna.UI2.WinForms.Guna2Button();
            btnProbarConexion = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCopyRights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo2).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.Hand;
            txtUsuario.ForeColor = Color.FromArgb(31, 42, 68);
            txtUsuario.Location = new Point(413, 124);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 25);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Cursor = Cursors.Hand;
            txtContrasena.ForeColor = Color.FromArgb(31, 42, 68);
            txtContrasena.Location = new Point(413, 194);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(300, 25);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.FromArgb(31, 42, 68);
            lblUsuario.Location = new Point(413, 101);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 17);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.ForeColor = Color.FromArgb(31, 42, 68);
            lblContrasena.Location = new Point(413, 171);
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
            lblSesion.Location = new Point(488, 39);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(156, 30);
            lblSesion.TabIndex = 8;
            lblSesion.Text = "Inicio de sesión";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(-15, -47);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(409, 485);
            picLogo.TabIndex = 7;
            picLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(691, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 16);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(691, 199);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 16);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // lblCreadoPara
            // 
            lblCreadoPara.AutoSize = true;
            lblCreadoPara.BackColor = Color.Transparent;
            lblCreadoPara.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold);
            lblCreadoPara.ForeColor = Color.FromArgb(31, 42, 68);
            lblCreadoPara.Location = new Point(548, 406);
            lblCreadoPara.Name = "lblCreadoPara";
            lblCreadoPara.Size = new Size(57, 12);
            lblCreadoPara.TabIndex = 11;
            lblCreadoPara.Text = "2026 UISIL.";
            // 
            // picCopyRights
            // 
            picCopyRights.BackColor = Color.Transparent;
            picCopyRights.Image = (Image)resources.GetObject("picCopyRights.Image");
            picCopyRights.Location = new Point(525, 400);
            picCopyRights.Name = "picCopyRights";
            picCopyRights.Size = new Size(23, 26);
            picCopyRights.TabIndex = 12;
            picCopyRights.TabStop = false;
            // 
            // picLogo2
            // 
            picLogo2.Image = (Image)resources.GetObject("picLogo2.Image");
            picLogo2.Location = new Point(740, -15);
            picLogo2.Name = "picLogo2";
            picLogo2.Size = new Size(367, 453);
            picLogo2.TabIndex = 13;
            picLogo2.TabStop = false;
            // 
            // btnIngresarSesion
            // 
            btnIngresarSesion.BackColor = Color.AliceBlue;
            btnIngresarSesion.BorderColor = Color.Lavender;
            btnIngresarSesion.BorderRadius = 8;
            btnIngresarSesion.BorderThickness = 1;
            btnIngresarSesion.Cursor = Cursors.Hand;
            btnIngresarSesion.CustomizableEdges = customizableEdges5;
            btnIngresarSesion.DisabledState.BorderColor = Color.DarkGray;
            btnIngresarSesion.DisabledState.CustomBorderColor = Color.DarkGray;
            btnIngresarSesion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnIngresarSesion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnIngresarSesion.FillColor = Color.White;
            btnIngresarSesion.FocusedColor = Color.FromArgb(42, 32, 112);
            btnIngresarSesion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnIngresarSesion.ForeColor = Color.FromArgb(31, 42, 68);
            btnIngresarSesion.HoverState.FillColor = Color.FromArgb(210, 230, 247);
            btnIngresarSesion.Location = new Point(413, 245);
            btnIngresarSesion.Name = "btnIngresarSesion";
            btnIngresarSesion.PressedColor = Color.FromArgb(42, 32, 112);
            btnIngresarSesion.ShadowDecoration.BorderRadius = 8;
            btnIngresarSesion.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnIngresarSesion.Size = new Size(300, 45);
            btnIngresarSesion.TabIndex = 14;
            btnIngresarSesion.Text = "Ingresar";
            btnIngresarSesion.Click += btnIngresarSesion_Click;
            // 
            // btnSalirSesion
            // 
            btnSalirSesion.BorderColor = Color.Lavender;
            btnSalirSesion.BorderRadius = 8;
            btnSalirSesion.BorderThickness = 1;
            btnSalirSesion.Cursor = Cursors.Hand;
            btnSalirSesion.CustomizableEdges = customizableEdges3;
            btnSalirSesion.DisabledState.BorderColor = Color.DarkGray;
            btnSalirSesion.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalirSesion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalirSesion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalirSesion.FillColor = Color.White;
            btnSalirSesion.FocusedColor = Color.FromArgb(42, 32, 112);
            btnSalirSesion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSalirSesion.ForeColor = Color.FromArgb(31, 42, 68);
            btnSalirSesion.HoverState.FillColor = Color.FromArgb(210, 230, 247);
            btnSalirSesion.Location = new Point(413, 306);
            btnSalirSesion.Name = "btnSalirSesion";
            btnSalirSesion.PressedColor = Color.FromArgb(42, 32, 112);
            btnSalirSesion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSalirSesion.Size = new Size(300, 45);
            btnSalirSesion.TabIndex = 15;
            btnSalirSesion.Text = "Salir";
            btnSalirSesion.Click += btnSalirSesion_Click;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.BorderColor = Color.Transparent;
            btnProbarConexion.BorderRadius = 8;
            btnProbarConexion.BorderThickness = 1;
            btnProbarConexion.CustomizableEdges = customizableEdges1;
            btnProbarConexion.DisabledState.BorderColor = Color.DarkGray;
            btnProbarConexion.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProbarConexion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProbarConexion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProbarConexion.FillColor = Color.Transparent;
            btnProbarConexion.FocusedColor = Color.FromArgb(42, 32, 112);
            btnProbarConexion.Font = new Font("Segoe UI", 9F);
            btnProbarConexion.ForeColor = Color.FromArgb(31, 42, 68);
            btnProbarConexion.HoverState.FillColor = Color.FromArgb(210, 230, 247);
            btnProbarConexion.HoverState.ForeColor = Color.FromArgb(42, 32, 112);
            btnProbarConexion.Location = new Point(503, 357);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.PressedColor = Color.FromArgb(42, 32, 112);
            btnProbarConexion.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnProbarConexion.Size = new Size(119, 17);
            btnProbarConexion.TabIndex = 38;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1105, 436);
            Controls.Add(btnProbarConexion);
            Controls.Add(btnSalirSesion);
            Controls.Add(btnIngresarSesion);
            Controls.Add(picLogo2);
            Controls.Add(picCopyRights);
            Controls.Add(lblCreadoPara);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblSesion);
            Controls.Add(picLogo);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(31, 42, 68);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TECHSTORE UISIL";
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCopyRights).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label lblUsuario;
        private Label lblContrasena;
        private ErrorProvider errorProviderLogin;
        private Label lblSesion;
        private PictureBox picLogo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblCreadoPara;
        private PictureBox picCopyRights;
        private PictureBox picLogo2;
        private Guna.UI2.WinForms.Guna2Button btnIngresarSesion;
        private Guna.UI2.WinForms.Guna2Button btnSalirSesion;
        private Guna.UI2.WinForms.Guna2Button btnProbarConexion;
    }
}