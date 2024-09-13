using sistema_gestion_biblioteca.Controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sistema_gestion_biblioteca.Vista
{
    public partial class FrmGestionDevoluciones : Form
    {
        private devolucionControlador obj_controlador;
        private prestamoControlador obj_prestamo_controlador;
        private usuarioControlador obj_usuario_controlador;
        private libroControlador obj_libro_controlador;

        public FrmGestionDevoluciones()
        {
            InitializeComponent();
            obj_controlador = new devolucionControlador();
            obj_prestamo_controlador = new prestamoControlador();
            obj_usuario_controlador = new usuarioControlador();
            obj_libro_controlador = new libroControlador();
            ActualizarDataGrid();
        }

        private void FrmGestionDevoluciones_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            cargarCmbLibros();
            cargarCmbCorreoUsuario();
            dtFechaDevolu.Format = DateTimePickerFormat.Custom;
            dtFechaDevolu.CustomFormat = " ";
            cargarNombresHeaders();
        }
        private BindingSource enlaceDatos = new BindingSource();

        private int index_tabla = -1;

        // METODOS DE SCRUD
        // Variable para evitar bucles de actualización infinita entre ComboBoxes
        private bool isUpdating = false;

        void cargarNombresHeaders()
        {
            dgDevoluciones.Columns[0].HeaderText = "Título del libro";
            dgDevoluciones.Columns[1].HeaderText = "Corrreo del usuario";
            dgDevoluciones.Columns[2].HeaderText = "Fecha de devolucion";
            dgDevoluciones.Columns[3].HeaderText = "Monto por retraso";
            dgDevoluciones.Columns[4].HeaderText = "Comentario";
        }

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
                        return;
                    }

                    // Vincula la selección con cmbUsuario
                    if (!isUpdating)
                    {
                        isUpdating = true;
                        cmbUsuario.SelectedIndex = cmbLibro.SelectedIndex;
                        isUpdating = false;
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
                        return;
                    }

                    // Vincula la selección con cmbLibro
                    if (!isUpdating)
                    {
                        isUpdating = true;
                        cmbLibro.SelectedIndex = cmbUsuario.SelectedIndex;
                        isUpdating = false;
                    }
                };
            }
        }


        void ActualizarDataGrid()
        {
            var listaPrestamos = obj_controlador.obtenerDevoluciones();
            enlaceDatos.DataSource = listaPrestamos;
            dgDevoluciones.DataSource = enlaceDatos;
        }

        void guardarDevolucion()
        {
            try
            {
                validarFechaMontoDevolucion();

                // Actualizamos el estado del libro nuevamente a "Disponible"
                string nombre_libro = cmbLibro.SelectedItem.ToString();
                string libroISBN = buscarISBNPorNombreLibro(nombre_libro);

                // Actualizamos el estado del prestamo a Devuelto
                string correo_usuario = cmbUsuario.SelectedItem.ToString();

                bool guardado = obj_controlador.agregarDevolucion(cmbLibro.Text, cmbUsuario.Text, dtFechaDevolu.Text, lblMonto.Text, txtComentario.Text);
                if (guardado)
                {
                    bool estado_libro_actualizar = obj_libro_controlador.actualizarEstadoLibro(libroISBN, "Disponible");
                    if (estado_libro_actualizar)
                    {
                        bool estado_prestamo = obj_prestamo_controlador.actualizarEstadoPrestamo(nombre_libro, correo_usuario, "Devuelto");
                        if (estado_prestamo)
                        {
                            MessageBox.Show("Prestamo ingresado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Prestamo ingresado exitosamente, pero no se ha logrado actualizar el estado del prestamo", "Tarea exitosa (Advertencia)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Prestamo ingresado exitosamente, pero no se ha logrado actualizar el estado del libro", "Tarea exitosa (Advertencia)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    ActualizarDataGrid();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al guardar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void actualizarDevolucion()
        {
            try
            {
                if (index_tabla >= 0)
                {
                    bool actualizar = obj_controlador.actualizarDevolucion(index_tabla, cmbLibro.Text, cmbUsuario.Text, dtFechaDevolu.Text, lblMonto.Text, txtComentario.Text);
                    if (actualizar)
                    {
                        MessageBox.Show("Registro actualizado con exito", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se logro actualizar el registro {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void eliminarDevolucion()
        {
            try
            {
                if (MessageBox.Show("Deseas eliminar el prestamo ?", "Confirmacion de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgDevoluciones.SelectedRows.Count > 0)
                    {
                        if (index_tabla >= 0)
                        {
                            bool eliminar = obj_controlador.eliminarDevolucion(index_tabla);

                            if (eliminar)
                            {
                                MessageBox.Show("Devolucion eliminada exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void validarFechaMontoDevolucion()
        {
            // Fecha de devolución real seleccionada por el usuario
            DateTime fechaDevolucionReal = dtFechaDevolu.Value;

            // Obtener la lista de préstamos desde el controlador
            var listaPrestamos = obj_prestamo_controlador.obtenerPrestamos();

            if (listaPrestamos != null && listaPrestamos.Count > 0)
            {
                foreach (var elemento in listaPrestamos)
                {
                    // Simulación de obtener la fecha establecida para un préstamo específico
                    string fechaDevolucionEstablecidaStr = elemento.fecha_devolucion_estimada;

                    // Convertir la fecha de devolución establecida a DateTime
                    if (DateTime.TryParseExact(
                        fechaDevolucionEstablecidaStr,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime fechaDevolucionEstablecida))
                    {
                        // Validar si la devolución se hizo dentro del plazo
                        if (fechaDevolucionReal <= fechaDevolucionEstablecida)
                        {
                            MessageBox.Show($"Devolución realizada dentro del plazo para el libro: {elemento.titulo_libro}.");
                            lblMonto.Text = "$0.00"; // No hay penalización si está dentro del plazo
                        }
                        else
                        {
                            // Calcular la cantidad de meses de retraso
                            int mesesRetraso = ((fechaDevolucionReal.Year - fechaDevolucionEstablecida.Year) * 12) +
                                               fechaDevolucionReal.Month - fechaDevolucionEstablecida.Month;

                            if (fechaDevolucionReal.Day < fechaDevolucionEstablecida.Day)
                            {
                                mesesRetraso--; // Ajuste si el día actual es menor al día de la fecha establecida
                            }

                            // Penalización de $5 por cada mes de atraso
                            decimal montoPenalizacion = (mesesRetraso * 5) + 5;
                            lblMonto.Text = $"${montoPenalizacion:0.00}";

                            MessageBox.Show($"La devolución para el libro: {elemento.titulo_libro} se realizó fuera del plazo. Penalización: {lblMonto.Text}.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al convertir la fecha de devolución establecida para el préstamo.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontraron préstamos para validar.");
            }
        }

        void validarFechaMontoSinMensaje()
        {
            // Fecha de devolución real seleccionada por el usuario
            DateTime fechaDevolucionReal = dtFechaDevolu.Value;

            // Obtener la lista de préstamos desde el controlador
            var listaPrestamos = obj_prestamo_controlador.obtenerPrestamos();

            if (listaPrestamos != null && listaPrestamos.Count > 0)
            {
                foreach (var elemento in listaPrestamos)
                {
                    // Simulación de obtener la fecha establecida para un préstamo específico
                    string fechaDevolucionEstablecidaStr = elemento.fecha_devolucion_estimada;

                    // Convertir la fecha de devolución establecida a DateTime
                    if (DateTime.TryParseExact(
                        fechaDevolucionEstablecidaStr,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime fechaDevolucionEstablecida))
                    {
                        // Validar si la devolución se hizo dentro del plazo
                        if (fechaDevolucionReal <= fechaDevolucionEstablecida)
                        {
                            lblMonto.Text = "$0.00"; // No hay penalización si está dentro del plazo
                        }
                        else
                        {
                            // Calcular la cantidad de meses de retraso
                            int mesesRetraso = ((fechaDevolucionReal.Year - fechaDevolucionEstablecida.Year) * 12) +
                                               fechaDevolucionReal.Month - fechaDevolucionEstablecida.Month;

                            if (fechaDevolucionReal.Day < fechaDevolucionEstablecida.Day)
                            {
                                mesesRetraso--; // Ajuste si el día actual es menor al día de la fecha establecida
                            }

                            // Penalización de $5 por cada mes de atraso
                            decimal montoPenalizacion = (mesesRetraso * 5) + 5;
                            lblMonto.Text = $"${montoPenalizacion:0.00}";
                        }
                    }
                }
            }
        }


        private void dtFechaDevolu_ValueChanged_1(object sender, EventArgs e)
        {
            dtFechaDevolu.Format = DateTimePickerFormat.Short;
            validarFechaMontoSinMensaje();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarDevolucion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarCmbLibros();
            cargarCmbCorreoUsuario();
            txtComentario.Clear();
            lblMonto.Text = " - ";
        }

        string buscarISBNPorNombreLibro(string p_nombreLibro)
        {
            var lista_libros = obj_libro_controlador.obtenerListaLibros();
            var libro = lista_libros.FirstOrDefault(l => l.titulo_libro == p_nombreLibro);

            return libro != null ? libro.ISBN : string.Empty;
        }

        private void dgDevoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgDevoluciones.Rows[e.RowIndex].Cells[0].Value != null)
            {
                index_tabla = e.RowIndex;

                var fila = dgDevoluciones.Rows[e.RowIndex].Cells;

                cmbLibro.Text = fila[0].Value?.ToString() ?? string.Empty;
                cmbUsuario.Text = fila[1].Value?.ToString() ?? string.Empty;
                dtFechaDevolu.Text = fila[2].Value?.ToString() ?? string.Empty;
                lblMonto.Text = fila[3].Value?.ToString() ?? string.Empty;
                txtComentario.Text = fila[4].Value?.ToString() ?? string.Empty;
            }
            else
            {
                index_tabla = -1;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarDevolucion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarDevolucion();
        }
    }
}
