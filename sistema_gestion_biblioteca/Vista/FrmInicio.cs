using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        usuarioControlador obj_usuario_controlador = new usuarioControlador();

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            mostrarGraficaUsuarios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void mostrarGraficaUsuarios()
        {
            // Obtenemos los datos desde el controlador
            var usuariosUltimoMes = obj_usuario_controlador.obtenerUsuariosUltimoMes();
            var registroPorMes = usuariosUltimoMes
                .GroupBy(usuario => new { Anio = usuario.fechaRegistro.Year, Mes = usuario.fechaRegistro.Month })
                .Select(grupo => new { Fecha = new DateTime(grupo.Key.Anio, grupo.Key.Mes, 1), Cantidad = grupo.Count() })
                .OrderBy(x => x.Fecha)
                .ToList();

            // Configuracion del char
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
                ForeColor = Color.White
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
            chartArea.AxisX.LabelStyle.Format = "MMM yyyy"; // Formato de fecha en el eje X
            chartArea.AxisX.Title = "Mes";
            chartArea.AxisY.Title = "Cantidad de Usuarios";
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Months; // Intervalos por mes
            chartArea.AxisX.Interval = 1; // Intervalo de 1 mes en el eje X
            chartArea.AxisX.LabelStyle.Angle = -45; // Rotar etiquetas en el eje X para mejor visibilidad
            chartArea.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea.AxisY.LabelStyle.ForeColor = Color.White;

            // Ajustar el rango de fechas en el eje X para mostrar más meses
            var fechaInicio = DateTime.Now.AddMonths(-3).AddDays(1); // Mostrar 12 meses hacia atrás desde el mes actual
            var fechaFin = DateTime.Now.AddMonths(3); // Añadir un mes futuro para completar el rango

            chartArea.AxisX.Minimum = fechaInicio.ToOADate();
            chartArea.AxisX.Maximum = fechaFin.ToOADate();
        }
    }
}
