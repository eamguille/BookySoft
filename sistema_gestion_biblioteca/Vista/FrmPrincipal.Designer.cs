namespace sistema_gestion_biblioteca.Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            PnMenuVertical = new Panel();
            btnSalirSesion = new PictureBox();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnHistorialPrestamos = new Button();
            btnPrestamosYDevoluciones = new Button();
            btnGestionUsuarios = new Button();
            btnConsultaLibros = new Button();
            btnRegistroLibros = new Button();
            btnInicio = new PictureBox();
            PnContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            PnMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalirSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 35);
            panel1.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1231, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestaurar.TabIndex = 14;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1231, 5);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 13;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1196, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 12;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1267, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 11;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // PnMenuVertical
            // 
            PnMenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            PnMenuVertical.Controls.Add(btnSalirSesion);
            PnMenuVertical.Controls.Add(panel8);
            PnMenuVertical.Controls.Add(panel7);
            PnMenuVertical.Controls.Add(panel6);
            PnMenuVertical.Controls.Add(panel3);
            PnMenuVertical.Controls.Add(panel2);
            PnMenuVertical.Controls.Add(btnHistorialPrestamos);
            PnMenuVertical.Controls.Add(btnPrestamosYDevoluciones);
            PnMenuVertical.Controls.Add(btnGestionUsuarios);
            PnMenuVertical.Controls.Add(btnConsultaLibros);
            PnMenuVertical.Controls.Add(btnRegistroLibros);
            PnMenuVertical.Controls.Add(btnInicio);
            PnMenuVertical.Dock = DockStyle.Left;
            PnMenuVertical.Location = new Point(0, 35);
            PnMenuVertical.Name = "PnMenuVertical";
            PnMenuVertical.Size = new Size(250, 667);
            PnMenuVertical.TabIndex = 1;
            // 
            // btnSalirSesion
            // 
            btnSalirSesion.Image = (Image)resources.GetObject("btnSalirSesion.Image");
            btnSalirSesion.Location = new Point(12, 607);
            btnSalirSesion.Name = "btnSalirSesion";
            btnSalirSesion.Size = new Size(37, 37);
            btnSalirSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSalirSesion.TabIndex = 8;
            btnSalirSesion.TabStop = false;
            btnSalirSesion.Tag = "Cerrar Sesion";
            btnSalirSesion.Click += btnSalirSesion_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(0, 425);
            panel8.Name = "panel8";
            panel8.Size = new Size(3, 48);
            panel8.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 80, 200);
            panel7.Location = new Point(0, 369);
            panel7.Name = "panel7";
            panel7.Size = new Size(3, 50);
            panel7.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(0, 317);
            panel6.Name = "panel6";
            panel6.Size = new Size(3, 46);
            panel6.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 259);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 48);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(0, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 48);
            panel2.TabIndex = 0;
            // 
            // btnHistorialPrestamos
            // 
            btnHistorialPrestamos.Cursor = Cursors.Hand;
            btnHistorialPrestamos.FlatAppearance.BorderColor = Color.FromArgb(26, 32, 40);
            btnHistorialPrestamos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnHistorialPrestamos.FlatStyle = FlatStyle.Flat;
            btnHistorialPrestamos.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnHistorialPrestamos.ForeColor = Color.Silver;
            btnHistorialPrestamos.Image = (Image)resources.GetObject("btnHistorialPrestamos.Image");
            btnHistorialPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorialPrestamos.Location = new Point(0, 424);
            btnHistorialPrestamos.Name = "btnHistorialPrestamos";
            btnHistorialPrestamos.Padding = new Padding(12, 0, 0, 0);
            btnHistorialPrestamos.Size = new Size(251, 50);
            btnHistorialPrestamos.TabIndex = 7;
            btnHistorialPrestamos.Text = "HISTORIAL DE PRÉSTAMOS";
            btnHistorialPrestamos.TextAlign = ContentAlignment.MiddleRight;
            btnHistorialPrestamos.UseVisualStyleBackColor = true;
            btnHistorialPrestamos.Click += btnHistorialPrestamos_Click;
            // 
            // btnPrestamosYDevoluciones
            // 
            btnPrestamosYDevoluciones.Cursor = Cursors.Hand;
            btnPrestamosYDevoluciones.FlatAppearance.BorderColor = Color.FromArgb(26, 32, 40);
            btnPrestamosYDevoluciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPrestamosYDevoluciones.FlatStyle = FlatStyle.Flat;
            btnPrestamosYDevoluciones.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnPrestamosYDevoluciones.ForeColor = Color.Silver;
            btnPrestamosYDevoluciones.Image = (Image)resources.GetObject("btnPrestamosYDevoluciones.Image");
            btnPrestamosYDevoluciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrestamosYDevoluciones.Location = new Point(0, 368);
            btnPrestamosYDevoluciones.Name = "btnPrestamosYDevoluciones";
            btnPrestamosYDevoluciones.Padding = new Padding(12, 0, 35, 0);
            btnPrestamosYDevoluciones.Size = new Size(251, 52);
            btnPrestamosYDevoluciones.TabIndex = 6;
            btnPrestamosYDevoluciones.Text = "PRÉSTAMO Y \r\n   DEVOLUCIONES";
            btnPrestamosYDevoluciones.TextAlign = ContentAlignment.MiddleRight;
            btnPrestamosYDevoluciones.UseVisualStyleBackColor = true;
            btnPrestamosYDevoluciones.Click += btnPrestamosYDevoluciones_Click;
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.Cursor = Cursors.Hand;
            btnGestionUsuarios.FlatAppearance.BorderColor = Color.FromArgb(26, 32, 40);
            btnGestionUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnGestionUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestionUsuarios.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnGestionUsuarios.ForeColor = Color.Silver;
            btnGestionUsuarios.Image = (Image)resources.GetObject("btnGestionUsuarios.Image");
            btnGestionUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionUsuarios.Location = new Point(0, 316);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Padding = new Padding(12, 0, 7, 0);
            btnGestionUsuarios.Size = new Size(251, 48);
            btnGestionUsuarios.TabIndex = 5;
            btnGestionUsuarios.Text = "GESTIÓN DE USUARIOS";
            btnGestionUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnGestionUsuarios.UseVisualStyleBackColor = true;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // btnConsultaLibros
            // 
            btnConsultaLibros.Cursor = Cursors.Hand;
            btnConsultaLibros.FlatAppearance.BorderColor = Color.FromArgb(26, 32, 40);
            btnConsultaLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnConsultaLibros.FlatStyle = FlatStyle.Flat;
            btnConsultaLibros.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnConsultaLibros.ForeColor = Color.Silver;
            btnConsultaLibros.Image = (Image)resources.GetObject("btnConsultaLibros.Image");
            btnConsultaLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaLibros.Location = new Point(0, 258);
            btnConsultaLibros.Name = "btnConsultaLibros";
            btnConsultaLibros.Padding = new Padding(10, 0, 15, 0);
            btnConsultaLibros.Size = new Size(251, 50);
            btnConsultaLibros.TabIndex = 2;
            btnConsultaLibros.Text = "CONSULTA DE LIBROS";
            btnConsultaLibros.TextAlign = ContentAlignment.MiddleRight;
            btnConsultaLibros.UseVisualStyleBackColor = true;
            btnConsultaLibros.Click += btnConsultaLibros_Click;
            // 
            // btnRegistroLibros
            // 
            btnRegistroLibros.BackgroundImageLayout = ImageLayout.None;
            btnRegistroLibros.Cursor = Cursors.Hand;
            btnRegistroLibros.FlatAppearance.BorderColor = Color.FromArgb(26, 32, 40);
            btnRegistroLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnRegistroLibros.FlatStyle = FlatStyle.Flat;
            btnRegistroLibros.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnRegistroLibros.ForeColor = SystemColors.ScrollBar;
            btnRegistroLibros.Image = (Image)resources.GetObject("btnRegistroLibros.Image");
            btnRegistroLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistroLibros.Location = new Point(0, 202);
            btnRegistroLibros.Name = "btnRegistroLibros";
            btnRegistroLibros.Padding = new Padding(10, 0, 15, 0);
            btnRegistroLibros.Size = new Size(252, 52);
            btnRegistroLibros.TabIndex = 1;
            btnRegistroLibros.Text = "REGISTRO DE LIBROS";
            btnRegistroLibros.TextAlign = ContentAlignment.MiddleRight;
            btnRegistroLibros.UseVisualStyleBackColor = true;
            btnRegistroLibros.Click += btnRegistroLibros_Click;
            // 
            // btnInicio
            // 
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(5, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(240, 183);
            btnInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // PnContenedor
            // 
            PnContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PnContenedor.Dock = DockStyle.Fill;
            PnContenedor.Location = new Point(250, 35);
            PnContenedor.Name = "PnContenedor";
            PnContenedor.Size = new Size(1050, 667);
            PnContenedor.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 702);
            Controls.Add(PnContenedor);
            Controls.Add(PnMenuVertical);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            PnMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSalirSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel PnMenuVertical;
        private Panel PnContenedor;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnInicio;
        private Button btnRegistroLibros;
        private Button btnHistorialPrestamos;
        private Button btnPrestamosYDevoluciones;
        private Button btnGestionUsuarios;
        private Button btnConsultaLibros;
        private Panel panel3;
        private Panel panel2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private PictureBox btnSalirSesion;
    }
}