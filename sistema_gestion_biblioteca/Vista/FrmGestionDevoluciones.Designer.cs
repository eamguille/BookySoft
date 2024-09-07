namespace sistema_gestion_biblioteca.Vista
{
    partial class FrmGestionDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionDevoluciones));
            dgDevoluciones = new DataGridView();
            button1 = new Button();
            txtBuscar = new TextBox();
            lblMonto = new Label();
            label7 = new Label();
            label6 = new Label();
            dtFechaDevolu = new DateTimePicker();
            label5 = new Label();
            cmbUsuario = new ComboBox();
            label4 = new Label();
            cmbLibro = new ComboBox();
            label3 = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            txtComentario = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgDevoluciones).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgDevoluciones
            // 
            dgDevoluciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgDevoluciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDevoluciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgDevoluciones.BackgroundColor = Color.FromArgb(49, 66, 82);
            dgDevoluciones.BorderStyle = BorderStyle.None;
            dgDevoluciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle1.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgDevoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgDevoluciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(8, 2, 8, 2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgDevoluciones.DefaultCellStyle = dataGridViewCellStyle2;
            dgDevoluciones.EnableHeadersVisualStyles = false;
            dgDevoluciones.GridColor = Color.FromArgb(49, 66, 82);
            dgDevoluciones.Location = new Point(42, 394);
            dgDevoluciones.Name = "dgDevoluciones";
            dgDevoluciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgDevoluciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgDevoluciones.Size = new Size(967, 248);
            dgDevoluciones.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(962, 78);
            button1.Name = "button1";
            button1.Size = new Size(46, 36);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.Location = new Point(113, 84);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(843, 23);
            txtBuscar.TabIndex = 19;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblMonto.ForeColor = Color.WhiteSmoke;
            lblMonto.Location = new Point(551, 144);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(48, 15);
            lblMonto.TabIndex = 35;
            lblMonto.Text = "monto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label7.Location = new Point(425, 143);
            label7.Name = "label7";
            label7.Size = new Size(130, 15);
            label7.TabIndex = 34;
            label7.Text = "Monto por retraso: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 186);
            label6.Name = "label6";
            label6.Size = new Size(227, 18);
            label6.TabIndex = 32;
            label6.Text = "Comentarios del préstamo: ";
            // 
            // dtFechaDevolu
            // 
            dtFechaDevolu.Font = new Font("Arial", 9.75F);
            dtFechaDevolu.Format = DateTimePickerFormat.Short;
            dtFechaDevolu.Location = new Point(247, 138);
            dtFechaDevolu.Name = "dtFechaDevolu";
            dtFechaDevolu.Size = new Size(163, 22);
            dtFechaDevolu.TabIndex = 30;
            dtFechaDevolu.ValueChanged += dtFechaDevolu_ValueChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 140);
            label5.Name = "label5";
            label5.Size = new Size(178, 18);
            label5.TabIndex = 29;
            label5.Text = "Fecha de devolución:";
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
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtComentario);
            groupBox1.Controls.Add(lblMonto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtFechaDevolu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbUsuario);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbLibro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(42, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(966, 259);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "GESTIÓN DE DEVOLUCIONES";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(248, 183);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(373, 65);
            txtComentario.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.LightGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(42, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(967, 2);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(428, 25);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 17;
            label1.Text = "DEVOLUCIONES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(42, 89);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 18;
            label2.Text = "Buscar: ";
            // 
            // FrmGestionDevoluciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1050, 670);
            Controls.Add(dgDevoluciones);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionDevoluciones";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "FrmGestionDevoluciones";
            Load += FrmGestionDevoluciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgDevoluciones).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDevoluciones;
        private Button button1;
        private TextBox txtBuscar;
        private Label lblMonto;
        private Label label7;
        private Label label6;
        private DateTimePicker dtFechaDevolu;
        private Label label5;
        private ComboBox cmbUsuario;
        private Label label4;
        private ComboBox cmbLibro;
        private Label label3;
        private Button btnAgregar;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox txtComentario;
    }
}