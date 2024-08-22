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
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            btnLimpiar = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgIngresoLibros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            button4 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
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
            label1.Size = new Size(159, 32);
            label1.TabIndex = 11;
            label1.Text = "USUARIOS";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
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
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.MouseDownBackColor = Color.Gray;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(49, 66, 82);
            button3.Location = new Point(416, 137);
            button3.Name = "button3";
            button3.Size = new Size(155, 44);
            button3.TabIndex = 23;
            button3.Text = "Agregar usuario";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(49, 66, 82);
            button1.Location = new Point(790, 137);
            button1.Name = "button1";
            button1.Size = new Size(155, 44);
            button1.TabIndex = 22;
            button1.Text = "Eliminar usuario";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(49, 66, 82);
            button2.Location = new Point(600, 137);
            button2.Name = "button2";
            button2.Size = new Size(164, 44);
            button2.TabIndex = 21;
            button2.Text = "Actualizar usuario";
            button2.UseVisualStyleBackColor = false;
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
            // 
            // textBox6
            // 
            textBox6.Location = new Point(120, 134);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(272, 64);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(508, 32);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(271, 26);
            textBox7.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(507, 83);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(272, 26);
            textBox5.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 26);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 26);
            textBox2.TabIndex = 10;
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
            // dgIngresoLibros
            // 
            dgIngresoLibros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgIngresoLibros.BackgroundColor = Color.FromArgb(49, 66, 82);
            dgIngresoLibros.BorderStyle = BorderStyle.None;
            dgIngresoLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle1.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgIngresoLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgIngresoLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIngresoLibros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgIngresoLibros.DefaultCellStyle = dataGridViewCellStyle2;
            dgIngresoLibros.EnableHeadersVisualStyles = false;
            dgIngresoLibros.GridColor = Color.FromArgb(49, 66, 82);
            dgIngresoLibros.Location = new Point(45, 339);
            dgIngresoLibros.Name = "dgIngresoLibros";
            dgIngresoLibros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgIngresoLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgIngresoLibros.Size = new Size(967, 261);
            dgIngresoLibros.TabIndex = 15;
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
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(116, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(843, 23);
            textBox4.TabIndex = 17;
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
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(dgIngresoLibros);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionUsuarios";
            Text = "FrmGestionLibros";
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
        private Button button2;
        private Button btnLimpiar;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button1;
        private DataGridView dgIngresoLibros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button4;
        private TextBox textBox4;
        private Label label4;
    }
}