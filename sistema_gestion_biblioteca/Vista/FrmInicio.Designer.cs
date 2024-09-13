namespace sistema_gestion_biblioteca.Forms
{
    partial class FrmInicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartUsuarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartPrestamosPorUsuario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartLibrosPrestados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPrestamosPorUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartLibrosPrestados).BeginInit();
            SuspendLayout();
            // 
            // chartUsuarios
            // 
            chartUsuarios.BackColor = Color.FromArgb(49, 66, 82);
            chartUsuarios.BackSecondaryColor = Color.Black;
            chartUsuarios.BorderlineColor = Color.Black;
            chartArea4.Name = "ChartArea1";
            chartUsuarios.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartUsuarios.Legends.Add(legend4);
            chartUsuarios.Location = new Point(44, 12);
            chartUsuarios.Name = "chartUsuarios";
            chartUsuarios.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartUsuarios.Series.Add(series4);
            chartUsuarios.Size = new Size(957, 300);
            chartUsuarios.TabIndex = 2;
            chartUsuarios.Text = "chart1";
            // 
            // chartPrestamosPorUsuario
            // 
            chartPrestamosPorUsuario.BackColor = Color.FromArgb(49, 66, 82);
            chartArea5.Name = "ChartArea1";
            chartPrestamosPorUsuario.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chartPrestamosPorUsuario.Legends.Add(legend5);
            chartPrestamosPorUsuario.Location = new Point(12, 318);
            chartPrestamosPorUsuario.Name = "chartPrestamosPorUsuario";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chartPrestamosPorUsuario.Series.Add(series5);
            chartPrestamosPorUsuario.Size = new Size(534, 285);
            chartPrestamosPorUsuario.TabIndex = 3;
            chartPrestamosPorUsuario.Text = "chart2";
            // 
            // chartLibrosPrestados
            // 
            chartLibrosPrestados.BackColor = Color.FromArgb(49, 66, 82);
            chartArea6.Name = "ChartArea1";
            chartLibrosPrestados.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chartLibrosPrestados.Legends.Add(legend6);
            chartLibrosPrestados.Location = new Point(552, 318);
            chartLibrosPrestados.Name = "chartLibrosPrestados";
            chartLibrosPrestados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chartLibrosPrestados.Series.Add(series6);
            chartLibrosPrestados.Size = new Size(486, 285);
            chartLibrosPrestados.TabIndex = 4;
            chartLibrosPrestados.Text = "Usuarios ingresados de la ultima semana";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1050, 615);
            Controls.Add(chartLibrosPrestados);
            Controls.Add(chartPrestamosPorUsuario);
            Controls.Add(chartUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInicio";
            Text = "FrmInicio";
            Load += FrmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)chartUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPrestamosPorUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartLibrosPrestados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsuarios;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrestamosPorUsuario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibrosPrestados;
    }
}