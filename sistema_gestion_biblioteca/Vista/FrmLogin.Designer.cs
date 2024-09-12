namespace sistema_gestion_biblioteca.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtUsuario = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtClave = new TextBox();
            btnIngresar = new Button();
            lblInicioSesion = new Label();
            lnkOlvidoClave = new LinkLabel();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Arial Rounded MT Bold", 12.75F);
            txtUsuario.ForeColor = Color.Silver;
            txtUsuario.Location = new Point(302, 96);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "  Ingrese su usuario";
            txtUsuario.Size = new Size(390, 28);
            txtUsuario.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.Location = new Point(302, 124);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(390, 1);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGray;
            textBox2.Location = new Point(302, 184);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(390, 1);
            textBox2.TabIndex = 5;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(15, 15, 15);
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Cursor = Cursors.IBeam;
            txtClave.Font = new Font("Arial Rounded MT Bold", 12.75F);
            txtClave.ForeColor = Color.Silver;
            txtClave.Location = new Point(302, 156);
            txtClave.Multiline = true;
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '•';
            txtClave.PlaceholderText = "  Ingrese su contreseña";
            txtClave.Size = new Size(390, 28);
            txtClave.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(40, 40, 40);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.Silver;
            btnIngresar.Location = new Point(302, 214);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(390, 37);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInicioSesion.ForeColor = Color.Silver;
            lblInicioSesion.Location = new Point(400, 38);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(195, 33);
            lblInicioSesion.TabIndex = 7;
            lblInicioSesion.Text = "Inicia Sesión";
            // 
            // lnkOlvidoClave
            // 
            lnkOlvidoClave.ActiveLinkColor = Color.Gray;
            lnkOlvidoClave.AutoSize = true;
            lnkOlvidoClave.LinkColor = Color.Silver;
            lnkOlvidoClave.Location = new Point(432, 271);
            lnkOlvidoClave.Name = "lnkOlvidoClave";
            lnkOlvidoClave.Size = new Size(134, 15);
            lnkOlvidoClave.TabIndex = 0;
            lnkOlvidoClave.TabStop = true;
            lnkOlvidoClave.Text = "¿ Olvidó su contraseña ?";
            lnkOlvidoClave.VisitedLinkColor = Color.DarkGray;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(757, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 9;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(727, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(20, 20);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 10;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(lnkOlvidoClave);
            Controls.Add(lblInicioSesion);
            Controls.Add(btnIngresar);
            Controls.Add(textBox2);
            Controls.Add(txtClave);
            Controls.Add(textBox1);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += FrmLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtClave;
        private Button btnIngresar;
        private Label lblInicioSesion;
        private LinkLabel lnkOlvidoClave;
        private PictureBox pictureBox1;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
    }
}