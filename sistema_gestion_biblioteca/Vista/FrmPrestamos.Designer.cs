namespace sistema_gestion_biblioteca.Forms
{
    partial class FrmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblFechaDevolucion = new Label();
            label7 = new Label();
            cmbEstadoPrestamo = new ComboBox();
            label6 = new Label();
            dtFechaInicial = new DateTimePicker();
            label5 = new Label();
            cmbUsuario = new ComboBox();
            label4 = new Label();
            cmbLibro = new ComboBox();
            label3 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            button1 = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            dgPrestamos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPrestamos).BeginInit();
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
            label1.Size = new Size(184, 32);
            label1.TabIndex = 11;
            label1.Text = "PRESTAMOS";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblFechaDevolucion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbEstadoPrestamo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtFechaInicial);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbUsuario);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbLibro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(45, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(966, 230);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "GESTION DE PRESTAMOS";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblFechaDevolucion.ForeColor = Color.WhiteSmoke;
            lblFechaDevolucion.Location = new Point(636, 143);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(121, 15);
            lblFechaDevolucion.TabIndex = 35;
            lblFechaDevolucion.Text = "fecha_devolucion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label7.Location = new Point(425, 143);
            label7.Name = "label7";
            label7.Size = new Size(210, 15);
            label7.TabIndex = 34;
            label7.Text = "Fecha estimada de devolucion: ";
            // 
            // cmbEstadoPrestamo
            // 
            cmbEstadoPrestamo.Font = new Font("Arial", 9.75F);
            cmbEstadoPrestamo.FormattingEnabled = true;
            cmbEstadoPrestamo.Location = new Point(247, 185);
            cmbEstadoPrestamo.Name = "cmbEstadoPrestamo";
            cmbEstadoPrestamo.Size = new Size(373, 24);
            cmbEstadoPrestamo.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 188);
            label6.Name = "label6";
            label6.Size = new Size(177, 18);
            label6.TabIndex = 32;
            label6.Text = "Estado de préstamo: ";
            // 
            // dtFechaInicial
            // 
            dtFechaInicial.Font = new Font("Arial", 9.75F);
            dtFechaInicial.Format = DateTimePickerFormat.Short;
            dtFechaInicial.Location = new Point(247, 138);
            dtFechaInicial.Name = "dtFechaInicial";
            dtFechaInicial.Size = new Size(163, 22);
            dtFechaInicial.TabIndex = 30;
            dtFechaInicial.ValueChanged += dtFechaInicial_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 143);
            label5.Name = "label5";
            label5.Size = new Size(221, 18);
            label5.TabIndex = 29;
            label5.Text = "Fecha inicial de préstamo: ";
            // 
            // cmbUsuario
            // 
            cmbUsuario.Font = new Font("Arial", 9.75F);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(247, 85);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(373, 24);
            cmbUsuario.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 88);
            label4.Name = "label4";
            label4.Size = new Size(165, 18);
            label4.TabIndex = 27;
            label4.Text = "Correo del usuario: ";
            // 
            // cmbLibro
            // 
            cmbLibro.Font = new Font("Arial", 9.75F);
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(247, 35);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(373, 24);
            cmbLibro.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 38);
            label3.Name = "label3";
            label3.Size = new Size(124, 18);
            label3.TabIndex = 25;
            label3.Text = "Título de libro: ";
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
            btnEliminar.Location = new Point(793, 170);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 44);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnActualizar.Location = new Point(793, 120);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(155, 44);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
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
            btnAgregar.Location = new Point(793, 70);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 44);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
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
            btnLimpiar.Location = new Point(793, 20);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(155, 44);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(965, 74);
            button1.Name = "button1";
            button1.Size = new Size(46, 36);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.Location = new Point(116, 80);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(843, 23);
            txtBuscar.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(45, 85);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "Buscar: ";
            // 
            // dgPrestamos
            // 
            dgPrestamos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPrestamos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgPrestamos.BackgroundColor = Color.FromArgb(49, 66, 82);
            dgPrestamos.BorderStyle = BorderStyle.None;
            dgPrestamos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle1.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(8, 2, 8, 2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            dgPrestamos.EnableHeadersVisualStyles = false;
            dgPrestamos.GridColor = Color.FromArgb(49, 66, 82);
            dgPrestamos.Location = new Point(45, 355);
            dgPrestamos.Name = "dgPrestamos";
            dgPrestamos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgPrestamos.Size = new Size(967, 283);
            dgPrestamos.TabIndex = 16;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1050, 650);
            Controls.Add(dgPrestamos);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            Load += FrmPrestamos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button button1;
        private TextBox txtBuscar;
        private Label label2;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label3;
        private ComboBox cmbUsuario;
        private Label label4;
        private ComboBox cmbLibro;
        private DateTimePicker dtFechaInicial;
        private Label label5;
        private ComboBox cmbEstadoPrestamo;
        private Label label6;
        private Label label7;
        private Label lblFechaDevolucion;
        private DataGridView dgPrestamos;
    }
}