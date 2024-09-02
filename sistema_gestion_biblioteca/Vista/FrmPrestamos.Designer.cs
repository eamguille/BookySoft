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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamos));
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            dgIngresoLibros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label7 = new Label();
            lblFechaDevolucion = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgIngresoLibros).BeginInit();
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
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
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
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(240, 185);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(168, 26);
            comboBox3.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 188);
            label6.Name = "label6";
            label6.Size = new Size(214, 18);
            label6.TabIndex = 32;
            label6.Text = "Condicion inicial del libro: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(143, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 26);
            dateTimePicker1.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 138);
            label5.Name = "label5";
            label5.Size = new Size(117, 18);
            label5.TabIndex = 29;
            label5.Text = "Fecha inicial: ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(105, 85);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(303, 26);
            comboBox2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 88);
            label4.Name = "label4";
            label4.Size = new Size(79, 18);
            label4.TabIndex = 27;
            label4.Text = "Usuario: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(324, 26);
            comboBox1.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 38);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 25;
            label3.Text = "Libro: ";
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
            // dgIngresoLibros
            // 
            dgIngresoLibros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgIngresoLibros.BackgroundColor = Color.FromArgb(49, 66, 82);
            dgIngresoLibros.BorderStyle = BorderStyle.None;
            dgIngresoLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Gray;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle4.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgIngresoLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgIngresoLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIngresoLibros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Silver;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle5.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgIngresoLibros.DefaultCellStyle = dataGridViewCellStyle5;
            dgIngresoLibros.EnableHeadersVisualStyles = false;
            dgIngresoLibros.GridColor = Color.FromArgb(49, 66, 82);
            dgIngresoLibros.Location = new Point(45, 352);
            dgIngresoLibros.Name = "dgIngresoLibros";
            dgIngresoLibros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Silver;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle6.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgIngresoLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgIngresoLibros.Size = new Size(966, 251);
            dgIngresoLibros.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
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
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(116, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(843, 23);
            textBox2.TabIndex = 12;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(434, 120);
            label7.Name = "label7";
            label7.Size = new Size(259, 18);
            label7.TabIndex = 34;
            label7.Text = "Fecha estimada de devolucion: ";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.ForeColor = Color.WhiteSmoke;
            lblFechaDevolucion.Location = new Point(434, 143);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(148, 18);
            lblFechaDevolucion.TabIndex = 35;
            lblFechaDevolucion.Text = "fecha_devolucion";
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1050, 615);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(dgIngresoLibros);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgIngresoLibros).EndInit();
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
        private TextBox textBox2;
        private Label label2;
        private DataGridView dgIngresoLibros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox3;
        private Label label6;
        private Label label7;
        private Label lblFechaDevolucion;
    }
}