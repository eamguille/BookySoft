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
            txtBuscar = new TextBox();
            groupBox1 = new GroupBox();
            dgLibros = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLibros).BeginInit();
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
            // txtBuscar
            // 
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(105, 36);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(843, 25);
            txtBuscar.TabIndex = 12;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgLibros);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtBuscar);
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
            // dgLibros
            // 
            dgLibros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(8, 2, 8, 2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgLibros.DefaultCellStyle = dataGridViewCellStyle2;
            dgLibros.EnableHeadersVisualStyles = false;
            dgLibros.GridColor = Color.FromArgb(49, 66, 82);
            dgLibros.Location = new Point(21, 102);
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
            dgLibros.Size = new Size(979, 393);
            dgLibros.TabIndex = 18;
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
            Load += FrmConsultaLibros_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox txtBuscar;
        private GroupBox groupBox1;
        private Button button1;
        private DataGridView dgLibros;
    }
}