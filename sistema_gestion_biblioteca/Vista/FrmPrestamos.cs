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
    public partial class FrmPrestamos : Form
    {
        private prestamoControlador obj_controlador;
        private usuarioControlador obj_usuario_controlador;
        private libroControlador obj_libro_controlador;

        public FrmPrestamos()
        {
            InitializeComponent();
            obj_controlador = new prestamoControlador();
            obj_usuario_controlador = new usuarioControlador();
            obj_libro_controlador = new libroControlador();
            ActualizarDataGrid();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            lblFechaDevolucion.Text = " - ";
            cargarCmbLibros();
            cargarCmbCorreoUsuario();
            cargarCmbEstadoPrestamo();
            dtFechaInicial.Format = DateTimePickerFormat.Custom;
            dtFechaInicial.CustomFormat = " ";
            cargarHeadersDataGrid();
        }

        private BindingSource enlaceDatos = new BindingSource();

        private int index_tabla = -1;

        // METODOS DE SCRUD

        void cargarCmbLibros()
        {
            var lista = obj_libro_controlador.obtenerListaLibros();
            if (lista != null && lista.Count > 0)
            {
                var pos = lista.Select(elemento => elemento.titulo_libro).ToList();
                cmbLibro.DataSource = pos;
            }
        }

        void cargarCmbCorreoUsuario()
        {
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            var lista = obj_usuario_controlador.obtenerUsuarios();
            if (lista != null && lista.Count > 0)
            {
                var pos = lista.Select(elemento => elemento.email).ToList();

                pos.Insert(0, "Selecciona el correo");

                cmbUsuario.DataSource = pos;

                cmbUsuario.SelectedIndex = 0;

                cmbUsuario.SelectedIndexChanged += (s, ev) =>
                {
                    if (cmbUsuario.SelectedIndex == 0)
                    {
                        cmbUsuario.SelectedIndex = -1;
                    }
                };
            }
        }

        void cargarCmbEstadoPrestamo()
        {
            cmbEstadoPrestamo.DropDownStyle = ComboBoxStyle.DropDownList;

            List<String> lista = new List<String> { "En curso", "Devuelto", "Retrasado" };

            cmbEstadoPrestamo.Items.Insert(0, "Selecciona el estado");

            cmbEstadoPrestamo.Items.AddRange(lista.ToArray());

            cmbEstadoPrestamo.SelectedIndex = 0;

            cmbEstadoPrestamo.SelectedIndexChanged += (s, ev) =>
            {
                if (cmbEstadoPrestamo.SelectedIndex == 0)
                {
                    cmbEstadoPrestamo.SelectedIndex = -1;
                }
            };
        }

        void ActualizarDataGrid()
        {
            var listaPrestamos = obj_controlador.obtenerPrestamos();
            enlaceDatos.DataSource = listaPrestamos;
            dgPrestamos.DataSource = enlaceDatos;
        }

        void guardarPrestamo()
        {
            try
            {
                bool guardado = obj_controlador.agregarPrestamo(cmbLibro.Text, cmbUsuario.Text, dtFechaInicial.Text, lblFechaDevolucion.Text, cmbEstadoPrestamo.Text);
                if (guardado)
                {
                    MessageBox.Show("Prestamo ingresado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al guardar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void actualizarPrestamo()
        {
            try
            {
                bool actualizar = obj_controlador.actualizarPrestamo(index_tabla, cmbLibro.Text, cmbUsuario.Text, dtFechaInicial.Text, lblFechaDevolucion.Text, cmbEstadoPrestamo.Text);

                if (actualizar)
                {
                    MessageBox.Show("Prestamo actualizado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al actualizar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void eliminarPrestamo()
        {
            try
            {
                bool eliminar = obj_controlador.eliminarPrestamo(index_tabla);

                if (eliminar)
                {
                    MessageBox.Show("Prestamo eliminado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al actualizar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cargarHeadersDataGrid()
        {
            dgPrestamos.Columns[0].HeaderText = "Título del libro";
            dgPrestamos.Columns[1].HeaderText = "Correo del usuario";
            dgPrestamos.Columns[2].HeaderText = "Fecha de préstamo";
            dgPrestamos.Columns[3].HeaderText = "Fecha de devolución";
            dgPrestamos.Columns[4].HeaderText = "Estado del préstamo";
        }

        // Variable para guardar la fecha estimada de devolucion
        DateTime fecha_devolucion;

        private void dtFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            dtFechaInicial.Format = DateTimePickerFormat.Short;

            DateTime fecha_prestamo = dtFechaInicial.Value;

            // Sumamos un mes para la fecha estimada de devolucion
            fecha_devolucion = fecha_prestamo.AddMonths(1);

            // Finalmente mostramos la fecha estimada de devolucion en el label
            lblFechaDevolucion.Text = fecha_devolucion.ToString("dd/MM/yyyy");
        }

        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedIndex == 0)
            {
                cmbLibro.SelectedIndex = -1;
            }
        }
    }
}
