using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_gestion_biblioteca.Controlador;

namespace sistema_gestion_biblioteca.Vista
{
    public partial class FrmHistorialDevoluciones : Form
    {
        public FrmHistorialDevoluciones()
        {
            InitializeComponent();
        }

        private BindingSource enlaceDatos = new BindingSource();
        devolucionControlador obj_controlador = new devolucionControlador();

        private void FrmHistorialDevoluciones_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            cargarNombresHeaders();
            dgDevoluciones.DefaultCellStyle.ForeColor = Color.Black;
        }

        void ActualizarDataGrid()
        {
            var lista = obj_controlador.obtenerDevoluciones();
            enlaceDatos.DataSource = lista;
            dgDevoluciones.DataSource = enlaceDatos;
        }

        void filtrarBuscador(string filtro_buscador)
        {
            var lista = obj_controlador.obtenerDevoluciones();
            if (string.IsNullOrEmpty(filtro_buscador))
            {
                enlaceDatos.DataSource = lista;
            }
            else
            {
                var buscador = filtro_buscador.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var listaFiltrada = lista.Where(ele =>
                    buscador.All(t =>
                        (ele.titulo_libro != null && ele.titulo_libro.Contains(t, StringComparison.OrdinalIgnoreCase)) ||
                        (ele.email_usuario != null && ele.email_usuario.Contains(t, StringComparison.OrdinalIgnoreCase)) ||
                        (ele.fecha_devolucion != null && ele.fecha_devolucion.Contains(t, StringComparison.OrdinalIgnoreCase))
                    )
                ).ToList();

                if (lista.Any())
                {
                    enlaceDatos.DataSource = listaFiltrada;
                }
            }
            dgDevoluciones.DataSource = enlaceDatos;
        }

        void cargarNombresHeaders()
        {
            dgDevoluciones.Columns[0].HeaderText = "Título del libro";
            dgDevoluciones.Columns[1].HeaderText = "Correo del usuario";
            dgDevoluciones.Columns[2].HeaderText = "Fecha de devolución";
            dgDevoluciones.Columns[3].HeaderText = "Monto por retraso";
            dgDevoluciones.Columns[4].HeaderText = "Comentarios de la devolucion";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarBuscador(txtBuscar.Text);
        }
    }
}
