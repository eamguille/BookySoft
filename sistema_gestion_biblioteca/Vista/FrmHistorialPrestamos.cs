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

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmHistorialPrestamos : Form
    {
        public FrmHistorialPrestamos()
        {
            InitializeComponent();
        }

        private void FrmHistorialPrestamos_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            cargarHeadersDataGrid();
        }

        private BindingSource enlaceDatos = new BindingSource();
        prestamoControlador obj_controlador = new prestamoControlador();

        void ActualizarDataGrid()
        {
            var listaPrestamos = obj_controlador.obtenerPrestamos();
            enlaceDatos.DataSource = listaPrestamos;
            dgPrestamos.DataSource = enlaceDatos;
        }

        void filtrarBuscador(string filtro_buscador)
        {
            var lista = obj_controlador.obtenerPrestamos();
            if (string.IsNullOrEmpty(filtro_buscador))
            {
                enlaceDatos.DataSource = lista;
            }
            else
            {
                var busqueda = filtro_buscador.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var listaFiltrada = lista.Where(ele =>
                    busqueda.All(t =>
                        (ele.titulo_libro != null && ele.titulo_libro.Contains(t, StringComparison.OrdinalIgnoreCase)) ||
                        (ele.email_usuario != null && ele.email_usuario.Contains(t, StringComparison.OrdinalIgnoreCase)) ||
                        (ele.fecha_prestamo != null && ele.fecha_prestamo.Contains(t, StringComparison.OrdinalIgnoreCase))
                    )
                ).ToList();

                if (lista.Any())
                {
                    enlaceDatos.DataSource = listaFiltrada;
                }
            }
            dgPrestamos.DataSource = enlaceDatos;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarBuscador(txtBuscar.Text);
        }

        void cargarHeadersDataGrid()
        {
            dgPrestamos.Columns[0].HeaderText = "Título del libro";
            dgPrestamos.Columns[1].HeaderText = "Correo del usuario";
            dgPrestamos.Columns[2].HeaderText = "Fecha de préstamo";
            dgPrestamos.Columns[3].HeaderText = "Fecha de devolución";
            dgPrestamos.Columns[4].HeaderText = "Estado del préstamo";
        }
    }
}
