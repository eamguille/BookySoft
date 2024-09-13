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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea1.Name = "ChartArea1";
            chartUsuarios.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartUsuarios.Legends.Add(legend1);
            chartUsuarios.Location = new Point(44, 12);
            chartUsuarios.Name = "chartUsuarios";
            chartUsuarios.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartUsuarios.Series.Add(series1);
            chartUsuarios.Size = new Size(957, 373);
            chartUsuarios.TabIndex = 2;
            chartUsuarios.Text = "chart1";
            // 
            // chartPrestamosPorUsuario
            // 
            chartPrestamosPorUsuario.BackColor = Color.FromArgb(49, 66, 82);
            chartArea2.Name = "ChartArea1";
            chartPrestamosPorUsuario.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartPrestamosPorUsuario.Legends.Add(legend2);
            chartPrestamosPorUsuario.Location = new Point(12, 409);
            chartPrestamosPorUsuario.Name = "chartPrestamosPorUsuario";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPrestamosPorUsuario.Series.Add(series2);
            chartPrestamosPorUsuario.Size = new Size(534, 240);
            chartPrestamosPorUsuario.TabIndex = 3;
            chartPrestamosPorUsuario.Text = "chart2";
            // 
            // chartLibrosPrestados
            // 
            chartLibrosPrestados.BackColor = Color.FromArgb(49, 66, 82);
            chartArea3.Name = "ChartArea1";
            chartLibrosPrestados.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartLibrosPrestados.Legends.Add(legend3);
            chartLibrosPrestados.Location = new Point(552, 409);
            chartLibrosPrestados.Name = "chartLibrosPrestados";
            chartLibrosPrestados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartLibrosPrestados.Series.Add(series3);
            chartLibrosPrestados.Size = new Size(486, 240);
            chartLibrosPrestados.TabIndex = 4;
            chartLibrosPrestados.Text = "Usuarios ingresados de la ultima semana";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1050, 670);
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