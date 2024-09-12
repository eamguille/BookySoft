﻿namespace sistema_gestion_biblioteca.Forms
{
    partial class FrmRegistroLibros
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            txtISBN = new TextBox();
            txtDescripcion = new TextBox();
            dtFechaPublicacion = new DateTimePicker();
            dtFechaIngreso = new DateTimePicker();
            txtNumeroPags = new TextBox();
            txtGenero = new TextBox();
            txtEditorial = new TextBox();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            dgLibros = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLibros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(433, 28);
            label1.Name = "label1";
            label1.Size = new Size(393, 39);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LIBROS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 47);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 1;
            label2.Text = "Título del libro: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 103);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 2;
            label3.Text = "Autor del libro: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 301);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 3;
            label4.Text = "ISBN: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 340);
            label5.Name = "label5";
            label5.Size = new Size(229, 23);
            label5.TabIndex = 4;
            label5.Text = "Fecha de publicación: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 240);
            label6.Name = "label6";
            label6.Size = new Size(102, 23);
            label6.TabIndex = 5;
            label6.Text = "Editorial: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 227);
            label7.Name = "label7";
            label7.Size = new Size(178, 23);
            label7.TabIndex = 6;
            label7.Text = "Género del libro: ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(dtFechaPublicacion);
            groupBox1.Controls.Add(dtFechaIngreso);
            groupBox1.Controls.Add(txtNumeroPags);
            groupBox1.Controls.Add(txtGenero);
            groupBox1.Controls.Add(txtEditorial);
            groupBox1.Controls.Add(txtAutor);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(51, 121);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1105, 383);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACIÓN DE LIBROS";
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
            btnEliminar.Location = new Point(903, 284);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(177, 59);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar libro";
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
            btnActualizar.Location = new Point(903, 199);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(177, 59);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar libro";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
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
            btnAgregar.Location = new Point(903, 115);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 59);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar libro";
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
            btnLimpiar.Location = new Point(903, 33);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(177, 59);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Arial", 9.75F);
            txtISBN.Location = new Point(626, 297);
            txtISBN.Margin = new Padding(3, 4, 3, 4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(233, 26);
            txtISBN.TabIndex = 19;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Arial", 9.75F);
            txtDescripcion.Location = new Point(527, 75);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(332, 137);
            txtDescripcion.TabIndex = 18;
            // 
            // dtFechaPublicacion
            // 
            dtFechaPublicacion.Font = new Font("Arial", 9.75F);
            dtFechaPublicacion.Format = DateTimePickerFormat.Short;
            dtFechaPublicacion.Location = new Point(237, 336);
            dtFechaPublicacion.Margin = new Padding(3, 4, 3, 4);
            dtFechaPublicacion.Name = "dtFechaPublicacion";
            dtFechaPublicacion.Size = new Size(261, 26);
            dtFechaPublicacion.TabIndex = 17;
            // 
            // dtFechaIngreso
            // 
            dtFechaIngreso.Font = new Font("Arial", 9.75F);
            dtFechaIngreso.Format = DateTimePickerFormat.Short;
            dtFechaIngreso.Location = new Point(237, 284);
            dtFechaIngreso.Margin = new Padding(3, 4, 3, 4);
            dtFechaIngreso.Name = "dtFechaIngreso";
            dtFechaIngreso.Size = new Size(261, 26);
            dtFechaIngreso.TabIndex = 16;
            // 
            // txtNumeroPags
            // 
            txtNumeroPags.Font = new Font("Arial", 9.75F);
            txtNumeroPags.Location = new Point(237, 161);
            txtNumeroPags.Margin = new Padding(3, 4, 3, 4);
            txtNumeroPags.Name = "txtNumeroPags";
            txtNumeroPags.Size = new Size(261, 26);
            txtNumeroPags.TabIndex = 15;
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Arial", 9.75F);
            txtGenero.Location = new Point(237, 223);
            txtGenero.Margin = new Padding(3, 4, 3, 4);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(261, 26);
            txtGenero.TabIndex = 13;
            // 
            // txtEditorial
            // 
            txtEditorial.Font = new Font("Arial", 9.75F);
            txtEditorial.Location = new Point(626, 236);
            txtEditorial.Margin = new Padding(3, 4, 3, 4);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(233, 26);
            txtEditorial.TabIndex = 12;
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Arial", 9.75F);
            txtAutor.Location = new Point(237, 99);
            txtAutor.Margin = new Padding(3, 4, 3, 4);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(261, 26);
            txtAutor.TabIndex = 11;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Arial", 9.75F);
            txtTitulo.Location = new Point(237, 43);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(261, 26);
            txtTitulo.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 288);
            label10.Name = "label10";
            label10.Size = new Size(190, 23);
            label10.TabIndex = 9;
            label10.Text = "Fecha de ingreso: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(527, 43);
            label9.Name = "label9";
            label9.Size = new Size(201, 23);
            label9.TabIndex = 8;
            label9.Text = "Descripción breve: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 165);
            label8.Name = "label8";
            label8.Size = new Size(212, 23);
            label8.TabIndex = 7;
            label8.Text = "Número de páginas: ";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.LightGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(51, 80);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1105, 3);
            textBox1.TabIndex = 8;
            // 
            // dgLibros
            // 
            dgLibros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLibros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgLibros.BackgroundColor = Color.FromArgb(49, 66, 82);
            dgLibros.BorderStyle = BorderStyle.None;
            dgLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle1.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(8, 2, 8, 2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgLibros.DefaultCellStyle = dataGridViewCellStyle2;
            dgLibros.EnableHeadersVisualStyles = false;
            dgLibros.GridColor = Color.FromArgb(49, 66, 82);
            dgLibros.Location = new Point(51, 529);
            dgLibros.Margin = new Padding(3, 4, 3, 4);
            dgLibros.Name = "dgLibros";
            dgLibros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgLibros.RowHeadersWidth = 51;
            dgLibros.Size = new Size(1105, 375);
            dgLibros.TabIndex = 17;
            // 
            // FrmRegistroLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1200, 920);
            Controls.Add(dgLibros);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRegistroLibros";
            Text = "FrmRegistroLibros";
            Load += FrmRegistroLibros_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox1;
        private TextBox txtNumeroPags;
        private TextBox txtGenero;
        private TextBox txtEditorial;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private TextBox txtDescripcion;
        private DateTimePicker dtFechaPublicacion;
        private DateTimePicker dtFechaIngreso;
        private TextBox txtISBN;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridView dgLibros;
    }
}