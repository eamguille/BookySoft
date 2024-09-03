namespace sistema_gestion_biblioteca.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            textBox8 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgPrestamos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(379, 21);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LIBROS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 35);
            label2.Name = "label2";
            label2.Size = new Size(128, 18);
            label2.TabIndex = 1;
            label2.Text = "Título del libro: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 77);
            label3.Name = "label3";
            label3.Size = new Size(129, 18);
            label3.TabIndex = 2;
            label3.Text = "Autor del libro: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 226);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 3;
            label4.Text = "ISBN: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 255);
            label5.Name = "label5";
            label5.Size = new Size(187, 18);
            label5.TabIndex = 4;
            label5.Text = "Fecha de publicación: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 180);
            label6.Name = "label6";
            label6.Size = new Size(83, 18);
            label6.TabIndex = 5;
            label6.Text = "Editorial: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 170);
            label7.Name = "label7";
            label7.Size = new Size(144, 18);
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
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
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
            groupBox1.Location = new Point(45, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 287);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACIÓN DE LIBROS";
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
            btnAgregar.Location = new Point(790, 86);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 44);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar libro";
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
            btnLimpiar.Location = new Point(790, 25);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(155, 44);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(548, 223);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(204, 26);
            textBox8.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(461, 56);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(291, 104);
            textBox6.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(207, 252);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(229, 23);
            dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(207, 213);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(207, 121);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(229, 26);
            textBox7.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(207, 167);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(229, 26);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(548, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 26);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 26);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 26);
            textBox2.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 216);
            label10.Name = "label10";
            label10.Size = new Size(155, 18);
            label10.TabIndex = 9;
            label10.Text = "Fecha de ingreso: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(461, 32);
            label9.Name = "label9";
            label9.Size = new Size(163, 18);
            label9.TabIndex = 8;
            label9.Text = "Descripción breve: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 124);
            label8.Name = "label8";
            label8.Size = new Size(171, 18);
            label8.TabIndex = 7;
            label8.Text = "Número de páginas: ";
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
            textBox1.TabIndex = 8;
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
            btnActualizar.Location = new Point(790, 149);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(155, 44);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar libro";
            btnActualizar.UseVisualStyleBackColor = false;
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
            btnEliminar.Location = new Point(790, 213);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 44);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar libro";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgPrestamos
            // 
            dgPrestamos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPrestamos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgPrestamos.BackgroundColor = Color.FromArgb(49, 66, 82);
            dgPrestamos.BorderStyle = BorderStyle.None;
            dgPrestamos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Gray;
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle4.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Silver;
            dataGridViewCellStyle5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(8, 2, 8, 2);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle5.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgPrestamos.DefaultCellStyle = dataGridViewCellStyle5;
            dgPrestamos.EnableHeadersVisualStyles = false;
            dgPrestamos.GridColor = Color.FromArgb(49, 66, 82);
            dgPrestamos.Location = new Point(45, 397);
            dgPrestamos.Name = "dgPrestamos";
            dgPrestamos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Silver;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle6.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgPrestamos.Size = new Size(967, 281);
            dgPrestamos.TabIndex = 17;
            // 
            // FrmRegistroLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1050, 690);
            Controls.Add(dgPrestamos);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistroLibros";
            Text = "FrmRegistroLibros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPrestamos).EndInit();
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
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox8;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridView dgPrestamos;
    }
}