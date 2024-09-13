using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using sistema_gestion_biblioteca.Controlador;

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            // Configuración de la cultura de la aplicación
            CultureInfo.CurrentCulture = new CultureInfo("es-ES");
            CultureInfo.CurrentUICulture = new CultureInfo("es-ES");
            InitializeComponent();
        }

        graficasControlador obj_grafica_controlador = new graficasControlador();

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            mostrarGraficaUsuarios();
            mostrarUsuariosConMasPrestamos();
            mostrarLibrosConMasPrestamos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void mostrarGraficaUsuarios()
        {
            // Obtenemos los datos desde el controlador
            var usuariosUltimoMes = obj_grafica_controlador.obtenerUsuariosUltimoMes();
            var registroPorMes = usuariosUltimoMes
                .GroupBy(usuario => new { Anio = usuario.fechaRegistro.Year, Mes = usuario.fechaRegistro.Month })
                .Select(grupo => new { Fecha = new DateTime(grupo.Key.Anio, grupo.Key.Mes, 1), Cantidad = grupo.Count() })
                .OrderBy(x => x.Fecha)
                .ToList();


            // CONFIGURACION DEL CHART
            chartUsuarios.Series.Clear();
            chartUsuarios.Legends.Clear();

            var series = new Series("Usuarios Registrados");
            series.ChartType = SeriesChartType.Column;
            series.YValueType = ChartValueType.Int32;

            var legend = new Legend("Leyenda")
            {
                Docking = Docking.Top, // Posición de la leyenda
                Alignment = StringAlignment.Center, // Alineación del texto en la leyenda
                BackColor = Color.Transparent, // Color de fondo de la leyenda
                ForeColor = Color.White,
                Font = new Font("Arial", 16, FontStyle.Bold)
            };


            // Agregamos los puntos de la serie
            foreach (var registro in registroPorMes)
            {
                series.Points.AddXY(registro.Fecha, registro.Cantidad);
            }

            chartUsuarios.Series.Add(series);
            chartUsuarios.Legends.Add(legend);

            chartUsuarios.Titles.Clear();

            // Configuración de los ejes
            var chartArea = chartUsuarios.ChartAreas[0];
            chartArea.AxisX.LabelStyle.Format = "MMM yyyy"; // Formato de salida de mes
            chartArea.AxisX.Title = "Meses";
            chartArea.AxisX.TitleForeColor = Color.White;
            chartArea.AxisX.TitleFont = new Font("Arial", 13, FontStyle.Bold);
            chartArea.AxisY.Title = "Cantidad de Usuarios";
            chartArea.AxisY.TitleAlignment = StringAlignment.Center;
            chartArea.AxisY.TitleForeColor = Color.White;
            chartArea.AxisY.TitleFont = new Font("Arial", 11, FontStyle.Bold);
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Months; // Intervalos por mes
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea.BackColor = Color.Transparent;
            chartArea.AxisX.MajorGrid.LineColor = Color.White;
            chartArea.AxisY.MajorGrid.LineColor = Color.White;

            chartArea.AxisX.MajorTickMark.LineColor = Color.White;
            chartArea.AxisY.MajorTickMark.LineColor = Color.White;

            chartArea.AxisX.LineColor = Color.White;
            chartArea.AxisY.LineColor = Color.White;

            // Ajustar el rango de fechas en el eje X para mostrar más meses
            var fechaInicio = DateTime.Now.AddMonths(-3).AddDays(1);
            var fechaFin = DateTime.Now.AddMonths(3);

            chartArea.AxisX.Minimum = fechaInicio.ToOADate();
            chartArea.AxisX.Maximum = fechaFin.ToOADate();
        }

        void mostrarUsuariosConMasPrestamos()
        {
            // Limpiamos las series existentes en el Chart
            chartPrestamosPorUsuario.Series.Clear();

            // Configuración para el fondo transparente
            chartPrestamosPorUsuario.BackColor = Color.Transparent;
            chartPrestamosPorUsuario.ChartAreas[0].BackColor = Color.Transparent;
            chartPrestamosPorUsuario.ChartAreas[0].BackSecondaryColor = Color.Transparent;
            chartPrestamosPorUsuario.ChartAreas[0].BorderColor = Color.Transparent;

            // Creamos una nueva serie para los usuarios con más préstamos
            Series seriesTopUsuarios = new Series("Top 5 Usuarios con Más Préstamos")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
            };

            // Obtener los datos desde el controlador
            var topUsuarios = obj_grafica_controlador.obtenerUsuariosConMasPrestamos();

            // Si hay menos de 5 usuarios, muestra solo los disponibles
            var usuariosParaMostrar = topUsuarios.Take(5).ToList();

            // Verificar si hay datos
            if (usuariosParaMostrar.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios con préstamos.");
                return;
            }

            // Agregamos los datos al chart
            foreach (var usuario in usuariosParaMostrar)
            {
                seriesTopUsuarios.Points.AddXY(usuario.Key, usuario.Value);
            }

            // Configuramos el Chart
            chartPrestamosPorUsuario.Series.Add(seriesTopUsuarios);

            // Personalización adicional
            chartPrestamosPorUsuario.Legends[0].BackColor = Color.Transparent;
            chartPrestamosPorUsuario.Legends[0].ForeColor = Color.White;

            // Agregamos un titulo al grafico
            Title titulo = new Title
            {
                Text = "Top 5 Usuarios con más Préstamos",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Alignment = ContentAlignment.TopCenter
            };

            chartPrestamosPorUsuario.Titles.Clear();
            chartPrestamosPorUsuario.Titles.Add(titulo);
        }

        void mostrarLibrosConMasPrestamos()
        {
            // Limpiamos las series existentes en el Chart
            chartLibrosPrestados.Series.Clear();

            // Configuración para el fondo transparente
            chartLibrosPrestados.BackColor = Color.Transparent;
            chartLibrosPrestados.ChartAreas[0].BackColor = Color.Transparent;
            chartLibrosPrestados.ChartAreas[0].BackSecondaryColor = Color.Transparent;
            chartLibrosPrestados.ChartAreas[0].BorderColor = Color.Transparent;

            // Creamos una nueva serie para los libros con más préstamos
            Series seriesTopLibros = new Series("Top Libros con Más Préstamos")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold),
            };

            // Obtener los datos desde el controlador
            var topLibros = obj_grafica_controlador.obtenerLibrosConMasPrestamos();

            // Si hay menos de 8 libros, muestra solo los disponibles
            var librosParaMostrar = topLibros.OrderByDescending(libro => libro.Value)
                                             .Take(8)
                                             .ToList();

            // Verificar si hay datos
            if (librosParaMostrar.Count == 0)
            {
                MessageBox.Show("No se encontraron préstamos para los libros.");
                return;
            }

            // Agregamos los datos al chart
            foreach (var libro in librosParaMostrar)
            {
                seriesTopLibros.Points.AddXY(libro.Key, libro.Value);
            }

            // Configuramos el Chart
            chartLibrosPrestados.Series.Add(seriesTopLibros);

            // Personalización adicional de la leyenda
            chartLibrosPrestados.Legends[0].BackColor = Color.Transparent;
            chartLibrosPrestados.Legends[0].ForeColor = Color.White;

            // Agregar un título al gráfico
            Title titulo = new Title
            {
                Text = "Libros con más Préstamos",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Alignment = ContentAlignment.TopCenter
            };

            chartLibrosPrestados.Titles.Clear();
            chartLibrosPrestados.Titles.Add(titulo);

        }
    }
}
