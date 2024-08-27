namespace sistema_gestion_biblioteca.Forms
{
    partial class FrmGestionUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionUsuarios));
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtIDUsuario = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgUsuarios = new DataGridView();
            button4 = new Button();
            txtBuscar = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.LightGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(45, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(967, 2);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(461, 25);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 11;
            label1.Text = "USUARIOS";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtIDUsuario);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(45, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 218);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "GESTION DE USUARIOS";
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Font = new Font("Arial", 11.25F);
            txtIDUsuario.Location = new Point(24, 173);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.ReadOnly = true;
            txtIDUsuario.Size = new Size(63, 25);
            txtIDUsuario.TabIndex = 24;
            txtIDUsuario.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.WhiteSmoke;
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.FromArgb(49, 66, 82);
            btnAgregar.Location = new Point(416, 137);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 44);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar usuario";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.FromArgb(49, 66, 82);
            btnEliminar.Location = new Point(790, 137);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 44);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar usuario";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.WhiteSmoke;
            btnActualizar.BackgroundImageLayout = ImageLayout.None;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.FromArgb(49, 66, 82);
            btnActualizar.Location = new Point(600, 137);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(164, 44);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar usuario";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.WhiteSmoke;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(49, 66, 82);
            btnLimpiar.Location = new Point(790, 32);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(155, 44);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Arial", 11.25F);
            txtDireccion.Location = new Point(120, 134);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(272, 64);
            txtDireccion.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial", 11.25F);
            txtTelefono.Location = new Point(508, 32);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(271, 25);
            txtTelefono.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 11.25F);
            txtEmail.Location = new Point(507, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(272, 25);
            txtEmail.TabIndex = 13;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Arial", 11.25F);
            txtApellidos.Location = new Point(120, 81);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(271, 25);
            txtApellidos.TabIndex = 11;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Arial", 11.25F);
            txtNombres.Location = new Point(119, 32);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(272, 25);
            txtNombres.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 134);
            label9.Name = "label9";
            label9.Size = new Size(94, 18);
            label9.TabIndex = 8;
            label9.Text = "Direccion: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(416, 35);
            label8.Name = "label8";
            label8.Size = new Size(86, 18);
            label8.TabIndex = 7;
            label8.Text = "Telefono: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 83);
            label7.Name = "label7";
            label7.Size = new Size(60, 18);
            label7.TabIndex = 6;
            label7.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 35);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 1;
            label2.Text = "Nombres: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 83);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 2;
            label3.Text = "Apellidos: ";
            // 
            // dgUsuarios
            // 
            dgUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgUsuarios.BackgroundColor = Color.FromArgb(49, 66, 82);
            dgUsuarios.BorderStyle = BorderStyle.None;
            dgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle1.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(8, 2, 8, 2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgUsuarios.EnableHeadersVisualStyles = false;
            dgUsuarios.GridColor = Color.FromArgb(49, 66, 82);
            dgUsuarios.Location = new Point(45, 339);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgUsuarios.Size = new Size(967, 261);
            dgUsuarios.TabIndex = 15;
            dgUsuarios.CellClick += dgUsuarios_CellClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(966, 70);
            button4.Name = "button4";
            button4.Size = new Size(46, 36);
            button4.TabIndex = 18;
            button4.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(116, 78);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(843, 21);
            txtBuscar.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(44, 81);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 16;
            label4.Text = "Buscar: ";
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1050, 615);
            Controls.Add(button4);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(dgUsuarios);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionUsuarios";
            Text = "FrmGestionLibros";
            Load += FrmGestionUsuarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnActualizar;
        private Button btnLimpiar;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridView dgUsuarios;
        private Button button4;
        private TextBox txtBuscar;
        private Label label4;
        private TextBox txtIDUsuario;
    }
}