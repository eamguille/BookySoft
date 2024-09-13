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

            // Aseguramos que las fechas se agrupan correctamente por año y mes
            var registroPorMes = usuariosUltimoMes
                .GroupBy(usuario => new { Anio = usuario.fechaRegistro.Year, Mes = usuario.fechaRegistro.Month })
                .Select(grupo => new { Fecha = new DateTime(grupo.Key.Anio, grupo.Key.Mes, 1), Cantidad = grupo.Count() })
                .OrderBy(x => x.Fecha)
                .ToList();

            // CONFIGURACIÓN DEL CHART
            chartUsuarios.Series.Clear();
            chartUsuarios.Legends.Clear();
            chartUsuarios.ChartAreas.Clear();

            // Creamos un ChartArea nuevo para evitar problemas de configuración
            ChartArea chartArea = new ChartArea("AreaUsuarios");
            chartUsuarios.ChartAreas.Add(chartArea);
            chartArea.BackColor = Color.Transparent;

            // Crear la serie para los usuarios registrados
            var series = new Series("Usuarios Registrados")
            {
                ChartType = SeriesChartType.Column,
                YValueType = ChartValueType.Int32,
                Color = Color.Blue // Cambia el color para asegurar visibilidad
            };

            // Validación para verificar si hay datos
            if (registroPorMes.Count <= 0)
            {
                // Si no hay datos, configuramos el gráfico para mostrar vacío
                chartUsuarios.Series.Add(series); // Agregar la serie vacía

                // Mensaje informativo en el título
                Title tituloSinDatos = new Title
                {
                    Text = "No hay datos disponibles para mostrar",
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    ForeColor = Color.White,
                    Alignment = ContentAlignment.TopCenter
                };
                chartUsuarios.Titles.Clear();
                chartUsuarios.Titles.Add(tituloSinDatos);
            }
            else
            {
                // Si hay datos, agregamos los puntos de la serie
                foreach (var registro in registroPorMes)
                {
                    series.Points.AddXY(registro.Fecha, registro.Cantidad);
                    series.Color = Color.FromArgb(0, 122, 204);
                }

                // Añadir la serie y la leyenda al gráfico
                chartUsuarios.Series.Add(series);

                // Verifica si existe la leyenda
                if (chartUsuarios.Legends.Count == 0)
                {
                    chartUsuarios.Legends.Add(new Legend("Leyenda")
                    {
                        Docking = Docking.Top,
                        Alignment = StringAlignment.Center,
                        BackColor = Color.Transparent,
                        ForeColor = Color.White,
                        Font = new Font("Arial", 13, FontStyle.Italic),
                        BackSecondaryColor = Color.Purple
                    });
                }

                // Configuración de los ejes
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
                chartArea.AxisX.MajorGrid.LineColor = Color.White;
                chartArea.AxisY.MajorGrid.LineColor = Color.White;
                chartArea.AxisX.MajorTickMark.LineColor = Color.White;
                chartArea.AxisY.MajorTickMark.LineColor = Color.White;
                chartArea.AxisX.LineColor = Color.White;
                chartArea.AxisY.LineColor = Color.White;
                chartArea.AxisY.Minimum = 0; // Mínimo del eje Y

                // Ajustar el rango de fechas en el eje X para mostrar meses relevantes
                DateTime fechaInicio = registroPorMes.First().Fecha.AddMonths(-2); // Un mes antes del primer registro
                DateTime fechaFin = registroPorMes.Last().Fecha.AddMonths(2); // Un mes después del último registro

                chartArea.AxisX.Minimum = fechaInicio.ToOADate();
                chartArea.AxisX.Maximum = fechaFin.ToOADate();

                // Agregar título al gráfico
                chartUsuarios.Titles.Clear();
                Title tituloConDatos = new Title
                {
                    Text = "Usuarios Ingresados por Mes",
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    ForeColor = Color.White,
                    Alignment = ContentAlignment.TopCenter
                };
                chartUsuarios.Titles.Add(tituloConDatos);
            }

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
                // No hay datos para mostrar, agregamos una serie vacía
                chartPrestamosPorUsuario.Series.Add(seriesTopUsuarios);

                // Mensaje informativo en el título del gráfico
                Title tituloSinDatos = new Title
                {
                    Text = "No se encontraron usuarios con préstamos.",
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    ForeColor = Color.White,
                    Alignment = ContentAlignment.TopCenter
                };

                chartPrestamosPorUsuario.Titles.Clear();
                chartPrestamosPorUsuario.Titles.Add(tituloSinDatos);

                return; // Salimos del método ya que no hay más que hacer
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

            // Agregamos un título al gráfico
            Title tituloConDatos = new Title
            {
                Text = "Top 5 Usuarios con más Préstamos",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Alignment = ContentAlignment.TopCenter
            };

            chartPrestamosPorUsuario.Titles.Clear();
            chartPrestamosPorUsuario.Titles.Add(tituloConDatos);
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
                // No hay datos para mostrar, agregamos una serie vacía
                chartLibrosPrestados.Series.Add(seriesTopLibros);

                // Mensaje informativo en el título del gráfico
                Title tituloSinDatos = new Title
                {
                    Text = "No se encontraron préstamos para los libros.",
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    ForeColor = Color.White,
                    Alignment = ContentAlignment.TopCenter
                };

                chartLibrosPrestados.Titles.Clear();
                chartLibrosPrestados.Titles.Add(tituloSinDatos);

                return; // Salimos del método ya que no hay más que hacer
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
            Title tituloConDatos = new Title
            {
                Text = "Libros con más Préstamos",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Alignment = ContentAlignment.TopCenter
            };

            chartLibrosPrestados.Titles.Clear();
            chartLibrosPrestados.Titles.Add(tituloConDatos);
        }
    }
}
