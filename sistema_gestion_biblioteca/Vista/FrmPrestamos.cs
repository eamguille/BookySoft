using System;
using System.Collections.Generic;
using System.Linq;
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

            // Establecer la fecha máxima en el DateTimePicker
            dtFechaInicial.MaxDate = DateTime.Now.Date;
        }

        private BindingSource enlaceDatos = new BindingSource();
        private int index_tabla = -1;

        // MÉTODOS DE CRUD

        void cargarCmbLibros()
        {
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            var lista = obj_libro_controlador.obtenerListaLibros();
            if (lista != null && lista.Count > 0)
            {
                var pos = lista.Select(elemento => elemento.titulo_libro).ToList();
                pos.Insert(0, "Selecciona el libro");
                cmbLibro.DataSource = pos;
                cmbLibro.SelectedIndex = 0;
                cmbLibro.SelectedIndexChanged += (s, ev) =>
                {
                    if (cmbLibro.SelectedIndex == 0)
                    {
                        cmbLibro.SelectedIndex = -1;
                    }
                };
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
                // Validación de la fecha de préstamo
                if (dtFechaInicial.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de préstamo no puede ser superior a la actual", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtenemos el libro seleccionado
                string nombre_libro = cmbLibro.SelectedItem.ToString();

                // Buscamos el ISBN según el título del libro
                string libroISBN = buscarISBNPorNombreLibro(nombre_libro);

                // Guardar el préstamo
                bool guardado = obj_controlador.agregarPrestamo(cmbLibro.Text, cmbUsuario.Text, dtFechaInicial.Text, lblFechaDevolucion.Text, cmbEstadoPrestamo.Text);
                if (guardado)
                {
                    bool estado_libro_actualizar = obj_libro_controlador.actualizarEstadoLibro(libroISBN, "No Disponible");
                    if (estado_libro_actualizar)
                    {
                        MessageBox.Show("Préstamo ingresado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Préstamo ingresado exitosamente, pero no se pudo actualizar el estado del libro", "Tarea exitosa (Advertencia)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
                if (index_tabla >= 0)
                {
                    bool actualizar = obj_controlador.actualizarPrestamo(index_tabla, cmbLibro.Text, cmbUsuario.Text, dtFechaInicial.Text, lblFechaDevolucion.Text, cmbEstadoPrestamo.Text);
                    if (actualizar)
                    {
                        MessageBox.Show("Préstamo actualizado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                    }
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
                if (MessageBox.Show("¿Deseas eliminar el préstamo?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgPrestamos.SelectedRows.Count > 0)
                    {
                        if (index_tabla >= 0)
                        {
                            bool eliminar = obj_controlador.eliminarPrestamo(index_tabla);
                            if (eliminar)
                            {
                                MessageBox.Show("Préstamo eliminado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ActualizarDataGrid();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al eliminar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        void FiltrarPrestamos(string filtro_buscador)
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

        // Variable para guardar la fecha estimada de devolución
        DateTime fecha_devolucion;

        private void dtFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            dtFechaInicial.Format = DateTimePickerFormat.Short;

            DateTime fecha_prestamo = dtFechaInicial.Value;

            // Validación: Comprobar si la fecha seleccionada es mayor que la fecha actual
            if (fecha_prestamo > DateTime.Now)
            {
                MessageBox.Show("La fecha de préstamo no puede ser superior a la actual", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Restablecer la fecha al valor actual
                dtFechaInicial.Value = DateTime.Now;
                return;
            }

            // Sumamos un mes para la fecha estimada de devolución
            fecha_devolucion = fecha_prestamo.AddMonths(1);

            // Finalmente mostramos la fecha estimada de devolución en el label
            lblFechaDevolucion.Text = fecha_devolucion.ToString("dd/MM/yyyy");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarPrestamo();
        }

        private void dgPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí arreglo el error de la selección de fila
            if (e.RowIndex >= 0 && dgPrestamos.Rows[e.RowIndex].Cells[0].Value != null)
            {
                // Guardar el índice de la fila seleccionada
                index_tabla = e.RowIndex;

                // Cargar los datos seleccionados en los controles correspondientes
                cmbLibro.Text = dgPrestamos.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbUsuario.Text = dgPrestamos.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtFechaInicial.Value = Convert.ToDateTime(dgPrestamos.Rows[e.RowIndex].Cells[2].Value);
                lblFechaDevolucion.Text = dgPrestamos.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbEstadoPrestamo.Text = dgPrestamos.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarPrestamo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarPrestamo();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Filtrar los préstamos basados en el texto ingresado en el cuadro de búsqueda
            FiltrarPrestamos(txtBuscar.Text);
        }

        private string buscarISBNPorNombreLibro(string nombre_libro)
        {
            // Método auxiliar para obtener el ISBN de un libro a partir de su nombre
            var listaLibros = obj_libro_controlador.obtenerListaLibros();
            var libro = listaLibros.FirstOrDefault(l => l.titulo_libro.Equals(nombre_libro, StringComparison.OrdinalIgnoreCase));
            return libro != null ? libro.ISBN : string.Empty;
        }
    }
}

