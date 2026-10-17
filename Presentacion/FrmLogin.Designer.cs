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
            picLogo = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblCreadoPara = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlVidrio = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            btnIngresarSesion.Location = new Point(413, 265);
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
            btnCancelarSesion.Location = new Point(413, 329);
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
            lblSesion.Location = new Point(487, 39);
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
            lblCreadoPara.Location = new Point(539, 407);
            lblCreadoPara.Name = "lblCreadoPara";
            lblCreadoPara.Size = new Size(57, 12);
            lblCreadoPara.TabIndex = 11;
            lblCreadoPara.Text = "2026 UISIL.";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(516, 401);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 26);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(748, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 453);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pnlVidrio
            // 
            pnlVidrio.BackColor = Color.FromArgb(90, 255, 255, 255);
            pnlVidrio.Location = new Point(396, 1);
            pnlVidrio.Name = "pnlVidrio";
            pnlVidrio.Size = new Size(353, 438);
            pnlVidrio.TabIndex = 14;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1110, 436);
            Controls.Add(pnlVidrio);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(lblCreadoPara);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblSesion);
            Controls.Add(picLogo);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelarSesion);
            Controls.Add(btnIngresarSesion);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private PictureBox picLogo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblCreadoPara;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Panel pnlVidrio;
    }
}