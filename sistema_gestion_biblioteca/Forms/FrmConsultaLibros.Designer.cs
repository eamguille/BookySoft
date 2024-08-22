namespace sistema_gestion_biblioteca.Forms
{
    partial class FrmConsultaLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaLibros));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnLimpiar = new Button();
            dgIngresoLibros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            button1 = new Button();
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
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(379, 21);
            label1.Name = "label1";
            label1.Size = new Size(320, 32);
            label1.TabIndex = 9;
            label1.Text = "CONSULTA DE LIBROS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 39);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 11;
            label2.Text = "Buscar: ";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(105, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(843, 26);
            textBox2.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(dgIngresoLibros);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1026, 511);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "ENCUENTRA TU LIBRO";
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
            button2.Location = new Point(851, 82);
            button2.Name = "button2";
            button2.Size = new Size(155, 44);
            button2.TabIndex = 22;
            button2.Text = "Eliminar Libro";
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
            btnLimpiar.Location = new Point(672, 82);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(155, 44);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Actualizar Libro";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgIngresoLibros
            // 
            dgIngresoLibros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgIngresoLibros.BackgroundColor = Color.FromArgb(49, 66, 82);
            dgIngresoLibros.BorderStyle = BorderStyle.None;
            dgIngresoLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle1.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgIngresoLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgIngresoLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIngresoLibros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgIngresoLibros.DefaultCellStyle = dataGridViewCellStyle2;
            dgIngresoLibros.EnableHeadersVisualStyles = false;
            dgIngresoLibros.GridColor = Color.FromArgb(49, 66, 82);
            dgIngresoLibros.Location = new Point(21, 142);
            dgIngresoLibros.Name = "dgIngresoLibros";
            dgIngresoLibros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgIngresoLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgIngresoLibros.Size = new Size(985, 363);
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
            button1.Location = new Point(954, 30);
            button1.Name = "button1";
            button1.Size = new Size(46, 36);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmConsultaLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1050, 615);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultaLibros";
            Text = "FrmConsultaLibros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgIngresoLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Button button1;
        private DataGridView dgIngresoLibros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button2;
        private Button btnLimpiar;
    }
}